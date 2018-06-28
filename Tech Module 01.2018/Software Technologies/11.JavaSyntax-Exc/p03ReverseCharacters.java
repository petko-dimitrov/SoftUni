import java.util.Scanner;

public class p03ReverseCharacters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        char[] letters = new char[3];

        for (int i = 0; i < 3; i++) {
            char letter =  scanner.nextLine().charAt(0);
            letters[i] = letter;
        }

        for (int i = letters.length - 1; i >= 0 ; i--) {
            System.out.printf("%c", letters[i]);
        }
    }
}
