using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Manager : Employee
    {
        static readonly string Alphabet = "abcdefghijklmnopqrstuvwxyz";

        private char payRateIndicator;
        private Employee[] emps;
        public override void EatLunch()
        {
            throw new NotImplementedException();
        }
        public new void Login()
        {

        }
        public override void LogOff()
        {

        }
    }
}