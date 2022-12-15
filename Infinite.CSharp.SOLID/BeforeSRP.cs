using System;

namespace Infinite.CSharp.SOLID
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class Registration
    {
        public void Create(User user)
        {
            try
            {
                Console.WriteLine("User details added successfull");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message :Unable to add user details to database\nReason :{ex.Message}");
                Console.WriteLine($"Error Logged :{DateTime.Now}Reason :{ex.Message}");
            }
        }
    }
}
