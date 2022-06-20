string[] array = new string[] { "one", "-2", "hello", "on", "second" };
string[] newarray = new string[array.Length];
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[count] = array[i];
            count++;
        } 
    }
}

SecondArray(array, newarray);


