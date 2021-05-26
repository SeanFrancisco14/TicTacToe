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
            gameBoard[0] = returnSymbol(current_Turn);
            button3.Text = gameBoard[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[0] = returnSymbol(current_Turn);
            button4.Text = gameBoard[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[0] = returnSymbol(current_Turn);
            button5.Text = gameBoard[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[0] = returnSymbol(current_Turn);
            button6.Text = gameBoard[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[0] = returnSymbol(current_Turn);
            button7.Text = gameBoard[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[0] = returnSymbol(current_Turn);
            button8.Text = gameBoard[0];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            current_Turn++;
            gameBoard[0] = returnSymbol(current_Turn);
            button9.Text = gameBoard[0];
        }
    }
}
