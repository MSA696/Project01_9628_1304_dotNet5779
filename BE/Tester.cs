using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    
    class Tester
    {
        int id;
        string lastName; //{ get; set;}
        string firstName;
        string birth;
        string sex;
        string phone;
        string address;
        int experience;
        int maxTests;
        string carType;
        bool[,] workHour = new bool[5, 6];
        int maxDis;
        override public string ToString()
        {
            return "";//
        }
    }
}
