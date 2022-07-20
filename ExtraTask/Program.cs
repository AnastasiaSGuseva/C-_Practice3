// Второй максимум
// Задана последовательность натуральных чисел, завершающаяся числом 0.
// Требуется определить значение второго по величине элемента в этой 
// последовательности, то есть элемента, который будет наибольшим, если
// из последовательности удалить наибольший элемент.

Console.WriteLine("Введите число: ");
int [] array = new int [100];
int i = 0;
int number;

do
{
    number = Convert.ToInt32(Console.ReadLine());
    array[i] = number;
    i++;
}
while (number != 0);

Console.WriteLine();

int numb = 0;
int maximum = array[numb];
int maxNumb = 0;
while (numb  < 100)
{
    if (array[numb] > maximum)
    {
        maximum = array[numb];
        maxNumb = numb;
    }

    numb++;
}

int index = 0;
int secondMaximum = array[index];
if (maxNumb == 0)                          
    secondMaximum = array[1];            
while (index < 100)
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
