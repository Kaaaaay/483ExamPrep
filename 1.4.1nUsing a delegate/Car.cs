using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._1nUsing_a_delegate
{
    class Car
    {
        public event Action OnChange;


        private double speed;
        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
                if (speed >= 60)
                {
                    if (OnChange != null)
                    {
                        OnChange();

                    }
                }
            }
        }
    }
}
