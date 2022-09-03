int GenerateRandomNumbers()
{
    int n = new Random().Next(1, 101);
    return n;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int i = 0;
    while(i < length)
    {
        collection[i] = new Random().Next(1, 101);
        i++;
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int i = 0;
    while(i < length)
    {
        Console.Write(collection[i] +" ");
        i++;
    }
}

void Max(int[] collection)
{
    int length = collection.Length;
    int max1 = collection[0];
    int max2 = collection[0];
    if(collection [1] > max1)
    {max1 = collection[1];}
    else
    {max2 = collection[1];}
    int i = 2;
    while(i < length)
    {
        if(collection[i] > max1)
        {
            max2 = max1;
            max1 = collection[i];
        }
        else if (collection[i] > max2 && collection[i] != max1)
        {
            max2 = collection[i];            
        }
        i++;

    }
    Console.WriteLine("max2: " + max2);
    
        
    
    
    

}

int n = GenerateRandomNumbers();
int[] array = new int[n];
FillArray(array);
PrintArray(array);
Max(array);
