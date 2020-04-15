using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebastian_Wood_Slutprojekt
{
    class Classroom1 : Rooms //subklass som ärver från Rooms
    {
        //konsturktorer https://sites.google.com/view/csharp-referens/klasser-och-objektorientering/konstruktorer?authuser=0

        //använder sig utav arv då Classroom1 ärver ifrån rooms vilket innebär att alla instanster från rooms kan också användas i Classroom1


        public string GetroomName()
        {

            return roomName + "Classroom"; //kan använda roomName trots att variabeln är skapad i Rooms. 


        }

        public Classroom1()
        {
            

            temperatur = 20;


        }

        public int WindSpeed()
        {

            return wind = 3;

        }



    }
}
