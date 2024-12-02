using System.ComponentModel.DataAnnotations;

class Program{
    static void Main(){
        Random rand = new();
        int[] numbers = new int[1000000000];

        for(int i =0;i<numbers.Length;i++){
            numbers[i]=rand.Next(1,1000);
        }

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

        Merge(input,leftHalf,rightHalf);
    }
    static void Merge(int[] input,int[]leftHalf,int[]rightHalf){
        int leftSize = leftHalf.Length;
        int rightSize = rightHalf.Length;

        int i = 0;
        int j = 0;
        int k = 0;

        while(i<leftSize&&j<rightSize){
            if(leftHalf[i]<=rightHalf[j]){
                input[k]=leftHalf[i];
                i++;
            }else{
                input[k]=rightHalf[j];
                j++;
            }
            k++;
        }
        while (i<leftSize){
            input[k]=leftHalf[i];
            i++;
            k++;
        }
        while (j<rightSize){
            input[k]=rightHalf[j];
            j++;
            k++;
        }
    }
}