using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4
{
    class payment
    {


        int _sum ;

        public payment(int sum)
        {
            _sum = sum;
        }

        public delegate void AccountStateHandler(string message);

        AccountStateHandler _del;

        public void RegisterHandler(AccountStateHandler del)
        {
            _del = del;
        }
        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;

                if (_del != null)
                    _del($"Сумма {sum} снята со счета");
                _del($"Оплата успешно подтверджена");
            }
            else
            {
                if (_del != null)
                    _del("Недостаточно денег на счете");
                _del("Вас отчислено");
            }
        }
    }
}

