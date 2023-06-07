using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_17_Homework_NextRefacoring_
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(IAccount account)
        {
            Console.WriteLine(account.GetInterest());
        }
    }
}
