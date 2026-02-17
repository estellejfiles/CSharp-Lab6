using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TeenHangout.Pages;

public class IndexModel : PageModel
{
    // create attributes that are arrays to store users and posts
    public User[] Users { get; set; }
    public Post[] Posts { get; set; }
    // method called when page is initially displayed
    public void OnGet()
    {
        // create user array to store users in attribute
        Users = new User[]
        {
            new User("MusicLover", 15, "Purple"),
            new User("GamerGirl", 16, "Red"),
            new User("BookwormBen", 15, "Yellow")
        };

        // create post array to store posts in attribute
        Posts = new Post[]
        {
            new Post("GamerGirl", "Anyone want to play online later?", 30),
            new Post("BookwormBen", "Reading the best book ever!", 15),
            new Post("MusicLover", "Concert next week! So excited!", 22)
        };
    }
}
