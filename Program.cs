using System.ComponentModel;

string[] arraystart =  new string [5]{"+", "56*", "gf%hh", "sdf5", "dod"};
string[] arrayfinish = new string [arraystart.Length];
int i = 0;
void Process (string[] arraystart, string[] arrayfinish)
{
    int index = 0;

    for (i=0; i < arraystart.Length; i++)
        {
            if(arraystart[i].Length<=3)
                {
                    arrayfinish[index] = arraystart[i];
                    index++;
                };
        }
};

void PrintArray (string[] arrayfinish)
{
    for (i=0; i < arrayfinish.Length; i++)
    {
        Console.Write($"{arrayfinish[i]} ");
    }
    Console.WriteLine(); 
}

Process(arraystart, arrayfinish);

PrintArray(arrayfinish);