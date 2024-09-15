using Microsoft.VisualBasic.ApplicationServices;

namespace task2
{
    public partial class Form1 : Form
    {
        public static List<string> users = new List<string> { "areeba", "aiman", "riffat", "ayesha", "zartashia", "khala-e-noor", "zoya", "zareen", "afsha", "aslihan" };
        public static List<string> passwords = new List<string> { "are123", "ai123", "ri123", "ay123", "zar123", "khala123", "zo123", "zar123", "af123", "as123" };

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // for registered users 

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;

            for (int i = 0; i < users.Count; i++)
            {
                if (textBox1.Text == users[i] && textBox2.Text == passwords[i])
                {
                    MessageBox.Show("Successfully Logged in");
                    textBox1.Text = "";
                    textBox2.Text = "";


                    found = true;

                    break;


                }




            }
            if (found == false)
            {

                MessageBox.Show("Not Registered! You Need to Create an account first.");



            }
        }
        // for new users 
        private void button2_Click(object sender, EventArgs e)
        {
            string newUser = textBox3.Text.Trim();
            string newPassword = textBox4.Text.Trim();

            users.Add(newUser);
            users.Add(newPassword);
            MessageBox.Show("New User Registered Successfully");


        }
    }
}
