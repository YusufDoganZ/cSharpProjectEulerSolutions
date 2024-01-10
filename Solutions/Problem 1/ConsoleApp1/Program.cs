int x = 0;

for (int i = 1;i<1000;i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        x += i;
    }
    else
        continue;
}
Console.WriteLine("Problem Solved Answer = "+x);
Console.ReadLine();