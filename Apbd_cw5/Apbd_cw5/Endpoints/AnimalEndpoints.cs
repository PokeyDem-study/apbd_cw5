using Apbd_cw5.DataBase;
using Apbd_cw5.Models;
using Microsoft.AspNetCore.Http.HttpResults;

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
            if (animal == null)
            {
                return Results.NotFound($"Animal with id {id} not found");
            }
            return Results.Ok(animal);
        });

        app.MapPost("/animals", (Animal animal) =>
        {
            //201 - Created
            StaticData.AddAnimal(animal);
            return Results.Created("", animal);
        });

        app.MapPut("/animals{id}", (int id, Animal animal) =>
        {
            var animalToEdit = StaticData.GetAnimalById(id);

            if (animalToEdit == null)
            {
                return Results.NotFound($"Animal with id {id} not found");
            }

            StaticData.RemoveAnimal(animalToEdit);
            StaticData.AddAnimal(animal);
            return Results.Ok();
        });

        app.MapDelete("/animals{id}", (int id) =>
        {
            var animalToDelete = StaticData.GetAnimalById(id);

            if (animalToDelete == null)
            {
                return Results.NotFound($"Animal with id {id} not found");
            }

            StaticData.RemoveAnimal(animalToDelete);
            return Results.Ok();
        });
    }
}