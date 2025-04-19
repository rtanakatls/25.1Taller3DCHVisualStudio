using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DCH251.Strategy
{
    internal class StrategyMenu : Menu
    {
        private int turnCount;

        public StrategyMenu()
        {
            turnCount = 0;
        }

        public override void Execute()
        {
            Console.WriteLine("Bienvenido al juego de estrategia");
            GameplayLoop();
        }

        private void GameplayLoop()
        {
            bool continueFlag=true;
            while (continueFlag)
            {
                turnCount++;
                Console.WriteLine($"Turno {turnCount}");
                PlayerTurn();
                EnemyTurn();
            }
        }

        private void PlayerTurn()
        {
            bool continueFlag = true;
            while (continueFlag) 
            {
                Console.WriteLine("Introduce una opción:");
                Console.WriteLine("1. Crear estructura");
                Console.WriteLine("2. Crear unidad");
                Console.WriteLine("3. Ver base");
                Console.WriteLine("4. Pasar de turno");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Aquí debería estar el menú de crear estructura");
                        break;
                    case "2":
                        Console.WriteLine("Aquí debería estar el menú de crear unidad");
                        break;
                    case "3":
                        Console.WriteLine("Aquí debería estar el menú de ver base");
                        break;
                    case "4":
                        Console.WriteLine("Pasó el turno");
                        continueFlag = false;
                        break;
                }
            }
        }

        private void EnemyTurn()
        {
            Console.WriteLine("Turno del enemigo");
            Console.WriteLine("Aquí el enemigo debe hacer algo");

        }
    }
}
