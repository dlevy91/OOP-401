using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Classes{
    class KidParty : Birthday{
        public override string[] Presents {get; set;}
        public override string Venue {get; set;}
        public override int Age {get; set;}
        public override void OpenPresents(string[] presents)
        {
            Console.WriteLine("opening presents");
        }
        public override void PlayGames()
        {
            Console.WriteLine("Playing the games");
        }
        public override void Setup(){
            Console.WriteLine("setting things up");
        }
        public override void TearDown()
        {
            Console.WriteLine("Cleaning it up");
        }

        public override void SingHappyBirthday()
        {
            Console.WriteLine("Happy birthday to you");
        }
    }
}