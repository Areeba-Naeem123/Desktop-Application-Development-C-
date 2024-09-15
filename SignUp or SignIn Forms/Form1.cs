namespace task1
{
    public partial class Form1 : Form
    {
        public static List<string> users = new List<string> { "areeba", "aiman", "riffat", "ayesha", "zartashia", "khala-e-noor", "zoya", "zareen", "afsha", "aslihan" };
        public static List<string> passwords = new List<string> { "are123", "ai123", "ri123", "ay123", "zar123", "khala123", "zo123", "zar123", "af123", "as123" };

        public Form1()
        {
            InitializeComponent();
            this.Text = "Login Form";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;

            for (int i = 0; i < users.Count; i++)
            {
                if ((user.Text == users[i] && password.Text == passwords[i]))
                {
                    MessageBox.Show("Successfully Logged in");
                    user.Text = "";
                    password.Text = "";


                    found = true;

                    break;


                }




            }
            if (found == false)
            {

                MessageBox.Show("Not Registered! You Need to Create an account first.");



            }
        }
    }
}