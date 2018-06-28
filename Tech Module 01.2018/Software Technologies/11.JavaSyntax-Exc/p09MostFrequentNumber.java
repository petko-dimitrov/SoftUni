import java.util.Arrays;
import java.util.Scanner;

public class p09MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays
                .stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int mostFrequent = numbers[0];
        int bestCount = 1;

        for (int i = 0; i < numbers.length; i++) {
            int current = numbers[i];
            int count = 1;

            for (int j = i + 1; j < numbers.length; j++) {
                if(numbers[j] == current){
                    count++;
                }
            }

            if(count > bestCount){
                mostFrequent = current;
                bestCount = count;
            }
        }

        System.out.println(mostFrequent);
    }
}
