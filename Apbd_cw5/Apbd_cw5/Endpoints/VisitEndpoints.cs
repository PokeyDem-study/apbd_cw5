using Apbd_cw5.DataBase;
using Apbd_cw5.Models;

namespace Apbd_cw5.Endpoints;

public static class VisitEndpoints
{
    public static void MapVisitEndpoints(this WebApplication app)
    {
        app.MapGet("/visits{id}", (int id) =>
        {
            var visits = StaticData.GetVisitsForAnimal(id);
            if (visits.Count == 0)
            {
                return Results.NotFound($"Visits for animal with id {id} not found");
            }

            return Results.Ok(visits);
        });

        app.MapPost("/visits", (Visit visit) =>
        {
            bool result = StaticData.AddVisit(visit);
            
            if (!result)
                return Results.NotFound("Animal with id " + visit.AnimalId + " not found, cant add visit");
            
            return Results.Created("", visit);
        });
    }
}