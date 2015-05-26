using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication1
{
    class Controller
    {
        ErdoganTheMaster.WebServiceSoapClient client = new ErdoganTheMaster.WebServiceSoapClient();

        public void setFileText(string text, string filename) 
        {
            try 
            {
                client.ChangeTxtFile(text, filename);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }
        }

        public string getTextFile(string filename) 
        {
            string text = null;
            try
            {
                text = client.getTxtFile(filename);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return text;
        }
        public List<string> getFiles()
        {
            List<string> files = new List<string>();
            try
            {
                files = client.getAllFileNames();
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }      
            return files;
        }
    }
}
