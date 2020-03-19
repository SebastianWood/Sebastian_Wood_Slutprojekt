using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebastian_Wood_Slutprojekt
{
    class Classroom1 : Rooms //subklass som ärver från Rooms
    {
        //använder sig utav arv då Classroom1 ärver ifrån rooms vilket innebär att alla instanster från rooms kan också användas i Classroom1
        

        public void PrintName()
        {
            Console.WriteLine(GetRoom());

        }
        



    }
}
