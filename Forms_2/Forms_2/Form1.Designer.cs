using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net.Http.Headers;
using System.Windows.Forms.VisualStyles;

namespace Forms_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows
        

        

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {

            this.file = new FileInfo("Data.txt");

            this.Panel = new System.Windows.Forms.TableLayoutPanel() { RowCount = 4, ColumnCount = 2, AutoSize = true };
            
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox() { UseSystemPasswordChar = true };
            
            this.ButLogin = new System.Windows.Forms.Button() { Text = "Log in" };
            this.ButGoToReg = new System.Windows.Forms.Button() { Text = "Sign in" };

            this.ButLogin.Click += ButLogin_Click;
            this.ButGoToReg.Click += ButGoToReg_Click;

            this.SuspendLayout();

            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Login: ", AutoSize = true }, 0, 0);
            this.Panel.Controls.Add(this.Login, 1, 0);

            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Password: ", AutoSize = true }, 0, 1);
            this.Panel.Controls.Add(this.Password, 1, 1);

            this.Panel.Controls.Add(this.ButLogin, 0, 2);
            this.Panel.Controls.Add(this.ButGoToReg, 0, 3);

            // Form1

            this.AutoSize = true;
            this.Controls.Add(this.Panel);
            this.Name = "form1";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ButGoToReg_Click(object sender, System.EventArgs e)
        {
            this.formReg = new FormReg();
            formReg.Show();
        }

        private void ButLogin_Click(object sender, System.EventArgs e)
        {
            if(!file.Exists)
            {
                MessageBox.Show("Users are not found!", "Error!");
                return;
            }

            using(System.IO.StreamReader reader = new StreamReader(file.FullName))
            {
                LoginRezerv = reader.ReadLine();
                PasswordRezerv = reader.ReadLine();
            }

            if((Login.Text == LoginRezerv) && (Password.Text == PasswordRezerv))
            {
                MessageBox.Show("Welcom, " + LoginRezerv, "Success!");
            }
            else
            {
                MessageBox.Show("User is not found!", "Failed!");
            }

        }


        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        
        private System.Windows.Forms.Button ButLogin;
        private System.Windows.Forms.Button ButGoToReg;

        private System.Windows.Forms.TableLayoutPanel Panel;

        private System.IO.FileInfo file;

        private FormReg formReg;

        private string LoginRezerv, PasswordRezerv;

    }
}

