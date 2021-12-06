using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Pong
{
    public partial class ScoreBoard : Form
    {
        public static string name1, name2;
        public static int score1, score2;
        int win1=0, win2=0;
        public bool truecheck = false;

        ClassLibrary1.SaveLoad sl = new ClassLibrary1.SaveLoad();
        List<ClassLibrary1.SaveLoad.DateRecord> datescore;
        List<ClassLibrary1.SaveLoad.UserRecord> userscore;

        public ScoreBoard()
        {
            InitializeComponent();
            if (score1 > score2)
            {
                MessageBox.Show(name1 + "이 이겼습니다.");
                win1 = 1;
            }
            else
            {
                MessageBox.Show(name2 + "이 이겼습니다.");
                win2 = 1;
            }
        }
        private void button3_Click(object sender, EventArgs e) //홈으로 
        {
            Form2 form2 = new Form2();
            Hide();
            form2.ShowDialog();
            Close();
        }

        private void recordwrite_Click(object sender, EventArgs e)
        {
            if (truecheck == false)
            {
                sl.datefilewrite(name1, score1, name2, score2);
                sl.userwrite(name1, score1, win1, name2, score2, win2);
                truecheck = true;
            }
            else
            {

            }
        }

        private void winrank_Click(object sender, EventArgs e)
        {
            userscore = sl.userread();
            listBox1.Items.Clear();
            var Q3 = userscore.GroupBy(cm => new { cm.Name1 },
             (key, Group) => new
             {
                 Key1 = key.Name1,
                 Win = Group.Sum(userscore => userscore.Win1)
             }
             ).OrderByDescending(userscore => userscore.Win);

            foreach (var listpersons in Q3)
            {
                string dateuser = listpersons.Key1 + " 누적 승리 횟수: " + listpersons.Win;
                listBox1.Items.Add(dateuser);
            }
        }

        private void scorerank_Click(object sender, EventArgs e)
        {
            userscore = sl.userread();
            listBox1.Items.Clear();
            var Q3 = userscore.GroupBy(cm => new { cm.Name1 },
             (key, Group) => new
             {
                 Key1 = key.Name1,
                 Score = Group.Sum(userscore => userscore.Score1),
             }
             ).OrderByDescending(userscore => userscore.Score);


            foreach (var listpersons in Q3)
            {
                string dateuser = listpersons.Key1 + " 누적 점수: " + listpersons.Score;
                listBox1.Items.Add(dateuser);
            }
        }

        private void record_Click(object sender, EventArgs e)
        {
            datescore = sl.datefileread();
            listBox1.Items.Clear();
            var Q5 = from ds in datescore
                     orderby ds.Dates
                     select ds;
            foreach (var ds in datescore)
            {
                string dateuser = ds.Name1 + ": " + ds.Score1 + "," + ds.Name2 + ": " + ds.Score2 + ", 날짜: " + ds.Dates;
                listBox1.Items.Add(dateuser);
            }
        }
    }
}
