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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP02.Controls
{
    public partial class SubPhotoControl : UserControl
    {
        DataBase db = new DataBase();
        ServicePhoto servicePhoto1;
        public SubPhotoControl(ServicePhoto servicePhoto)
        {
            servicePhoto1= servicePhoto;
            InitializeComponent();

            buttonDeleteSubPhoto.BackColor = MyColor.blueColor;
            buttonDeleteSubPhoto.ForeColor = MyColor.whiteColor;

            pictureBoxSubPhoto.BackColor = MyColor.whiteColor;
            pictureBoxSubPhoto.Image = Image.FromFile(servicePhoto1.PhotoPath);
            //Path.Combine(Environment.CurrentDirectory, "..\\..\\Img", servicePhoto1.PhotoPath)
        }

        private void buttonDeleteSubPhoto_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действитено хотите удалить доп изображение?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                DeleteSubPhoto(servicePhoto1.ID);
            }
        }

        void DeleteSubPhoto(int idSubPhoto)
        {
            try
            {
                var param1 = new SqlParameter();
                param1.ParameterName = "@id";
                param1.DbType = DbType.Int32;
                param1.Value = idSubPhoto; ;
                SqlParameter[] parameters = { param1, };
                string query = "delete from ServicePhoto where ID = @id";
                var result = db.DeleteQuery(query, parameters);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
