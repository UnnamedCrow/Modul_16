using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_17_Homework_NextRefacoring_
{
    public class SalaryAccount : IAccount
    {
        private double balance;
        public double Balance 
        { get 
            { 
                return balance;
            }           
            set
            {
                balance = value;

                // расчёт процентной ставки будет происходить автоматически при изменении балланса аккаунта
                Interest = value * 0.5;
            }
        }
        // изменять значение процентной ставки можно только внутри класса
        public double Interest { get; private set; }

    }
}
