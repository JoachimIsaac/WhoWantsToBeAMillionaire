using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
    public partial class Infile : Form
    {
        public Infile()
        {
            InitializeComponent();
        }

        public static string[] input;
        public static bool loadedFile = false;


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.Text = openFileDialog1.FileName;
                input = System.IO.File.ReadAllLines( label2.Text);
               
                Game frm2 = new Game();
                this.Hide();
                frm2.ShowDialog();
            }
        }

       
    }
}
