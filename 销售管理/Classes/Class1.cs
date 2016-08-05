using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 一卡通.Classes
{
    public sealed class Singleton
    {
        static readonly Singleton instance = new Singleton();

        static Singleton()
        {
        }

        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        string s1;

        public string S1
        {
            get { return s1; }
            set { s1 = value; }
        }
    }

    static class Programaaa
    {
        void main()
        {
            Singleton.S1 = "";
        }
    }

}
