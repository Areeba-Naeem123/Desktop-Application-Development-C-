using Microsoft.VisualBasic.ApplicationServices;
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

namespace Task3
{
    public partial class Form2 : Form
    {
        public static List<string> users = new List<string> { "areeba", "aiman", "riffat", "ayesha", "zartashia", "khala-e-noor", "zoya", "zareen", "afsha", "aslihan" };
        public static List<string> passwords = new List<string> { "are123", "ai123", "ri123", "ay123", "zar123", "khala123", "zo123", "zar123", "af123", "as123" };

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Login = new Form1();
            Login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newUser = textBox1.Text.Trim();

            string newPassword = textBox2.Text.Trim();

            users.Add(newUser);
            users.Add(newPassword);
            MessageBox.Show("New User Registered Successfully");
        }
    }
}
