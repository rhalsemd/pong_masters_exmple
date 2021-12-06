using System;
using System.Windows.Forms;
using System.Drawing;

namespace Pong {
    public class Ball : Interface1{
        PongForm form;
        private PictureBox ballPictureBox, ballModel;
        Random rand = new Random();
        Player leftsidePlayer, rightsidePlayer;
        int xSpeed, ySpeed;

        public Ball(PongForm form, PictureBox aBallModel, Player leftsidePlayer, Player rightsidePlayer) {
            this.form = form;
            ballModel = aBallModel;
            this.ballPictureBox = new PictureBox();
            this.ballPictureBox.Size = aBallModel.Size;
            this.ballPictureBox.Image = aBallModel.Image;
            form.Controls.Add(ballPictureBox);
            this.leftsidePlayer = leftsidePlayer;
            this.rightsidePlayer = rightsidePlayer;
            ResetBall();
        }

        public bool ProcessMove() {
            DoMove();

            var bottom = PongWorldInfo.bottomOfWorld - ballPictureBox.Height;
            if(ballPictureBox.Location.Y >= bottom || ballPictureBox.Location.Y <= PongWorldInfo.topOfWorld) {
                ySpeed *= -1;
            }

            if(ballPictureBox.Location.X <= PongWorldInfo.leftOfWorld) {
                Score(leftsidePlayer); //왼쪽 밖으로 나가게 되면
                return true;
            } else if(ballPictureBox.Location.X >= PongWorldInfo.rightOfWorld - ballPictureBox.Width) { //오른쪽 밖으로 나가게 되면
                Score(rightsidePlayer);
                return true;
            }

            if(leftsidePlayer.paddle.Bounds.IntersectsWith(ballPictureBox.Bounds) //플레이어 바에 닿게 되면
                || rightsidePlayer.paddle.Bounds.IntersectsWith(ballPictureBox.Bounds)) {
                xSpeed *= -1;

                form.ballList.Add(new Ball(form, ballModel, leftsidePlayer, rightsidePlayer));

                while(leftsidePlayer.paddle.Bounds.IntersectsWith(ballPictureBox.Bounds)
                    || rightsidePlayer.paddle.Bounds.IntersectsWith(ballPictureBox.Bounds)) {
                    DoMove();
                }
            }

            return false;
        }

        public int DoMove() {
            var bottom = PongWorldInfo.bottomOfWorld - ballPictureBox.Height;
            ballPictureBox.Location = new Point(ballPictureBox.Location.X + xSpeed,Math.Max(PongWorldInfo.topOfWorld, Math.Min(bottom, ballPictureBox.Location.Y + ySpeed)));
            return bottom;
        }

        private void Score(Player winningPlayer) { //공이 지나가면 없어지면서 점수가 높아짐
            winningPlayer.score++;
            form.Controls.Remove(ballPictureBox);
        }

        private void ResetBall() { //중앙에서 공이 생성됨
            ballPictureBox.Location = new Point((PongWorldInfo.leftOfWorld + PongWorldInfo.rightOfWorld) / 2,
                            (PongWorldInfo.topOfWorld + PongWorldInfo.bottomOfWorld) / 2);
            do {
                xSpeed = rand.Next(-3, 3); //-3~3사이로 랜덤하게 움직임
                ySpeed = rand.Next(-3, 3);
            } while(Math.Abs(xSpeed) + Math.Abs(ySpeed) <= 3 || Math.Abs(xSpeed) <= 1);
        }
    }
}
