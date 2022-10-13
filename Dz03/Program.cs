Console.Clear();


int [] arr;
arr = new int[8];

for(int i = 0; i < arr.Length; i++)
{
    int num = new Random().Next(1,9);
    arr[i] = num;
}    
    
    Console.WriteLine("[{0}]", string.Join(", ", arr));




