/*
Console.Write("lütfen sayiyi giriniz:");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.Write("sayi çifttir.");
}
else
{
    Console.Write("sayi tektir.");
}
*/

/*
char team;
Console.Write("lütfen takim sembolünü giriniz.");
team = char.Parse(Console.ReadLine());

if (team == 'g' | team == 'G')
{
    Console.Write("Galatasaray");
}

if (team == 'f' | team == 'F')
{
    Console.Write("Fenerbahçe");
}

if (team == 'b' | team == 'B')
{
    Console.Write("Beşiktaş");
}
*/

//switch case hesap makinesi

int number1 , number2 , result;
char symbol;

Console.Write("1. sayiyi giriniz:");
number1=int.Parse(Console.ReadLine());

Console.Write("2. sayiyi giriniz:");
number2=int.Parse(Console.ReadLine());

Console.Write("yapmak istediğiniz islemi giriniz:");
symbol=char.Parse(Console.ReadLine());

switch(symbol)
{
    case '+':
      result=number1+number2;
      Console.WriteLine("toplam: " + result);
      break;
    case '-':
      result=number1-number2;
      Console.WriteLine("fark: " + result);
      break;
    case '*':
      result=number1*number2;
      Console.WriteLine("carpim: " + result);
      break;
    case '/':
      result=number1/number2;
      Console.WriteLine("bolum: " + result);
      break;   
}


