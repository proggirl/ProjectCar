using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions
{
    
    public class Opel : Car
    {
        private const int canRide = 3;

        public Opel(string mark, string model, string cNumber, string FIO, string color = null, string status = null) :
            base(mark, model, cNumber, FIO, color, status)
        {

        }

        public override string[] GetProps()
        {
            return base.GetProps();
        }

        public override void Go()
        {
            this.ride = canRide;
        }

        public override string String()
        {
            return base.String();
        }


    }
}
