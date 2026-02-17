namespace TeenHangout;
// class for creating a new post on the social media site
public class Post {
    // attributes to describe object
    public string Username { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }

    // cosntructor method to create new post object
    public Post(string username, string content, int likes) {
        // set values of attributes to the arguments
        Username = username;
        Content = content;
        Likes = likes;
    }
}