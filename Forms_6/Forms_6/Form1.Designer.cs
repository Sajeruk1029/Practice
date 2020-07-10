using System;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace Forms_6
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
            this.number = 0;

            this.email = "";
            this.name = "";
            this.recipient = "";
            this.message = "";
            this.port = "";
            this.server = "";
            this.password = "";

            if(!File.Exists("Data.txt"))
            {
                File.Create("Data.txt").Close();
            }
            else
            {
                    using (StreamReader sr = new StreamReader("Data.txt"))
                    {
                        while(!sr.EndOfStream)
                        {
                            switch(this.number)
                            {
                                case 0:
                                    {
                                        this.email = sr.ReadLine();
                                        this.number++;
                                        break;
                                    }

                                case 1:
                                    {
                                        this.name = sr.ReadLine();
                                        this.number++;
                                        break;
                                    }

                                case 2:
                                    {
                                        this.recipient = sr.ReadLine();
                                        this.number++;
                                        break;
                                    }

                                case 3:
                                    {
                                        this.message = sr.ReadLine();
                                        this.number++;
                                        break;
                                    }

                                    case 4:
                                    {
                                        this.them = sr.ReadLine();
                                        this.number++;
                                        break;
                                    }

                                case 5:
                                    {
                                        this.port = sr.ReadLine();
                                        this.number++;
                                        break;
                                    }

                                case 6:
                                    {
                                        this.server = sr.ReadLine();
                                        this.number++;
                                        break;
                                    }

                                case 7:
                                    {
                                        this.password = sr.ReadLine();
                                        this.number++;
                                        break;
                                    }
                            }
                    }
                }
            }

            this.Panel = new System.Windows.Forms.TableLayoutPanel() { RowCount = 9, ColumnCount = 2, Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom, Dock = System.Windows.Forms.DockStyle.Fill };

            this.TextBoxes = new System.Windows.Forms.TextBox[7];

            this.PortText = new System.Windows.Forms.MaskedTextBox() { Text = this.port };

            this.ButSend = new System.Windows.Forms.Button() { Text = "Send!" };

            this.TextBoxes[0] = new System.Windows.Forms.TextBox(){ Text = this.email };
            this.TextBoxes[1] = new System.Windows.Forms.TextBox(){ Text = this.name };
            this.TextBoxes[2] = new System.Windows.Forms.TextBox(){ Text = this.recipient };
            this.TextBoxes[3] = new System.Windows.Forms.TextBox(){ Text = this.message };
            this.TextBoxes[4] = new System.Windows.Forms.TextBox() { Text = this.them };
            this.TextBoxes[5] = new System.Windows.Forms.TextBox(){ Text = this.server };
            this.TextBoxes[6] = new System.Windows.Forms.TextBox(){ UseSystemPasswordChar = true, Text = this.password };

            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Email" }, 0, 0);
            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Name" }, 0, 1);
            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Recipient email" }, 0, 2);
            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Message" }, 0, 3);
            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Them" }, 0, 4);
            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Port" }, 0, 5);
            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Server" }, 0, 6);
            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Password" }, 0, 7);

            this.Panel.Controls.Add(this.TextBoxes[0], 1, 0);
            this.Panel.Controls.Add(this.TextBoxes[1], 1, 1);
            this.Panel.Controls.Add(this.TextBoxes[2], 1, 2);
            this.Panel.Controls.Add(this.TextBoxes[3], 1, 3);
            this.Panel.Controls.Add(this.TextBoxes[4], 1, 4);
            this.Panel.Controls.Add(this.PortText, 1, 5);
            this.Panel.Controls.Add(this.TextBoxes[5], 1, 6);
            this.Panel.Controls.Add(this.TextBoxes[6], 1, 7);

            this.Panel.Controls.Add(this.ButSend, 0, 8);

            this.ButSend.Click += ButSend_Click;

            this.components = new System.ComponentModel.Container();
            this.Text = "Email";
            this.Controls.Add(this.Panel);
            this.AutoSize = true;
        }

        private void ButSend_Click(object sender, System.EventArgs e)
        {
            StreamWriter sw;

            if(this.TextBoxes[0].Text == "")
            {
                MessageBox.Show("The Email cannot be empty!", "Error!");
                return;
            }

            if (this.TextBoxes[1].Text == "")
            {
                MessageBox.Show("The Name cannot be empty!", "Error!");
                return;
            }

            if (this.TextBoxes[2].Text == "")
            {
                MessageBox.Show("The Recipient cannot be empty!", "Error!");
                return;
            }

            if (this.TextBoxes[3].Text == "")
            {
                MessageBox.Show("The Message cannot be empty!", "Error!");
                return;
            }

            if (this.TextBoxes[4].Text == "")
            {
                MessageBox.Show("The them cannot be empty!", "Error!");
                return;
            }

            if (this.PortText.Text == "")
            {
                MessageBox.Show("The Port cannot be empty!", "Error!");
                return;
            }

            if (this.TextBoxes[5].Text == "")
            {
                MessageBox.Show("The Server cannot be empty!", "Error!");
                return;
            }

            if (this.TextBoxes[6].Text == "")
            {
                MessageBox.Show("The Password cannot be empty!", "Error!");
                return;
            }

            try
            {


                MailAddress senderEmail = new MailAddress(this.TextBoxes[0].Text, this.TextBoxes[1].Text);
                MailAddress recipientMail = new MailAddress(this.TextBoxes[2].Text);

                MailMessage message = new MailMessage(senderEmail, recipientMail);
                message.Body = this.TextBoxes[3].Text;
                message.Subject = this.TextBoxes[4].Text;
                message.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient(this.TextBoxes[5].Text, Convert.ToInt32(this.PortText.Text));
                smtp.UseDefaultCredentials = false;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(this.TextBoxes[0].Text, this.TextBoxes[6].Text);
                smtp.EnableSsl = true;

                smtp.Send(message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error!");
                return;
            }            
                MessageBox.Show("Success!", "Success!");

                sw = new StreamWriter("Data.txt");

                sw.WriteLine(this.TextBoxes[0].Text);
                sw.WriteLine(this.TextBoxes[1].Text);
                sw.WriteLine(this.TextBoxes[2].Text);
                sw.WriteLine(this.TextBoxes[3].Text);
                sw.WriteLine(this.TextBoxes[4].Text);
                sw.WriteLine(this.PortText.Text);
                sw.WriteLine(this.TextBoxes[5].Text);
                sw.WriteLine(this.TextBoxes[6].Text);

                sw.Close();

        }

        private System.Windows.Forms.TableLayoutPanel Panel;

        private System.Windows.Forms.TextBox[] TextBoxes;

        private System.Windows.Forms.MaskedTextBox PortText;

        private System.Windows.Forms.Button ButSend;

        private string email, name, recipient, message, port, server, password, them;

        private int number;

        #endregion
    }
}

