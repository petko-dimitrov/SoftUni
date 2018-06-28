import java.util.Scanner;

public class p05IntToHexAndBin {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int number = Integer.parseInt(scanner.nextLine());
        String numberInHex = Integer.toHexString(number).toUpperCase();
        String numberInBin = Integer.toBinaryString(number).toUpperCase();

        System.out.println(numberInHex);
        System.out.println(numberInBin);
    }
}
