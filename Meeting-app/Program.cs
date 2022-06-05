
using Meeting_app;
using Meeting_app.Models;

bool exit = false;
int selection;

string[] loginVariants = new string[]
{
    "Register",
    "Login"
};

string[] menuVariants = new string[]
{
    "Create a new meeting",
    "Delete an existing meeting",
    "Add a person to the meeting",
    "Remove person from a meeting",
    "List of all created meetings",
    "exit"
};

selection = Utility.getStringFromArray(loginVariants, "please select : ");

switch (selection)
{
    case 0: User.Register();
        break;
    case 1: User.Login();
        break;
}


selection = Utility.getStringFromArray(menuVariants, "please select");
while (!exit)
{
    switch (selection)
    {
        case 0: Console.WriteLine("create meeting");
            break;
        case 1: Console.WriteLine("delete meeting");
            break;
        case 2: Console.WriteLine("add person");
            break;
        case 3: Console.WriteLine("remove person");
            break;
        case 4: Console.WriteLine("list all meetings");
            break;
        default: exit = true; break;
    }
    break;
}