using System.Security.Principal;
using Microsoft.EntityFrameworkCore;
using Streamify;
Console.WriteLine("SALU MOND!");

var context = new Context();

//selectionne le film ayant le title id '4'
var title = context.Titles.
    Include(title => title.Genres).
    Include(title => title.Credits).
    ThenInclude(cred => cred.Person).
    First(x => x.TitleId == 4);
Console.WriteLine(title.TitleName);




List<Title> titleList = new List<Title>{};
List<Rating> ratingList = new List<Rating>{};
var test = context.Titles;
var test2 = context.Ratings;
foreach (var i in test){
    titleList.Add(i);
}
foreach (var i in test2){
    ratingList.Add(i);
}

var res = from e1 in test 
    join e2 in test 
        on e1.TitleId equals e2.TitleId 
            select new 
            { 
                title_id = e1.TitleId,
                title_name = e1.TitleName,
                good_ratings_n = e2.Ratings.Count
            }; 


res = res.OrderByDescending(x => x.good_ratings_n);
var resList = res.ToList();
Console.WriteLine("Meilleurs films de la plateforme:");
Console.WriteLine($"{resList[0].title_name}");





//liste les genres du film
Console.WriteLine("Genres du film:");
foreach (var genre in title.Genres) {
    Console.WriteLine(genre.Name);
}

//liste les acteurs
Console.WriteLine("\nListe du staff:");
foreach (var credit in title.Credits) {
    Console.WriteLine($"{credit.PersonId}: \nNom : {credit.Person.Name}\nJob : {credit.Role}\nNoms de personnages : {credit.CharacterName}\n");
}

//recommandation
Console.WriteLine("\nFilms les plus appréciés:");

Dictionary<int, int> openWith = new Dictionary<int, int>();



var transaction = context.Database.BeginTransaction();

/*var newTitle = new Title {
    Id = "T89",
    Name = "Some Title",
    PublisherId = "P01"
};*/

//context.Titles.Add(newTitle);
//context.SaveChanges();
//transaction.Commit();





//context.Remove(newTitle);
context.SaveChanges();

