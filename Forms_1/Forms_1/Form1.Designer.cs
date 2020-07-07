using System.Collections.Specialized;
using System.Windows.Forms;

namespace Forms_1
{
    partial class Form1
    {
        static bool turn = true;

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
            this.label = new System.Windows.Forms.Label();

            this.panel = new System.Windows.Forms.TableLayoutPanel();

            this.butstartgame = new System.Windows.Forms.Button();

            this.butrestartgame = new System.Windows.Forms.Button();



            buttons = new System.Windows.Forms.Button[9];

            this.SuspendLayout();
            // 
            // panel
            // 
            this.label.Text = "Tic Tac Toe";
            this.label.Size = new System.Drawing.Size(100, 100);
            //this.label.Location = new System.Drawing.Point((this.Location.X + this.Width) / 2);

            this.butstartgame.Text = "Start Game";
            this.butstartgame.Size = new System.Drawing.Size(100, 100);

            this.butrestartgame.Text = "Restart Game";
            this.butrestartgame.Size = new System.Drawing.Size(100, 100);

            //this.panel.Location = new System.Drawing.Point(this.label.Location.Y);
            this.panel.AutoSize = true;
            this.panel.ColumnCount = 3;
            this.panel.Name = "panel";
            this.panel.RowCount = 4;
            //this.panel.Location = new System.Drawing.Point(this.Location.X, this.label.Location.Y + 20);
            // 
            // Form1
            //

            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panel.Controls.Add(this.butstartgame);
            this.panel.Controls.Add(this.label);
            this.panel.Controls.Add(this.butrestartgame);

            this.butrestartgame.Enabled = false;

            for (int count = 0; count < 9; count++)
            {
                this.buttons[count] = new System.Windows.Forms.Button();
                this.buttons[count].Text = "";
                this.buttons[count].Size = new System.Drawing.Size(100, 100);
                this.panel.Controls.Add(buttons[count]);
                this.buttons[count].Enabled = false;
                this.buttons[count].Click += Form1_Click;
            }

            //panel.Controls.Add(buttons[0]);

            this.AutoSize = true;
            //this.ClientSize = new System.Drawing.Size(284, 261);
            //this.Controls.Add(this.label);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();


            this.butstartgame.Click += Butstartgame_Click;
            this.butrestartgame.Click += Butrestartgame_Click;

        }

        private void Butrestartgame_Click(object sender, System.EventArgs e)
        {
            Clear();
            this.butstartgame.Enabled = true;
            this.butrestartgame.Enabled = false;

            Lock();

        }

        private void Form1_Click(object sender, System.EventArgs e)
        {
            if (turn)
            {
                turn = !turn;
                (sender as System.Windows.Forms.Button).Text = "X";
            }
            else
            {
                turn = !turn;
                (sender as System.Windows.Forms.Button).Text = "O";
            }

            (sender as System.Windows.Forms.Button).Enabled = false;

            check();

        }

        private void Butstartgame_Click(object sender, System.EventArgs e)
        {
            this.butstartgame.Enabled = false;
            this.butrestartgame.Enabled = true;

            for (int count = 0; count < 9; count++)
            {
                this.buttons[count].Enabled = true;
            }
        }

        void check()
        {
            if (buttons[0].Text == "X" && buttons[1].Text == "X" && buttons[2].Text == "X")
            {
                MessageBox.Show("Player X is winner!");
                Lock();
            }
            else if (buttons[3].Text == "X" && buttons[4].Text == "X" && buttons[5].Text == "X")
            {
                MessageBox.Show("Player X is winner!");
                Lock();
            }
            else if (buttons[6].Text == "X" && buttons[7].Text == "X" && buttons[8].Text == "X")
            {
                MessageBox.Show("Player X is winner!");
                Lock();
            }
            else if (buttons[0].Text == "X" && buttons[3].Text == "X" && buttons[6].Text == "X")
            {
                MessageBox.Show("Player X is winner!");
                Lock();
            }
            else if (buttons[1].Text == "X" && buttons[4].Text == "X" && buttons[7].Text == "X")
            {
                MessageBox.Show("Player X is winner!");
                Lock();
            }
            else if (buttons[2].Text == "X" && buttons[5].Text == "X" && buttons[8].Text == "X")
            {
                MessageBox.Show("Player X is winner!");
                Lock();
            }
            else if (buttons[0].Text == "X" && buttons[4].Text == "X" && buttons[8].Text == "X")
            {
                MessageBox.Show("Player X is winner!");
                Lock();
            }
            else if (buttons[2].Text == "X" && buttons[4].Text == "X" && buttons[6].Text == "X")
            {
                MessageBox.Show("Player X is winner!");
                Lock();
            }
            //
            else if (buttons[0].Text == "O" && buttons[1].Text == "O" && buttons[2].Text == "O")
            {
                MessageBox.Show("Player O is winner!");
                Lock();
            }
            else if (buttons[3].Text == "O" && buttons[4].Text == "O" && buttons[5].Text == "O")
            {
                MessageBox.Show("Player O is winner!");
                Lock();
            }
            else if (buttons[6].Text == "O" && buttons[7].Text == "O" && buttons[8].Text == "O")
            {
                MessageBox.Show("Player O is winner!");
                Lock();
            }
            else if (buttons[0].Text == "O" && buttons[3].Text == "O" && buttons[6].Text == "O")
            {
                MessageBox.Show("Player O is winner!");
                Lock();
            }
            else if (buttons[1].Text == "O" && buttons[4].Text == "O" && buttons[7].Text == "O")
            {
                MessageBox.Show("Player O is winner!");
                Lock();
            }
            else if (buttons[2].Text == "O" && buttons[5].Text == "O" && buttons[8].Text == "O")
            {
                MessageBox.Show("Player O is winner!");
                Lock();
            }
            else if (buttons[0].Text == "O" && buttons[4].Text == "O" && buttons[8].Text == "O")
            {
                MessageBox.Show("Player O is winner!");
                Lock();
            }
            else if (buttons[2].Text == "O" && buttons[4].Text == "O" && buttons[6].Text == "O")
            {
                MessageBox.Show("Player O is winner!");
                Lock();
            }
            //
            else
            {
                if(this.buttons[0].Enabled == false && this.buttons[1].Enabled == false && this.buttons[2].Enabled == false && this.buttons[3].Enabled == false && this.buttons[4].Enabled == false && this.buttons[5].Enabled == false && this.buttons[6].Enabled == false && this.buttons[7].Enabled == false && this.buttons[8].Enabled == false)
                {
                    MessageBox.Show("Nobody!");
                }
                
            }
        }

        void Lock()
        {
            for(int count = 0; count < 9; count++)
            {
                this.buttons[count].Enabled = false;
            }
        }

        void Clear()
        {
            for (int count = 0; count < 9; count++)
            {
               // this.buttons[count].Enabled = true;
                this.buttons[count].Text = "";
            }
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel;
        private System.Windows.Forms.Button [] buttons;
        private System.Windows.Forms.Button butstartgame;
        private System.Windows.Forms.Button butrestartgame;
        private System.Windows.Forms.Label label;
    }
}

