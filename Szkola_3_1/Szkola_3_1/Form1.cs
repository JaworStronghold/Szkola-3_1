using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Szkola_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();



            /*
             SaveFileDialog saveFileDialog1 = new SaveFileDialog();

             if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                 using (StreamWriter sw = new StreamWriter(s))
                 {
                     sw.Write(textBox1.Text);
                 }
             }
             */
        }


        //zapis
        private void SaveFile()
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(textBox1.Text);
                    sw.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }


        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }


            /*
            Stream Agoddamnstream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();


            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((Agoddamnstream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    MessageBox.Show(strfilename);
                    textBox1.Text = filetext;
                }
            }
            */
        }

       private void openFileDialog1_FileOk(object sender, EventArgs e)
        {

        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Jakub Jaworski");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are u sure u want to quit the app?", ":(", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fd.Font;
            }
        }
    }
}
