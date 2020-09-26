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

namespace WhoWantsToBeAMillionaire
{
    public partial class Form2 : Form
    {
        public static ArrayList questions = new ArrayList();
        //public static ArrayList answers = new ArrayList();
        List<List<string>> answers = new List<List<string>>(15);
        public static Hashtable answer_key = new Hashtable();
     




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

        private void Form2_Load(object sender, EventArgs e)
        {

            load_questions_and_answers();


           // Console.WriteLine(answers.Count + "working answers");
           // Console.WriteLine(questions.Count + "working questions");
            //Console.WriteLine(answer_key.Count + "working answer key ");

           // Console.WriteLine(answer_key[questions[0]]);
           // Console.WriteLine(answer_key[questions[2]]);

           
            //Game starts here , we want to go through the 


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
