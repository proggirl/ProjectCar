using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions
{
    public class Car
    {
       
        protected string mark;
        protected string model;
        protected string carnumber;
        protected string empFIO;
        protected string NoImportant;
        
        
        protected int ride = 0;

        public Car(string mark, string model, string cNumber, string FIO, string color = null, string status = null)
        {
            this.mark = mark;
            this.model = model;
            this.carnumber = cNumber;
            this.empFIO = FIO;
            if (!string.IsNullOrEmpty(color))
                NoImportant += "Цвет: " + color;
            if (!string.IsNullOrEmpty(status))
                NoImportant += " \nСостояние: " + status;
            
        }
        public virtual string[] GetProps()
        {
            return new string[] { this.mark, this.model, this.carnumber, this.empFIO, this.NoImportant };
        }
        public virtual string String()
        {
            return $" {mark}  {model} ({carnumber})  выехал сделал {ride} круга и приехал ";
        }
        
         public virtual void Go()
        {            
        }
    }
}
