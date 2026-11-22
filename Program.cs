namespace Assignment_3
{
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //  1-Declare string title = "clean code";. Call title. ToUpper() and store it in a new variable upperTitle. Print both title and upper Title to show that title did not change.

            //string title = "clea code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion

            #region Question 2
            // 2-Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.

            //string book1 = "Clean Code";
            //string book2 = "Clean Code";
            //Console.WriteLine(object.ReferenceEquals(book1, book2));

            #endregion

            #region Question 3
            // 3 Create a StringBuilder, Append() the text "Book List", then Append()" - Updated" onto the same object. Print the final result.


            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" -Updated");
            //Console.WriteLine(sb);


            #endregion

            #region Question 4

            // 4-Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.

            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb);
            #endregion

            #region Question 5
            // 5- Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator.
            //string title = "Clean Code";
            //int pages = 464;
            //string result = "Book: " + title + ",pages: " + pages;
            //Console.WriteLine(result);
            #endregion

            #region Question 6
            // 6- Build the same sentence as above, but using string interpolation (S"...").

            //string title1 = "Clean Code";
            //int pages = 464;
            //string result = $"Book:  + {title1} + ,pages:  + { pages}";
            //Console.WriteLine(result);

            #endregion

            #region Question 7
            // 7-Build the same sentence again, but using string.Format().
            //string title = "Clean Code";
            //int pages = 464;
            //string result = string.Format("Book: {0},pages: {}", title, pages);
            //Console.WriteLine(result);

            #endregion

            #region Question 8
            // 8- Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".

            //int pages = 464;
            //if 
            //    (pages>300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}
            #endregion

            #region Question 9

            // 9-Given int pages 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and is Available is true. Use the && operator.
            //int pages = 464;
            //bool isAvailable = true;
            //if
            //    (pages > 300 && isAvailable == true)
            //{
            //    Console.WriteLine("you can borrow this book");
            //}
            #endregion

            #region Question 10

            // 10-Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

            ////string title = "Refactoring";
            ////switch
            ////    (title)
            ////{
            ////    case "Clean Code":
            ////        Console.WriteLine("Great choice");
            ////        break;

            ////            case "Refctiring":
            ////        Console.WriteLine("Nice pick!");
            ////        break;

            ////    default:
            ////        Console.WriteLine("Never heard ofb it");
            ////        break;


            //}
            #endregion

            #region Question 11
            // 11- Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel (same rule as question 8: long if pages > 300).
            //int pages = 464;
            //string sizelabel = pages > 300 ? "Long Book":"Short Book";
            //Console.WriteLine(sizelabel);

            #endregion

            #region Question 12
            // 12-Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring");, use a for loop to print each book with its position number, like 1. Clean Code.

            string[] books =
            {
                "Clean Code",
                "The Proagmatic Programmer",
                "Refactoring"
            };
            for
                (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine((i + 1)+". " + books[i]);
                
            }
            #endregion

        }
    }
}
