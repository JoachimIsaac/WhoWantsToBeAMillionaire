using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace WhoWantsToBeAMillionaire
{
    public partial class Form2 : Form
    {
        public static ArrayList questions = new ArrayList(15);
  
        List<List<string>> answers = new List<List<string>>(15);

        public static Hashtable answer_key = new Hashtable();
     
        public int current_level = 0;



        public Form2()
        {
            InitializeComponent();
            

                }


        public void load_questions_and_answers()
        {
            var counter = 0;
            var temp_array = new List<string>();

            foreach (string current_string in Form1.input)
            {
                if (counter == 0)
                {
                    questions.Add(current_string);
                    counter += 1;
                }
                else
                {
                    temp_array.Add(current_string);
                    counter += 1;
                    if (counter == 5)
                    {
                        counter = 0;
                        answers.Add(temp_array);
                        temp_array = new List<string>();

                    }
                }

            }

            for (var index = 0; index < 15; index++)
            {
                answer_key.Add(questions[index], answers[index][0]);
                //Console.WriteLine("test starts here");
                //Console.WriteLine(answers[index][0]);
                //Console.WriteLine(answers[index][1]);
                //Console.WriteLine(answers[index][2]);
                //Console.WriteLine(answers[index][3]);
            }

        }

        public void load_buttons_and_labels(int index)
        {
            label1.Text = questions[index].ToString();
            


            button1.Text = answers[index][0];
            button2.Text = answers[index][1];
            button3.Text = answers[index][2];
            button4.Text = answers[index][3];


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            load_questions_and_answers();

            label1.Text = "Welcome to who wants to win a million dollars!!!";
            
            load_buttons_and_labels(current_level);

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Shown(object sender, EventArgs e)
        {
           
           

        }
    }
}
