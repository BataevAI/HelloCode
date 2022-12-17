
void FillArray (int []  collection) {

    int length = collection.Length; 
    int index = 0;

    while(index < length) 
    {

        collection[index] = new Random().Next(1, 10);    

        index ++;

    }


}

void PrintArray (int [] col)
{

    for (int i = 0; i < col.Length; i++) 
    {    
        Console.Write(col[i]);
        Console.Write(" ");

    }

}

int IndexOf (int []  collection1, int find) 
{

        int count = collection1.Length;              
        int index = 0;
        int position = 0;

            while(index < count) 
            {

                if (  collection1[index] == find ) {

                position = index;
                break;

                    }   

                    //else   Console.WriteLine("нет совпадений");
                    index++;

            }
            
return position;

}

int [] array = new int[10];
 
FillArray(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine(IndexOf(array, 4));

//int pos = IndexOf(array, 4);

//Console.WriteLine(pos);


