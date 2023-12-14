using Microsoft.EntityFrameworkCore;
using Streamify;
Console.WriteLine("SALU MOND!");

var context = new Context();

var title = context.Titles.
    Include(title => title.Genres).
    First(x => x.TitleId == 1);
Console.WriteLine(title.TitleName);

foreach (var genre in title.Genres) {
    Console.WriteLine(genre.Name);
}

foreach (var _title in context.Titles.Include(x => x.Credits).ThenInclude(x => x.Person)) {
    foreach (var credit in _title.Credits) {
        Console.WriteLine(credit.Person.Name, credit.Title);
    }
}



var transaction = context.Database.BeginTransaction();

/*var newTitle = new Title {
    Id = "T89",
    Name = "Some Title",
    PublisherId = "P01"
};*/

//context.Titles.Add(newTitle);
//context.SaveChanges();
//transaction.Commit();


/*
foreach (var title in context.Titles.Where(t => t.Name.Length > 20)) {
    Console.WriteLine(title.Name);
}


context.Remove(newTitle);
*/
context.SaveChanges();

