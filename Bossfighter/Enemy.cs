using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfighter
{
    internal class Enemy
    {
        public string Obrazek;
        public string Jmeno;
        public int Utok;
        public int HP;

        public Enemy(string obrazek, string jmeno, int hP , int utok)
        {
            Obrazek = obrazek;
            Jmeno = jmeno;
            Utok = utok;
            HP = hP;
        }
    }
}
