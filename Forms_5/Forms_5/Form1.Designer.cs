using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.IO;
using System;

namespace Forms_5
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
            this.HomePage = "https://www.yandex.ru";

            this.Panel = new System.Windows.Forms.TableLayoutPanel() { RowCount = 3, Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom, Dock = System.Windows.Forms.DockStyle.Fill };

            this.Menu = new System.Windows.Forms.MenuStrip();

            this.MenuDo = new System.Windows.Forms.ToolStripMenuItem("Tasks");

            this.Tab = new System.Windows.Forms.TabControl() { Dock = System.Windows.Forms.DockStyle.Fill };

            this.Addres = new System.Windows.Forms.TextBox() { Dock = System.Windows.Forms.DockStyle.Fill };

            First_open();

            this.MenuDo.DropDownItems.Add("Go");
            this.MenuDo.DropDownItems.Add("Next");
            this.MenuDo.DropDownItems.Add("Back");
            this.MenuDo.DropDownItems.Add("Home");
            this.MenuDo.DropDownItems.Add("Close tab");
            this.MenuDo.DropDownItems.Add("Open tab");

            this.MenuDo.DropDownItems[0].Click += Web_Go_Click;
            this.MenuDo.DropDownItems[1].Click += Web_Next_Click;
            this.MenuDo.DropDownItems[2].Click += Web_Back_Click;
            this.MenuDo.DropDownItems[3].Click += Web_Home_Click;

            this.Addres.KeyDown += Addres_KeyDown;

            this.MenuDo.DropDownItems[4].Click += Tab_CloseTab_Click;
            this.MenuDo.DropDownItems[5].Click += Tab_OpenTab_Click;

            this.Menu.Items.Add(this.MenuDo);

            this.Panel.Controls.Add(this.Menu, 0, 0);

            this.Panel.Controls.Add(this.Addres, 0, 1);

            this.Panel.Controls.Add(this.Tab, 0, 2);

            this.components = new System.ComponentModel.Container();
            this.AutoSize = true;
            this.Controls.Add(this.Panel);
            this.Text = "Browser";
        }

        private void Addres_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                (Tab.SelectedTab.Controls[0] as WebBrowser).Navigate(this.Addres.Text);
            }
        }

        private void Web_Next_Click(object sender, System.EventArgs e)
        {
            if ((Tab.SelectedTab.Controls[0] as WebBrowser).CanGoForward)
            {
                (Tab.SelectedTab.Controls[0] as WebBrowser).GoForward();
            }
        }

        private void Tab_OpenTab_Click(object sender, System.EventArgs e)
        {
            First_open();
        }

        private void Tab_CloseTab_Click(object sender, System.EventArgs e)
        {
            if(this.Tab.TabCount == 1)
            {
                Application.Exit();
            }
            else
            {
                this.Tab.TabPages.Remove(this.Tab.SelectedTab);
            }
        }

        private void Web_Home_Click(object sender, System.EventArgs e)
        {
            (Tab.SelectedTab.Controls[0] as WebBrowser).Navigate(HomePage);   
        }

        private void Web_Back_Click(object sender, System.EventArgs e)
        {
            if ((Tab.SelectedTab.Controls[0] as WebBrowser).CanGoBack)
            {
                (Tab.SelectedTab.Controls[0] as WebBrowser).GoBack();
            }
        }

        private void Web_Go_Click(object sender, System.EventArgs e)
        {
            (Tab.SelectedTab.Controls[0] as WebBrowser).Navigate(this.Addres.Text);
        }

        private void First_open()
        {
            TabPage tab = new TabPage("New tab");
            WebBrowser web = new WebBrowser();
            web.Dock = DockStyle.Fill;
            tab.Controls.Add(web);
            web.Navigate(HomePage);
            this.Tab.TabPages.Add(tab);
            this.Addres.Text = HomePage;

            web.ScriptErrorsSuppressed = true;

            web.Navigated += Web_Navigated;
            web.NewWindow += Web_NewWindow;

        }

        private void Web_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (sender as WebBrowser).Url = new System.Uri((sender as WebBrowser).StatusText);
            e.Cancel = true;
            
        }

        private void Web_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

            StreamWriter sw;

            if(!File.Exists("Journal.txt"))
            {
                File.Create("Journal.txt").Close();
            }

            sw = new StreamWriter("Journal.txt", true);

            sw.WriteLine(e.Url.AbsoluteUri);
            this.Addres.Text = e.Url.AbsoluteUri;

            sw.Close();

        }

        private System.Windows.Forms.TableLayoutPanel Panel;

        private System.Windows.Forms.TabControl Tab;

        private System.Windows.Forms.MenuStrip Menu;

        private System.Windows.Forms.ToolStripMenuItem MenuDo;

        private System.Windows.Forms.TextBox Addres;

        private string HomePage;

        #endregion
    }
}

