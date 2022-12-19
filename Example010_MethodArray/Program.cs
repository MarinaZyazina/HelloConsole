// Имеется одномерный массив array из n элементов
// Найдём элемент массива, совпадающий с некоторым значением, 
// который определяет пользователь (find).

int[] array = {1,12,31,4,18,15,16,17,18};

int n = array.Length;
int find = 18;

int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // прерывается, ищем только индекс первого элемента
    }
    //index = index + 1
    index++;
}

