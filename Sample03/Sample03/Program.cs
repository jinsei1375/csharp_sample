// See https://aka.ms/new-console-template for more information
int a;
double b, c, d;

a = (int) 1.23;
b = 1.23;
c = 10.0;
d = (double)c;
Console.WriteLine("a={0}, b={1}, c={2}, d={3}", a, b, c, d);

string str1, str2;
Console.Write("str1");
str1 = Console.ReadLine();
Console.Write("str2");
str2 = Console.ReadLine();
Console.WriteLine("str1={0}, str2={1}", str1, str2);

const int NUMBER = 123;
const string str = "ABC";
Console.WriteLine("number={0}, str={1}", NUMBER, str);
//NUMBER = 100;


