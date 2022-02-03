using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Net;

namespace HMS
{
    public partial class Form2 : Form
    {
        

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        

        public Form2()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        public static int tokenGen()
        {
            Random rand = new Random();
            int random;
            random = rand.Next(999999, 9999999);

            return random;
        }

        int token1 = tokenGen();

        private void signInMail(string to)
        {
            try
            {
                //int tokenGenerated = tokenGen();

                string random1 = Convert.ToString(token1);

                string from, pass, messageBody;

                MailMessage message = new MailMessage();

                from = "theultron8054@gmail.com";
                pass = "ultron8054";

                messageBody = random1;

                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = "From : " + from + "<br>Token: " + messageBody;
                message.Subject = "Access Token";
                message.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                smtp.Send(message);
                MessageBox.Show("Email Sent Successfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string username1 = "jefferson";
            string password1 = "jeff8054";

            if ( usernameTextBox.Text != username1 || passwordTextBox.Text != password1 || usernameTextBox.Text == "" || passwordTextBox.Text == "" /*emailTextBox.Text == "" || subjectTextBox.Text == "" || messageTextBox.Text == ""*/)
            {
                MessageBox.Show("Incorrect password", "Handler DB", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {

                signInMail("nessahjefferson7@gmail.com");

                try
                {
                    gunaLabel5.Visible = false;
                    gunaLabel6.Visible = false;
                    usernameTextBox.Visible = false;
                    passwordTextBox.Visible = false;
                    signInButton.Visible = false;

                    accessTokenTextBox.Visible = true;
                    gunaLabel7.Visible = true;
                    confirmButton.Visible = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string tokenConfirm;
            tokenConfirm = Convert.ToString(token1);

            if (accessTokenTextBox.Text == tokenConfirm)
            {
                MessageBox.Show("Access granted", "Handler DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                accessTokenTextBox.Text = "";

                Form3 addDeviceForm = new Form3();
                addDeviceForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Token", "Handler DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
