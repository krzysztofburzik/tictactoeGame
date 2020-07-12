using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
                    if (x is Button && x.Text == "?" && x.Enabled)
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

        private void WON()
        {
            foreach (Control x in this.Controls)
            {


                if (x is Button && x.Tag == "play")
                {
                    ((Button)x).Enabled = false;
                    ((Button)x).BackColor = default(Color);
                        }
            }
        }

        private void Check()
        {
            if (
                button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                )
            {
                WON();
                label1.Text = "X Wygrywa!";
            }
            else if
                (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                WON();
                label1.Text = "O Wygrywa!";
            }
            {
        
        }



        }
    }
}
