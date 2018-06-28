import java.util.Arrays;
import java.util.Scanner;

public class LargestThreeNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays
                .stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        Arrays.sort(numbers);
        int length = Math.min(numbers.length, 3);

        for (int i = 0; i < length; i++) {
            System.out.println(numbers[numbers.length - 1 - i]);
        }
    }
}
