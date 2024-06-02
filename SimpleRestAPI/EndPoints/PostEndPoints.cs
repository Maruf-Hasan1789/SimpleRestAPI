using SimpleRestAPI.Data;
using SimpleRestAPI.DTO;

namespace SimpleRestAPI.Endpoints;

public static class PostEndPoints
{
    public static List<PostInformation> allPosts = new();

    public static WebApplication MapPostEndpoints(this WebApplication app)
    {
        app.MapGet("/posts", () => allPosts);

        app.MapPost("/posts",(CreatePostDTO newPost) =>
        {
            var newPostDetails = new PostInformation()
            {
                PostId = allPosts.Count + 1,
                Title = newPost.Title,
                Content = newPost.Content,
            };

            allPosts.Add(newPostDetails);
            return Results.Ok(newPostDetails);
        }).WithParameterValidation();
        
        return app;
    } 
}
