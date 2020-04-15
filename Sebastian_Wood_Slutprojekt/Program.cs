using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebastian_Wood_Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //länk till slutprojektet https://docs.google.com/document/d/1j626zejPnTAe9wrt4lNcQyH0BdIh9oMxrgYEJfcrZwQ/edit?usp=drive_open&ouid=102143881779339334621

            /*
            

            Det här är bara mina ideer och tankar, inget viktigt. 

            Ide: Ett textbaserat utforskningsspel – kanske går man runt i en dungeon, eller en drömvärld, 
            eller ett kontorslandskap. Klasserna kan vara rum, prylar, folk man träffar på, dialogval… 
            
            Programmerings ide: Skapa ett spel i en skolmiljö, där man använder sig utav rum if satser och i if satserna 
            kallas klasserna in. Objekt som man hittar i if satsen är refererade från en klass också. 

            Det finns även en människo klass som erhåller (namn, ålder, egenskaper) som man kan använda arv(subklass på) för
            att referera den och skapa riktiga människor.

            Klassrummen kan också använda sig utav arv där vi har en vanlig miljö som erhåller (storlek, färg, namn på rum) 
            så när man skapar klasser för rum kan man arva från klassen miljö. 

            Föremål kan också använda sig utav arv där man skapar main klassen med egenskaper som (namn på föremål, användemål/egenskaper,
            storlek)

    */


            /* 
             Vad jag behöver ha med. 

            Klasser och instanser, Arv/subklass. 

            List exempelvis 

            Välformulerade klasser som lagrar information i variabler. 

            Inkapsling (private inom klasser)

            Stabilitet – vid minst ett tillfälle finns en risk att programmet kraschar pga användaren (t.ex. att hen ska skriva in ett heltal). Din kod hindrar den kraschen.



             

    */



            //Här börjar min kod. 


            string room = "hallway"; //säger vart vi är nu. 

            while (room != "end") //implementerar att så länge room inte är end så kommer spelet att fortsätta inom denna while loop. 
            {
                if (room == "hallway") //room ovan är lika med hallway så denna if sats kommer att köras så länge room är fortfarande lika med hallway.
                {
                    Console.WriteLine("Hello and welcome to your office. Your mission is to retrieve your cat and head home. Good luck!");

                    Console.WriteLine("So, where would you like to go now? Type in what is between the two apostrof to move their. You can go 'right'");
                    string input = Console.ReadLine(); //här får användaren skriva in vart man ska gå.

                    if (input == "right") //om användaren skrev in right ovan kommer man till denna if sats.
                    {
                        room = "room1"; //man flyttar till else if satsen nedan.
                    }
                    else //om man inte skrev in right så kommer denna else satsen att köras. Efter den här börjar man om från början vid if satsen room == "hallway"
                    {
                        Console.WriteLine("I could not quite copy your command. Will you try again? "); //påpekar använder att försöka igen.
                    }
                }
                else if (room == "room1") //hitt kommer man ifall man skrev in right. 
                {

                    //Classroom1 classroom = new Classroom1(); //skapar klassen Classroom1 som heter classroom som är en subklass av klassen Rooms.

                    Console.WriteLine("You went right and have arrived in the classroom. Your cat is in front of you. "); //vanlig console.WriteLine

                    Console.WriteLine("Would you like to go 'back' or 'pickup' your cat?"); //påpekar använder utöver vad man ska göra.
                    string input = Console.ReadLine(); //här får användaren skriva in sitt input. 

                    if (input == "back") //om användaren input är back så kommer man tillbaka till hallway vilket är i början av spelet. 
                    {
                        room = "hallway"; //man kommer till if satsen där room == "hallway"
                    }

                    else if (input == "pickup") //körs ifall input är lika med pickup. 
                    {
                        Console.WriteLine("You picked up your cat! ");
                        Console.WriteLine("However, where are you right now? It looks like we are in...");
                       
                        Classroom1 classroom = new Classroom1(); //skapar en klass som heter Classroom som är utifrån Classroom1 vilket också ärver utifrån Rooms. 

                        string classroomName = classroom.GetroomName(); //skapar utifrån Classroom1 där man ärver utifrån public string GetroomName()
                        //set fixas.
                        Console.WriteLine(classroomName); //skriver ut vad klassen Classroom1 heter vilket i detta fall är 'return roomName + "Classroom";'

                        Console.ReadLine();

                        Console.WriteLine("However that is a boring name! Please use between 3 and 10 letters for another name!"); //tilltalar använder att man ska skriva in vart man är

                        {
                            classroomName = Console.ReadLine();

                            while (classroomName.Length > 10 || classroomName.Length < 3) //om antal inte höll bara nummer så kommer denna loop att köras
                            {
                                Console.WriteLine("Please use between 3 and 10 letters!");

                                Console.WriteLine(""); // ännu en till tillsägelse på vad man ska göra. Köras så länge man är ret@rded eller trollar. Yep, censuerade ordet.

                                if (classroomName.Length > 10 || classroomName.Length < 3) //använder kan skriva in flera försök tills den uppnår kraven.
                                {
                                    classroomName = Console.ReadLine(); //får försöka igen.

                                }
                            }

                        }

                    Console.WriteLine("You are in " + classroomName + "! The temperatur is " + classroom.temperatur + "..."); //skriver ut classroomName och även ut temperaturen utifrån Classroom som är ifrån Classroom1.

                        int wind = classroom.WindSpeed(); //ändra till litet c.

                        Console.WriteLine("Wind speed is " + wind + "!");

                        Console.WriteLine("Where do you wanna go now? To the'exit' or 'stay'?");

                       input = Console.ReadLine(); //här får användaren skriva in vart den vill gå. 


                        if (input == "exit")
                        {
                            Console.WriteLine("You decided to go to the exit!");

                                Console.ReadLine();

                            room = "exit"; //skickar till input där room == "exit". 

                        }

                        else if (input == "stay")
                        {
                            Console.WriteLine("You decided to stay. Ohh look, someone has dropped several things on the floor!");

                            Console.WriteLine("What is lying overthere? Please write in 2 things!");

                            List<string> myList = new List<string>();

                            string things = Console.ReadLine();

                            myList.Add(things);

                            things = Console.ReadLine();

                            myList.Add(things);

                            Console.WriteLine("You found " + myList[0] + " and... " + myList[1] + "!");

                            Console.ReadLine();

                            Console.WriteLine("Looks like there is no road left but the one that leads to the exit...");
                            Console.ReadLine();

                            room = "exit";

                        }

                    }

                }

                else if (room == "exit")
                {

                    Rooms exit = new Rooms(); //skapar utifrån klassen Rooms som heter exit. 

                    Console.WriteLine("You are at the exit. Here the temperatur is " + exit.temperatur + "!"); //skriver ut temperaturen som finns i Rooms vilket är 5. 

                    Console.WriteLine("Thank you for playing!! THE END");

                    Console.ReadLine();

                }
            }

        }
    }
}
