import java.util.Arrays;
import java.util.Scanner;

public class ThreeIntegersSum {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] nums = Arrays
                .stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        if(!sumNumbers(nums[0], nums[1], nums[2]) &&
                !sumNumbers(nums[0], nums[2], nums[1]) &&
                !sumNumbers(nums[1], nums[2], nums[0])){
            System.out.println("No");
        }
    }

    static boolean sumNumbers(int num1, int num2, int sum){
        if(num1 + num2 == sum){
            if(num1 <= num2){
                System.out.printf("%d + %d = %d", num1, num2, sum);
            } else{
                System.out.printf("%d + %d = %d", num2, num1, sum);
            }
            return true;
        }else{
            return false;
        }
    }
}
