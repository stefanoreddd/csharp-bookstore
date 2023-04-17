int[] test  = { 1, 2, 3, 4, 5 };

printArrayInt(test);


void printArrayInt(int[] array)
{

    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");

}
