using System;

namespace OOP{
    class Program{
        static void Main(string[] args){
            //creating instance of Car john with 4 wheels
            Car john = new Car(4);
        }
    }

//Creating Vehicle class
    public class Vehicle{
        public int Wheels {get; set;}

        public void Drive(){
            console.WriteLine($"{Wheels} wheels are moving");
        }
    }

// Pulling information from Vehicle to inherit and change what is expected
    public class Car : Vehicle{
        public Car(int wheels){
            Wheels = wheels;
        }
    }
}
