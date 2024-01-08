namespace RailwayTest
{

    public partial class Login : Form
    {
        private const string username = "username";
        private const string password = "password";
        public Login()
        {

            InitializeComponent();

        }





        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username1 = Username.Text;
            string password1 = Password.Text;

            if(IsUserInfoTrue(username1,password1))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }


        }

        private bool IsUserInfoTrue(string inputUsername, string inputPassword)
        {
            return inputUsername == username && inputPassword == password;
        }

    }
}
