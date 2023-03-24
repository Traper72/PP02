using PP02.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PP02.Forms
{
    public partial class UpcomingEntriesForm : Form
    {
        int counter = 0;
        DataBase db = new DataBase();

        public UpcomingEntriesForm()
        {
            InitializeComponent();

            UpdateEntries();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (counter == 30)
            {
                UpdateEntries();
                counter = 0;
            }
            counter++;
        }

        private void UpcomingEntriesForm_Load(object sender, EventArgs e)
        {

            dataGridView1.BackgroundColor = MyColor.whiteColor;
        }

        private void UpdateEntries()
        {
            try
            {
                string query = "select s.Title as 'Наименование услуги,', CONCAT(c.LastName, ' ', c.FirstName, ' ', c.Patronymic) as " +
                "'ФИО клиента', c.Email as 'Email', c.Phone as 'Телефон', convert(varchar, cs.StartTime, 120) as 'Время записи', " +
                "CONCAT(datediff(MINUTE, GETDATE(), cs.StartTime) / 60, ' часов ', datediff(MINUTE, GETDATE(), cs.StartTime) % 60, " +
                "' минут') as 'Осталось времени' from ClientService cs \r\njoin Client c on c.ID = cs.ClientID\r\njoin Service s " +
                "on s.ID = cs.ServiceID\r\nwhere datediff(SECOND, GETDATE(), cs.StartTime) >= 0 and datediff(MINUTE, GETDATE(), " +
                "cs.StartTime) <= 2880\r\norder by cs.StartTime";
                var result = db.SelectQuery(query);

                if (result != null)
                {
                    dataGridView1.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var t = (string)row.Cells[dataGridView1.Columns.Count - 1].Value;
                var s = t.Split(' ')[0];
                var tmp = int.Parse(((string)row.Cells[dataGridView1.Columns.Count - 1].Value).Split(' ')[0]);

                if (tmp < 1)
                {
                    row.Cells[dataGridView1.Columns.Count - 1].Style.ForeColor = Color.Red;
                }
            }
        }
    }
}
