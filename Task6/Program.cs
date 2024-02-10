using Task6;
try
{
    var book = new Book();
    var library = new Library();
    while (true)
    {
        System.Console.WriteLine("For adding : print add ");
        System.Console.WriteLine("For showing : print show ");
        System.Console.WriteLine("For updating : print update ");
        System.Console.WriteLine("For deleting : print delete ");
        System.Console.WriteLine("For searching : by title print searchByTitle ");
        System.Console.WriteLine("For searching by : author print searchByAuthor ");
        System.Console.WriteLine("For exisiting : print exit ");
        string command = System.Console.ReadLine();

        if (command == "add")
        {
            System.Console.Write("Your ID :");
            book.Id = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Your title : ");
            book.Title = System.Console.ReadLine();
            System.Console.Write("Your author : ");
            book.Author = System.Console.ReadLine();
            library.AddBook(book);
        }
        else if (command == "show")
        {
            foreach (var i in library.DisplayBooks())
            {
                System.Console.WriteLine(i.Id);
                System.Console.WriteLine(i.Title);
                System.Console.WriteLine(i.Author);
            }
        }
        else if (command == "update")
        {
            System.Console.Write("Your updating ID :");
            book.Id = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Your updating title : ");
            book.Title = System.Console.ReadLine();
            System.Console.Write("Ypur updating author : ");
            book.Author = System.Console.ReadLine();
            library.UpdateBook(book);
        }
        else if (command == "delete")
        {
            System.Console.Write("Your id : ");
            int id = Convert.ToInt32(System.Console.ReadLine());
            library.DeleteBook(id);
        }
        else if (command == "searchByTitle")
        {
            System.Console.Write("Your title : ");
            Book search = library.SearchByTitle(System.Console.ReadLine());
            System.Console.WriteLine(search.Id);
            Console.WriteLine(search.Title);
            System.Console.WriteLine(search.Author);
        }
        else if (command == "searchByAuthor")
        {
            System.Console.WriteLine("Your author : ");
            Book searching = library.SearchByAuthor(System.Console.ReadLine());
            System.Console.WriteLine(searching.Id);
            Console.WriteLine(searching.Title);
            System.Console.WriteLine(searching.Author);
        }
        else if(command == "exit")
        {
            break;
        }

    }
}
catch (System.Exception)
{
    System.Console.WriteLine("Xato kadesti");
}





