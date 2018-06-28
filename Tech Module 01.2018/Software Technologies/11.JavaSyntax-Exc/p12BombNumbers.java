import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class p12BombNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Integer> numbers = Arrays
                .stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        int[] bombInfo = Arrays
                .stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int bombNumber = bombInfo[0];
        int bombPower = bombInfo[1];

        while(numbers.contains(bombNumber)){
            int index = numbers.indexOf(bombNumber);
            int leftIndex = index - bombPower;
            int rightIndex = index + bombPower;

            if(leftIndex < 0){
                leftIndex = 0;
            }
            if(rightIndex >= numbers.size()){
                rightIndex = numbers.size() - 1;
            }

            numbers.subList(leftIndex, rightIndex + 1).clear();
        }

        int result = numbers.stream().mapToInt(Integer::intValue).sum();
        System.out.println(result);
    }
}
