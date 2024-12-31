using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
namespace Homework26.Models
{
    public class PersonModel
    {
		private string _firstName;

		public string FirstName
		{
			get { return _firstName; }
		}

		private string _lastName;

		public string LastName
		{
			get { return _lastName; }
		}

        public PersonModel(string firstName, string lastName)
        {
            _firstName = firstName;
			_lastName = lastName;
        }
    }


    public static class PersonModelEndpoints
    {
	    public static void MapPersonModelEndpoints (this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/PersonModel").WithTags(nameof(PersonModel));

            group.MapGet("/", (string firstName, string lastName) =>
            {
                PersonModel person = new PersonModel(firstName, lastName);
                return $"Hi {person.FirstName} {person.LastName}";
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
                //return TypedResults.Created($"/api/PersonModels/{model.ID}", model);
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
    }
}
