using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions
{
    public class Lada : Car
    {
        public Lada(string mark, string model, string cNumber, string FIO, string color = null, string status = null) :
            base(mark, model, cNumber, FIO, color, status)
        {

        }

        public override string[] GetProps()
        {
            return base.GetProps();
        }

        public override void Go()
        {

        }

        public override string String()
        {
            return $" {mark}  {model} ({carnumber} Поехал в пункт В и вернулся обратно";
        }
       
    }
}
