using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SaveLoad
    {
        [Serializable]
        public class DateRecord //게임 기록을 저장하는 클래스입니다.
        {
            public string Name1;
            public string Name2;
            public int Score1;
            public int Score2;
            public string Dates;
            public DateRecord(string name1, int score1, string name2, int score2, string date)
            {
                Name1 = name1;
                Score1 = score1;
                Name2 = name2;
                Score2 = score2;
                Dates = date;
            }
        }

        [Serializable]
        public class UserRecord //유저별 누적 기록을 저장하는 클래스입니다.
        {
            public string Name1;
            public int Score1;
            public int Win1;
            public UserRecord(string name1, int score1, int win1)
            {
                Name1 = name1;
                Score1 = score1;
                Win1 = win1;
            }
        }
        List<DateRecord> datescore = new List<DateRecord>();
        List<UserRecord> userscore = new List<UserRecord>();

        public void datefilewrite(string name1, int score1, string name2, int score2) //날짜별 기록 저장
        {
            try
            {
                Stream ws = new FileStream("datefile.txt", FileMode.Open);
                BinaryFormatter serializer = new BinaryFormatter();
                // obj의 필드에 값 저장…
                datescore.Add(new DateRecord(name1, score1, name2, score2, DateTime.Now.ToString("yyyy-MM-dd")));
                serializer.Serialize(ws, datescore);
                ws.Close();
            }
            catch (IOException)
            {
            }
        }
        public List<DateRecord> datefileread() //날짜별 기록 읽기
        {
            try
            {
                using (Stream input = File.OpenRead("datefile.txt"))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    datescore = (List<DateRecord>)bf.Deserialize(input);
                }
            }
            catch (SerializationException)
            {

            }
            return datescore;
        }
        public void userwrite(string name1, int score1,int win1, string name2, int score2,int win2) //user별 기록 저장
        {
            try
            {
                Stream ws = new FileStream("userfile.txt", FileMode.Open);

                BinaryFormatter serializer = new BinaryFormatter();
                // obj의 필드에 값 저장…

                userscore.Add(new UserRecord(name1, score1, win1));
                userscore.Add(new UserRecord(name2, score2, win2));
                serializer.Serialize(ws, userscore);
                ws.Close();

            }
            catch (IOException)
            {

            }
        }
        public List<UserRecord> userread() //user별 기록 읽기
        {
            try
            {
                using (Stream input = File.OpenRead("userfile.txt"))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    userscore = (List<UserRecord>)bf.Deserialize(input);
                }
            }
            catch (SerializationException)
            {

            }
            return userscore;
        }
    }
}
