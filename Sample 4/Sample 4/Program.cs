using System;

namespace Sample_4
{
    public class PhotoBook
    {
        protected int numPages;
        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int n)
        {
            numPages = n;
        }
        public int GetNumberofPages()
        {
            return numPages;
        }
    }
    public class BigPhotoBook:PhotoBook
    {
        public BigPhotoBook()
        {
            numPages = 64;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PhotoBook photobook = new PhotoBook();
            Console.WriteLine("The photo book has "+photobook.GetNumberofPages() + " number of pages");
            Console.WriteLine("Enter the number of pages that your photo book should have");
            int n = Convert.ToInt32(Console.ReadLine());
            PhotoBook photobook2 = new PhotoBook(n);
            Console.WriteLine("The photo book has " + photobook2.GetNumberofPages() + " number of pages");
            PhotoBook bigphotobook = new PhotoBook();
            Console.WriteLine("The photo book has " + bigphotobook.GetNumberofPages() + " number of pages");
            Console.ReadLine();
        }
    }
}
