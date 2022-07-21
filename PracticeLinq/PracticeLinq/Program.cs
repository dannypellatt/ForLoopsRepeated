var myFavoriteGames = new List<string>() { "Return OF The Obra Dinn", "The Outer Wilds", "The Witcher 3: Wild Hunt", "Super Mario Odyssey", "Fallout New Vegas", "What Remains Of Edith Finch", "Red Dead Redemption 2", "Spider-Man", "Prince Of Persia: The Sands Of Time" };


var LengthOfGameName = myFavoriteGames.OrderByDescending(x => x.Length).ToList();

foreach (var game in LengthOfGameName)
{
    Console.WriteLine(game);
}