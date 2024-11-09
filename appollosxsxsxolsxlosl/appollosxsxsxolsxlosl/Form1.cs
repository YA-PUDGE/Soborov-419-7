using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appollosxsxsxolsxlosl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool isAdmin = textBox1.Text == "aplo" && textBox2.Text == "aplo";

            if (isAdmin)
            {
                // Открываем форму для администратора
                Form2 adminForm = new Form2();
                adminForm.ShowDialog();
            }
            else
            {
                // Открываем форму для гостей
                Form3 guestForm = new Form3();
                guestForm.ShowDialog();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}