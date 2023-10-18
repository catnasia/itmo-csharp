
float[] array = new float[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{

    array[i] = rand.NextSingle() * 20 * 1 - 10;
    Console.WriteLine(array[i]);
}

int a = 0;
int min_index = 0;
while (a < array.Length)
{
    if (array[a] < array[min_index])
    {
        min_index = a;
    }
    a++;
}
Console.WriteLine("Индекс минимального элемента = " + min_index);

int b = 0;
while (b < array.Length)
{
    if (array[b] < 0)
    {
        break;
    }
    b++;
}
int c = b + 1;
while (c < array.Length)
{
    if (array[c] < 0)
    {
        break;
    }
    c++;
}
float d = 0;
for (int i = b + 1; i < c; i++)
{
    d = d + array[i];
}
Console.WriteLine("Сумма от первого отрицательного до второго отрицательного (не включительно) = " + d);


int less_than_one = 0;
int more_than_one = array.Length - 1;
while (less_than_one < more_than_one)
{
    if (Math.Abs(array[less_than_one]) > 1)
    {
        float t = array[less_than_one];
        array[less_than_one] = array[more_than_one];
        array[more_than_one] = t;
        more_than_one--;
    }
    else
    {
        less_than_one++;
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}