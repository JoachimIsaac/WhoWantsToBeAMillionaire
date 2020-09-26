using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
    public partial class Form3 : Form

    {

        public bool gameOver;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        public void load_game_state(bool outcome)
        {
            gameOver = outcome;

            if (gameOver)
            {
                label1.Text = "YOU LOOSE!!!!!!";
               
            }
            else
            {
                label1.Text = "YOU WIN A MILLION DOLLARS!!!";
            }
        }


        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
