namespace third_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price (index 1). 

            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine("the second pricr is :" + prices[1]);
            #endregion

            #region Question2
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0

            //int[,] shelfCopies = { { 3 , 5 } , { 1 , 4 } };

            //Console.WriteLine("shelf 1 slot 0 : " + shelfCopies[1,0]);
            #endregion

            #region Question3
            //Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!". Call it from Main. 

            //static void PrintWelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to the Library");
            //}
            //PrintWelcomeMessage();
            #endregion

            #region Question4
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".

            //static void PrintBookTitle(string title)
            //{
            //    Console.WriteLine("book title : " + title);
            //}
            //PrintBookTitle("clean code");
            #endregion

            #region Question5
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?

            //static void AddBonusPages(int pages)
            //{
            //    pages =pages+50;
            //}
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine("pages : " + pages);  //nothing change here bc change in the virable of the method does not change anything in the value of the virable outside the method
          
            #endregion
        }
    }
}
