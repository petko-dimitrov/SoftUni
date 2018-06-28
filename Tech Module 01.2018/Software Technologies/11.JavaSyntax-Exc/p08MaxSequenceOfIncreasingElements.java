import java.util.Arrays;
import java.util.Scanner;

public class p08MaxSequenceOfIncreasingElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays
                .stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int bestLength = 1;
        int bestStart = 0;
        int length = 1;
        int start = 0;

        for (int i = 1; i < numbers.length; i++) {
            if(numbers[i] > numbers[i - 1]){
                length++;
            }else{
                if(length > bestLength){
                    bestLength = length;
                    bestStart = start;
                }
                start = i;
                length = 1;
            }
            if(i == numbers.length - 1){
                if(length > bestLength){
                    bestLength = length;
                    bestStart = start;
                }
            }
        }

        for (int i = bestStart; i < bestStart + bestLength; i++) {
            System.out.printf("%d ", numbers[i]);
        }
    }
}
