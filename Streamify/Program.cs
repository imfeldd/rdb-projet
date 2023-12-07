using Streamify;
Console.WriteLine("Hello, World!");

var context = new Context();
var transaction = context.Database.BeginTransaction();

var newTitle = new Title {
    Id = "T89",
    Name = "Some Title",
    PublisherId = "P01"
};

context.Titles.Add(newTitle);
context.SaveChanges();
transaction.Commit();


foreach (var title in context.Titles.Where(t => t.Name.Length > 20)) {
    Console.WriteLine(title.Name);
}


context.Remove(newTitle);
context.SaveChanges();

