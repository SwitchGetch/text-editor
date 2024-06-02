using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // file
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(ofd.FileName);

                InitializeTabPage(file);
            }
        }

        private void button2_Click(object sender, EventArgs e) // save
        {
            if (tabControl1.Controls.Count > 0)
            {
                if (tabControl1.SelectedTab.Name != "")
                {
                    File.WriteAllText(tabControl1.SelectedTab.Name, tabControl1.SelectedTab.Controls[0].Text);
                }
                else
                {
                    SaveFileDialog sfd = new SaveFileDialog();

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string path = sfd.FileName;
                        FileInfo file = new FileInfo(path);
                        string name = file.Name;

                        File.WriteAllText(path, tabControl1.SelectedTab.Controls[0].Text);
                        tabControl1.SelectedTab.Name = path;
                        tabControl1.SelectedTab.Text = name;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // new
        {
            InitializeTabPage(IsNewFile : true);
        }

        private void button4_Click(object sender, EventArgs e) // close
        {
            if (tabControl1.Controls.Count > 0)
            {
                tabControl1.Controls.RemoveAt(tabControl1.SelectedIndex);
            }
        }
    }
}
