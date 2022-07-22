using encamsulation_and_inheritance;

name name1 = new name();
name1.setIsim("Günay");
string gelen = name1.getIsim();

if (gelen == "Günay")
{
    Console.WriteLine("İşlem başarılı");

}

else
{
    Console.WriteLine("ERORR");
}



//inheritance

son son1=new son();
son1.name = "Günay";
son1.surname = "ŞEKERCİSOY";
Console.WriteLine(son1.name + " " + son1.surname);

Console.ReadKey();