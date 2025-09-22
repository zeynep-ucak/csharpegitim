//1 ile 20 arasındaki çift sayıların toplamı

/* int totalValue=0;
for(int i=1 ; i<20 ; i++){
    if(i%2==0){
       totalValue+=i; 
       Console.WriteLine(i);
    }
}
Console.WriteLine("-----");
Console.WriteLine(totalValue); */

//1 ile 50 arasında 7ye tam bölünen kaç sayı var

/* int count=0;
for(int i=1;i<=50;i++){
    if(i%7==0){
        count++;
    }
}
Console.WriteLine(count);
Console.Read(); */

//her saat 2 ile çarpılarak çoğalan bakteri ortamında 24 saat sonunda kaç bakteri olur
/* int bacterium=1;
for(int i=1 ; i<=24 ; i++)
{
    bacterium*=2;
    Console.WriteLine(i + ". saat sonunda:" +bacterium);
}
*/
//while döngüsü şart sağlandıkça anlamı taşır.

//klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
Console.Write("sayiyi giriniz:");
int number=int.Parse(Console.ReadLine());
int ones , tens , hundreds;
int sum;

ones= number % 10;
tens= (number % 100) / 10;
hundreds = number / 100;

Console.WriteLine(ones + "-" +tens + "-" + hundreds);
sum=ones+tens+hundreds;
Console.WriteLine(sum);
