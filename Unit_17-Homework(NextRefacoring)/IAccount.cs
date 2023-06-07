using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_17_Homework_NextRefacoring_
{
    public interface IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        protected double Interest { get; set; }

        // получение процентной ставки
        public double GetInterest();
    }
}
