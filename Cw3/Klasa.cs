namespace Cw3
{
    public class Klasa
    {
    }


public static class StudentEndpoints
{
	public static void MapStudentEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Student", () =>
        {
            return new [] { new Student() };
        })
        .WithName("GetAllStudents");

        routes.MapGet("/api/Student/{id}", (int id) =>
        {
            //return new Student { ID = id };
        })
        .WithName("GetStudentById");

        routes.MapPut("/api/Student/{id}", (int id, Student input) =>
        {
            return Results.NoContent();
        })
        .WithName("UpdateStudent");

        routes.MapPost("/api/Student/", (Student model) =>
        {
            //return Results.Created($"/Students/{model.ID}", model);
        })
        .WithName("CreateStudent");

        routes.MapDelete("/api/Student/{id}", (int id) =>
        {
            //return Results.Ok(new Student { ID = id });
        })
        .WithName("DeleteStudent");  
    }
}}
