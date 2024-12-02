using System.ComponentModel.DataAnnotations;

class Program{
    static void Main(){
        Random rand = new();
        int[] numbers = new int[10];

        for(int i =0;i<numbers.Length;i++){
            numbers[i]=rand.Next(1,1000);
        }

        Console.WriteLine($"Before: {string.Join(", ",numbers)}");
        Console.WriteLine();
        MergeSort(numbers);
        Console.WriteLine($"After: {string.Join(", ",numbers)}");
    }
    static void MergeSort(int[] input){
        int n = input.Length;

        if(n<2){
            return;
        }

        int midI = n/2;
        int[] leftHalf = new int[midI];
        int[] rightHalf = new int[n-midI];
        for(int i =0;i<midI;i++){
            leftHalf[i]=input[i];
        }
        for(int i = midI;i<n;i++){
            rightHalf[i-midI]=input[i];
        }
        MergeSort(leftHalf);
        MergeSort(rightHalf);
    }
    static void Merge(int[] input,int[]leftHalf,int[]rightHalf){

    }
}