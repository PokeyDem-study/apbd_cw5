using Apbd_cw5.Models;

namespace Apbd_cw5.DataBase;

public class MockDb //Second variant of data base
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public MockDb()
    {
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
    }
}