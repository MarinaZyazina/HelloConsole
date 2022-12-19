// Mетод, отличный от void, на базе Example011.
// Он будет возвращать позицию, то есть index. 
// Назовём этот метод IndexOf, 
// а в качестве аргумента будет приходить массив collection 
// и какой-то элемент find.

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index] == find)
    {
            position = index;
            break; // оператор позволяет получать 1 вхождение
        }
        index++;
    }
    return position;
}

    int[] array = new int[10];

    FillArray(array);
    array[4] = 4; //принудительно добавим пару 4 (на 4 и 6 позиции)
    array[6] = 4;
    PrintArray(array);
    Console.WriteLine();

    int pos = IndexOf(array, 4);
    Console.WriteLine(pos);