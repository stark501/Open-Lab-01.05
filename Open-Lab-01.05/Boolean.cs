using System;

namespace Open_Lab_01._05
{
    public class Boolean
    {
        public bool Reverse(bool value)
        {
            if (value == true)
            {
                value = false;
            }
            else
            {
                value = true;
            }
            return value;
        }
    }
}