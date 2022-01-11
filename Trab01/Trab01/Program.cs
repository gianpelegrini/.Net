using System;
//Douglas Willian CB3005348
//João Vitor Gino CB3005488
namespace Trab01
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new FakeBookRepository();

            ImprimeLista(_repo.ToRead);
            ImprimeLista(_repo.Reading);
            ImprimeLista(_repo.Read);

            //Author[] author1 = new Author[1];
            //author1[0] = new Author("nome", "email", 'M');
            //Book book1 = new Book("nome", author1, 25.00, 10);

            //Console.WriteLine(book1.ToString());




            Console.ReadKey();
        }

        static void ImprimeLista(BookList lista)
        {
            Console.WriteLine(lista);
        }
    }
}
