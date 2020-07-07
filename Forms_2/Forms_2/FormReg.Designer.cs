using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Forms_2
{
    partial class FormReg
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            file = new FileInfo("Data.txt");

            this.Panel = new System.Windows.Forms.TableLayoutPanel() { RowCount = 9, ColumnCount = 2, AutoSize = true };

            this.Login = new System.Windows.Forms.TextBox();
            //this.Password = new System.Windows.Forms.TextBox() { UseSystemPasswordChar = true };
            this.RepeatPassword = new System.Windows.Forms.TextBox() { UseSystemPasswordChar = true };
            this.Email = new System.Windows.Forms.TextBox();

            this.Password = new System.Windows.Forms.MaskedTextBox() { Mask = "A-z" };
            this.SeriaPasport = new System.Windows.Forms.MaskedTextBox() { Mask = "0000" };
            this.NumberPasport = new System.Windows.Forms.MaskedTextBox() { Mask = "000000" };
            this.NumberPhone = new System.Windows.Forms.MaskedTextBox() { Mask = "00000000000" };

            this.Check = new System.Windows.Forms.CheckBox();

            this.ButLoad = new System.Windows.Forms.Button() { Text = "Sign in", Enabled = false };
            this.ButGoToLogin = new System.Windows.Forms.Button() { Text = "Back to Log in" };

            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Login: ", AutoSize = true }, 0, 0);
            this.Panel.Controls.Add(this.Login, 1, 0);

            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Password: ", AutoSize = true }, 0, 1);
            this.Panel.Controls.Add(this.Password, 1, 1);

            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Repeat Password: ", AutoSize = true }, 0, 2);
            this.Panel.Controls.Add(this.RepeatPassword, 1, 2);

            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Seria pasport: ", AutoSize = true }, 0, 3);
            this.Panel.Controls.Add(this.SeriaPasport, 1, 3);

            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Number pasport: ", AutoSize = true }, 0, 4);
            this.Panel.Controls.Add(this.NumberPasport, 1, 4);

            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Phone number: ", AutoSize = true }, 0, 5);
            this.Panel.Controls.Add(this.NumberPhone, 1, 5);

            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Email: ", AutoSize = true }, 0, 6);
            this.Panel.Controls.Add(this.Email, 1, 6);

            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Confirm: ", AutoSize = true }, 0, 7);
            this.Panel.Controls.Add(this.Check, 1, 7);

            this.Panel.Controls.Add(this.ButLoad, 1, 8);

            this.Check.CheckedChanged += Check_CheckedChanged;
            this.ButLoad.Click += ButLoad_Click;
            
            this.AutoSize = true;
            this.Controls.Add(this.Panel);
            this.Name = "FormReg";
            this.Text = "Sign in";
        
        }

        private void Check_CheckedChanged(object sender, System.EventArgs e)
        {
            if(this.Check.Checked)
            {
                this.ButLoad.Enabled = true;
            }
            else
            {
                this.ButLoad.Enabled = false;
            }
        }

        private void ButLoad_Click(object sender, System.EventArgs e)
        {

            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(Email.Text, pattern, RegexOptions.IgnoreCase);

            if (Password.Text != RepeatPassword.Text)
            {
                MessageBox.Show("Passwords don't match!", "Error!");
                return;
            }

            if(!isMatch.Success)
            {
                MessageBox.Show("Email is incorrected!", "Error!");
                return;
            }

            if(!file.Exists)
            {
                file.Create().Close();
            }

            using(System.IO.StreamWriter writer = new StreamWriter(file.FullName))
            {
                writer.WriteLine(Login.Text);
                writer.WriteLine(Password.Text);
                writer.WriteLine(SeriaPasport.Text);
                writer.WriteLine(NumberPasport.Text);
                writer.WriteLine(NumberPhone.Text);
                writer.WriteLine(Email.Text);
            }

        }

        private System.Windows.Forms.TextBox Login;
        //private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox RepeatPassword;
        private System.Windows.Forms.TextBox Email;

        private System.Windows.Forms.MaskedTextBox Password;
        private System.Windows.Forms.MaskedTextBox NumberPhone;
        private System.Windows.Forms.MaskedTextBox SeriaPasport;
        private System.Windows.Forms.MaskedTextBox NumberPasport;

        private System.Windows.Forms.CheckBox Check;

        private System.Windows.Forms.Button ButLoad;
        private System.Windows.Forms.Button ButGoToLogin;

        private System.Windows.Forms.TableLayoutPanel Panel;

        private System.IO.FileInfo file;

        private Form1 formParent;

        #endregion
    }
}