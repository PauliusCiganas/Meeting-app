using System.Text.Json;

namespace Meeting_app.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public static List<User> UserList = new List<User>();

        public static User CurrentUser = null;

        const string FILE_NAME = "Users.json";




        public static void Register()
        {
            Console.Clear();
            bool exit = false;
            while (!exit)
            {
                if (File.Exists(FILE_NAME))
                {
                    var data = File.ReadAllText(FILE_NAME);
                    var objectData = JsonSerializer.Deserialize<List<User>>(data);
                    UserList = objectData;
                }

                Console.WriteLine("Please select a username");
                string username = Console.ReadLine();
                Console.WriteLine("Please select a password");
                string password = Console.ReadLine();
                
                var user = UserList.Where(x => x.Name == username).FirstOrDefault();
                if (user != null)
                    {
                        Console.Clear();
                        Console.WriteLine("User already exists");
                        continue;
                    }

                var newUser = new User() { Name = username, Password = password};

                CurrentUser = newUser;
                UserList.Add(newUser);
                var jsonString = JsonSerializer.Serialize(UserList);
                File.WriteAllText(FILE_NAME, jsonString);
                
                Console.Clear();
                exit = true;
            }
        }


        public static void Login()
        {
            Console.Clear();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please enter your username");
                string username = Console.ReadLine();
                Console.WriteLine("Please enter your password");
                string password = Console.ReadLine();

                var user = UserList.Where(x => x.Name == username).FirstOrDefault();

                if (user == null)
                {
                    Console.Clear();
                    Console.WriteLine("Register if you want to find friends!");
                    continue;
                }
                if (user.Password == password && user.Name == username)
                {
                    Console.Clear();
                    CurrentUser = user;
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Password is not correct");
                    continue;
                }
            }
        }
    }
}


