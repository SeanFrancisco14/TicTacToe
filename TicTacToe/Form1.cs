using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] gameBoard = new string[9];
        int current_Turn = 0;

        public String returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else 
            {
                return "X";
            }
        }

        public void checkWinConditions()
        {
            for (int i=0; i<8; i++)
            {
                String combination = "";

                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        break;
                    case 6:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[7];
                        break;
                    case 7:
                        combination = gameBoard[3] + gameBoard[5] + gameBoard[8];
                        break;
                }

                if (combination.Equals("OOO"))
                {
                    MessageBox.Show("O wins the game!" + MessageBoxButtons.OK + MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("X wins the game!" + MessageBoxButtons.OK + MessageBoxIcon.Exclamation);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[0] = returnSymbol(current_Turn);
            button1.Text = gameBoard[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[0] = returnSymbol(current_Turn);
            button2.Text = gameBoard[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[1] = returnSymbol(current_Turn);
            button3.Text = gameBoard[1];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[3] = returnSymbol(current_Turn);
            button4.Text = gameBoard[3];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[4] = returnSymbol(current_Turn);
            button5.Text = gameBoard[4];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[5] = returnSymbol(current_Turn);
            button6.Text = gameBoard[5];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[6] = returnSymbol(current_Turn);
            button7.Text = gameBoard[6];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[7] = returnSymbol(current_Turn);
            button8.Text = gameBoard[7];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[8] = returnSymbol(current_Turn);
            button9.Text = gameBoard[8];
        }
    }
}
