using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebastian_Wood_Slutprojekt
{
    class Rooms
    {



        protected string roomName = ""; //protected string som används inom Classroom1 och kan sedan användas genom en klass i program.

        public string GetroomName () //en metod som används i Classroom1 och som kan användas i program.
        {

            return roomName; //returnerar den protectade stringen roomName ovan


        }


        public int temperatur; //en public int temperatur.

       

        public Rooms() 
        {
            
            temperatur = 5; //definerar vilken temperatur int värdet ska ha. 

            

        }

        protected int wind;
        public int WindSpeed()
        {


            return wind;


        }


        
        

        public int GetSlump() //klassmetod med algoritm som if satser och en for loop som körs med hjälp av en random generator
        {
            Random generator = new Random(); //random generator. 

            int randomNumber = generator.Next(10); //random generator som slumpar till numret 10. 
            

            

           
            if (randomNumber < 3) //körs ifall randomNumber int är lägre än 3.
            {

                Console.WriteLine("Wow you got number " + randomNumber + "!"); //skriver ut vilket nummber som blev randomisad. 
                Console.WriteLine("Now lets count to number 2!");

                for (randomNumber = 0 + randomNumber; randomNumber > 1; randomNumber-= 1) //for loop som kör så länge randomnumber är över 1. Den tar bort -1 från randomnumber varje gång loopen kör. Den innehåller också randomNumber för att se vilket värde den har. 
                {
                    Console.WriteLine(randomNumber); //skriver ut vad randomnumber är. 
                    Console.WriteLine("...!");
                }

            }

            else if (randomNumber >= 3) //körs ifall randomnumber är lika med 3 eller mer. 
            {

                Console.WriteLine("It seems you got number " + randomNumber + "!");

                Console.WriteLine("We will now count from " + randomNumber  + ".");

                for (randomNumber = 0 + randomNumber; randomNumber > 1; randomNumber -= 1) //som foorloppen ovan. 
                {
                    Console.WriteLine(randomNumber);
                    Console.WriteLine("...!");
                }


            }


            return randomNumber; //returnar randomNumber så att den kan användas inom Main och ge ett value. 

        }

    }
}
