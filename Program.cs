// Create an array of strings
string[] GamesArray = new string[13];

// Create an empty list of strings
List<string> GamesList = new List<string>();

// Add to an Array
GamesArray[0] = "Monster Hunter";
GamesArray[1] = "Age of Empires II: Definitive Edition";
GamesArray[2] = "Zelda";
GamesArray[3] = "Halo";
GamesArray[4] = "League of Legends";
GamesArray[5] = "Game of Thrones";
GamesArray[6] = "World of Warcraft";
GamesArray[7] = "The Sims 4";
GamesArray[8] = "Apex Legends";
GamesArray[9] = "Starcraft II";
GamesArray[10] = "Mechwarrior Online";
GamesArray[11] = "Overwatch";
GamesArray[12] = "Call of duty";


// Add to the list
GamesList.Add("Monster Hunter");
GamesList.Add("Age of Empires II: Definitive Edition");
GamesList.Add("Zelda");
GamesList.Add("Halo");
GamesList.Add("League of Legends");
GamesList.Add("Game of Thrones");
GamesList.Add("World of Warcraft");
GamesList.Add("The Sims 4");
GamesList.Add("Apex Legends");
GamesList.Add("Starcraft II");
GamesList.Add("Mechwarrior Online");
GamesList.Add("Overwatch");
GamesList.Add("Call of duty");

// Get the size (number of elements) in the Array
Console.WriteLine("Size of the Array: " + GamesArray.Length);

// Get the size (number of elements) in the List
Console.WriteLine("Size of the List: " + GamesList.Count);


// Access an individual element in the List/Array
System.Console.WriteLine("Element 0 in Array: " + GamesArray[0]);
System.Console.WriteLine("Element 0 in List: " + GamesList[0]);

// Update an element in a List/Array
GamesArray[GamesArray.Length - 1] = "Call of Duty - Modern Warfare II";
GamesList[GamesList.Count - 1] = "Call of Duty - Modern Warfare II";

System.Console.WriteLine("------------------------------");

// print Elements in a List and Array
foreach (var game in GamesArray)
{
    System.Console.WriteLine(game);
}

System.Console.WriteLine("------------------------------");
foreach (var game in GamesList)
{
    System.Console.WriteLine(game);
}

// A list is dynamic.  Therefore, we can add to its size
GamesList.Add("XCOM");
System.Console.WriteLine("------------------------------");
foreach (var game in GamesList)
{
    System.Console.WriteLine(game);
}

// A list can be sorted
GamesList.Sort();
System.Console.WriteLine("-----------Sorted List-------------------");
foreach (var game in GamesList)
{
    System.Console.WriteLine(game);
}

// A list can be reversed
GamesList.Reverse();
System.Console.WriteLine("-----------Reversed List-------------------");
foreach (var game in GamesList)
{
    System.Console.WriteLine(game);
}

System.Console.WriteLine("-----------Removing Elements Array-------------------");
// Removing elements Array
Console.WriteLine("Size of the Array: " + GamesArray.Length);
GamesArray[6] = "";
Console.WriteLine("Size of the Array: " + GamesArray.Length);

System.Console.WriteLine("-----------Removing Elements List-------------------");
// Removing elements Array
Console.WriteLine("Size of the List: " + GamesList.Count);
GamesList.RemoveAt(6);
Console.WriteLine("Size of the List: " + GamesList.Count);
GamesList.Remove("Halo");
Console.WriteLine("Size of the List: " + GamesList.Count);
foreach (var game in GamesList)
{
    System.Console.WriteLine(game);
}

System.Console.WriteLine("Add a game: ");
var newGame = Console.ReadLine();

if (newGame != null)
{
    GamesList.Add(newGame);
}

foreach (var game in GamesList)
{
    System.Console.WriteLine(game);
}


// Exercises
// 
// 1. Create a program that reads in 5 names from the console. It then prints out "Hello <name>" for all the names entered
// 2. A program starts with the values 34, 5, 67, 1, 99, 34, 44, 78, 34, 0. Write a program that adds all numbers together and outputs the total.
// 3. Write a program that reads in 5 numbers. It then asks the user for another number and outputs whether the number has already been entered.
// 4. As above except the program will tell the user how many times a repeated number has been entered
// 5. A program stores words read from console, until the word "stop" is entered. It then outputs the words entered in reverse order.

void Ex1()
{
    System.Console.WriteLine("================= Ex1 =========================");
    var numTimes = 5;
    List<string> Names = new List<string>();

    for (var i = 0; i < numTimes; i++)
    {
        System.Console.WriteLine("Please enter a name: ");
        Names.Add(Console.ReadLine());
    }

    foreach (var name in Names) 
    {
        System.Console.WriteLine("Hello " + name);
    }
}

Ex1();

void Ex2() {

    System.Console.WriteLine("================= Ex2 =========================");
    List<int> Numbers = new List<int>() { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };
    var numTotal = 0;

    foreach (var num in Numbers) {
        // numTotal = numTotal + num;
        numTotal += num;
    }

    // We could cheat and use the below...but we won't just yet >:)
    // numTotal = Numbers.Sum();

    System.Console.WriteLine(numTotal);
}

Ex2();

void Ex3(){

    System.Console.WriteLine("================= Ex3 =========================");
    var num = 5;
    List<string> Numbers = new List<string>();
    for (var i = 0; i < num; i++)
    {
        System.Console.WriteLine("Please enter a number: ");
        Numbers.Add(Console.ReadLine());
    }

    System.Console.WriteLine("Please enter a number to check if it's in the list:");
    string usernum = Console.ReadLine();

    bool checkForMatch = false;
    foreach (var number in Numbers) {
        if (number == usernum) {
            checkForMatch = true;
        }
    }
    if (checkForMatch == true){
        System.Console.WriteLine("That number is already in the list");
    }
    else {
        System.Console.WriteLine("That number is not in the list");
    }

}

Ex3();