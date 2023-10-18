int n = 5;
int m = 7;
int[,] matrix = new int[n, m];
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    { 
        matrix[i, j] = rand.Next(-5, 5);
        Console.Write($"{matrix[i, j],2} ");
    }
    Console.WriteLine();
}

Console.WriteLine("======");


int getFeature(int[,] matrix, int column)
{
    int sum = 0;
    for(int i = 0; i < n; i+=2) 
    {
        sum += matrix[i, column];
    }
    return sum;
}

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < m - 1; j++)
    {
        int f1 = getFeature(matrix, j);
        int f2 = getFeature(matrix, j + 1);
        if(f1 > f2)
        {
            for(int k = 0; k < n; k++)
            {
                int c = matrix[k, j];
                matrix[k, j] = matrix[k, j + 1];
                matrix[k, j + 1] = c;
            }
        }
    }
}


for (int i = 0; i < n; ++i)
{
    for (int j = 0; j < m; ++j)
    {
        Console.Write($"{matrix[i, j],2} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Характеристики:");
for (int i = 0; i < m; i++)
{
    Console.Write($"{getFeature(matrix, i), 2} ");
}
Console.WriteLine();
int sumNegCols = 0;
for (int j = 0; j < m; j++)
{
    int colSum = 0;
    bool hasNegative = false;
    for (int i = 0; i < n; i++)
    {
        if (matrix[i, j] < 0)
        {
            hasNegative = true;
        }
        colSum += matrix[i, j];
    }
    if(hasNegative)
    {
        sumNegCols += colSum;
    }
}

Console.WriteLine("Сумма столбцов с отрицательными элементами: " + sumNegCols);