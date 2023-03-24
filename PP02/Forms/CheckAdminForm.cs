using PP02.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP02.Forms
{
    public partial class CheckAdminForm : Form
    {
        MainForm Owner;
        public CheckAdminForm(MainForm owner)
        {
            Owner = owner;
            InitializeComponent();

            this.CenterToScreen();

            BackColor = MyColor.whiteColor;

            textBox1.UseSystemPasswordChar= true;
            textBox1.BackColor = MyColor.greenColor;
            button1.BackColor = MyColor.blueColor;
            button1.ForeColor = MyColor.whiteColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введите код", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox1.Text != "0000")
            {
                MessageBox.Show("Неверный код", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Успешный вход", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Owner.isAdmin = true;
            Owner.UpdateContainers();
            Owner.UpdateAdminForm(Owner.isAdmin);
            this.Close();
        }

        private void CheckAdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
