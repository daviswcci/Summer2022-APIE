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
    }
}