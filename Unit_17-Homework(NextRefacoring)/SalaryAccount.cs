using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_17_Homework_NextRefacoring_
{
    public class SalaryAccount : IAccount
    {
        public double Balance { get; set; }

        // Расчёт процентной ставки при создании экземпляра объекта
        public double Interest { get; set; }

        public double GetInterest()
        {
            Interest = Balance * 0.5;
            return Interest;
        }
    }
}
