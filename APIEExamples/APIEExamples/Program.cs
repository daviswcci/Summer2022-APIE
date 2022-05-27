using APIEExamples;

// console application that acts like a media collection
List<Media> collection = new List<Media>(); // list of all media objects we own
// if we want to allow a user to look at the collection multiple times
// loops! specifically while
bool isRunning = true;
while (isRunning)
{
    Console.Clear();
    Console.WriteLine("What type of media would you like to add to the collection?");
    Console.WriteLine("1 - Game \n2 - Movie");
    Console.WriteLine("3 - Display Media");
    Console.WriteLine("4 - Classify Media");
    Console.WriteLine("5 - End Program");
    int selection = Int32.Parse(Console.ReadLine()); // take in a user's input
    switch (selection)
    {
        case 1:
            // create a game
            Console.Clear();
            Game exampleGame = new Game();
            Console.WriteLine("What is the name of your game?");
            string gameTitle = Console.ReadLine();
            exampleGame.ChangeTitle(gameTitle); // another way to write this is 'exampleGame.Title = gameTitle;'
            exampleGame.Play();
            // add it to the list
            collection.Add(exampleGame);
            break;
        case 2:
            // create a movie
            Console.Clear();
            Movie exampleMovie = new Movie();
            Console.WriteLine("What is the name of your movie?");
            string movieTitle = Console.ReadLine();
            exampleMovie.ChangeTitle(movieTitle);
            // add it to the list
            collection.Add(exampleMovie);
            break;
        case 3:
            // loop through our list
            foreach(Media media in collection)
            {
                // Title: Halo - Hours Played: 10 - Game
                // Title: Kill Bill - Movie
                // challenge 1: how do we know what is a game vs. what is a movie
                if (media.GetType() == typeof(Game)) // movie object is a game
                {
                    Game gameFromShelf = (Game)media; // type casting
                    Console.WriteLine("Title: " + gameFromShelf.Title + " - Hours Played: " + gameFromShelf.TimePlayed + " - Game");
                }
                else if (media.GetType() == typeof(Movie)) // media object is a movie
                {
                    Console.WriteLine("Title: " + media.Title + " - Movie" + media.Rating);
                }
                else
                {
                    Console.WriteLine();
                }
                
                // challenge 2: how do we access child class specific properties from a parent class
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            break;
        case 4:
            Console.WriteLine("What media would you like to classify?");
            int input = Int32.Parse(Console.ReadLine());
            Media fromCollection = collection[input];
            Console.WriteLine("What genre is this piece of media?");
            input = Int32.Parse(Console.ReadLine());
            fromCollection.ClassifyMedia(input);
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            break;
        case 5:
            isRunning = false;
            break;
    }
}

// dictionaries syntax and examples
// type name = value;
// <key, value> types
Dictionary<Movie, string> movieDirectors = new Dictionary<Movie, string>();

// variable declaration, assignment, property assignment
Movie DrStrange = new Movie();
DrStrange.Title = "Dr Strange and the Multiverse of Madness";

movieDirectors.Add(DrStrange, "Sam Raimi"); // key-value pair
Console.WriteLine(movieDirectors[DrStrange]); // accessing a value for a given key

movieDirectors[DrStrange] = "Ted Raimi"; // update the value of our KVP