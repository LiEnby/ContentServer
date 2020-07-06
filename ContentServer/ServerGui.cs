using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ContentServer
{
    public partial class ServerGui : Form
    {
        ContentServer cs;
        public ServerGui()
        {
            InitializeComponent();
        }

        public void AppendToConsole(string txt)
        {
            consoleOutput.AppendText(txt);
        }
        private void AddToList(string path)
        {
            try
            {
                string Name = Path.GetFileName(path);
                ContentItem ci = new ContentItem(Name, path);
                cs.Contents.Add(ci);
                serverContents.Items.Add(Name);
            }catch(FileNotFoundException)
            {
                MessageBox.Show("File \"" + path + "\" does not exist!", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ServerGui_Load(object sender, EventArgs e)
        {
            cs = new ContentServer();
        }

        private void addPKG_Click(object sender, EventArgs e)
        {
            OpenFileDialog pkgFileDialog = new OpenFileDialog();
            pkgFileDialog.Filter = "Packages|*.PKG";
            pkgFileDialog.Title = "Select a PKG File";
            if (pkgFileDialog.ShowDialog() == DialogResult.OK)
            {
                AddToList(pkgFileDialog.FileName);
            }
        }

        private void addPUP_Click(object sender, EventArgs e)
        {
            OpenFileDialog pupFileDialog = new OpenFileDialog();
            pupFileDialog.Filter = "Packages|*.PUP";
            pupFileDialog.Title = "Select a PUP File";
            if (pupFileDialog.ShowDialog() == DialogResult.OK)
            {
                AddToList(pupFileDialog.FileName);
            }
        }

        private void addMisc_Click(object sender, EventArgs e)
        {
            OpenFileDialog anyFileDialog = new OpenFileDialog();
            anyFileDialog.Filter = "Misc|*.*";
            anyFileDialog.Title = "Select a File";
            if (anyFileDialog.ShowDialog() == DialogResult.OK)
            {
                AddToList(anyFileDialog.FileName);
            }
        }

        private void addFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog addFolderDialog = new FolderBrowserDialog();
            if(addFolderDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileList = Directory.GetFiles(addFolderDialog.SelectedPath, "*", SearchOption.AllDirectories);
                foreach(string file in fileList)
                {
                    AddToList(file);
                }
            }
        }

        private void rmFile_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = serverContents.SelectedItem.ToString();

                foreach (ContentItem ci in cs.Contents)
                {
                    if (ci.name == Name)
                    {
                        cs.Contents.Remove(ci);
                        serverContents.Items.Remove(Name);
                        return;
                    }
                }
                
            }
            catch (Exception){ }
            
        }
        private void rmAll_Click(object sender, EventArgs e)
        {
            cs.Contents.Clear();
            serverContents.Items.Clear();
        }



        private void ServerGui_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill(); //kys
        }

    
    }
}
