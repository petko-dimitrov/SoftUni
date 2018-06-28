import java.util.Scanner;

public class SymmetricNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] number = scanner.nextLine().split(" ");
        int num = Integer.parseInt(number[0]);

        for (int i = 1; i <= num; i++) {
            if (isSymmetric(i)){
                System.out.printf(i + " ");
            }
        }
    }

    static boolean isSymmetric(int num){
        String numAsString = Integer.toString(num);
        boolean areSymmetric = true;

        for (int i = 0; i < numAsString.length() / 2; i++) {
            if(numAsString.charAt(i) != numAsString.charAt(numAsString.length() - 1 - i)){
               areSymmetric = false;
            }
        }

        return areSymmetric;
    }
}
