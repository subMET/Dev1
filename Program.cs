void FillRandom(int[] Arr_V1) // Заполняет массив случайными числами от 10 до 99.
{
    int L1 = Arr_V1.Length;
    for (int j1 = 0; j1 < L1;)
    {
        Arr_V1[j1] = new Random().Next(10, 100);
        ++j1;
    }
}

void PrintArray(int[] Arr_V2) // Печатает массив в терминале.
{
    int L2 = Arr_V2.Length;
    for (int j2 = 0; j2 < L2;)
    {
        Console.Write(Arr_V2[j2] + " ");
        ++j2;
    }
}

void AlwaysBiggerCut(int[] Arr_V3) // Занулят остаток массива после того как встретит первое число, которое нарушит порядок возрастания.
{
    int L3 = Arr_V3.Length;
    int max3 = Arr_V3[0];
    bool flag3 = false;
    for (int j3 = 1; j3 < L3;)
    {
        if (flag3 == false)
        {
            if (max3 < Arr_V3[j3])
            {
                max3 = Arr_V3[j3];
            }
            else
            {
                flag3 = true;
                Arr_V3[j3] = 0;
            }
        }
        else
        {
            Arr_V3[j3] = 0;
        }
        ++j3;
    }
}

void AlwaysBigger(int[] Arr_V4) // Зануляет все элементы, которые нарушают порядок возрастания.
{
    int L4 = Arr_V4.Length;
    int max4 = Arr_V4[0];
    for (int j4 = 1; j4 < L4;)
    {
        if (Arr_V4[j4] > max4)
        {
            max4 = Arr_V4[j4];
        }
        else
        {
            Arr_V4[j4] = 0;
        }
        ++j4;
    }
}

void CopyArray(int[] Arr_V5_1, int[] Arr_V5_2) // Копирует заполненный массив Arr_V5_1 в пустой массив той же длинны Arr_V5_2
{
    int L5 = Arr_V5_1.Length;
    for (int j5 = 0; j5 < L5;)
    {
        Arr_V5_2[j5] = Arr_V5_1[j5];
        ++j5;
    }
}

int[] CutTheZero(int[] Arr_V6_1) // Создаёт массив на основе Arr_V6, где элементы равные 0 удалены.
{
    int L6_1 = Arr_V6_1.Length;
    int L6_2 = 0;
    for (int j6_1 = 0; j6_1 < L6_1;)
    {
        if (Arr_V6_1[j6_1] > 0)
        {
            ++L6_2;
        }
        ++j6_1;
    }
    int[] Arr_V6_2 = new int[L6_2];
    int j6_3 = 0;
    for (int j6_2 = 0; j6_2 < L6_1;)
    {
        if (Arr_V6_1[j6_2] > 0)
        {
            Arr_V6_2[j6_3]=Arr_V6_1[j6_2];
            ++j6_3;
        }
        ++j6_2;
    }
    return Arr_V6_2;
}

int ArithMeanSearch(int[] Arr_V7) // Поиск среднего арифметического, округлённого в меньшую сторону.
{
    double Avg = 0;
    int L7 = Arr_V7.Length;
    for (int j7 = 0; j7 < L7;)
    {
        Avg = Avg + Convert.ToDouble(Arr_V7[j7]);
        ++j7;
    }
    Avg = Avg/Convert.ToDouble(L7);
    Avg = Math.Floor(Avg);
    return Convert.ToInt32(Avg);
}

void CutAboveNumber(int[] Arr_V8, int Num_8) // Зануляет все элементы массива, которые больше числа Num_8
{
    int L8 = Arr_V8.Length;
    for (int j8 = 0; j8 < L8;)
    {
        if (Arr_V8[j8] > Num_8)
        {
            Arr_V8[j8] = 0;
        }
        ++j8;
    }
}

void DeleteEven(int[] Arr_V9) //Зануляет все чётные числа в массиве.
{
    int L9 = Arr_V9.Length;
    for (int j9 = 0; j9 < L9;)
    {
        if (Arr_V9[j9]%2 == 0)
        {
            Arr_V9[j9] = 0;
        }
        ++j9;
    }
}

Console.WriteLine("Задайте длину массива.");
int N = Convert.ToInt32(Console.ReadLine());
int[] Arr_A = new int[N];
int[] Arr_B1 = new int[N];
int[] Arr_B2 = new int[N];
int[] Arr_B3 = new int[N];

FillRandom(Arr_A);
CopyArray(Arr_A, Arr_B1);
CopyArray(Arr_A, Arr_B2);
CopyArray(Arr_A, Arr_B3);
int Avarage = ArithMeanSearch(Arr_A);

Console.Write("Изначальный массив: ");
PrintArray(Arr_A);

AlwaysBigger(Arr_B1);
Arr_B1 = CutTheZero(Arr_B1);
Console.WriteLine(" ");
Console.Write("Возрастающий массив: ");
PrintArray(Arr_B1);

CutAboveNumber(Arr_B2, Avarage);
Arr_B2 = CutTheZero(Arr_B2);
Console.WriteLine(" ");
Console.Write("Среднее арифметическое изначального массива: ");
Console.Write(Avarage);
Console.WriteLine(" ");
Console.Write("Массив, где все числа больше среднего арифметического удалены: ");
PrintArray(Arr_B2);

DeleteEven(Arr_B3);
Arr_B3 = CutTheZero(Arr_B3);
Console.WriteLine(" ");
Console.Write("Массив с удалёнными чётными числами: ");
PrintArray(Arr_B3);