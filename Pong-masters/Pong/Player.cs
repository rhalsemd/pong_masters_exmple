using System;
using System.Windows.Forms;
using System.Drawing;

namespace Pong {
    public class Player : Interface1{
        const int movementSpeed = 3;

        public bool isUpPressed, isDownPressed;

        public PictureBox paddle;
        Label scoreLabel; //점수판
        bool? wasGoingUpLastTick;
        int numberOfTicksGoingInTheSameDirection;

        int _score;
        public int score {
            get {
                return _score;
            }
            set {
                _score = value;
                scoreLabel.Text = score.ToString();
            }
        }

        public Player(PictureBox aPaddle1, Label scoreLabel) { //플레이어 이미지
            this.paddle = aPaddle1;
            this.scoreLabel = scoreLabel;
        }

        public bool ProcessMove() { //방향키 움직임
            bool? goingUp = null;

            if(isUpPressed) {
                goingUp = true;
            }

            if(isDownPressed) {
                if(goingUp.HasValue) {
                    goingUp = null;
                } else {
                    goingUp = false;
                }
            }

            if(wasGoingUpLastTick.HasValue) {
                if(!goingUp.HasValue) {
                    wasGoingUpLastTick = null;
                    numberOfTicksGoingInTheSameDirection = 0;
                } else if(wasGoingUpLastTick.Value == goingUp.Value) {
                    numberOfTicksGoingInTheSameDirection++;
                } else {
                    wasGoingUpLastTick = goingUp;
                    numberOfTicksGoingInTheSameDirection = 1;
                }
            } else if(goingUp.HasValue) {
                wasGoingUpLastTick = goingUp;
                numberOfTicksGoingInTheSameDirection = 1;
            }

            DoMove(goingUp);
            return true;
        }
        public int DoMove()
        {
            return 0;
        }

        private void DoMove(bool? goingUp) {
            if(goingUp.HasValue) {
                var speed = (int)Math.Round(movementSpeed * ((float)numberOfTicksGoingInTheSameDirection / 10)); //키를 눌렀을때 스피드 3에 곱해져서 움직임
                if(goingUp.Value) {
                    speed *= -1;
                }

                paddle.Location = new Point(paddle.Location.X,
                    Math.Max(PongWorldInfo.topOfWorld,
                        Math.Min(PongWorldInfo.bottomOfWorld - paddle.Height
                        , paddle.Location.Y + speed)
                        ) //폼 크기에서 이미지 사이즈크기만큼 뺀 위치에 위치, 스피드가 올라가면 위치 변동
                    );
            }
        }
    }
}
