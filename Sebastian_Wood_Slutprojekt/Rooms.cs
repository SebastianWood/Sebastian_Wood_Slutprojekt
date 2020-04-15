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


    }
}
