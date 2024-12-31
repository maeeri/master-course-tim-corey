using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
namespace Homework27.Models
{
    public class PersonModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
    }


public static class PersonModelEndpoints
{
	public static void MapPersonModelEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Person").WithTags(nameof(PersonModel));

        group.MapGet("/", () =>
        {
            return new [] { new PersonModel() };
        })
        .WithName("GetAllPersonModels")
        .WithOpenApi();

        group.MapGet("/{id}", (int id) =>
        {
            //return new PersonModel { ID = id };
        })
        .WithName("GetPersonModelById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, PersonModel input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdatePersonModel")
        .WithOpenApi();

        group.MapPost("/", (PersonModel model) =>
        {
            return TypedResults.Created($"/api/PersonModels/{model.ID}", model);
        })
        .WithName("CreatePersonModel")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new PersonModel { ID = id });
        })
        .WithName("DeletePersonModel")
        .WithOpenApi();
    }
}}
