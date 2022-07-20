// Второй максимум
// Задана последовательность натуральных чисел, завершающаяся числом 0.
// Требуется определить значение второго по величине элемента в этой 
// последовательности, то есть элемента, который будет наибольшим, если
// из последовательности удалить наибольший элемент.

Console.WriteLine("Введите последовательность из не менее 2 натуральных неотрицательных чисел, завершающуюся числом 0: ");
string A = Console.ReadLine();
int N = A.Length;

int [] array = new int [N];
for ( int i = 0; i < N; i++)
{
    array [i] = A [i] - 48; // Это момент, про который я вас спрашивала. Не придумала ничего лучше, чем вычесть 48, в таком виде работает, но я не знаю почему.
}
Console.WriteLine();

int numb = 0;
int maximum = array[numb];
int maxNumb = 0;
while (numb  < N)
{
    if (array[numb] > maximum)
    {
        maximum = array[numb];
        maxNumb = numb;
    }

    numb++;
}

Console.WriteLine("Максимальное число = " + maximum);


int index = 0;
int secondMaximum = array[index];
if (maxNumb == 0)                          
    secondMaximum = array[1];            
while (index < N)
{
    if (index == maxNumb)
    {
        index++;
    }
    else
    {
        if(array[index] > secondMaximum)
        {
            secondMaximum = array[index];
        }
        index++;
    }
}

Console.WriteLine("Второе максимальное число = " + secondMaximum);

// Решение работает только для однозначных чисел, т.к. не придумала,
// как решить без массива, и как добавить многозначные числа в массив.