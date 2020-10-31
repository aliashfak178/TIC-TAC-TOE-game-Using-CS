using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class MainGame : Form
    {
        private string FirstPlayerName;
        private string SecondPlayerName;
        private bool XForPlayer;
        private bool StartPlayers;

        private bool isPlayerOneTurn;
        private int Player1Win = 0;
        private int Player2Win = 0;
        private int ButtonClicksCount=0;

        public MainGame(string F_PlayerName,string S_PlayerName,bool XPlayer,bool StartPlayer)
        {
            InitializeComponent();
            FirstPlayerName = F_PlayerName;
            SecondPlayerName = S_PlayerName;
            XForPlayer = XPlayer;
            StartPlayers = StartPlayer;
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            if (StartPlayers)
            {
                isPlayerOneTurn = true;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isPlayerOneTurn == true)
            {
                if (XForPlayer)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
                isPlayerOneTurn = false;
                b.Enabled = false;
            }
            else
            {
                if (!XForPlayer)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
                isPlayerOneTurn = true;
                b.Enabled = false;
            }
            ButtonClicksCount++;

            CheckTheWinner();
        }

        private void CheckTheWinner()
        {
            bool IsWinner = false;
            if (ButtonClicksCount == 9)
            {
                MessageBox.Show("The Game Is Drawn,Plese Reset The Game", "Game Over",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearButton();
            }
            else
            {
                if ((A1Button.Text == A2Button.Text) && (A2Button.Text == A3Button.Text) && (!A1Button.Enabled))
                {
                    IsWinner = true;
                }
                else if ((A4Button.Text == A5Button.Text) && (A5Button.Text == A6Button.Text) && (!A4Button.Enabled))
                {
                    IsWinner = true;
                }
                else if ((A7Button.Text == A8Button.Text) && (A8Button.Text == A9Button.Text) && (!A7Button.Enabled))
                {
                    IsWinner = true;
                }
                else if ((A1Button.Text == A4Button.Text) && (A4Button.Text == A7Button.Text) && (!A4Button.Enabled))
                {
                    IsWinner = true;
                }
                else if ((A2Button.Text == A5Button.Text) && (A5Button.Text == A8Button.Text) && (!A2Button.Enabled))
                {
                    IsWinner = true;
                }
                else if ((A3Button.Text == A6Button.Text) && (A6Button.Text == A9Button.Text) && (!A3Button.Enabled))
                {
                    IsWinner = true;
                }
                else if ((A1Button.Text == A5Button.Text) && (A5Button.Text == A9Button.Text) && (!A1Button.Enabled))
                {
                    IsWinner = true;
                }
                else if ((A3Button.Text == A5Button.Text) && (A5Button.Text == A7Button.Text) && (!A3Button.Enabled))
                {
                    IsWinner = true;
                }

                if(IsWinner==true)
                {
                    if (isPlayerOneTurn == false)
                    {
                        MessageBox.Show(FirstPlayerName + "  Is The Winner", "Game Over",MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Player1Win++;
                        PlayerOneDet.Text = FirstPlayerName + " Winning Time =" +Player1Win;
                      PlayerTwoDet.Text = SecondPlayerName + " Winning Time =" + Player2Win;
                    }
                    else
                    {
                        MessageBox.Show(SecondPlayerName +"  Is The Winner", "Game Over",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Player2Win++;
                      PlayerTwoDet.Text = SecondPlayerName + " Winning Time =" + Player2Win;
                      PlayerOneDet.Text = FirstPlayerName + " Winning Time =" + Player1Win;
                    }
                }
            }
        }

        private void ClearButton()
        {
            A1Button.Text = "";
            A2Button.Text = "";
            A3Button.Text = "";
            A4Button.Text = "";
            A5Button.Text = "";
            A6Button.Text = "";
            A7Button.Text = "";
            A8Button.Text = "";
            A9Button.Text = "";
        }

        private void StartNewGame_Click(object sender, EventArgs e)
        {
            A1Button.Enabled = true;
            A2Button.Enabled = true;
            A3Button.Enabled = true;
            A4Button.Enabled = true;
            A5Button.Enabled = true;
            A6Button.Enabled = true;
            A7Button.Enabled = true;
            A8Button.Enabled = true;
            A9Button.Enabled = true;
            ClearButton();
            ButtonClicksCount = 0;
        }
    }
}
