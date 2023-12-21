using System.Security.Principal;
using Microsoft.EntityFrameworkCore;
using Streamify;
Console.WriteLine("SALU MOND!");

var context = new Context();

//selectionne le film ayant le title id '4'
var title = context.Titles
    .Include(title => title.Genres)
    .Include(title => title.Credits)
    .ThenInclude(cred => cred.Person)
    .First(x => x.TitleId == 4);
Console.WriteLine(title.TitleName);
Console.WriteLine(title.Credits[0].Person.Name);


var res = from e1 in context.Titles
    join e2 in context.Titles
    on e1.TitleId equals e2.TitleId
    select new {
                title_id = e1.TitleId,
                title_name = e1.TitleName,
                good_ratings_n = e2.Ratings.Count
            }; 


var resSorted = res.OrderByDescending(x => x.good_ratings_n);
Console.WriteLine("Meilleurs films de la plateforme:");
Console.WriteLine($"{resSorted.First().title_name}");



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


var transaction = context.Database.BeginTransaction();

var newUser = new User {
    UserId = new Random().Next(99999),
    Name = "John Doe",
    Email = "jdoe@hevs.ch"
};

context.Users.Add(newUser);
context.SaveChanges();

transaction.Commit();


//context.Remove(newUser);
context.SaveChanges();

