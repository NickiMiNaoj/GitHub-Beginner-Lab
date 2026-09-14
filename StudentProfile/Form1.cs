namespace StudentProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string validUsername = "registrar1";
            string validPassword = "Password123!";

            string enteredUsername = txtUsername.Text.Trim();
            string enteredPassword = txtPassword.Text;

            if (enteredUsername == validUsername && enteredPassword == validPassword)
            {
                lblMessage.Text = "";
                MessageBox.Show($"Login successful! Welcome, {enteredUsername}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblMessage.Text = "Invalid username or password.";
            }
        }
    }
}
