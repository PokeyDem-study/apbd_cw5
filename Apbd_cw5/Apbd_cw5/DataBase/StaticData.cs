using Apbd_cw5.Models;

namespace Apbd_cw5.DataBase;

public class StaticData //First variant of data base
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(),
        new Animal(),
        new Animal()
    };
}