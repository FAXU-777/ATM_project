public static void Main(string[] args)
    {
        

        
        string[] books = {
            "The Hobbit," ,
            "1984,",
            "To Kill a Mockingbird,",
            "The Great Gatsby,",
            "Harry Potter and the Sorcerer's Stone,"
        };


        while (true)
        {
            Console.WriteLine("Library Menu");
            Console.WriteLine("1. View all books");
            Console.WriteLine("2. Search book by title");
            Console.WriteLine("3. Exit");
            Console.Write("Option: ");
            

            int num = Convert.ToInt32(Console.ReadLine());
         



            switch (num)
            {
                case 1:
                    Console.WriteLine("Library books: ");
                    Console.WriteLine(string.Join(" ", books));
                    Console.Write("If you want to go back enter 1: ");
                    
                    int goBack = Convert.ToInt32(Console.ReadLine());
                    
                    switch (goBack)
                    {
                        case 1: break;
                        default: Console.WriteLine("Please enter 1 if you want to go back");
                            break;

                    }
                    break;
                
                
                case 2:
                    Console.WriteLine("Enter book title to search: ");
                    string bookName = Console.ReadLine();
                    
                    Console.WriteLine(SearchByBookName(books, bookName));
                    
                    Console.WriteLine("Do you want to take it? yes/no");
                    
                    string option = Console.ReadLine();
                    
                    switch (option)
                    {
                        case "yes" :
                            break;
                        case "no" : break;
                        default: Console.WriteLine("Plese enter yes or no");
                            break;
                    }
                    break;
                
                
                case 3: return;
                default:
                    Console.WriteLine("Please enter number between 1-3");
                    break;

            }
        }




    }

    public static string SearchByBookName(string[] books, string bookName)
    {
        for (int i = 0; i < books.Length; i++)
        {
            
            if (books[i] == bookName)
            {
                Console.Write("Here is your book: ");

                return books[i];
            }
        }

        return "Book not found";
    }

    public static void NewBooks(string[] books ,string bookName)
    {
        string[] newBooksArr;
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == bookName){
                
            }
        }
        
    }
