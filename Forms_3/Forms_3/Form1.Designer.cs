using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;

namespace Forms_3
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

            this.Opener = new OpenFileDialog() { Filter = "RTF(*.rtf)|*.rtf" };
            this.Saver = new SaveFileDialog() { Filter = "RTF(*.rtf)|*.rtf" };

            this.Panel = new TableLayoutPanel() { RowCount = 2, AutoSize = true, Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom, Dock = DockStyle.Fill };

            this.Edit = new RichTextBox() { AutoSize = true, Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom, Dock = DockStyle.Fill };

            this.Context = new MenuStrip() { AutoSize = true, Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom, Dock = DockStyle.Fill };

            this.Context2 = new ContextMenuStrip();

            this.MenuFile = new ToolStripMenuItem("File");
            this.MenuEdit = new ToolStripMenuItem("Edit");

            this.MenuFile.DropDownItems.Add("Open file");
            this.MenuFile.DropDownItems.Add("Save file");

            this.MenuEdit.DropDownItems.Add("Select All");
            this.MenuEdit.DropDownItems.Add("Format");
            this.MenuEdit.DropDownItems.Add("Change Color");
            this.MenuEdit.DropDownItems.Add("Copy");
            this.MenuEdit.DropDownItems.Add("Paste");
            this.MenuEdit.DropDownItems.Add("Delete");
            this.MenuEdit.DropDownItems.Add("Align Left");
            this.MenuEdit.DropDownItems.Add("Align Center");
            this.MenuEdit.DropDownItems.Add("Align Right");
            this.MenuEdit.DropDownItems.Add("Change the line spasing 1");
            this.MenuEdit.DropDownItems.Add("Create list");

            this.Context2.Items.Add("Copy");
            this.Context2.Items.Add("Paste");
            this.Context2.Items.Add("Select all");
            this.Context2.Items.Add("Delete");

            this.Edit.ContextMenuStrip = this.Context2;

            this.Context.Items.Add(this.MenuFile);
            this.Context.Items.Add(this.MenuEdit);

            this.MenuFile.DropDownItems[0].Click += MenuFile_Open_Click;
            this.MenuFile.DropDownItems[1].Click += MenuFile_Save_Click;

            this.MenuEdit.DropDownItems[1].Click += MenuEdit_Format_Click;
            this.MenuEdit.DropDownItems[2].Click += MenuEdit_Change_Color_Click;
            this.MenuEdit.DropDownItems[6].Click += MenuEdit_Align_Left_Click;
            this.MenuEdit.DropDownItems[7].Click += MenuEdit_Align_Center_Click;
            this.MenuEdit.DropDownItems[8].Click += MenuEdit_Align_Right_Click;
            this.MenuEdit.DropDownItems[9].Click += MenuEdit_Change_the_line_space_Click;
            this.MenuEdit.DropDownItems[10].Click += MenuEdit_Create_List_Click;

            this.MenuEdit.DropDownItems[0].Click += Select_all_Click;
            this.MenuEdit.DropDownItems[3].Click += Copy_Click;
            this.MenuEdit.DropDownItems[4].Click += Paste_Click;
            this.MenuEdit.DropDownItems[5].Click += Delete_Click;

            this.Context2.Items[0].Click += Copy_Click;
            this.Context2.Items[1].Click += Paste_Click;
            this.Context2.Items[2].Click += Select_all_Click;
            this.Context2.Items[3].Click += Delete_Click;

            this.Panel.Controls.Add(this.Context, 0, 0);
            this.Panel.Controls.Add(this.Edit, 0, 1);

            this.components = new System.ComponentModel.Container();
            this.AutoSize = true;
            this.Controls.Add(this.Panel);
            this.Text = "TextEditor";
        }

        private void MenuFile_Save_Click(object sender, System.EventArgs e)
        {
            DialogResult res = this.Saver.ShowDialog();

            if(res == DialogResult.OK)
            {
                File.Create(this.Saver.FileName).Close();
                Edit.SaveFile(this.Saver.FileName);

            }

        }

        

        private void MenuFile_Open_Click(object sender, System.EventArgs e)
        {
            DialogResult res = this.Opener.ShowDialog();

            if(res == DialogResult.OK)
            {
                Edit.LoadFile(this.Opener.FileName);
            }

        }

        private void MenuEdit_Create_List_Click(object sender, System.EventArgs e)
        {
            Edit.SelectionBullet = true;
            Edit.SelectionIndent = 8;
            Edit.SelectionHangingIndent = 3;
            Edit.SelectionRightIndent = 12;
        }

        private void MenuEdit_Change_the_line_space_Click(object sender, System.EventArgs e)
        {

            switch (this.Mode)
            {
                case 0:
                    {
                        Edit.SelectionCharOffset = 1;
                        this.Mode++;
                        this.MenuEdit.DropDownItems[9].Text = "Change the line spasing 2";
                        break;
                    }

                case 1:
                    {
                        Edit.SelectionCharOffset = 2;
                        this.Mode++;
                        this.MenuEdit.DropDownItems[9].Text = "Change the line spasing 3";
                        break;
                    }

                case 2:
                    {
                        Edit.SelectionCharOffset = 3;
                        this.Mode++;
                        this.MenuEdit.DropDownItems[9].Text = "Change the line spasing 0";
                        break;
                    }

                case 3:
                    {
                        Edit.SelectionCharOffset = 0;
                        this.Mode = 0;
                        this.MenuEdit.DropDownItems[9].Text = "Change the line spasing 1";
                        break;
                    }
            }

        }

        private void MenuEdit_Align_Right_Click(object sender, System.EventArgs e)
        {
            Edit.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void MenuEdit_Align_Center_Click(object sender, System.EventArgs e)
        {
            Edit.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void MenuEdit_Align_Left_Click(object sender, System.EventArgs e)
        {
            Edit.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            Edit.SelectedText = ""; 
        }

        private void Paste_Click(object sender, System.EventArgs e)
        {
            Edit.Paste();
        }

        private void Copy_Click(object sender, System.EventArgs e)
        {
            Edit.Copy();
        }

        private void MenuEdit_Change_Color_Click(object sender, System.EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            DialogResult res = dialog.ShowDialog();

            if(res == DialogResult.OK)
            {
                Edit.SelectionColor = dialog.Color;
            }
        }

        private void MenuEdit_Format_Click(object sender, System.EventArgs e)
        {
            FontDialog dialog = new FontDialog();

            DialogResult res = dialog.ShowDialog();

            if(res == DialogResult.OK)
            {
                Edit.SelectionFont = dialog.Font;
            }


        }

        private void Select_all_Click(object sender, System.EventArgs e)
        {
            Edit.SelectAll();
        }

        private System.Windows.Forms.TableLayoutPanel Panel;

        private System.Windows.Forms.MenuStrip Context;

        private System.Windows.Forms.ContextMenuStrip Context2;

        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;

        private System.Windows.Forms.RichTextBox Edit;

        private System.Windows.Forms.OpenFileDialog Opener;
        
        private System.Windows.Forms.SaveFileDialog Saver;

        private int Mode;

        #endregion
    }
}

