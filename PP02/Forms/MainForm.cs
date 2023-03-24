using PP02.Controls;
using PP02.Data;
using PP02.Data.Models;
using PP02.Forms;
using PP02.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP02
{
    public partial class MainForm : Form
    {
        public bool isAdmin = false;
        DataBase db = new DataBase();

        public MainForm()
        {
            InitializeComponent();

            panelContent.AutoScroll = true;
            

            BackColor = MyColor.whiteColor;
            panelMenu.BackColor = MyColor.greenColor;

            buttonAdminPanel.BackColor = MyColor.blueColor;
            buttonAdminPanel.ForeColor = MyColor.whiteColor;
            buttonUpcomingEntries.BackColor = MyColor.blueColor;
            buttonUpcomingEntries.ForeColor = MyColor.whiteColor;
            buttonReset.BackColor = MyColor.blueColor;
            buttonReset.ForeColor = MyColor.whiteColor;
            buttonAddService.BackColor = MyColor.blueColor;
            buttonAddService.ForeColor = MyColor.whiteColor;

            comboBoxSale.Items.Add("все");
            comboBoxSale.Items.Add("от 0 до 5%");
            comboBoxSale.Items.Add("от 5 до 15%");
            comboBoxSale.Items.Add("от 15 до 30%");
            comboBoxSale.Items.Add("от 30 до 70%");
            comboBoxSale.Items.Add("от 70 до 100%");
            comboBoxSale.SelectedIndex= 0;

            comboBoxSort.Items.Add("ревелантности");
            comboBoxSort.Items.Add("возрастанию");
            comboBoxSort.Items.Add("убыванию");
            comboBoxSort.SelectedIndex= 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateAdminForm(isAdmin);
            UpdateContainers();
        }

        public void UpdateAdminForm(bool isAdmin)
        {
            if (isAdmin)
            {
                buttonAdminPanel.Text = "Пользовательский режим";
                buttonUpcomingEntries.Visible = true;
                buttonAddService.Visible = true;
            }
            else
            {
                buttonAdminPanel.Text = "Админ режим";
                buttonUpcomingEntries.Visible = false;
                buttonAddService.Visible = false;
            }
        }

        public void UpdateContainers()
        {
            panelContent.SuspendLayout();
            panelContent.Controls.Clear();
            var services = GetServicesByFilterAndSearchString(comboBoxSale.SelectedIndex, comboBoxSort.SelectedIndex, textBoxSearch.Text);
            foreach (var item in services)
            {
                ServiceItemControl serviceItem = new ServiceItemControl(item, isAdmin)
                {
                    Dock = DockStyle.Top
                };
                serviceItem.bublik1 = UpdateContainers;
                panelContent.Controls.Add(serviceItem);
            }
            panelContent.ResumeLayout();
            labelResultSearch.Text = "Количество результатов поиска: " + services.Count;
        }

        private List<Service> GetServicesByFilterAndSearchString(int filterDiscount, int sort, string searchString = "")
        {
            var param1 = new SqlParameter();
            param1.ParameterName = "@searchString";
            param1.DbType = DbType.String;
            param1.SqlValue = searchString;
            SqlParameter[] parameters =
            {
                param1,
            };

            var query = "SELECT ID, Title, Cost, DurationInSeconds, Description, Discount, MainImagePath FROM Service";

            switch (filterDiscount)
            {
                case 0:
                    query += " WHERE Title LIKE '%' + @searchString + '%' or Description LIKE '%' + @searchString + '%'";
                    break;
                case 1:
                    query += " WHERE Discount >= 0 and Discount < 0.05 and Title LIKE '%' + @searchString + '%' or Description LIKE '%' + @searchString + '%' and Discount >= 0 and Discount < 0.05";
                    break;
                case 2:
                    query += " WHERE Discount >= 0.05 and Discount < 0.15 and Title LIKE '%' + @searchString + '%' or Description LIKE '%' + @searchString + '%' and Discount >= 0.05 and Discount < 0.15";
                    break;
                case 3:
                    query += " WHERE Discount >= 0.15 and Discount < 0.3 and Title LIKE '%' + @searchString + '%' or Description LIKE '%' + @searchString + '%' and Discount >= 0.15 and Discount < 0.3";
                    break;
                case 4:
                    query += " WHERE Discount >= 0.3 and Discount < 0.7 and Title LIKE '%' + @searchString + '%' or Description LIKE '%' + @searchString + '%' and Discount >= 0.3 and Discount < 0.7";
                    break;
                case 5:
                    query += " WHERE Discount >= 0.7 and Discount < 1 and Title LIKE '%' + @searchString + '%' or Description LIKE '%' + @searchString + '%' and Discount >= 0.7 and Discount < 1";
                    break;
                default:
                    query += " WHERE Title LIKE '%' + @searchString + '%' or Description LIKE '%' + @searchString + '%'";
                    break;
            }

            switch (sort)
            {
                case 1:
                    query += " ORDER BY (Cost - Cost* Discount) DESC";
                    break;
                case 2:
                    query += " ORDER BY (Cost - Cost* Discount) ASC";
                    
                    break;
                default:
                    break;
            }

            var result =  db.SelectQuery(query, parameters);
            List<Service> services = new List<Service>();

            foreach (DataRow row in result.Rows)
            {
                int id = (int)row[0];
                string title = (string)row[1];
                decimal cost = (decimal)row[2];
                int durationInSeconds = (int)row[3];
                string description = row[4] is DBNull ? null : (string)row[4];
                double discount = row[5] is DBNull ? 0 : (double)row[5];
                string mainImagePath = row[6] is DBNull ? null : (string)row[6];
                var model = new Service()
                {
                    Id = id,
                    Title = title,
                    Cost = cost,
                    Description = description,
                    Discount = discount,
                    MainImagePath = mainImagePath,
                    Duration = durationInSeconds,
                };
                services.Add(model);
            }

            return services;
        }


        private void buttonAdminPanel_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                isAdmin = false;
                UpdateContainers();
                UpdateAdminForm(isAdmin);
                return;
            }
            CheckAdminForm frm = new CheckAdminForm(this);
            frm.ShowDialog();
        }

        private void comboBoxSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContainers();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContainers();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateContainers();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = string.Empty;
            comboBoxSale.SelectedIndex = 0;
            comboBoxSort.SelectedIndex = 0;
        }

        private void buttonUpcomingEntries_Click(object sender, EventArgs e)
        {
            UpcomingEntriesForm frm = new UpcomingEntriesForm();
            frm.ShowDialog();
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            ViewServiceForm frm = new ViewServiceForm();
            var dialog = frm.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                UpdateContainers();
            }
        }
    }
}
