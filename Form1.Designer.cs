using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeTabPage(FileInfo file = null, bool IsNewFile = false)
        {
            TabPage tabPage = new TabPage();

            tabPage.BackColor = SystemColors.ActiveCaption;
            tabPage.Location = new Point(4, 24);
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(786, 371);
            tabPage.Name = IsNewFile ? "" : file.FullName; ;
            tabPage.Text = IsNewFile ? "New File" : file.Name; ;
            tabPage.Controls.Add(InitializeTextBox(file, IsNewFile));

            tabPage.ResumeLayout(false);
            tabPage.PerformLayout();
            tabPage.SuspendLayout();

            tabControl1.Controls.Add(tabPage);
            tabControl1.SelectTab(tabPage);
        }

        private TextBox InitializeTextBox(FileInfo file, bool IsNewFile)
        {
            TextBox textBox = new TextBox();

            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(3, 3);
            textBox.Multiline = true;
            textBox.Size = new Size(780, 365);
            textBox.Text = IsNewFile ? "" : File.ReadAllText(file.FullName);
            textBox.TabIndex = 0;
            textBox.ScrollBars = ScrollBars.Both;

            return textBox;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        ////
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1 = new TabControl();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 9);
            tableLayoutPanel1.Controls.Add(button2, 2, 9);
            tableLayoutPanel1.Controls.Add(button3, 6, 9);
            tableLayoutPanel1.Controls.Add(button4, 8, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tableLayoutPanel1.SetColumnSpan(tabControl1, 10);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tableLayoutPanel1.SetRowSpan(tabControl1, 9);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 399);
            tabControl1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.SetColumnSpan(button1, 2);
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 408);
            button1.Name = "button1";
            button1.Size = new Size(154, 39);
            button1.TabIndex = 1;
            button1.Text = "File";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.SetColumnSpan(button2, 2);
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(163, 408);
            button2.Name = "button2";
            button2.Size = new Size(154, 39);
            button2.TabIndex = 2;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.SetColumnSpan(button3, 2);
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(483, 408);
            button3.Name = "button3";
            button3.Size = new Size(154, 39);
            button3.TabIndex = 3;
            button3.Text = "New";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.SetColumnSpan(button4, 2);
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(643, 408);
            button4.Name = "button4";
            button4.Size = new Size(154, 39);
            button4.TabIndex = 4;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
