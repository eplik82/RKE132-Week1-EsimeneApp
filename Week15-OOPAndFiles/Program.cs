﻿
List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    //Console.WriteLine("Temp array");
    //ReadDataFromArray(tempArray);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my movies: {movie.Title} was released in {movie.Year}");
}

static string[] GetDataFromMyFile()
{
    string fileBath = @"C:\TKTK\movies.txt";
    return File.ReadAllLines(fileBath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Movie
{
    string title;
    string year;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }
    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}