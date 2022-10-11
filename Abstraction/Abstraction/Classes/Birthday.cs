using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Classes{
    public abstract class Birthday : Party{
        public override int MaxNumberOfGuests { get; set; } = 100;
        public override decimal Budget {get; set;} = 1000.00m;
        
//Method signature, required to override
        public abstract int Age {get; set;}
        public abstract string[] Presents {get; set;}

        public abstract void PlayGames();
        public abstract void OpenPresents(string[] presents);


//May be implemented, not necessary
        public virtual void SingHappyBirthday(){
            Console.WriteLine("singing happy birthday song");
        }
    }
}