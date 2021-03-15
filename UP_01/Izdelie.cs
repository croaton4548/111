using System;
using System.Collections.Generic;
using System.Text;

namespace UP_01
{
    class Izdelie
    {
        private string name;
        private string shifr;
        private int count;

        public string GetName
        {
            get
            {
                return name;
            }
            set
            {
                this.name = GetName;
            }
        }

        public string GetShifr
        {
            get
            {
                return shifr;
            }
            set
            {
                this.shifr = GetShifr;
            }
        }

        public int GetCount
        {
            get
            {
                return count;
            }
            set
            {
                this.count = GetCount;
            }
        }
    }
}
