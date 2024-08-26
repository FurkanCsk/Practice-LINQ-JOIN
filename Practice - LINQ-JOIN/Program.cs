using Practice___LINQ_JOIN;


//Create a list of authors
var authorList = new List<Author>();

authorList.Add(new Author { AuthorID = 1, AuthorName = "Orhan Pamuk"});
authorList.Add(new Author { AuthorID = 2, AuthorName = "Elif Şafak" });
authorList.Add(new Author { AuthorID = 3, AuthorName = "Ahmet Ümit" });

// Create a list of books
var bookList = new List<Book>();

bookList.Add(new Book { BookID = 1, Title = "Kar", AuthorID = 1 });
bookList.Add(new Book { BookID = 2, Title = "İstanbul", AuthorID = 1 });
bookList.Add(new Book { BookID = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorID = 2 });
bookList.Add(new Book { BookID = 4, Title = "Beyoğlu Rapsodisi", AuthorID = 3 });

// Perform a join between author and books based on AuthorID
var booksAndAuthors = from author in authorList
                      join book in bookList on author.AuthorID equals book.AuthorID
                      select new
                      {
                          book.Title,
                          author.AuthorName,
                      };

// Print the results: book titles and author names
foreach (var book in booksAndAuthors)
{
    Console.WriteLine($"Book Title : {book.Title}\nAuthor Name: {book.AuthorName}\n");
}
