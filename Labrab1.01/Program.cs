
float[] array = new float[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{

    array[i] = rand.NextSingle() * 20 * 1 - 10;
    Console.WriteLine(array[i]);
}

int a = 0;
int minIndex = 0;
while (a < array.Length)
{
    if (array[a] < array[minIndex])
    {
        minIndex = a;
    }
    a++;
}
Console.WriteLine("Индекс минимального элемента = " + minIndex);

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


int lessThanOne = 0;
int moreThanOne = array.Length - 1;
while (lessThanOne < moreThanOne)
{
    if (Math.Abs(array[lessThanOne]) > 1)
    {
        float t = array[lessThanOne];
        array[lessThanOne] = array[moreThanOne];
        array[moreThanOne] = t;
        moreThanOne--;
    }
    else
    {
        lessThanOne++;
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}