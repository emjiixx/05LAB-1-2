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

namespace RegistrationTextFile
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        public bool NoFileName()
        {
            try
            {
                if (lvShowRecord.Items.Count == 0)
                {
                    throw new IOException("No items have been selected. Please select a text file.");
                }
                return true;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error File Name");
                return false;
            }
        }

        public void DisplayToList()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            ofdFind.InitialDirectory = @"C:\Users\emjix\OneDrive\Documents";
            ofdFind.Title = "Browse Text Files";
            ofdFind.DefaultExt = "txt";
            ofdFind.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofdFind.ShowDialog();
            path = ofdFind.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowRecord.Items.Add(_getText);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (NoFileName())
            {
                lvShowRecord.Items.Clear();
                MessageBox.Show("Successfully Uploaded!");
            }
        }
    }
}
