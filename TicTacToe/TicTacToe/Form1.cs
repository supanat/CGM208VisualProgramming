using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Collections;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int activeplayer = 1;
        List<int> player1 = new List<int>();
        List<int> player2 = new List<int>();



        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            

            if(activeplayer == 1)
            {
                btn1.Text = "X";
                activeplayer = 2;
                player1.Add(1);
            }
            else
            {
                btn1.Text = "O";
                activeplayer = 1;
                player2.Add(1);
            }

            btn1.Enabled = false;
            FindWinner();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (activeplayer == 1)
            {
                btn2.Text = "X";
                player1.Add(2);
                activeplayer = 2;
            }
            else
            {
                btn2.Text = "O";
                player2.Add(2);
                activeplayer = 1;
            }

            btn2.Enabled = false;
            FindWinner();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (activeplayer == 1)
            {
                btn3.Text = "X";
                player1.Add(3);
                activeplayer = 2;
            }
            else
            {
                btn3.Text = "O";
                player2.Add(3);
                activeplayer = 1;
            }

            btn3.Enabled = false;
            FindWinner();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (activeplayer == 1)
            {
                btn4.Text = "X";
                player1.Add(4);
                activeplayer = 2;
            }
            else
            {
                btn4.Text = "O";
                player2.Add(4);
                activeplayer = 1;
            }

            btn4.Enabled = false;
            FindWinner();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (activeplayer == 1)
            {
                btn5.Text = "X";
                player1.Add(5);
                activeplayer = 2;

            }
            else
            {
                btn5.Text = "O";
                player2.Add(5);
                activeplayer = 1;
            }

            btn5.Enabled = false;
            FindWinner();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (activeplayer == 1)
            {
                btn6.Text = "X";
                player1.Add(6);
                activeplayer = 2;
            }
            else
            {
                btn6.Text = "O";
                player2.Add(6);
                activeplayer = 1;
            }

            btn6.Enabled = false;
            FindWinner();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (activeplayer == 1)
            {
                btn7.Text = "X";
                player1.Add(7);
                activeplayer = 2;
            }
            else
            {
                btn7.Text = "O";
                player2.Add(7);
                activeplayer = 1;
            }

            btn7.Enabled = false;
            FindWinner();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (activeplayer == 1)
            {
                btn8.Text = "X";
                player1.Add(8);
                activeplayer = 2;
            }
            else
            {
                btn8.Text = "O";
                player2.Add(8);
                activeplayer = 1;
            }

            btn8.Enabled = false;
            FindWinner();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (activeplayer == 1)
            {
                btn9.Text = "X";
                player1.Add(9);
                activeplayer = 2;
            }
            else
            {
                btn9.Text = "O";
                player2.Add(9);
                activeplayer = 1;
            }

            btn9.Enabled = false;
            FindWinner();
        }

        private void FindWinner()
        {
            //Rows1
            if (player1.Contains(1) && player1.Contains(2) && player1.Contains(3))
            {
                MessageBox.Show("Player1 Win !!!");
            }
            if (player2.Contains(1) && player2.Contains(2) && player2.Contains(3))
            {
                MessageBox.Show("Player2 Win !!!");
            }




            //Rows2
            if (player1.Contains(4) && player1.Contains(5) && player1.Contains(6))
            {
                MessageBox.Show("Player1 Win !!!");
            }
            if (player2.Contains(4) && player2.Contains(5) && player2.Contains(6))
            {
                MessageBox.Show("Player2 Win !!!");
            }


            //Rows3
            if (player1.Contains(7) && player1.Contains(8) && player1.Contains(9))
            {
                MessageBox.Show("Player1 Win !!!");
            }
            if (player2.Contains(7) && player2.Contains(8) && player2.Contains(9))
            {
                MessageBox.Show("Player2 Win !!!");
            }

            //diagonal
            if (player1.Contains(1) && player1.Contains(5) && player1.Contains(9))
            {
                MessageBox.Show("Player1 Win !!!");
            }
            if (player2.Contains(1) && player2.Contains(5) && player2.Contains(9))
            {
                MessageBox.Show("Player2 Win !!!");
            }

            if (player1.Contains(3) && player1.Contains(5) && player1.Contains(7))
            {
                MessageBox.Show("Player1 Win !!!");
            }
            if (player2.Contains(3) && player2.Contains(5) && player2.Contains(7))
            {
                MessageBox.Show("Player2 Win !!!");
            }


        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.Clear();
            player2.Clear();
            activeplayer = 1;

            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = true;

        }
    }
}
