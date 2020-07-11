using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoeGame
{
    public partial class Form1 : Form
    {


        public enum Player
        {
            X, O
        }

        Player currentPlayer;


        public Form1()
        {
            InitializeComponent();
        }



            
        private void playAI(object sender, EventArgs e)
        {
                foreach (Control x in this.Controls)
                {
                    if (x is Button && x.Tag == "play")
                    {
                        x.Enabled = false;
                        currentPlayer = Player.O;
                        x.Text = currentPlayer.ToString();
                        x.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                        AITIMER.Stop();
                        Check();
                        break;
                    }
                    else
                    {
                        AITIMER.Stop();
                    }



                }
        }

        private void resetGame(object sender, EventArgs e)
        {
            label1.Text = "??";

            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag == "play")
                {
                    ((Button)x).Enabled = true;
                    ((Button)x).Text = "?";
                    ((Button)x).BackColor = default(Color);
                }
                

               

                
            }
        }

        private void buttonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = System.Drawing.Color.LightGreen;
            Check();
            AITIMER.Start();
        }

        private void Check()
        {

        }
    }
}
