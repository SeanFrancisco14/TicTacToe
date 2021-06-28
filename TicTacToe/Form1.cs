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

        public System.Drawing.Color determineColor(String symbol)
        {

            if (symbol.Equals("O"))
            {
                return System.Drawing.Color.LightGreen;
            }
            else if(symbol.Equals("X"))
            {
                return System.Drawing.Color.LightBlue;
            }
            return System.Drawing.Color.White;   
        }

        public void checkWinConditions()
        {
            for (int i=0; i<8; i++)
            {
                String combination = "";
                int one = 0, two = 0, three = 0;

                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        one = 0;
                        two = 1;
                        three = 2;
                        break;
                    case 1:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        one = 3;
                        two = 4;
                        three = 5;
                        break;
                    case 2:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        one = 6;
                        two = 7;
                        three = 8;
                        break;
                    case 3:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        one = 0;
                        two = 3;
                        three = 6;
                        break;
                    case 4:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        one = 1;
                        two = 4;
                        three = 7;
                        break;
                    case 5:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        one = 2;
                        two = 5;
                        three = 8;
                        break;
                    case 6:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        one = 0;
                        two = 4;
                        three = 8;
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        one = 2;
                        two = 4;
                        three = 6;
                        break;
                }

                if (combination.Equals("OOO"))
                {
                    change_Color(one);
                    change_Color(two);
                    change_Color(three);

                    MessageBox.Show("O wins the game! " + "\r\n" + "GG ");
                   
                }
                else if (combination.Equals("XXX"))
                {
                    change_Color(one);
                    change_Color(two);
                    change_Color(three);

                    MessageBox.Show("X wins the game! "+ "\r\n" + "GG ");
                    
                }

                checkDrawConditions();
            }

        }

        public void reset() 
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
            button4.BackColor = System.Drawing.Color.White;
            button5.BackColor = System.Drawing.Color.White;
            button6.BackColor = System.Drawing.Color.White;
            button7.BackColor = System.Drawing.Color.White;
            button8.BackColor = System.Drawing.Color.White;
            button9.BackColor = System.Drawing.Color.White;
            gameBoard = new string[9];
            current_Turn = 0;
        }

        public void change_Color(int number)
        {
            switch (number)
            {
                case 0:
                    button1.BackColor = System.Drawing.Color.Red;
                    break;
                case 1:
                    button2.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    button3.BackColor = System.Drawing.Color.Red;
                    break;
                case 3:
                    button4.BackColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    button5.BackColor = System.Drawing.Color.Red;
                    break;
                case 5:
                    button6.BackColor = System.Drawing.Color.Red;
                    break;
                case 6:
                    button7.BackColor = System.Drawing.Color.Red;
                    break;
                case 7:
                    button8.BackColor = System.Drawing.Color.Red;
                    break;
                case 8:
                    button9.BackColor = System.Drawing.Color.Red;
                    break;
            }
        }

        public void checkDrawConditions()
        {
            int counter = 0;
            for (int i = 0; i<gameBoard.Length; i++)
            { 
                if(gameBoard[i] != null) { counter++;}

                if (counter == 9) 
                {
                    reset();
                    MessageBox.Show("The game is a draw! " + "\r\n" + "WP" + MessageBoxButtons.OK + MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[0] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[0]);
            button1.BackColor = button_Color;
            button1.Text = gameBoard[0];
            checkWinConditions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[1] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[1]);
            button2.BackColor = button_Color;
            button2.Text = gameBoard[1];
            checkWinConditions();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[2] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[2]);
            button3.BackColor = button_Color;
            button3.Text = gameBoard[2];
            checkWinConditions();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[3] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[3]);
            button4.BackColor = button_Color;
            button4.Text = gameBoard[3];
            checkWinConditions();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[4] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[4]);
            button5.BackColor = button_Color;
            button5.Text = gameBoard[4];
            checkWinConditions();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[5] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[5]);
            button6.BackColor = button_Color;
            button6.Text = gameBoard[5];
            checkWinConditions();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[6] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[6]);
            button7.BackColor = button_Color;
            button7.Text = gameBoard[6];
            checkWinConditions();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[7] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[7]);
            button8.BackColor = button_Color;
            button8.Text = gameBoard[7];
            checkWinConditions();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[8] = returnSymbol(current_Turn);
            Color button_Color = determineColor(gameBoard[8]);
            button9.BackColor = button_Color;
            button9.Text = gameBoard[8];
            checkWinConditions();
        }

        private void reset_Button_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
