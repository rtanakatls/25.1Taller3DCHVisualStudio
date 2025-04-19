using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller3DCH251.Strategy;
using Taller3DCH251.Week1;
using Taller3DCH251.Week2;

namespace Taller3DCH251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new StrategyMenu();
            menu.Execute();
        }
    }
}
