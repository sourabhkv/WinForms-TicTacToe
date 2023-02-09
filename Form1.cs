using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tictactoe
{
    public partial class Form1 : Form
    {
        public int[] board = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        public int turn = 0,win=0;

        public void reset()
        {
            board = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            turn = 0;
            win = 0;
        }
        public void checkWin(int n)
        {
            if ((board[0]==n && board[1] == n && board[2] == n) || (board[3] == n && board[4] == n && board[5] == n) || (board[6] == n && board[7] == n && board[8] == n) || (board[3] == n && board[0] == n && board[6] == n) || (board[1] == n && board[4] == n && board[7] == n) || (board[2] == n && board[5] == n && board[8] == n) || (board[0] == n && board[4] == n && board[8] == n) || (board[6] == n && board[4] == n && board[2] == n))
            {
                if (n == 0)
                {
                    label2.Text = "0 is the winner";
                    win = 1;
                    MessageBox.Show("0 is the winner", "Tic Tac Toe", MessageBoxButtons.OK);
                    reset();
                }
                else if  (n == 1)
                {
                    win = 1;
                    label2.Text = "X is th e winner";
                    MessageBox.Show("X is the winner", "Tic Tac Toe", MessageBoxButtons.OK);
                    reset();
                }
            }
            if (turn == 9 && win!=1)
            {
                turn = 0;
                label2.Text = "Draw";
                MessageBox.Show("Game Drawn", "Tic Tac Toe", MessageBoxButtons.OK);
                reset();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ++turn;
            if (board[0] == -1)
            {
                if (turn % 2 == 0)
                {
                    board[0] = 0;
                    button1.Text = "0";
                    button10.Focus();
                    checkWin(0);
                }
                else
                {
                    board[0] = 1;
                    button1.Text = "X";
                    button11.Focus();
                    checkWin(1);
                }
            }
            label2.Text = turn.ToString();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            ++turn;
            if (board[1] == -1)
            {
                if (turn % 2 == 0)
                {
                    board[1] = 0;
                    button2.Text = "0";
                    button10.Focus();
                    checkWin(0);
                }
                else
                {
                    board[1] = 1;
                    button2.Text = "X";
                    button11.Focus();
                    checkWin(1);
                }
            }
            label2.Text = turn.ToString();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            ++turn;
            if (board[2] == -1)
            {
                if (turn % 2 == 0)
                {
                    board[2] = 0;
                    button3.Text = "0";
                    button10.Focus();
                    checkWin(0);
                }
                else
                {
                    board[2] = 1;
                    button3.Text = "X";
                    button11.Focus();
                    checkWin(1);
                }
            }
            label2.Text = turn.ToString();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            ++turn;
            if (board[3] == -1)
            {
                if (turn % 2 == 0)
                {
                    board[3] = 0;
                    button4.Text = "0";
                    button10.Focus();
                    checkWin(0);
                }
                else
                {
                    board[3] = 1;
                    button4.Text = "X";
                    button11.Focus();
                    checkWin(1);
                }
            }
            label2.Text = turn.ToString();
        }

        public void button5_Click(object sender, EventArgs e)
        {
            ++turn;
            if (board[4] == -1)
            {
                if (turn % 2 == 0)
                {
                    board[4] = 0;
                    button5.Text = "0";
                    button10.Focus();
                    checkWin(0);
                }
                else
                {
                    board[4] = 1;
                    button5.Text = "X";
                    button11.Focus();
                    checkWin(1);
                }
            }
            label2.Text = turn.ToString();
        }

        public void button6_Click(object sender, EventArgs e)
        {
            ++turn;
            if (board[5] == -1)
            {
                if (turn % 2 == 0)
                {
                    board[5] = 0;
                    button6.Text = "0";
                    button10.Focus();
                    checkWin(0);
                }
                else
                {
                    board[5] = 1;
                    button6.Text = "X";
                    button11.Focus();
                    checkWin(1);
                }
            }
            label2.Text = turn.ToString();
        }

        public void button7_Click(object sender, EventArgs e)
        {
            ++turn;
            if (board[6] == -1)
            {
                if (turn % 2 == 0)
                {
                    board[6] = 0;
                    button7.Text = "0";
                    button10.Focus();
                    checkWin(0);
                }
                else
                {
                    board[6] = 1;
                    button7.Text = "X";
                    button11.Focus();
                    checkWin(1);
                }
            }
            label2.Text = turn.ToString();
        }

        public void button8_Click(object sender, EventArgs e)
        {
            ++turn;
            if (board[7] == -1)
            {
                if (turn % 2 == 0)
                {
                    board[7] = 0;
                    button8.Text = "0";
                    button10.Focus();
                    checkWin(0);
                }
                else
                {
                    board[7] = 1;
                    button8.Text = "X";
                    button11.Focus();
                    checkWin(1);
                }
            }
            label2.Text = turn.ToString();
        }

        public void button9_Click(object sender, EventArgs e)
        {
            ++turn;
            if (board[8] == -1)
            {
                if (turn % 2 == 0)
                {
                    board[8] = 0;
                    button9.Text = "0";
                    button10.Focus();
                    checkWin(0);
                }
                else
                {
                    board[8] = 1;
                    button9.Text = "X";
                    button11.Focus();
                    checkWin(1);
                }
            }
            label2.Text = turn.ToString();
        }
    }
}
