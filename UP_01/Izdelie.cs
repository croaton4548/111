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

        public Izdelie(string name, string shifr, int count)
        {
            this.name = name;
            this.shifr = shifr;
            this.count = count;
        }

        public Izdelie()
        {
            name = "";
            shifr = "";
            count = 0;
        }

        public void SetInfo()
        {
            Console.Write("Название: ");
            this.name = Console.ReadLine();
            Console.Write("Шифр: ");
            this.shifr = Console.ReadLine();
            Console.Write("Количество: ");
            this.count = Convert.ToInt32(Console.ReadLine());
        }

        public void GetInfo()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Шифр: " + shifr);
            Console.WriteLine("Количество: " + count);
        }
    }
}
