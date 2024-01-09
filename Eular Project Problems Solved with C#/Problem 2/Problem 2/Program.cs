int x =0,y = 0,z = 0;
for (int i = 1;i<4000000;)
{
    z = x;
    x = i;
    x -= z;
    if (i % 2 == 0)
        y += i;
    i = x + i;

}
Console.WriteLine("Problem Solved Answer = " + y);
Console.ReadLine();
