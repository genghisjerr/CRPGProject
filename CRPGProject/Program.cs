using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//jerr '23
namespace CRPGProject
{
    class Program
    {


        private static Player _player = new Player();

        static void Main(string[] args)
        {
            GameEngine.Initialize();
            _player.Name = "Anonymous";

           
            
            Console.ReadLine();
        }
    }
}
