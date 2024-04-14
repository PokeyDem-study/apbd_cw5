using Apbd_cw5.DataBase;
using Apbd_cw5.Models;

namespace Apbd_cw5.Endpoints;

public static class AnimalEndpoints //Obsluga endpointow using minimal API, musi byc static bo metody rozszerzen sa static
{
    public static void MapAnimalEndpoints(this WebApplication app) //metoda rozszerzen (rozszerzamy app)
    {
        //Minimal API
        app.MapGet("/animals", () =>
        {
            //200 - Ok (Others: 400 - Bad Request,401 - Unauthorized,403 - Forbidden,404 - Not Found,500)
            var animals = StaticData.Animals;
            
            return Results.Ok(animals);
        });

        app.MapGet("/animals/{id}", (int id) =>
        {
            var animal = StaticData.GetAnimalById(id);
            return Results.Ok(animal);
        });

        app.MapPost("/animals", (Animal animal) =>
        {
            //201 - Created
            StaticData.AddAnimal(animal);
            return Results.Created("", animal);
        });
    }
}