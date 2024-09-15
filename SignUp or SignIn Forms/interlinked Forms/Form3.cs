using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{

    public partial class Form3 : Form
    {
        public static List<string> users = new List<string> { "areeba", "aiman", "riffat", "ayesha", "zartashia", "khala-e-noor", "zoya", "zareen", "afsha", "aslihan" };
        public static List<string> passwords = new List<string> { "are123", "ai123", "ri123", "ay123", "zar123", "khala123", "zo123", "zar123", "af123", "as123" };

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (textBox1.Text == users[i])
                {
                    passwords[i] = textBox2.Text;
                    MessageBox.Show("Password Changed Successfully!");

                    return;

                }

            }
            MessageBox.Show("user Not Found!");



        }
    }
}