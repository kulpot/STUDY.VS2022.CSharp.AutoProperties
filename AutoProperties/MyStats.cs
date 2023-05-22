using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties  // Get set accessors of Properties
{
    class MyStats
    {
        private int _age;

        public MyStats(int age)
        {
            _age = age;
        }

        /// <summary>
        /// Typical set Method
        /// </summary>
        public void SetAge(int age)
        {
            _age = age;
        }

        public int Age
        {
            get { return  _age; }
            set
            {
                // Make age a valid positive number
                if(_age <= 0)
                {
                    _age = 1;
                }
                else
                {
                    _age = value;
                }
            }
        }
    }
}
