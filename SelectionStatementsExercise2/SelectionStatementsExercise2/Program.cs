// Switch Statements Exercise

// couldn't figure out ToLower so did three cases for each instead

Console.WriteLine("What's your favorite school subject?");


string favSubject = Console.ReadLine().ToLower(); //got the ToLower
//working by adding (), so three cases now unnecessary

switch (favSubject)
{
    case "math":
    case "Math":
    case "MATH":
        Console.WriteLine("Your favorite subject is Math!");
        break;
    case "music":
    case "Music":
    case "MUSIC":
        Console.WriteLine("Your favorite subject is Music!");
        break;
    case "english":
    case "English":
    case "ENGLISH":
        Console.WriteLine("Your favorite subject is English!");
        break;
    case "science":
    case "Science":
    case "SCIENCE":
        Console.WriteLine("Your favorite subject is Science!");
        break;
    case "art":
    case "Art":
    case "ART":
        Console.WriteLine("Your favorite subject is Art!");
        break;
    default:
        Console.WriteLine("That's not one of the five options, " +
            "the options are: Math, English, Science, Music, or Art");
    break;
}




