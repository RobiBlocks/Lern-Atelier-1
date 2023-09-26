using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Errate_die_Geheimzahl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Spiel beginnt
            Console.WriteLine("Hallo Spieler!");
            Console.WriteLine("Möchtest du alleine (1) oder zu zweit (2) spielen?");
            int mode = Convert.ToInt32(Console.ReadLine());

            while

            {
                Console.WriteLine("Dieser Modus existiert gar nicht. Du musst eine 1 oder eine 2 verwenden!");
                Console.WriteLine("Möchtest du alleine (1) oder zu zweit (2) spielen?");
                mode = Convert.ToInt32(Console.ReadLine());
            }
            if (mode == 1)
            {
                //Glückszahl erstellen
                Random cube = new Random();
                int Ergebnis = cube.Next(1, 100);
                Console.WriteLine(Ergebnis);

                //definieren der Variabeln
                bool Wahrheit = false;
                int guess = 0;
                int highscore = 0;
                bool Richtigkeit = false;

                //Programm fragt nach einer Zahl
                Console.WriteLine("Wie lautet die Geheimzahl (zwischen 1 und 100)?");

                //Programm kontrolliert die Zahl
                while (Wahrheit == false)
                {
                    //Benutzer tätigt eine Eingabe
                    do
                    {
                        try
                        {
                            guess = Convert.ToInt32(Console.ReadLine());
                            //Es wird geschaut, ob die Zahl ungültig ist (kleiner als 0 oder grösser als 100)
                            while (guess < 0 | guess > 100)
                            {
                                Console.WriteLine("Die Zahl ist ungültig! Nimm eine andere Zahl!");
                                Console.WriteLine("Wie lautet die Geheimzahl (zwischen 1 und 100)?");
                                guess = Convert.ToInt32(Console.ReadLine());
                            }
                            Richtigkeit = true;
                        }
                        catch
                        {
                            Console.WriteLine("Es ist ein Fehler unterlaufen! Probieren Sie es nochmals!");
                        }
                    } while (Richtigkeit == false);

                    //Programm schaut, ob die gerratene Zahl richtig oder falsch ist
                    Wahrheit = guess == Ergebnis;
                    if (Wahrheit == true)
                    {
                        //schaut, ob die Zahl mit der Geheimzahl übereinstimmt
                        Console.WriteLine("Bravo, super gemacht! Du hast die Geheimzahl herausgefunden!");
                        Console.WriteLine("Dein Highscore beträgt: " + highscore);
                    }
                    //Wenn die Zahl Falsch ist, wird geschaut, ob die Zahl grösser oder kleiner als die Geheimzahl ist
                    if (Wahrheit == false)
                    {
                        if (guess < Ergebnis)
                        {
                            Console.WriteLine("Falsch, die Geheimzahl ist grösser! Versuche es nochmal!");
                        }
                        if (guess > Ergebnis)
                        {
                            Console.WriteLine("Falsch, die Geheimzahl ist kleiner! Versuche es nochmal!");
                        }
                    }
                    //Highscore wird um 1 erhöht
                    highscore = highscore + 1;
                }
            }
            if (mode == 2)
            {
                //definieren der Variabeln
                string name1 = "a";
                bool Wahrheit1 = false;
                int guess1 = 0;
                int highscore1 = 0;
                bool Richtigkeit1 = false;

                string name2 = "b";
                bool Wahrheit2 = false;
                int guess2 = 0;
                int highscore2 = 0;
                bool Richtigkeit2 = false;

                //Fragt nach den Spieler Namen
                Console.WriteLine("Wie heisst Spieler 1?");
                do
                {
                    try
                    {
                        name1 = Console.ReadLine();
                        Richtigkeit1 = true;
                    }
                    catch
                    {
                        Console.WriteLine("Es ist ein Fehler unterlaufen! Probieren Sie es nochmal!");
                    }
                } while (Richtigkeit1 == false);

                Console.WriteLine("Wie heisst Spieler 2?");
                do
                {
                    try
                    {
                        name2 = Console.ReadLine();
                        Richtigkeit2 = true;
                    }
                    catch
                    {
                        Console.WriteLine("Es ist ein Fehler unterlaufen! Probieren Sie es nochmal!");
                    }
                } while (Richtigkeit2 == false);

                //Glückszahlen erstellen
                Random cube1 = new Random();
                int Ergebnis1 = cube1.Next(1, 100);
                Console.WriteLine(Ergebnis1);

                Random cube2 = new Random();
                int Ergebnis2 = cube2.Next(1, 100);
                Console.WriteLine(Ergebnis2);

                //Programm fragt nach einer Zahl
                Console.WriteLine(name1 + " ist am Zug!");
                Console.WriteLine("Wie lautet die Geheimzahl? (zwischen 1 und 100)");

                //Spieler 1 ist am Zug
                while (Wahrheit1 == false)
                {
                    //Spieler 1 tätigt eine Eingabe
                    do
                    {
                        Richtigkeit1 = false;
                        try
                        {
                            guess1 = Convert.ToInt32(Console.ReadLine());
                            //Es wird geschaut, ob die Zahl ungültig ist (kleiner als 0 oder grösser als 100)
                            while (guess1 < 0 | guess1 > 100)
                            {
                                Console.WriteLine("Die Zahl ist ungültig! Nimm eine andere Zahl! (zwischen 1 und 100)");
                                guess1 = Convert.ToInt32(Console.ReadLine());
                            }

                            Richtigkeit1 = true;
                        }
                        catch
                        {
                            Console.WriteLine("Es ist ein Fehler unterlaufen! Probieren Sie es nochmal!");
                        }
                    } while (Richtigkeit1 == false);


                    Wahrheit1 = guess1 == Ergebnis1;

                    //Programm schaut, ob die gerratene Zahl richtig oder falsch ist
                    if (Wahrheit1 == true)
                    {
                        //schaut, ob die Zahl mit der Geheimzahl übereinstimmt
                        Console.WriteLine("BRAVO! " + name1 + " hat die Geheimzahl herausgefunden!");
                    }
                    //Wenn die Zahl Falsch ist, wird geschaut, ob die Zahl grösser oder kleiner als die Geheimzahl ist
                    if (guess1 < Ergebnis1)
                    {
                        Console.WriteLine("Falsch, die Geheimzahl ist grösser! Versuche es nochmal!");
                    }
                    if (guess1 > Ergebnis1)
                    {
                        Console.WriteLine("Falsch, die Geheimzahl ist kleiner! Versuche es nochmal!");
                    }
                    //Highscore wird um 1 erhöht
                    highscore1 = highscore1 + 1;
                }
                //Spieler 2 ist am Zug
                Console.WriteLine(name2 + " ist am Zug!");
                Console.WriteLine("Wie lautet die Geheimzahl (zwischen 1 und 100)?");
                while (Wahrheit2 == false)
                {
                    //Spieler 2 tätigt eine Eingabe
                    do
                    {
                        Richtigkeit2 = false;
                        try
                        {
                            guess2 = Convert.ToInt32(Console.ReadLine());
                            //Es wird geschaut, ob die Zahl ungültig ist (kleiner als 0 oder grösser als 100)
                            while (guess2 < 0 | guess2 > 100)
                            {
                                Console.WriteLine("Die Zahl ist ungültig! Nimm eine grössere Zahl! (zwischen 1 und 100)");
                                guess2 = Convert.ToInt32(Console.ReadLine());
                            }
                            Richtigkeit2 = true;
                        }
                        catch
                        {
                            Console.WriteLine("Es ist ein Fehler unterlaufen! Probieren Sie es nochmal!");
                        }
                    } while (Richtigkeit2 == false);
                    Wahrheit2 = guess2 == Ergebnis2;

                    //Programm schaut, ob die gerratene Zahl richtig oder falsch ist
                    //schaut, ob die Zahl mit der Geheimzahl übereinstimmt
                    if (Wahrheit2 == true)
                    {
                        Console.WriteLine("BRAVO! " + name2 + " hat die Geheimzahl herausgefunden!");
                    }
                    //Wenn die Zahl Falsch ist, wird geschaut, ob die Zahl grösser oder kleiner als die Geheimzahl ist
                    if (guess2 < Ergebnis2)
                    {
                        Console.WriteLine("Falsch, die Geheimzahl ist grösser! Versuche es nochmal!");
                    }
                    if (guess2 > Ergebnis2)
                    {
                        Console.WriteLine("Falsch, die Geheimzahl ist kleiner! Versuche es nochmal!");
                    }
                    //Highscore wird um 1 erhöht
                    highscore2 = highscore2 + 1;
                }
                if (highscore1 == highscore2)
                {
                    Console.WriteLine("GLEICHSTAND! Es gibt ein DUELL!");
                    //Duell startet
                    //Erstellung der Platzierungsnummern
                    Random cube3 = new Random();
                    int placementnumber = cube3.Next(1, 10);

                    Console.WriteLine(name1 + " wählt seine Platzierungszahl (zwischen 1 und 10)!:");
                    int placenumber1 = 0;
                    Richtigkeit1 = false;
                    do
                    {
                        try
                        {
                            placenumber1 = placementnumber - Convert.ToInt32(Console.ReadLine());
                            while (placenumber1 < 0 | placenumber1 > 10)
                            {
                                Console.WriteLine("Die Zahl ist ungültig! Nimm eine grössere Zahl! (zwischen 1 und 100)");
                                placenumber1 = Convert.ToInt32(Console.ReadLine());
                            }
                            Richtigkeit1 = true;
                        }
                        catch
                        {
                            Console.WriteLine("Es ist ein Fehler unterlaufen! Probiere es nochmal!");
                        }
                    } while (Richtigkeit1 == false);


                    Console.WriteLine(name2 + " wählt seine Platzierungszahl (zwischen 1 und 10)!:");
                    int placenumber2 = 0;
                    Richtigkeit2 = false;
                    do
                    {
                        try
                        {
                            placenumber2 = placementnumber - Convert.ToInt32(Console.ReadLine());
                            while (placenumber2 < 0 | placenumber2 > 10)
                            {
                                Console.WriteLine("Die Zahl ist ungültig! Nimm eine grössere Zahl! (zwischen 1 und 100)");
                                placenumber2 = Convert.ToInt32(Console.ReadLine());
                            }
                            Richtigkeit2 = true;
                        }
                        catch
                        {
                            Console.WriteLine("Es ist ein Fehler unterlaufen! Probiere es nochmal!");
                        }
                    } while (Richtigkeit2 == false);


                    //Überprüfung der Platzierungsnummern
                    if (placenumber1 == placenumber2)
                    {
                        Console.WriteLine("Es gibt ein UNENTSCHIEDEN. Ihr seid beides Glückhasen!");
                    }
                    if (placenumber1 < placenumber2)
                    {
                        Console.WriteLine("BRAVO! " + name1 + " hat GEWONNEN mit der Platzierungszahl " + placenumber1 + "! Du Glückshase!");
                        Console.WriteLine(name2 + " wird zweiter mit der Platzierungszahl " + placenumber2 + "!");
                    }
                    if (placenumber1 > placenumber2)
                    {
                        Console.WriteLine("BRAVO! " + name2 + " hat GEWONNEN mit der Platzierungszahl " + placenumber2 + "! Du Glückshase!");
                        Console.WriteLine(name1 + " wird zweiter mit der Platzierungszahl " + placenumber1 + "!");
                    }
                }
                if (highscore1 < highscore2)
                {
                    Console.WriteLine(name1 + " hat GEWONNEN mit einem Highscore von: " + highscore1);
                    Console.WriteLine(name2 + " wird zweiter mit einem Highscore von: " + highscore1);
                }
                if (highscore1 > highscore2)
                {
                    Console.WriteLine(name2 + " hat GEWONNEN mit einem Highscore von: " + highscore2);
                    Console.WriteLine(name1 + " wird zweiter mit einem Highscore von: " + highscore1);
                }
            }
        }
    }
}
