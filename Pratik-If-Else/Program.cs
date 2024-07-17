// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen sayi giriniz: ");
string input = Console.ReadLine();
int inputİnt = Convert.ToInt32(input);


//sayı 10'dan büyük ise çift olup olmadığı hesaplanarak ekrana yazdırılıyor.
if(inputİnt > 10)
{
    Console.WriteLine("Sayınız 10'dan büyük.");
    if(inputİnt % 2 == 0){
        Console.WriteLine("sayınız çifttir.");
    }
    else
    {
        Console.WriteLine("sayiniz tektir.");
    }
}
//sayı 10'a eşit ise çift olup olmadığı hesaplanarak ekrana yazdırılıyor.
else if (inputİnt == 10)
{
    Console.WriteLine("sayınız 10 sayısına eşittir.");
    if (inputİnt % 2 == 0)
    {
        Console.WriteLine("sayınız çifttir.");
    }
    else
    {
        Console.WriteLine("sayiniz tektir.");
    }
}
//sayı 10'dan küçük ise çift olup olmadığı hesaplanarak ekrana yazdırılıyor.
else
{
    Console.WriteLine("Sayınız 10'dan küçüktür.");
    if (inputİnt % 2 == 0)
    {
        Console.WriteLine("sayınız çifttir.");
    }
    else
    {
        Console.WriteLine("sayiniz tektir.");
    }
}

