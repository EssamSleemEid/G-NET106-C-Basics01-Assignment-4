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

            #region Question6
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to see, and why?

            //static void ApplyDiscount(double[] prices)
            //{
            //    prices[0] = prices[0] - 5;
            //}
            //double[] prices = { 25.5, 40.0 };

            //ApplyDiscount(prices);

            //Console.WriteLine("prices : "+ prices[0]);  //here its work bc the array reference to the method and not copy like the Q5
            #endregion

            #region Question7
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5?

            //static void AddBonusPages(ref int pages)
            //{
            //    pages = pages + 50;
            //}
            //int pages = 400;
            //AddBonusPages(ref pages);
            //Console.WriteLine("pages : " + pages);    //bc we use reference here we take the same value from the variable and changed it
            #endregion

            #region Question8
            //Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length afterward.

            //static void ReplaceArray(ref double[] prices)
            //{
            //    prices = new double[]{10.0, 12.5, 15.0};
            //}
            //double[] prices = { 14.9, 20.1, 7.67 ,77.7};
            //ReplaceArray(ref prices);
            //Console.WriteLine("prices : "+ prices.Length);
            #endregion

            #region Question9
            //Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call it and print the price if found  

            //static bool TryGetPrice(string title,out double price)
            //{
            //    if (title == "Clean Code")
            //    {
            //        price = 25.5;
            //        return true;
            //    }
            //    price = 0;
            //    return false;
            //}
            //double price;
            //if(TryGetPrice("Clean Code",out price)){
            //    Console.WriteLine("price :" + price);
            //}
            #endregion
        }
    }
}
