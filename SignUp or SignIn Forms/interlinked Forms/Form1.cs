using Microsoft.VisualBasic.ApplicationServices;

namespace Task3
{
    public partial class Form1 : Form
    {
        public static List<string> users = new List<string> { "areeba", "aiman", "riffat", "ayesha", "zartashia", "khala-e-noor", "zoya", "zareen", "afsha", "aslihan" };
        public static List<string> passwords = new List<string> { "are123", "ai123", "ri123", "ay123", "zar123", "khala123", "zo123", "zar123", "af123", "as123" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 SignUp = new Form2();
            SignUp.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;

            for (int i = 0; i < users.Count; i++)
            {
                if ((textBox1.Text == users[i] && textBox2.Text == passwords[i]))
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
                textBox1.Text = "";
                textBox2.Text = "";


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 ChangePassword = new Form3();
            ChangePassword.Show();

        }
    }
}
