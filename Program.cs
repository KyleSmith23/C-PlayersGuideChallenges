/* Console.WriteLine("Enter the base size: ");
decimal baseSize = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the height: ");
decimal height = int.Parse(Console.ReadLine());

decimal area = baseSize * height / 2;
Console.WriteLine($"The area of the triangle is: {area}"); */

/* Console.WriteLine("How many eggs do you have?");
int totalEggs = Convert.ToInt32(Console.ReadLine());

int duckBearsShare = totalEggs % 4;
int sistersShare = totalEggs / 4;

Console.WriteLine($"Sisters get {sistersShare} eggs each.\nDuckbear gets {duckBearsShare} eggs."); */

/* Console.WriteLine("How many estates do you have?: ");
int estates = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many duchies do you have?: ");
int duchies = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many provences do you have?: ");
int provinces = Convert.ToInt32(Console.ReadLine());

int points = (provinces * 6) + (duchies * 3) + estates;

Console.WriteLine($"You have {points} points."); */
/*
Console.ForegroundColor = ConsoleColor.Red;
Console.Title = "Defense of Consolas";

Console.WriteLine("Target Row?: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Target Column?: ");
int column = Convert.ToInt32(Console.ReadLine());

int RowMinusOne = row - 1;
int RowPlusOne = row + 1;
int ColMinusOne = column - 1;
int ColPlusOne = column + 1;

Console.WriteLine($"Deploy to\n({column}, {RowMinusOne})\n({column}, {RowPlusOne})\n({ColMinusOne}, {row})\n({ColPlusOne}, {row})");

Console.Beep();

Console.ReadKey(true); */

/* Console.Write("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
  Console.WriteLine("Tick");
else
  Console.WriteLine("Tock"); */

/* Console.WriteLine("What is the value for X?");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("What is the value for Y?");
int y = int.Parse(Console.ReadLine());

if (x < 0 && y > 0)
  Console.WriteLine("The enemy is to the northwest!");
else if (x == 0 && y > 0)
  Console.WriteLine("The enemy is to the north!");
else if (x > 0 && y > 0)
  Console.WriteLine("The enemy is to the northeast!");
else if (x < 0 && y == 0)
  Console.WriteLine("The enemy is to the west!");
else if (x > 0 && y == 0)
  Console.WriteLine("The enemy is to the east!");
else if (x < 0 && y > 0)
  Console.WriteLine("The enemy is to the southwest!");
else if (x == 0 && y < 0)
  Console.WriteLine("The enemy is to the north!");
else if (x > 0 && y < 0)
  Console.WriteLine("The enemy is to the northeast!");
else
{
  Console.WriteLine("The enemy is here!");
} */

//Level 10 - Shop menu


/*
bool exit = false;
do
{

    Console.WriteLine("The following items are available:\n" +
        "1 - Rope\n" +
        "2 - Torches\n" +
        "3 - Climbing Equipment\n" +
        "4 - Clean Water\n" +
        "5 - Machete\n" +
        "6 - Canoe\n" +
        "7 - Food Supplies\n" +
        "What number do you want to see the prices of?\n" +
        "Or type \"exit\" to quit");

    string userInput = Console.ReadLine();

    if (userInput == "exit")
    {
        exit = true;
    }
    else
    {
        int itemNum = Convert.ToInt32(userInput);


        string myName = "Kyle";

        Console.WriteLine("What is your name?");
        string theirName = Console.ReadLine();

        decimal itemCost = 0;
        string item = "";

        switch (itemNum)
        {
            case 1:
                itemCost = 10;
                item = "Rope";
                break;
            case 2:
                itemCost = 15;
                item = "Torch";
                break;
            case 3:
                itemCost = 25;
                item = "Climbing equipment";
                break;
            case 4:
                itemCost = 1;
                item = "Clean water";
                break;
            case 5:
                itemCost = 20;
                item = "Machete";
                break;
            case 6:
                itemCost = 200;
                item = "Canoe";
                break;
            case 7:
                itemCost = 1;
                item = "Food supplies";
                break;
        };

        if (theirName == myName)
        {
            itemCost = itemCost / 2;
        }

        Console.WriteLine($"{item} cost {itemCost}");
    }
} while (exit == false);
*/

// Level 11 Guessing game

/*
Random random = new Random(); 
int randonNum = random.Next(1, 101);
int user2Guess = 0;
bool guessCorrect = false;

Console.Write("User 1, enter an number between 1 and 100:");

user2Guess = Convert.ToInt32(Console.ReadLine());

Console.Clear();

do
{

    if (user2Guess == randonNum)
    {
        guessCorrect = true;
        continue;
    }
    else if (user2Guess < randonNum)
    {
        Console.WriteLine($"{user2Guess} is too low");
    }
    else
    {
        Console.WriteLine($"{user2Guess} is too high");
    }

    Console.Write("Guess again: ");
    user2Guess = Convert.ToInt32(Console.ReadLine());

} while (!guessCorrect);

Console.WriteLine($"{user2Guess} is correct!");
*/

// Blast predictor

/*
int blastIndex = 0;
string blastType = "";

for (int i = 1; i >= 1 && i <= 100; i++)
{
    blastIndex = i;

    if (blastIndex % 3 == 0 && blastIndex % 5 == 0)
    {
        blastType = "Nuclear!";
    }
    else if (blastIndex % 3 == 0)
    {
        blastType = "Fire";
    }
    else if (blastIndex % 5 == 0)
    {
        blastType = "Electric";
    }
    else
    {
        blastType = "Normal";
    }

    Console.WriteLine($"{blastIndex}: {blastType}");
}

*/

// Level 12 - The replicator of D'to

/*
int[] arrayOne = new int[5];
int[] arrayTwo = new int[5];

// Populate array one with user input
for (int i = 0; i <= arrayOne.Length - 1; i++)
{
    Console.Write("Enter a number: ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    arrayOne[i] = userInput;
}

// copy array one into array two
for (int i =0; i < arrayOne.Length; i++)
{
    arrayTwo[i] = arrayOne[i];
}

// show array one
for (int i = 0;i < arrayOne.Length; i++)
{
    Console.WriteLine(arrayOne[i]);
}

// show array two
for (int i = 0; i < arrayTwo.Length; i++)
{
    Console.WriteLine(arrayTwo[i]);
}
*/

// The laws of Freach
/*
int[] array = new int[] {100, 23, 234, 56, 567, 10};

int currentSmallest = int.MaxValue;

foreach  (int num in array)
{
    if (num < currentSmallest)
        currentSmallest = num;
}
Console.WriteLine(currentSmallest);

int total  = 0;

foreach (int num in array)
    total += num;
Console.WriteLine(total);
*/

//Level 13 - Taking a number

using System.ComponentModel.Design;
/*
int AskForNumber(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
*/

/*
int AskForNumberInRange (string text, int min, int max)
{   
    while (true)
    {
        Console.WriteLine(text);
        int input = Convert.ToInt32(Console.ReadLine());

        if (input >= min && input <= max)
        {
            return input;
        } 
        Console.WriteLine("Not a valid number, try again");  
    } 
}
int number = AskForNumberInRange("Please enter a number between 1 - 10", 1, 10);
Console.WriteLine(number);
*/

// Level 14 BOSS BATTLE Hunting the Manticore

/*

int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;
int distance;
int damage;
int cannonRange;

// Player one chooses the Manticores distance from the city
distance = GetManticoreDistance();
do
{
    // Display round no, Manticore health & city health
    Status();
    // Damage varies depending on the round number
    damage = GetDamage();
        
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
    // Player two fires cannon at the Manticore
    cannonRange = AskForNumberInRange("Enter desired cannon range:", 1, 100);
    // Give clues as to Manticores location relative to cannon range
    BattleSequence(cannonRange, distance);
      
    cityHealth -- ;
    round++;
    
} while (manticoreHealth > 0 && cityHealth > 0);

if (manticoreHealth > 0)
    Console.WriteLine("The city has been destroyed!");
else
    Console.WriteLine("The Manticore has been destroyed!");

Console.ReadKey(); 

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        Console.WriteLine(text);
        int input = Convert.ToInt32(Console.ReadLine());

        if (input >= min && input <= max)
        {
            return input;
        }
        Console.WriteLine("Not a valid number, try again");
    }
}

int  GetManticoreDistance()
{
    Console.Write("Choose the Manticores distance from the city.");
    distance = Convert.ToInt32(Console.ReadLine());
    return distance;
    
}

void Status()
{
    Console.WriteLine($"STATUS: Round: {round}\t" +
    $"City: {cityHealth}/15\t" +
    $"Manticore: {manticoreHealth}/10");
}

int GetDamage()
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        damage = 10;
    }
    else if (round % 3 == 0 || round % 5 == 0)
    {
        damage = 3;
    }
    else
    {
        damage = 1;
    }

    return damage;
}

void BattleSequence(int cannonRange, int distance)
{
    if (cannonRange == distance)
    {
        Console.WriteLine("That was a DIRECT HIT!");
        manticoreHealth -= damage;
    }
    else if (cannonRange > distance)
    {
        Console.WriteLine("That OVERSHOT the target");
    }
    else
    {
        Console.WriteLine("That FELL SHORT of the target");
    }
}

*/

// Part Two Object Oriented Programming
// Level 16 

// Simulas Test

/*
string command;

ChestState currentChestState = new ChestState();
while (true)
{
    Console.Write($"The chest is {currentChestState}. What do you want to do? ");


    switch (currentChestState)
    {
        case ChestState.Locked:
            Console.WriteLine("Type unlock to unlock.");
            command = Console.ReadLine().ToLower();
            if (command != "unlock")
            {
                Console.WriteLine("Not a valid command, try again");
                Console.WriteLine();
            }
            else
                currentChestState = ChestState.Closed;
            break;

        case ChestState.Closed:
            Console.WriteLine("Type open or lock.");
            command = Console.ReadLine().ToLower();
            if (command != "open" && command != "lock")
            {
                Console.WriteLine("Not a valid command, try again");
                Console.WriteLine();
            }
            else if (command == "open")
                currentChestState = ChestState.Open;
            else
                currentChestState = ChestState.Locked;
            break;

        case ChestState.Open:
            Console.WriteLine("Type close to close");
            command = Console.ReadLine().ToLower();
            if (command != "close")
            {
                Console.WriteLine("Not a valid command, try again");
                Console.WriteLine();
            }
            else
                currentChestState = ChestState.Closed;
            break;
    }

}


enum ChestState
{
    Locked,
    Closed,
    Open
}
*/

// Level 17 Simula's Soup

(string SoupType, string Main, string Seasoning) soup = ("","","");

Type soupType = new Type();
MainIngredient mainIngredient = new MainIngredient();
Seasoning seasoning = new Seasoning();

Console.WriteLine("Choose from - Soup, Stew or Gumbo?");
string userInput = Console.ReadLine().ToLower();

switch (userInput){
    case "soup": soupType = Type.Soup; break;
    case "stew": soupType = Type.Stew; break;
    case "gumbo": soupType = Type.Gumbo; break;
}

soup.SoupType = Convert.ToString(soupType);

Console.WriteLine("Choose from - Mushroom, Chicken, Carrot or Potato?");
userInput = Console.ReadLine().ToLower();

switch (userInput){
    case "mushroom": mainIngredient = MainIngredient.Mushroom; break;
    case "chicken": mainIngredient = MainIngredient.Chicken; break;
    case "carrot": mainIngredient = MainIngredient.Carrot; break;
    case "potato": mainIngredient = MainIngredient.Potato; break;
}

soup.Main = Convert.ToString(mainIngredient);

Console.WriteLine("Choose from - Spicy, Salty or Sweet?");
userInput = Console.ReadLine().ToLower();

switch (userInput){
    case "salty": seasoning = Seasoning.Salty; break;
    case "spicy": seasoning = Seasoning.Spicy; break;
    case "sweet": seasoning = Seasoning.Sweet; break;
}

soup.Seasoning = Convert.ToString(seasoning);

Console.WriteLine(soup);

enum Type { Soup, Stew, Gumbo }
enum MainIngredient { Mushroom, Chicken, Carrot, Potato }
enum Seasoning { Spicy, Salty, Sweet }