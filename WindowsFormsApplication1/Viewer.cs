using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Viewer : Form
    {
        Controller controller = new Controller();

        public Viewer()
        {
            InitializeComponent();
        }

        private void VeiweFiles(object sender, EventArgs e)
        {
            List<string> files = controller.getFiles();
            fileListBox.Items.Clear();

            foreach(string file in files)
            {
                fileListBox.Items.Add(file);
            }
        }
    
        private void FileSelected(object sender, EventArgs e)
        {
            textBox.Text = controller.getTextFile(fileListBox.GetItemText(fileListBox.SelectedItem));
        }

        private void CommitChanges(object sender, EventArgs e)
        {
            controller.setFileText(textBox.Text, fileListBox.GetItemText(fileListBox.SelectedItem));
        }
    }
}
