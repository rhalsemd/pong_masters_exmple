using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var path = Application.StartupPath + @"\bgm.wav";
            using (var soundPlayer = new SoundPlayer(path))
            {
                soundPlayer.PlayLooping();// can also use soundPlayer.PlaySync()
            }
            Application.Run(new Form2());

        }
    }
}
