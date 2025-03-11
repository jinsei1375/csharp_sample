// See https://aka.ms/new-console-template for more information


int[] d = { 2, 4, 8 };
double sum, avg;
sum = 0;
for (int i = 0; i < d.Length; i++)
{
  Console.Write("{0} ", d[i]);
  sum += d[i];
}
Console.WriteLine();
avg = sum / d.Length;
Console.WriteLine("sum={0}, avg={1}", sum, avg);

foreach (int n in d)
{
  Console.Write("{0} ", n);
}