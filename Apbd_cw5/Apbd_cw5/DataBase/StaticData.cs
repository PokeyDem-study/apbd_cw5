using Apbd_cw5.Models;

namespace Apbd_cw5.DataBase;

public class StaticData //First variant of data base
{
    public static List<Animal> Animals = new List<Animal>();

    public static List<Visit> Visits = new List<Visit>();

    public static List<Visit> GetVisitsForAnimal(int id)
    {
        List<Visit> visitsToReturn = new List<Visit>();

        foreach (var visit in Visits)
        {
            if (visit.AnimalId == id)
            {
                visitsToReturn.Add(visit);
            }
        }

        return visitsToReturn;
    }

    public static bool AddVisit(Visit visit)
    {
        var visitAnimal = GetAnimalById(visit.AnimalId);
        
        if (visitAnimal == null)
            return false;
        
        if (!Animals.Contains(visitAnimal))
            return false;
        
        Visits.Add(visit);
        return true;
    }

    public static Animal? GetAnimalById(int id)
    {
        Animal? animalToReturn = null;
        foreach (var animal in Animals)
        {
            if (animal.Id == id)
            {
                animalToReturn = animal;
            }
        }

        return animalToReturn;
    }

    public static void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public static void RemoveAnimal(Animal animal)
    {
        Animals.Remove(animal);
    }
}