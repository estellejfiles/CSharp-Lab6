namespace TeenHangout
{
    public class User
    {
        // create attributes to describe the object
        public string Username { get; set; }
        public int Age { get; set; }
        public string FavoriteColor { get; set; }
        // create constructor to make an object using the class as a blueprint
        public User(string username, int age, string favoriteColor)
        {
            // set the values of the attributes for the new user
            Username = username;
            Age = age;
            FavoriteColor = favoriteColor;
        }
    }
}