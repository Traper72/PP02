using PP02.Controls;
using PP02.Data;
using PP02.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace PP02.Forms
{
    public partial class ViewServiceForm : Form
    {
        DataBase db = new DataBase();
        int idService1 = 0;
        string newFileName;
        string newSubFileName;

        public ViewServiceForm()
        {
            InitializeComponent();

            this.Text = "Создание услуги";
            textBoxIdService.Visible = false;
            labelIdService.Visible = false;
        }
        public ViewServiceForm(int idService, bool isAdmin)
        {
            InitializeComponent();

            idService1 = idService;

            UpdateDataService();

            textBoxIdService.ReadOnly = true;

            if (isAdmin)
            {
                this.Text = "Редактирование услуги";
                panelDataService.Enabled = true;
                panelSubPhoto.Enabled = true;
            }
            else
            {
                this.Text = "Просмотр услуги";
                panelDataService.Enabled = false;
                panelSubPhoto.Enabled = false;
            }

        }

        private void UpdateDataService()
        {
            var service = GetServiceByIdWithPhotos(idService1);

            textBoxIdService.Text = service.Id.ToString();
            textBoxNameService.Text = service.Title;
            numericCostService.Value = service.Cost;
            numericDurationService.Value = service.Duration / 60;
            numericSaleService.Value = (decimal)service.Discount * 100;
            textBoxDescriptionService.Text = service.Description;
            var path = service.MainImagePath[0] == ' ' ? service.MainImagePath.Remove(0, 1) : service.MainImagePath;
            pictureBoxMainPhoto.ImageLocation = Path.Combine(Environment.CurrentDirectory, "..\\..\\Img", path);

            UpdateSubPhoto(service.Photos);
        }

        private void ViewServiceForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            panelDataService.BackColor = MyColor.whiteColor;
            panelSubPhoto.BackColor = MyColor.whiteColor;
            panelSubPhoto.AutoScroll = true;
            buttonEditMainPhoto.BackColor = MyColor.blueColor;
            buttonEditMainPhoto.ForeColor = MyColor.whiteColor;
            buttonAddSubPhoto.BackColor= MyColor.blueColor;
            buttonAddSubPhoto.ForeColor = MyColor.whiteColor;
            buttonSaveService.BackColor = MyColor.blueColor;
            buttonSaveService.ForeColor = MyColor.whiteColor;

            pictureBoxMainPhoto.BackColor = MyColor.greenColor;
        }

        public Service GetServiceByIdWithPhotos(int id)
        {
            var param1 = new SqlParameter();
            param1.ParameterName = "@id";
            param1.DbType = DbType.Int32;
            param1.SqlValue = id;
            SqlParameter[] parameters =
            {
                param1,
            };
            var query = "SELECT Title, Cost, DurationInSeconds, Description, Discount, MainImagePath FROM Service WHERE ID = @id";
            var result = db.SelectQuery(query, parameters);
            Service model = null;

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                var title = (string)row[0];
                var cost = (decimal)row[1];
                var durationInSeconds = (int)row[2];
                var description = row[3] is DBNull ? null : (string)row[3];
                double discount = row[4] is DBNull ? 0 : (double)row[4];
                var mainImagePath = row[5] is DBNull ? null : (string)row[5];
                model = new Service()
                {
                    Id = id,
                    Title = title,
                    Cost = cost,
                    Description = description,
                    Discount = discount,
                    MainImagePath = mainImagePath,
                    Duration = durationInSeconds,
                    Photos = new List<ServicePhoto>(),
                };

                var param2 = new SqlParameter();
                param2.ParameterName = "@id";
                param2.DbType = DbType.Int32;
                param2.SqlValue = id;
                SqlParameter[] parameters2 =
                {
                    param2,
                };

                query = "SELECT ID, ServiceID, PhotoPath FROM ServicePhoto WHERE ServiceID = @id";
                result = db.SelectQuery(query, parameters2);
                foreach (DataRow item in result.Rows)
                {
                    var idPhoto = (int)item[0];
                    var idService = (int)item[1];
                    var path = (string)item[2];

                    var photo = new ServicePhoto()
                    {
                        ID = idPhoto,
                        ServiceID = idService,
                        PhotoPath = path,
                    };
                    model.Photos.Add(photo);
                }
            }

            return model;
        }

        void UpdateSubPhoto(List<ServicePhoto> servicePhotos)
        {
            panelSubPhoto.SuspendLayout();
            panelSubPhoto.Controls.Clear();
            foreach (var item in servicePhotos)
            {
                item.PhotoPath = Path.Combine(Environment.CurrentDirectory, "..\\..\\Img", item.PhotoPath);
                SubPhotoControl subPhoto = new SubPhotoControl(item)
                {
                    Dock = DockStyle.Left,
                    Width = 154,
                };
                panelSubPhoto.Controls.Add(subPhoto);
            }
            panelSubPhoto.ResumeLayout();
        }

        private void buttonEditMainPhoto_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Изображения (*.bmp, *.jpg, *.png|*.bmp;*.jpg;*.png)";

            if (openDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var type = openDialog.FileName.Split('.');
            var fileName = $"{Guid.NewGuid()}.{type[type.Length-1]}";

            if (idService1 != 0)
            {
                if (!string.IsNullOrEmpty(pictureBoxMainPhoto.ImageLocation))
                {
                    var pathOld = pictureBoxMainPhoto.ImageLocation;
                    FileInfo fileInfo= new FileInfo(pathOld);

                    if (fileInfo.Exists)
                    {
                        fileInfo.Delete();
                    }
                }
                var path = Path.Combine(Environment.CurrentDirectory, "..\\..\\Img\\Услуги школы\\", fileName);
                pictureBoxMainPhoto.Image = Image.FromFile(openDialog.FileName);
                pictureBoxMainPhoto.Image.Save(path);
                UpdateMainPhotoService(Path.Combine("Услуги школы\\", fileName));
            }
            else
            {
                newFileName = Path.Combine("Услуги школы\\", fileName);
                pictureBoxMainPhoto.Image = Image.FromFile(openDialog.FileName);
            }
        }

        void UpdateMainPhotoService(string pathFile)
        {
            if (idService1 != 0)
            {
                try
                {
                    var param1 = new SqlParameter();
                    param1.ParameterName = "@id";
                    param1.DbType = DbType.Int32;
                    param1.Value = idService1;
                    var param2 = new SqlParameter();
                    param2.ParameterName = "@path";
                    param2.DbType = DbType.String;
                    param2.Value = pathFile;
                    SqlParameter[] parameters = { param1, param2};
                    string query = "update Service set MainImagePath = @path where ID = @id";
                    var result = db.UpdateQuery(query, parameters);

                    UpdateDataService();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        private void ViewServiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonAddSubPhoto_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Изображения (*.bmp, *.jpg, *.png|*.bmp;*.jpg;*.png)";

            if (openDialog.ShowDialog() == DialogResult.Cancel) return;
            var type = openDialog.FileName.Split('.');
            var fileName = $"{Guid.NewGuid()}.{type[type.Length - 1]}";

            if (idService1 != 0)
            {
                var path = Path.Combine(Environment.CurrentDirectory, "..\\..\\Img\\Доп фотографии\\", fileName);
                var newServicePhoto = new ServicePhoto()
                {
                    PhotoPath = openDialog.FileName,
                };
                var tmp = new SubPhotoControl(newServicePhoto)
                {
                    Dock = DockStyle.Left,
                    Width = 154,
                };
                panelSubPhoto.Controls.Add(tmp);
                tmp.pictureBoxSubPhoto.Image.Save(path);
                AddPhotoService(idService1, Path.Combine("Доп фотографии\\", fileName));
            }
            else
            {
                var newServicePhoto = new ServicePhoto()
                {
                    PhotoPath = openDialog.FileName,
                };
                var tmp = new SubPhotoControl(newServicePhoto)
                {
                    Dock = DockStyle.Left,
                    Width = 154,
                };
                panelSubPhoto.Controls.Add(tmp);
            }
        }

        public void AddPhotoService(int id, string imageName)
        {
            try
            {
                var param1 = new SqlParameter();
                param1.ParameterName = "@imageName";
                param1.DbType = DbType.String;
                param1.SqlValue = imageName;
                var param2 = new SqlParameter();
                param2.ParameterName = "@id";
                param2.DbType = DbType.Int32;
                param2.SqlValue = id;
                SqlParameter[] parameters =
                {
                param1,
                param2,
            };
                var query = "INSERT INTO ServicePhoto(ServiceID, PhotoPath) VALUES (@id, @imageName)";
                db.InsertQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonSaveService_Click(object sender, EventArgs e)
        {
            CheckDataService();
        }

        void CheckDataService()
        {
            if (string.IsNullOrWhiteSpace(textBoxNameService.Text))
            {
                MessageBox.Show("Введите название", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CheckNameservice(textBoxNameService.Text) == false)
            {
                MessageBox.Show("Данное нименование уже используется", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pictureBoxMainPhoto.Image == null)
            {
                MessageBox.Show("Выберете главное изображение", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idService1 == 0)
            {
                Service service = new Service()
                {
                    Title = textBoxNameService.Text,
                    Cost = numericCostService.Value,
                    Duration = (int)numericDurationService.Value * 60,
                    Discount = (double)numericSaleService.Value/100,
                    Description = textBoxDescriptionService.Text,
                    MainImagePath = newFileName,
                };
                try
                {
                    SaveNewService(service);
                    pictureBoxMainPhoto.Image.Save(Path.Combine(Environment.CurrentDirectory, "..\\..\\Img\\", newFileName));
                    var id = GetLastId();

                    foreach (SubPhotoControl photoItem in panelSubPhoto.Controls)
                    {
                        var type = "jpg";
                        var fileName = $"{Guid.NewGuid()}.{type}";
                        var path = Path.Combine(Environment.CurrentDirectory, "..\\..\\Img\\Доп фотографии", fileName);
                        photoItem.pictureBoxSubPhoto.Image.Save(path);
                        AddPhotoService(id, Path.Combine("Доп фотографии\\", fileName));
                    }
                    MessageBox.Show("Услуга добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Service service = new Service()
                {
                    Id = idService1,
                    Title = textBoxNameService.Text,
                    Cost = numericCostService.Value,
                    Duration = (int)numericDurationService.Value * 60,
                    Discount = (double)numericSaleService.Value / 100,
                    Description = textBoxDescriptionService.Text,
                    MainImagePath = newFileName,
                };
                try
                {
                    SaveEditService(service);
                    MessageBox.Show("Услуга изменена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int GetLastId()
        {
            string query = "SELECT IDENT_CURRENT('Service')";
            return Convert.ToInt32(db.SelectQuery(query).Rows[0][0]);
        }

        public void SaveEditService(Service updateModel)
        {
            var param1 = new SqlParameter();
            param1.ParameterName = "@title";
            param1.DbType = DbType.String;
            param1.SqlValue = updateModel.Title;
            var param2 = new SqlParameter();
            param2.ParameterName = "@cost";
            param2.DbType = DbType.Decimal;
            param2.SqlValue = updateModel.Cost;
            var param3 = new SqlParameter();
            param3.ParameterName = "@discount";
            param3.DbType = DbType.Double;
            param3.SqlValue = updateModel.Discount;
            var param4 = new SqlParameter();
            param4.ParameterName = "@description";
            param4.DbType = DbType.String;

            if (String.IsNullOrEmpty(updateModel.Description))
            {
                param4.SqlValue = DBNull.Value;
            }
            else
            {
                param4.SqlValue = updateModel.Description;
            }
            var param5 = new SqlParameter();
            param5.ParameterName = "@durationInSeconds";
            param5.DbType = DbType.Int32;
            param5.SqlValue = updateModel.Duration;
            var param6 = new SqlParameter();
            param6.ParameterName = "@id";
            param6.DbType = DbType.Int32;
            param6.SqlValue = updateModel.Id;
            SqlParameter[] parameters =
            {
                param1,
                param2,
                param3,
                param4,
                param5,
                param6,
            };

            var query = "UPDATE Service SET Title = @title, Cost = @cost, Description = @description, DurationInSeconds = @durationInSeconds, Discount = @discount WHERE ID = @id";
            db.UpdateQuery(query, parameters);
        }

        void SaveNewService(Service model)
        {
            var param1 = new SqlParameter();
            param1.ParameterName = "@title";
            param1.DbType = DbType.String;
            param1.SqlValue = model.Title;
            var param2 = new SqlParameter();
            param2.ParameterName = "@cost";
            param2.DbType = DbType.Decimal;
            param2.SqlValue = model.Cost;
            var param3 = new SqlParameter();
            param3.ParameterName = "@discount";
            param3.DbType = DbType.Double;
            param3.SqlValue = model.Discount;
            var param4 = new SqlParameter();
            param4.ParameterName = "@description";
            param4.DbType = DbType.String;

            if (String.IsNullOrEmpty(model.Description))
            {
                param4.SqlValue = DBNull.Value;
            }
            else
            {
                param4.SqlValue = model.Description;
            }
            var param5 = new SqlParameter();
            param5.ParameterName = "@mainImagePath";
            param5.DbType = DbType.String;

            if (String.IsNullOrEmpty(model.MainImagePath))
            {
                param5.SqlValue = DBNull.Value;
            }
            else
            {
                param5.SqlValue = model.MainImagePath;
            }
            var param6 = new SqlParameter();
            param6.ParameterName = "@durationInSeconds";
            param6.DbType = DbType.Int32;
            param6.SqlValue = model.Duration;
            SqlParameter[] parameters =
            {
                param1,
                param2,
                param3,
                param4,
                param5,
                param6,
            };
            var query = "INSERT INTO Service(Title, Cost, DurationInSeconds, Description, Discount, MainImagePath) VALUES (@title, @cost, @durationInSeconds, @description, @discount, @mainImagePath)";
            db.InsertQuery(query, parameters);
        }

        private bool CheckNameservice(string nameService)
        {
            var param1 = new SqlParameter();
            param1.ParameterName = "@nameService";
            param1.DbType = DbType.String;
            param1.SqlValue = nameService;
            SqlParameter[] parameters =
                {
                param1,
            };
            string query = "select * from Service where Title = @nameService";
            var result = db.SelectQuery(query, parameters);

            if (result.Rows.Count == 1 && idService1 != 0)
            {
                return true;
            }
            if (result.Rows.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
