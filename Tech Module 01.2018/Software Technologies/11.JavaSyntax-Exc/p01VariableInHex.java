import java.util.Scanner;

public class p01VariableInHex {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String numInHex = scanner.nextLine();
        int number = Integer.parseInt(numInHex, 16);
        System.out.println(number);
    }
}
