using Apbd_cw5.Models;

namespace Apbd_cw5.DataBase;

public class StaticData //First variant of data base
{
    public static List<Animal> Animals = new List<Animal>()
    {
        
    };

    public static Animal GetAnimalById(int id)
    {
        Animal animalToReturn = new Animal();
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
}