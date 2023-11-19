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

namespace ArtCal2
{
    public partial class MainScreen : Form
    {
        public string filePath = string.Empty;
        public string fileContent = string.Empty;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    StreamReader reader = new StreamReader(fileStream);
                    // * verwijderen. Export van CC maakt automatisch nieuwe lijnen.
                    // Naar de toekomst toe , * = newline integreren om ook andere software exports te kunnen gebruiken.

                    string line = "";
                    string line2 = "";
                    string multiline = "";
                    string CommandBlock = "";
                    char lineEnd = '*';
                    char commandC = '%';
                    char ch;


                    while (!reader.EndOfStream)
                    {
                        ch = (char)reader.Read();
                    }

                }
            }
        }
    }
}
