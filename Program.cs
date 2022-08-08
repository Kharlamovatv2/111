using System;
using static System.Console;

Clear();

string [] array = {"hello", "2", "world", ":-)"};
Print (array);
newArray(array);

void newArray (string [] array)
{
     string[] newarr = new string[array.Length];
     for (int i=0; i<array.Length; i++)
     {      
        if(array[i].Length<=3)
        {
        newarr[i]=array[i];;
        Write($"{newarr[i]} "); 
        }
     }
        WriteLine(); 
}
void Print(string [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}