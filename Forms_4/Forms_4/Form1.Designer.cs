using Sprache.Calc;
using System;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace Forms_4
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
            this.Mode = 0;

            this.Panel = new System.Windows.Forms.TableLayoutPanel() { ColumnCount = 9, RowCount = 7, AutoSize = true, Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom, Dock = System.Windows.Forms.DockStyle.Fill };

            this.Menu = new System.Windows.Forms.MenuStrip();

            this.MenuMode = new System.Windows.Forms.ToolStripMenuItem("Mode");

            this.EditZone = new System.Windows.Forms.TextBox() { ReadOnly = true, Width = 30, Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right };

            this.DateChanger = new System.Windows.Forms.DateTimePicker[2];

            this.Buttons = new System.Windows.Forms.Button[22];

            this.RadioButtons = new System.Windows.Forms.RadioButton[4];

            this.Buttons[0] = new System.Windows.Forms.Button() { Text = "1", Width = 50, Height = 50 };
            this.Buttons[1] = new System.Windows.Forms.Button() { Text = "2", Width = 50, Height = 50 };
            this.Buttons[2] = new System.Windows.Forms.Button() { Text = "3", Width = 50, Height = 50 };
            this.Buttons[3] = new System.Windows.Forms.Button() { Text = "4", Width = 50, Height = 50 };
            this.Buttons[4] = new System.Windows.Forms.Button() { Text = "5", Width = 50, Height = 50 };
            this.Buttons[5] = new System.Windows.Forms.Button() { Text = "6", Width = 50, Height = 50 };
            this.Buttons[6] = new System.Windows.Forms.Button() { Text = "7", Width = 50, Height = 50 };
            this.Buttons[7] = new System.Windows.Forms.Button() { Text = "8", Width = 50, Height = 50 };
            this.Buttons[8] = new System.Windows.Forms.Button() { Text = "9", Width = 50, Height = 50 };
            this.Buttons[9] = new System.Windows.Forms.Button() { Text = "0", Width = 50, Height = 50 };
            this.Buttons[10] = new System.Windows.Forms.Button() { Text = "=", Width = 50, Height = 50 };
            this.Buttons[11] = new System.Windows.Forms.Button() { Text = "C", Width = 50, Height = 50 };
            this.Buttons[12] = new System.Windows.Forms.Button() { Text = "+", Width = 50, Height = 50 };
            this.Buttons[13] = new System.Windows.Forms.Button() { Text = "-", Width = 50, Height = 50 };
            this.Buttons[14] = new System.Windows.Forms.Button() { Text = "*", Width = 50, Height = 50 };
            this.Buttons[15] = new System.Windows.Forms.Button() { Text = "/", Width = 50, Height = 50 };
            this.Buttons[16] = new System.Windows.Forms.Button() { Text = "^2", Width = 50, Height = 50, Enabled = false };
            this.Buttons[17] = new System.Windows.Forms.Button() { Text = "^3", Width = 50, Height = 50, Enabled = false };
            this.Buttons[18] = new System.Windows.Forms.Button() { Text = "Log", Width = 50, Height = 50, Enabled = false };
            this.Buttons[19] = new System.Windows.Forms.Button() { Text = "F", Width = 50, Height = 50, Enabled = false };
            this.Buttons[20] = new System.Windows.Forms.Button() { Text = "(", Width = 50, Height = 50 };
            this.Buttons[21] = new System.Windows.Forms.Button() { Text = ")", Width = 50, Height = 50 };

            this.RadioButtons[0] = new System.Windows.Forms.RadioButton() { Text = "2", Width = 50, Height = 50, Enabled = false };
            this.RadioButtons[1] = new System.Windows.Forms.RadioButton() { Text = "8", Width = 50, Height = 50, Enabled = false };
            this.RadioButtons[2] = new System.Windows.Forms.RadioButton() { Text = "10", Width = 50, Height = 50, Checked = true, Enabled = false };
            this.RadioButtons[3] = new System.Windows.Forms.RadioButton() { Text = "16", Width = 50, Height = 50, Enabled = false };

            this.DateChanger[0] = new System.Windows.Forms.DateTimePicker() { Enabled = false };
            this.DateChanger[1] = new System.Windows.Forms.DateTimePicker() { Enabled = false };

            this.MenuMode.DropDownItems.Add("Normal");
            this.MenuMode.DropDownItems.Add("Engineer");
            this.MenuMode.DropDownItems.Add("Programmer");
            this.MenuMode.DropDownItems.Add("Date calc");

            this.Buttons[0].Click += Button_1_Click;
            this.Buttons[1].Click += Button_2_Click;
            this.Buttons[2].Click += Button_3_Click;
            this.Buttons[3].Click += Button_4_Click;
            this.Buttons[4].Click += Button_5_Click;
            this.Buttons[5].Click += Button_6_Click;
            this.Buttons[6].Click += Button_7_Click;
            this.Buttons[7].Click += Button_8_Click;
            this.Buttons[8].Click += Button_9_Click;
            this.Buttons[9].Click += Button_0_Click;

            this.Buttons[10].Click += Button_Equally_Click;

            this.Buttons[11].Click += Button_Clear_Click;

            this.Buttons[12].Click += Button_Plus_Click;
            this.Buttons[13].Click += Button_Minus_Click;
            this.Buttons[14].Click += Button_Multiply_Click;
            this.Buttons[15].Click += Button_Divide_Click;
            this.Buttons[16].Click += Button_Square_Click;
            this.Buttons[17].Click += Button_Cube_Click;
            this.Buttons[18].Click += Button_Log_Click;
            this.Buttons[19].Click += Button_Factorial_Click;
            this.Buttons[20].Click += Button_StartBracket_Click;
            this.Buttons[21].Click += Button_EndBracket_Click;

            this.MenuMode.DropDownItems[0].Click += MenuMode_Normal_Click;
            this.MenuMode.DropDownItems[1].Click += MenuMode_Enginner_Click;
            this.MenuMode.DropDownItems[2].Click += MenuMode_Programmer_Click;
            this.MenuMode.DropDownItems[3].Click += MenuMode_DataCalc_Click;

            this.Menu.Items.Add(this.MenuMode);

            this.Panel.Controls.Add(this.Menu, 0, 0);
            this.Panel.SetColumnSpan(this.Menu, 9);

            this.Panel.Controls.Add(this.EditZone, 0, 1);
            this.Panel.SetColumnSpan(this.EditZone, 9);

            this.Panel.Controls.Add(this.Buttons[0], 0, 2);
            this.Panel.Controls.Add(this.Buttons[1], 1, 2);
            this.Panel.Controls.Add(this.Buttons[2], 2, 2);

            this.Panel.Controls.Add(this.Buttons[3], 0, 3);
            this.Panel.Controls.Add(this.Buttons[4], 1, 3);
            this.Panel.Controls.Add(this.Buttons[5], 2, 3);

            this.Panel.Controls.Add(this.Buttons[6], 0, 4);
            this.Panel.Controls.Add(this.Buttons[7], 1, 4);
            this.Panel.Controls.Add(this.Buttons[8], 2, 4);

            this.Panel.Controls.Add(this.Buttons[9], 0, 5);
            this.Panel.Controls.Add(this.Buttons[10], 1, 5);
            this.Panel.Controls.Add(this.Buttons[11], 2, 5);

            this.Panel.Controls.Add(this.Buttons[12], 4, 2);
            this.Panel.Controls.Add(this.Buttons[13], 4, 3);
            this.Panel.Controls.Add(this.Buttons[14], 4, 4);
            this.Panel.Controls.Add(this.Buttons[15], 4, 5);

            this.Panel.Controls.Add(this.Buttons[16], 5, 2);
            this.Panel.Controls.Add(this.Buttons[17], 5, 3);
            this.Panel.Controls.Add(this.Buttons[18], 5, 4);
            this.Panel.Controls.Add(this.Buttons[19], 5, 5);
            this.Panel.Controls.Add(this.Buttons[20], 0, 6);
            this.Panel.Controls.Add(this.Buttons[21], 1, 6);

            this.Panel.Controls.Add(this.RadioButtons[0], 6, 2);
            this.Panel.Controls.Add(this.RadioButtons[1], 6, 3);
            this.Panel.Controls.Add(this.RadioButtons[2], 6, 4);
            this.Panel.Controls.Add(this.RadioButtons[3], 6, 5);

            this.Panel.Controls.Add(this.DateChanger[0], 7, 2);
            this.Panel.Controls.Add(this.DateChanger[1], 7, 3);
            
            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Date first" }, 8, 2);
            this.Panel.Controls.Add(new System.Windows.Forms.Label() { Text = "Date Second" }, 8, 3);

            this.components = new System.ComponentModel.Container();
            this.AutoSize = true;
            this.Controls.Add(this.Panel);
            this.Text = "Calc";
        }

        private void Button_EndBracket_Click(object sender, System.EventArgs e)
        {
            EditZone.Text += ")";
        }

        private void Button_StartBracket_Click(object sender, System.EventArgs e)
        {
            EditZone.Text += "(";
        }

        private void Button_Factorial_Click(object sender, System.EventArgs e)
        {
            EditZone.Text += "F(";
        }

        private void Button_Log_Click(object sender, System.EventArgs e)
        {
            EditZone.Text += "Log(";
        }

        private void Button_Cube_Click(object sender, System.EventArgs e)
        {
            EditZone.Text += "^3";
        }

        private void Button_Square_Click(object sender, System.EventArgs e)
        {
            EditZone.Text += "^2";
        }

        private void Button_Divide_Click(object sender, System.EventArgs e)
        {
            EditZone.Text += "/";
        }

        private void Button_Multiply_Click(object sender, System.EventArgs e)
        {
            EditZone.Text += "*";
        }

        private void Button_Plus_Click(object sender, System.EventArgs e)
        {
            EditZone.Text += "+";
        }

        private void Button_Minus_Click(object sender, System.EventArgs e)
        {
            EditZone.Text += "-";
        }

        private void Button_Clear_Click(object sender, System.EventArgs e)
        {
            EditZone.Text = "";
        }

        private double Factor(double number)
        {
            int num = (int)number;
            double rez = 1;

            for(int count = 1; count <= num; count++ )
            {
                rez *= count;
            }

            return rez;
        }

        private void Button_Equally_Click(object sender, System.EventArgs e)
        {
            int num;

            Sprache.Calc.XtensibleCalculator calc = new Sprache.Calc.XtensibleCalculator().RegisterFunction("F", (Num) => Factor(Num));

            if (this.Mode != 3)
            {

                try
                {
                    var res = calc.ParseExpression(this.EditZone.Text).Compile();

                    num = (int)res.Invoke();

                    this.EditZone.Text = num.ToString();

                    if (this.Mode == 2)
                    {
                        if (this.RadioButtons[0].Checked)
                        {
                            this.EditZone.Text = Convert.ToString(num, 2).ToString();
                        }
                        else if (this.RadioButtons[1].Checked)
                        {
                            this.EditZone.Text = Convert.ToString(num, 8).ToString();
                        }
                        else if (this.RadioButtons[2].Checked)
                        {
                            this.EditZone.Text = Convert.ToString(num, 10).ToString();
                        }
                        else
                        {
                            this.EditZone.Text = Convert.ToString(num, 16).ToString();
                        }
                    }
                    else
                    {
                        this.EditZone.Text = Convert.ToString(num, 10).ToString();
                    }
                }
                catch (Exception exp)
                {
                    this.EditZone.Text = exp.Message;
                }
            }
            else
            {
                this.EditZone.Text = (this.DateChanger[0].Value - this.DateChanger[1].Value).Duration().ToString();
            }
        }

        private void Button_0_Click(object sender, System.EventArgs e)
        {
            this.EditZone.Text += "0";
        }

        private void Button_9_Click(object sender, System.EventArgs e)
        {
            this.EditZone.Text += "9";
        }

        private void Button_8_Click(object sender, System.EventArgs e)
        {
            this.EditZone.Text += "8";
        }

        private void Button_7_Click(object sender, System.EventArgs e)
        {
            this.EditZone.Text += "7";
        }

        private void Button_6_Click(object sender, System.EventArgs e)
        {
            this.EditZone.Text += "6";
        }

        private void Button_5_Click(object sender, System.EventArgs e)
        {
            this.EditZone.Text += "5";
        }

        private void Button_4_Click(object sender, System.EventArgs e)
        {
            this.EditZone.Text += "4";
        }

        private void Button_3_Click(object sender, System.EventArgs e)
        {
            this.EditZone.Text += "3";
        }

        private void Button_2_Click(object sender, System.EventArgs e)
        {
            this.EditZone.Text += "2";
        }

        private void Button_1_Click(object sender, System.EventArgs e)
        {
            this.EditZone.Text += "1";
        }

        private void Chage_Mode()
        {
            switch(this.Mode)
            {
                case 0:
                    {
                        Buttons[0].Enabled = true;
                        Buttons[1].Enabled = true;
                        Buttons[2].Enabled = true;
                        Buttons[3].Enabled = true;
                        Buttons[4].Enabled = true;
                        Buttons[5].Enabled = true;
                        Buttons[6].Enabled = true;
                        Buttons[7].Enabled = true;
                        Buttons[8].Enabled = true;
                        Buttons[9].Enabled = true;
                        Buttons[10].Enabled = true;
                        Buttons[11].Enabled = true;
                        Buttons[12].Enabled = true;
                        Buttons[13].Enabled = true;
                        Buttons[14].Enabled = true;
                        Buttons[15].Enabled = true;
                        Buttons[16].Enabled = false;
                        Buttons[17].Enabled = false;
                        Buttons[18].Enabled = false;
                        Buttons[19].Enabled = false;
                        Buttons[20].Enabled = true;
                        Buttons[21].Enabled = true;

                        RadioButtons[0].Enabled = false;
                        RadioButtons[1].Enabled = false;
                        RadioButtons[2].Enabled = false;
                        RadioButtons[3].Enabled = false;

                        DateChanger[0].Enabled = false;
                        DateChanger[1].Enabled = false;

                        break;
                    }

                case 1:
                    {
                        Buttons[0].Enabled = true;
                        Buttons[1].Enabled = true;
                        Buttons[2].Enabled = true;
                        Buttons[3].Enabled = true;
                        Buttons[4].Enabled = true;
                        Buttons[5].Enabled = true;
                        Buttons[6].Enabled = true;
                        Buttons[7].Enabled = true;
                        Buttons[8].Enabled = true;
                        Buttons[9].Enabled = true;
                        Buttons[10].Enabled = true;
                        Buttons[11].Enabled = true;
                        Buttons[12].Enabled = true;
                        Buttons[13].Enabled = true;
                        Buttons[14].Enabled = true;
                        Buttons[15].Enabled = true;
                        Buttons[16].Enabled = true;
                        Buttons[17].Enabled = true;
                        Buttons[18].Enabled = true;
                        Buttons[19].Enabled = true;
                        Buttons[20].Enabled = true;
                        Buttons[21].Enabled = true;

                        RadioButtons[0].Enabled = false;
                        RadioButtons[1].Enabled = false;
                        RadioButtons[2].Enabled = false;
                        RadioButtons[3].Enabled = false;

                        DateChanger[0].Enabled = false;
                        DateChanger[1].Enabled = false;

                        break;
                    }

                case 2:
                    {
                        Buttons[0].Enabled = true;
                        Buttons[1].Enabled = true;
                        Buttons[2].Enabled = true;
                        Buttons[3].Enabled = true;
                        Buttons[4].Enabled = true;
                        Buttons[5].Enabled = true;
                        Buttons[6].Enabled = true;
                        Buttons[7].Enabled = true;
                        Buttons[8].Enabled = true;
                        Buttons[9].Enabled = true;
                        Buttons[10].Enabled = true;
                        Buttons[11].Enabled = true;
                        Buttons[12].Enabled = true;
                        Buttons[13].Enabled = true;
                        Buttons[14].Enabled = true;
                        Buttons[15].Enabled = true;
                        Buttons[16].Enabled = false;
                        Buttons[17].Enabled = false;
                        Buttons[18].Enabled = false;
                        Buttons[19].Enabled = false;
                        Buttons[20].Enabled = true;
                        Buttons[21].Enabled = true;

                        RadioButtons[0].Enabled = true;
                        RadioButtons[1].Enabled = true;
                        RadioButtons[2].Enabled = true;
                        RadioButtons[3].Enabled = true;

                        DateChanger[0].Enabled = false;
                        DateChanger[1].Enabled = false;

                        break;
                    }

                case 3:
                    {
                        Buttons[0].Enabled = false;
                        Buttons[1].Enabled = false;
                        Buttons[2].Enabled = false;
                        Buttons[3].Enabled = false;
                        Buttons[4].Enabled = false;
                        Buttons[5].Enabled = false;
                        Buttons[6].Enabled = false;
                        Buttons[7].Enabled = false;
                        Buttons[8].Enabled = false;
                        Buttons[9].Enabled = false;
                        Buttons[10].Enabled = true;
                        Buttons[11].Enabled = false;
                        Buttons[12].Enabled = false;
                        Buttons[13].Enabled = false;
                        Buttons[14].Enabled = false;
                        Buttons[15].Enabled = false;
                        Buttons[16].Enabled = false;
                        Buttons[17].Enabled = false;
                        Buttons[18].Enabled = false;
                        Buttons[19].Enabled = false;
                        Buttons[20].Enabled = false;
                        Buttons[21].Enabled = false;

                        RadioButtons[0].Enabled = false;
                        RadioButtons[1].Enabled = false;
                        RadioButtons[2].Enabled = false;
                        RadioButtons[3].Enabled = false;

                        DateChanger[0].Enabled = true;
                        DateChanger[1].Enabled = true;

                        break;
                    }
            }
        }

        private void MenuMode_DataCalc_Click(object sender, System.EventArgs e)
        {
            this.Mode = 3;

            Chage_Mode();

        }

        private void MenuMode_Programmer_Click(object sender, System.EventArgs e)
        {
            this.Mode = 2;
            
            Chage_Mode();
        }

        private void MenuMode_Enginner_Click(object sender, System.EventArgs e)
        {
            this.Mode = 1;

            Chage_Mode();
        }

        private void MenuMode_Normal_Click(object sender, System.EventArgs e)
        {
            this.Mode = 0;

            Chage_Mode();
        }

        private System.Windows.Forms.TableLayoutPanel Panel;

        private System.Windows.Forms.MenuStrip Menu;

        private System.Windows.Forms.ToolStripMenuItem MenuMode;

        private System.Windows.Forms.TextBox EditZone;

        private System.Windows.Forms.Button[] Buttons;

        private System.Windows.Forms.RadioButton[] RadioButtons;

        private System.Windows.Forms.DateTimePicker[] DateChanger;

        private int Mode;

        #endregion
    }
}

