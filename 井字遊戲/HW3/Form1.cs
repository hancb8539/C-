using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3
{
    public partial class Form1 : Form
    {
        Button[,] board = new Button[3, 3];
        int[,] state = new int[3, 3];
        bool start = false;
        bool computer = true;
        int count;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            board[0, 0] = button1;
            board[0, 1] = button2;
            board[0, 2] = button3;
            board[1, 0] = button4;
            board[1, 1] = button5;
            board[1, 2] = button6;
            board[2, 0] = button7;
            board[2, 1] = button8;
            board[2, 2] = button9;
        }
        public void showBoard()
        {
            int i, j;
            for(i=0;i<3;i++)
                for (j = 0; j < 3; j++)
                {
                    if (state[i, j] == 0) board[i, j].Text = "";
                    if (state[i, j] == 1) board[i, j].Text = "O";
                    if (state[i, j] == 10) board[i, j].Text = "X";
                }
            if (computer) textBox1.Text = "電腦";
            else textBox1.Text = "玩家";
            if(state[0,0]+state[1,1]+state[2,2] == 3 || state[0, 2] + state[1, 1] + state[2, 0] == 3)
            {
                MessageBox.Show("電腦獲勝", "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Information);
                start = false;
                return;
            }
            for(i=0;i<3;i++)
                if (state[i, 0] + state[i, 1] + state[i, 2] == 3 || state[0, i] + state[1, i] + state[2, i] == 3)
                {
                    MessageBox.Show("電腦獲勝", "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    start = false;
                    return;
                }
            if (state[0, 0] + state[1, 1] + state[2, 2] == 30 || state[0, 2] + state[1, 1] + state[2, 0] == 30)
            {
                MessageBox.Show("恭喜玩家獲勝", "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Information);
                start = false;
                return;
            }
            for (i = 0; i < 3; i++)
                if (state[i, 0] + state[i, 1] + state[i, 2] == 30 || state[0, i] + state[1, i] + state[2, i] == 30)
                {
                    MessageBox.Show("恭喜玩家獲勝", "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    start = false;
                    return;
                }
            if(count == 9)
            {
                MessageBox.Show("雙方平手", "遊戲結束", MessageBoxButtons.OK, MessageBoxIcon.Information);
                start = false;
            }
        }
        public void play()
        {
            int i, j;
            int c;
            c = count;

            if (state[0, 0] + state[1, 1] + state[2, 2] == 2)
            {
                for (i = 0; i < 3; i++)
                {
                    if (start && computer && state[i, i] == 0)
                    {
                        state[i, i] = 1;
                        count++;
                        computer = false;
                        showBoard();
                    }
                }
            }


            if (state[0, 2] + state[1, 1] + state[2, 0] == 2)
            {
                if (start && computer && state[0, 2] == 0)
                {
                    state[0, 2] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
                if (start && computer && state[1, 1] == 0)
                {
                    state[1, 1] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
                if (start && computer && state[2, 0] == 0)
                {
                    state[2, 0] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
            }
            //直
            for (i = 0; i < 3; i++)
            {
                if (state[0, i] + state[1, i] + state[2, i] == 2)
                {
                    for (j = 0; j < 3; j++)
                    {
                        if (start && computer && state[j, i] == 0)
                        {
                            state[j, i] = 1;
                            count++;
                            computer = false;
                            showBoard();
                        }
                    }
                }
            }
            //橫
            for (i = 0; i < 3; i++)
            {
                if (state[i, 0] + state[i, 1] + state[i, 2] == 2)
                {
                    for (j = 0; j < 3; j++)
                    {
                        if (start && computer && state[i, j] == 0)
                        {
                            state[i, j] = 1;
                            count++;
                            computer = false;
                            showBoard();
                        }
                    }
                }
            }

            if (state[0, 0] + state[1, 1] + state[2, 2] == 20)
            {
                for (i = 0; i < 3; i++)
                {
                    if (start && computer && state[i, i] == 0)
                    {
                        state[i, i] = 1;
                        count++;
                        computer = false;
                        showBoard();
                    }
                }
            }


            if (state[0, 2] + state[1, 1] + state[2, 0] == 20)
            {
                if (start && computer && state[0, 2] == 0)
                {
                    state[0, 2] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
                if (start && computer && state[1, 1] == 0)
                {
                    state[1, 1] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
                if (start && computer && state[2, 0] == 0)
                {
                    state[2, 0] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
            }
            //直
            for (i = 0; i < 3; i++)
            {
                if (state[i, 0] + state[i, 1] + state[i, 2] == 20)
                {
                    for (j = 0; j < 3; j++)
                    {
                        if (start && computer && state[i, j] == 0)
                        {
                            state[i, j] = 1;
                            count++;
                            computer = false;
                            showBoard();
                        }
                    }
                }
            }


            for (i = 0; i < 3; i++)
            {
                if (state[0, i] + state[1, i] + state[2, i] == 20)
                {
                    for (j = 0; j < 3; j++)
                    {
                        if (start && computer && state[j, i] == 0)
                        {
                            state[j, i] = 1;
                            count++;
                            computer = false;
                            showBoard();
                        }
                    }
                }
            }//2
            if (state[0, 0] == 10 && state[2, 2] == 10)
            {
                if (start && computer && state[0, 1] == 0)
                {
                    state[0, 1] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
            }
            if (state[0, 2] == 10 && state[2, 0] == 10)
            {
                if (start && computer && state[0, 1] == 0)
                {
                    state[0, 1] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
            }
            if (state[1, 1] == 1 && state[0, 0] == 1)
            {
                if (start && computer && state[2, 0] == 0)
                {
                    state[2, 0] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
                if (start && computer && state[0, 2] == 0)
                {
                    state[0, 2] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
            }

            //3-[2,0]
            int cl = 0, cr = 0;


            for (i = 0; i < 2; i++)
            {
                if (state[2, i + 1] == 10) cl++;
                if (state[i, 0] == 10) cr++;
            }

            if (cl == 1 && cr == 1)
            {
                if (start && computer && state[2, 0] == 0)
                {
                    state[2, 0] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
            }
            //3-[0,0]
            cl = 0;
            cr = 0;


            for (i = 1; i < 3; i++)
            {
                if (state[0, i] == 10) cl++;
                if (state[i, 0] == 10) cr++;
            }

            if (cl == 1 && cr == 1)
            {
                if (start && computer && state[0, 0] == 0)
                {
                    state[0, 0] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
            }

            //3-[0,2]
            cl = 0;
            cr = 0;


            for (i = 0; i < 2; i++)
            {
                if (state[0, i] == 10) cl++;
                if (state[i + 1, 2] == 10) cr++;
            }

            if (cl == 1 && cr == 1)
            {
                if (start && computer && state[0, 2] == 0)
                {
                    state[0, 2] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
            }
            //3-[2,2]
            cl = 0;
            cr = 0;


            for (i = 0; i < 2; i++)
            {
                if (state[2, i] == 10) cl++;
                if (state[i, 2] == 10) cr++;
            }

            if (cl == 1 && cr == 1)
            {
                if (start && computer && state[0, 2] == 0)
                {
                    state[0, 2] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
            }

            if (c == count)
            {
                if (start && computer && state[1, 1] == 0)
                {
                    state[1, 1] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
                if (start && computer && state[0, 0] == 0)
                {
                    state[0, 0] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
                if (start && computer && state[0, 2] == 0)
                {
                    state[0, 2] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
                if (start && computer && state[2, 0] == 0)
                {
                    state[2, 0] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
                if (start && computer && state[2, 2] == 0)
                {
                    state[2, 2] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
                if (start && computer && state[0, 1] == 0)
                {
                    state[0, 1] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }

                if (start && computer && state[1, 0] == 0)
                {
                    state[1, 0] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }

                if (start && computer && state[1, 2] == 0)
                {
                    state[1, 2] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }

                if (start && computer && state[2, 1] == 0)
                {
                    state[2, 1] = 1;
                    count++;
                    computer = false;
                    showBoard();
                }
            }
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                    state[i, j] = 0;
            }
            count = 0;
            showBoard();
            start = true;
            if(radioButton2.Checked == true)
            {
                computer = false;
                textBox1.Text = "玩家";
            }
            else
            {
                computer = true;
                textBox1.Text = "電腦";
                play();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(start && !computer && state[0,0] == 0)
            {
                state[0, 0] = 10;
                count++;
                computer = true;
                showBoard();
                play();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (start && !computer && state[0, 1] == 0)
            {
                state[0, 1] = 10;
                count++;
                computer = true;
                showBoard();
                play();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (start && !computer && state[0, 2] == 0)
            {
                state[0, 2] = 10;
                count++;
                computer = true;
                showBoard();
                play();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (start && !computer && state[1, 0] == 0)
            {
                state[1, 0] = 10;
                count++;
                computer = true;
                showBoard();
                play();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (start && !computer && state[1, 1] == 0)
            {
                state[1, 1] = 10;
                count++;
                computer = true;
                showBoard();
                play();
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (start && !computer && state[1, 2] == 0)
            {
                state[1, 2] = 10;
                count++;
                computer = true;
                showBoard();
                play();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (start && !computer && state[2, 0] == 0)
            {
                state[2, 0] = 10;
                count++;
                computer = true;
                showBoard();
                play();
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (start && !computer && state[2, 1] == 0)
            {
                state[2, 1] = 10;
                count++;
                computer = true;
                showBoard();
                play();
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (start && !computer && state[2, 2] == 0)
            {
                state[2, 2] = 10;
                count++;
                computer = true;
                showBoard();
                play();
            }
        }
    }
}
