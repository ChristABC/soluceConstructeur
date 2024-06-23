using System;
using projConstructeur;

class MainProgram
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Quelle formule,voulez-vous : le nombre d'étages et la hauteur du bâtiment (1) ou seulement le nombre d'étages (2) ?");
        string formule = Console.ReadLine();

        Building building;

        if (formule == "1")
        {
            Console.Write("Quel est le nombre d'étages? ");
            int floors = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quelle est la taille de l'immeuble en mètres: ");
            double height = Convert.ToDouble((Console.ReadLine()));
            building = new Building(floors, height);
        }
        else if (formule == "2")
        {
            Console.Write("Quel est le nombre d'étages? ");
            int floors = Convert.ToInt32((Console.ReadLine()));
            building = new Building(floors);
        }
        else
        {
            Console.WriteLine("Choix incorrect. Veuillez choisir entre (1) et (2). ");
            return;
        }
        double numbFloors= building.GetFloorCount();
        double heightBulding = building.GetSize();
        double maxSize = building.GetFloorMaxSize();
        Console.WriteLine("Nombre d'étages: " +numbFloors );
        Console.WriteLine("Hauteur du bâtiment: " + heightBulding);
        Console.WriteLine("Taille maximum d'un étage: " + maxSize);
    }
}
