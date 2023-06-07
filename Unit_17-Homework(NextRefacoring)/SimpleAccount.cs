using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_17_Homework_NextRefacoring_
{
    public class SimpleAccount : IAccount
    {
        public double Balance
        {
            get
            {
                return Balance;
            }
            set
            {
                Balance = value;
                Interest = value * 0.4;
                if (value < 1000)
                    Interest -= value * 0.2;

                if (value >= 1000)
                    Interest -= value * 0.4;
            }
        }

        public double Interest { get; set; }
        
        // Расчёт процентной ставки для конкретного типа аккаунта
        public double GetInterest()
        {
            return Interest;
        }
    }
}
