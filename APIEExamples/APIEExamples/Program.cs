using APIEExamples;

// Encapsulation
Game loz = new Game();
loz.Play();
Movie batman = new Movie();
batman.Play();
batman.Title = "The Batman";
loz.ChangeTitle(batman.Title);
batman.ChangeTitle("The Dark Knight Rises");