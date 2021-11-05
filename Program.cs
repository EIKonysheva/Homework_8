using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.PutItOnTheAccount(787878m);
            bank.Dispose("bankTransy.txt");
            Song mySong = new Song();
        }
    }
}
