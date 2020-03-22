using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Settings
    {
        public static Scale eat;
        public static Scale sleep;
        public static Scale happy;
        public static Scale clear;
        public static Scale HP;

        public static int dif;
        public static int add;

        public Settings()
        {
            eat = new Scale(100);
            sleep = new Scale(100);
            happy = new Scale(100);
            clear = new Scale(100);
            HP = new Scale(100);

            dif = 8;
            add = 15;
        }
    }
}
