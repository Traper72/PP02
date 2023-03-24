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

namespace PP02.Forms
{
    public partial class CreateEntryForm : Form
    {
        DataBase db = new DataBase();
        int idService;
        public CreateEntryForm(Service service)
        {
            idService = service.Id;
            InitializeComponent();

            BackColor = MyColor.whiteColor;
            button1.BackColor = MyColor.blueColor;
            button1.ForeColor = MyColor.whiteColor;

            var path = service.MainImagePath[0] == ' ' ? service.MainImagePath.Remove(0, 1) : service.MainImagePath;
            pictureBox1.ImageLocation = Path.Combine(Environment.CurrentDirectory, "..\\..\\Img", path);
            labelClient2.Text = service.Title;
            labelDuration.Text = "Продолжительность: " + service.Duration/60;
        }

        private void CreateEntryForm_Load(object sender, EventArgs e)
        {
            string query = "select id as 'Id', concat(LastName, ' ', FirstName, ' ', Patronymic) as 'Fio' from Client";
            var result = db.SelectQuery(query);

            comboBoxClient.DataSource = result;
            comboBoxClient.ValueMember = "Id";
            comboBoxClient.DisplayMember= "Fio";
        }

        public void CreateEntry(Entry newEntry)
        {
            var param1 = new SqlParameter();
            param1.ParameterName = "@сlientID";
            param1.DbType = DbType.Int32;
            param1.Value = newEntry.ClientId;
            var param2 = new SqlParameter();
            param2.ParameterName = "@serviceID";
            param2.DbType = DbType.Int32;
            param2.Value = newEntry.ServiceId;
            var param3 = new SqlParameter();
            param3.ParameterName = "@startTime";
            param3.DbType = DbType.DateTime;
            param3.Value = newEntry.StartTime;
            SqlParameter[] parameters =
            {
                param1,
                param2,
                param3,
            };
            var query = "INSERT INTO ClientService(ClientID, ServiceID, StartTime) VALUES (@сlientID, @serviceID, @startTime)";
            db.InsertQuery(query, parameters);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((dateTimePicker2.Value.Date + dateTimePicker1.Value.TimeOfDay) < DateTime.Now)
            {
                return;
            }

            var model = new Entry()
            {
                StartTime = dateTimePicker2.Value.Date + dateTimePicker1.Value.TimeOfDay,
                ServiceId = idService,
                ClientId = (int)comboBoxClient.SelectedValue,
            };
            try
            {
                CreateEntry(model);
                MessageBox.Show("Запись добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
