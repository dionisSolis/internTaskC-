using System;
namespace InternTaskCSharp; 

public class Program {
    public static int? SumMinDigits(int[] numbers) {
        if (numbers.Length < 2) {
            return null;
        }

        int min1 = int.MaxValue;
        int min2 = int.MaxValue;

        foreach (int number in numbers) {
            if (number < min1) {
                min2 = min1;
                min1 = number;
            } else if (number < min2) {
                min2 = number;
            }
        }

        return min1 + min2;
    }
}