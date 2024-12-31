using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
namespace Homework27.Models
{
    public class AddressModel
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }


public static class AddressModelEndpoints
{
	public static void MapAddressModelEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Address").WithTags(nameof(AddressModel));

        group.MapGet("/", () =>
        {
            return new [] { new AddressModel() };
        })
        .WithName("GetAllAddressModels")
        .WithOpenApi();

        group.MapGet("/{id}", (int id) =>
        {
            //return new AddressModel { ID = id };
        })
        .WithName("GetAddressModelById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, AddressModel input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdateAddressModel")
        .WithOpenApi();

        group.MapPost("/", (AddressModel model) =>
        {
            return TypedResults.Created($"/api/AddressModels/{model.ID}", model);
        })
        .WithName("CreateAddressModel")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new AddressModel { ID = id });
        })
        .WithName("DeleteAddressModel")
        .WithOpenApi();
    }
}}
