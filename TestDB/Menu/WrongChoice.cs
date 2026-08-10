using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Menu
{
    public class WrongChoice
    {
        public void PrintWrongChoiceMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неверный выбор. Попробуйте снова.");
            Console.ResetColor();
        }
    }

}
