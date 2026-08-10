using MySql.Data.MySqlClient;
using stepik.Menu;
using stepik.Models;
using stepik.Services;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection.Metadata;
using System.Text;

namespace TestDB
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            var menu = new MainMenu();
            menu.Display();
            menu.HandleUserChoice();
        }
    }
}
