﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoruvs20
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;

        const string PlayerTest = "(-.-)";
        const string EnemyTest = "🔶";
        const string ItemTest = "★";

        static Random rand = new Random();

        enum State
        {
            None=-1, //無効
            Title,   //タイトル
            Game,    //ゲーム
            Gameover,//ゲームオーバー
            Clear,    //クリア
        }
        State currentState = State.None;
        State nextState = State.Title;

        const int SpeedMax = 20;
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];


        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();

            for(int i=0;i<ChrMax;i++)
            {
                chrs[i] = new Label();
                chrs[i] . AutoSize = true;
                if (i == PlayerIndex)
                {
                    chrs[i].Text = PlayerTest;
                }
                else if (i < ItemIndex) 
                {
                    chrs[i].Text = EnemyTest;
                }
                else
                {
                    chrs[i].Text = ItemTest;
                }
                Controls.Add(chrs[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState !=State.None)
            {
                initProc();
            }

            if(isDebug)
            {
                if(GetAsyncKeyState((int)Keys.O)<0)
                {
                    nextState = State.Gameover;
                }
                else if(GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }

            if (currentState == State.Game)
            {
                UpdateGame();
            }

        }

        void UpdateGame()
        {
            Point mp = PointToClient(MousePosition);
            chrs[0].Left = mp.X-chrs[0].Width/2;
            chrs[0].Top = mp.Y-chrs[0].Height/2;

            for (int i = EnemyIndex; i < ChrMax; i++) 
            {
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];
                if (chrs[i].Left < 0) 
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0) 
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (chrs[i].Right > ClientSize.Width) 
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrs[i].Bottom > ClientSize.Height) 
                {
                    vy[i] = -Math.Abs(vy[i]);

                
                 }


             }

         }


        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch(currentState)
            {
                case State.Title:
                    titleLabel.Visible = true;
                    timelabel.Visible = true;
                    StartButtom.Visible = true;
                    copyrightlabel.Visible = true;
                    highscorelabel.Visible = true;
                    gameoverlabel.Visible = false;
                    clearlabel.Visible = false;
                    titlebottom.Visible = false;
                    for (int i = 0; i < ChrMax; i++) chrs[i].Visible = false;
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    StartButtom.Visible = false;
                    copyrightlabel.Visible = false;
                    highscorelabel.Visible = false;
                    for (int i = 0; i < ChrMax; i++) chrs[i].Visible = true;
                    for (int i=EnemyIndex;i<ChrMax;i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                    }

                    break;

                case State.Gameover:
                    gameoverlabel.Visible = true;
                    titlebottom.Visible = true;
                    break;

                case State.Clear:
                    clearlabel.Visible = true;
                    titlebottom.Visible = true;
                    highscorelabel.Visible = true;
                    break;
            }
        }

        private void gameoverlabel_Click(object sender, EventArgs e)
        {

        }

        private void StartButtom_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void titlebottom_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
