using System;
using System.Collections.Generic;

namespace MTPApp.Core
{
    public class Calculator
    {   
        private int _total;
        private List<int> _saveinput;
        private Boolean _abs;
        public Calculator()
        {
            _total = 0;
            _abs = false;
            _saveinput = new List<int>();
        }

        public Calculator(Boolean abs)
        {
            _total = 0;
            _abs = abs;
            _saveinput = new List<int>();
        }
        public void SetAbs (Boolean abs)
        {
            _abs = abs;
        }




        public void GetInput(int a)
        {
            if(_abs == true)
            {
                a = Math.Abs(a);
            }
            _total += a;
            _saveinput.Add(a);
            //return A;
        }

        public int GetResult()
        {
            return _total;
        }

        public List<int> GetHistory()
        {
            return _saveinput;
        }


    }
}
