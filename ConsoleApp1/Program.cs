// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

List<Movies> movies = new List<Movies>()
{
    new Movies(){Id=1,Title="welcome",genere="comedy",rating=8.3},
    new Movies(){Id=2,Title="HeraPheri",genere="comedy",rating=8.3},
    new Movies(){Id=3,Title="Fukrey",genere="comedy",rating=8.3},

};
Console.WriteLine("name \t genere \t rating");
foreach (Movies movie in movies)
{
    Console.Write(movie.Title + "\t");
    Console.Write(movie.genere + "\t");
    Console.Write(movie.rating + "\t");
    Console.Write("\n");
}
Console.WriteLine("enter movie title to search ");
string name = Console.ReadLine();
Movies findmovie = GetMovieByName(movies, name);

if (findmovie != null)
{
    Console.WriteLine("movie found ");
}
else
{
    Console.WriteLine("not found");
}
static Movies GetMovieByName(List<Movies> movieList, string targetName)
{
    return movieList.FirstOrDefault(movie => movie.Title.Equals(targetName, StringComparison.OrdinalIgnoreCase));
}

