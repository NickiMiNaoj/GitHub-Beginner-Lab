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
                MessageBox.Show($"Invalid username or password.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
			{
				
				txtUsername.BackColor = System.Drawing.Color.White;
				txtPassword.BackColor = System.Drawing.Color.White;
				lblMessage.Text = "";

				if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
				{
					if (string.IsNullOrEmpty(enteredUsername))
					{
						txtUsername.BackColor = System.Drawing.Color.MistyRose; 
					}

					if (string.IsNullOrEmpty(enteredPassword))
					{
						txtPassword.BackColor = System.Drawing.Color.MistyRose; 
					}

					lblMessage.Text = "Please fill in all required fields.";
					return; 
				}

			

				
				if (enteredUsername == validUsername && enteredPassword == validPassword)
				{
					MessageBox.Show($"Login successful! Welcome, {enteredUsername}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					
					lblMessage.Text = "Invalid username or password.";
					MessageBox.Show("Invalid username or password.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

					txtPassword.Clear();
					txtPassword.Focus(); 
				}
			}

		}
	}
}
