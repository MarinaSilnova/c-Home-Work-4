// 

int max = 0;
int[] n = new int[8];
for (int i = 0; i < n.Length; i++)
{
    n[i] = new Random().Next(1, 1001);
    for (int j = 2; j <= i; j++)
{
    if ((n[j] + n[j - 1] + n[j - 2]) > max)
        max = n[j] + n[j - 1] + n[j - 2];
}   
}
Console.WriteLine ( "[" + string.Join(", ", n) + "]");
Console.WriteLine(max);



