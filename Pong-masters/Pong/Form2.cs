using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            label1.Text = "Player 1의 방향키는 W,S이며 Player2의 방향키는 위, 아래 키입니다.\n생성된 공이 랜덤하게 움직이며 자신의 뒤로 공이 오지 않게 지키면서\n 상대쪽으로 공을 보내어 일정 점수를 획득하면 이기는 게임입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("플레이어 두명의 이름을 모두 입력해야 합니다.");
            }
            else if(textBox1.Text == textBox2.Text)
            {
                MessageBox.Show("플레이어 두명의 이름이 같습니다.");
            }
            else
            {
                PongForm.name1 = textBox1.Text;
                PongForm.name2 = textBox2.Text;
                PongForm pongForm = new PongForm();
                Hide();
                pongForm.ShowDialog();
                Close();
            }      
        }
    }
}
