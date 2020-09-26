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
    public partial class Form1 : Form
    {
        public Form1()
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
                textBox1.Text = openFileDialog1.FileName;

                Thread.Sleep(3000);
                Console.WriteLine(textBox1);
                input = System.IO.File.ReadAllLines( textBox1.Text);
                ///input = System.IO.File.ReadAllLines(@"C:\Users\joachim\source\repos\WhoWantsToBeAMillionaire\WhoWantsToBeAMillionaire\MillFile.txt");
            
                foreach (string line in input)
                {
                    Console.WriteLine(line);
                   
                }



                Form2 frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
