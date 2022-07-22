
using Business;

namespace ConsoleApp3
{
    class Program
    {
           static void Main(String[]args)
        {
            CategoryMan km = new CategoryMan();

            foreach (var item in km.GetAll())
            {

                Console.WriteLine("ID:"+" "+item.categoryid+" "+"KATEGORİ İSMİ:"+" "+item.categoryname);

            }


        }


    }






}