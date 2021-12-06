using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pong {
    public partial class PongForm : Form {
        Player player1, player2;
        public static string name1, name2;
        bool windowchange = true;

        public List<Ball> ballList;

        delegate void StopThread();
        delegate void CheckKeys(KeyEventArgs e, bool isDown);

        public PongForm() {
            InitializeComponent();
            label2.Text = name2;
            label4.Text = name1;
            player1 = new Player(aPaddle1, aLabelPlayer1); //플레이어 생성
            player2 = new Player(aPaddle2, aLabelPlayer2); //플레이어 생성
            ballList = new List<Ball>(); //볼 생성
            StartNewGame();
        }

        private void StartNewGame() {
            if ((player1.score == 5 || player2.score == 5) && windowchange == true) //스레드 중단
            {
                ThreadStop();
            }
            else
            {
                ballList.Add(new Ball(this, aBall, player1, player2)); //볼 생성
            }
        }

        private void aTimer_Tick(object sender, EventArgs e) {
            player1.ProcessMove();
            player2.ProcessMove();

            for(int i = ballList.Count - 1; i >= 0; i--) { 
                if(ballList[i].ProcessMove()) {
                    ballList.RemoveAt(i);
                }
            }

            if(ballList.Count == 0) { //공이 없으면 새로 공생성
                    StartNewGame();
            }
            if ((player1.score == 5 || player2.score == 5) && windowchange == true) //스레드 중단
            {
                ThreadStop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) { //키에서 손을 때면(람다)
            CheckKeys checkKeys = (KeyEventArgs es, bool isDown) =>{
                switch (e.KeyCode)
                {
                    case Keys.Oemcomma:
                    case Keys.W:
                        player1.isUpPressed = isDown;
                        break;
                    case Keys.S:
                        player1.isDownPressed = isDown;
                        break;

                    case Keys.Up:
                        player2.isUpPressed = isDown;
                        break;
                    case Keys.Down:
                        player2.isDownPressed = isDown;
                        break;
                }

            };
            checkKeys(e, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) { //키 입력시(람다)
            CheckKeys checkKeys = (KeyEventArgs es, bool isDown) => {
                switch (e.KeyCode)
                {
                    case Keys.Oemcomma:
                    case Keys.W:
                        player1.isUpPressed = isDown;
                        break;
                    case Keys.S:
                        player1.isDownPressed = isDown;
                        break;

                    case Keys.Up:
                        player2.isUpPressed = isDown;
                        break;
                    case Keys.Down:
                        player2.isDownPressed = isDown;
                        break;
                }

            };
            checkKeys(e, false);
        }
        public void ThreadStop()
        {
            windowchange = false;
            ballList.Clear();
            aTimer.Enabled = false;
            aTimer.Stop();
            ScoreBoard.name1 = label2.Text;
            ScoreBoard.name2 = label4.Text;
            ScoreBoard.score1 = Convert.ToInt32(aLabelPlayer2.Text);
            ScoreBoard.score2 = Convert.ToInt32(aLabelPlayer1.Text);
            ScoreBoard scoreboard = new ScoreBoard();
            Hide();
            scoreboard.ShowDialog();
            Close();
        }
    }
}
