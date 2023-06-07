using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_17_Homework_NextRefacoring_
{
    // тип аккаунта и его процентную ставку будет определять конкретная реализация интерфейса
    public interface IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }
        // процентная ставка учётной записи
        public double Interest { get;}

    }
}
