using System;
using System.Collections.Generic;
using System.Text;

namespace payment_of_karmand
{
    class KRMND
    {
        public int Id;
        private ulong _basepay;
        public string Name;
        public string Family;
        private double _maliat;
        private const double insurance = 0.07;
        public ulong basepay
        {
            get
            {
                return _basepay;
            }
            set
            {
                if (value > 0)
                {
                    _basepay = value;
                    if (value >= 6500000) _maliat = 0.1;
                    else _maliat = 0;
                }
                else
                {
                    _basepay = value;
                    Console.WriteLine("the value of basepay is invalid");
                }           }
        }
        public double finalpay()
        {
            return (basepay * (1 - (insurance + _maliat)));
        }
    }
}
