using Domain.Models;

namespace Infrastructure.Services;

public class PostService
{
    private List<Post> posts = new List<Post>();
    private int nextId = 1;

    public List<Post> GetPosts()
    {
        return posts;
    }

    public void AddPost(Post post)
    {
        if (string.IsNullOrWhiteSpace(post.Title))
        {
            Console.WriteLine("Title is required.");
            return;
        }

        if (string.IsNullOrWhiteSpace(post.Discription))
        {
            Console.WriteLine("Discription is required.");
            return;
        }

        post.Id = nextId++;
        posts.Add(post);

        Console.WriteLine("Post added successfully.");
    }

    public void Update(Post post)
    {
        foreach (var item in posts)
        {
            if (item.Id == post.Id)
            {
                item.Title = post.Title;
                item.Discription = post.Discription;

                Console.WriteLine("Post updated.");
                return;
            }
        }

        Console.WriteLine("Post not found.");
    }

    public void Delete(int id)
    {
        foreach (var item in posts)
        {
            if (item.Id == id)
            {
                posts.Remove(item);
                Console.WriteLine("Post deleted.");
                return;
            }
        }

        Console.WriteLine("Post not found.");
    }
}
