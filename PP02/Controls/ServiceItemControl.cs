using PP02.Data;
using PP02.Data.Models;
using PP02.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP02.Controls
{
    public partial class ServiceItemControl : UserControl
    {
        DataBase db = new DataBase();
        public Service serviceControl;
        bool isadmin;
        public delegate void delegate1();
        public delegate1 bublik1;

        public ServiceItemControl(Service service, bool isAdmin)
        {
            isadmin = isAdmin;
            serviceControl = service;
            InitializeComponent();

            BackColor = MyColor.whiteColor;
            buttonViewService.BackColor = MyColor.blueColor;
            buttonDeleteService.BackColor = MyColor.blueColor;
            buttonAddRecord.BackColor= MyColor.blueColor;
            buttonViewService.ForeColor = MyColor.whiteColor;
            buttonDeleteService.ForeColor = MyColor.whiteColor;
            buttonAddRecord.ForeColor = MyColor.whiteColor;

            if (isAdmin)
            {
                buttonDeleteService.Visible = true;
                buttonAddRecord.Visible = true;
            }
            else
            {
                buttonDeleteService.Visible = false;
                buttonAddRecord.Visible = false;
            }
        }

        private void ServiceItemControl_Load(object sender, EventArgs e)
        {
            if (serviceControl.Discount != 0)
            {
                this.BackColor = MyColor.greenColor;
            }
            int price = (int)(serviceControl.Cost * (1 - (decimal)serviceControl.Discount));
            var path = serviceControl.MainImagePath[0] == ' ' ? serviceControl.MainImagePath.Remove(0, 1) : serviceControl.MainImagePath;
            pictureBoxService.ImageLocation = Path.Combine(Environment.CurrentDirectory, "..\\..\\Img", path);
            labelNameService.Text = serviceControl.Title;
            if (serviceControl.Discount == 0)
            {
                labelSalePriceService.Visible = false;
                labelPriceService.Text = $"{(int)serviceControl.Cost} рублей за {serviceControl.Duration/60} минут";
                labelSaleService.Visible = false;
            }
            else
            {
                labelSalePriceService.Visible = true;
                labelSaleService.Visible = true;
                labelPriceService.Text = ((int)serviceControl.Cost).ToString();
                labelPriceService.Font = new Font(labelPriceService.Font, labelPriceService.Font.Style ^ FontStyle.Strikeout);
                labelSalePriceService.Text = $"{price} рублей за {serviceControl.Duration / 60} минут";
                labelSaleService.Text = $"* скидка {serviceControl.Discount * 100}%";
            }
        }

        private void buttonViewService_Click(object sender, EventArgs e)
        {
            if (isadmin)
            {
                ViewServiceForm frm = new ViewServiceForm(serviceControl.Id, isadmin);
                var dialog = frm.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    bublik1();
                }
            }
            else
            {
                ViewServiceForm frm = new ViewServiceForm(serviceControl.Id, false);
                var dialog = frm.ShowDialog();
            }
        }

        private void buttonDeleteService_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы действительно хотите удалить данную услугу?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            var count = CanBeDeleteService();
            if (count)
            {
                try
                {
                    DeleteService();
                    MessageBox.Show("Услуга удалена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bublik1();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Данную услугу невозможно удалить, так как на нее есть запись", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool CanBeDeleteService()
        {
            var param1 = new SqlParameter();
            param1.ParameterName = "@id";
            param1.DbType = DbType.Int32;
            param1.SqlValue = serviceControl.Id;
            SqlParameter[] parameters =
            {
                param1,
            };
            var query = "SELECT count(id) FROM ClientService WHERE ServiceID = @id";

            return (int)(db.SelectQuery(query, parameters)).Rows[0][0] == 0;
        }

        void DeleteService()
        {
            var param1 = new SqlParameter();
            param1.ParameterName = "@id";
            param1.DbType = DbType.Int32;
            param1.SqlValue = serviceControl.Id;
            SqlParameter[] parameters =
            {
                param1,
            };
            var query = "delete Service WHERE ID = @id";
            db.DeleteQuery(query, parameters);
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            CreateEntryForm frm = new CreateEntryForm(serviceControl);
            frm.ShowDialog();
        }
    }
}
