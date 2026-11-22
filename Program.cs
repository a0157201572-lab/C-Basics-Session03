namespace Assignment_3
{
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //  1-Declare string title = "clean code";. Call title. ToUpper() and store it in a new variable upperTitle. Print both title and upper Title to show that title did not change.

            string title = "clea code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            #endregion

            #region Question 2
            // 2-Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.

            string book1 = "Clean Code";
            string book2 = "Clean Code";
            Console.WriteLine(object.ReferenceEquals(book1, book2));

            #endregion

            #region Question 3
            // 3 Create a StringBuilder, Append() the text "Book List", then Append()" - Updated" onto the same object. Print the final result.


            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" -Updated");
            Console.WriteLine(sb);


            #endregion

            #region Question 4

            // 4-Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.

            sb.Replace("Book List", "Library");
            Console.WriteLine(sb);
            #endregion

            #region Question 5
            // 5- Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator.
            //string title1 = "Clean Code";
            //int pages = 464;
            //string result = "Book: " + title1 + ",pages: " + pages;
            //Console.WriteLine(result);
            #endregion

            #region Question 6
            // 6- Build the same sentence as above, but using string interpolation (S"...").

            string title1 = "Clean Code";
            int pages = 464;
            string result = $"Book:  + {title1} + ,pages:  + { pages}";
            Console.WriteLine(result);

            #endregion



        }
    }
}
