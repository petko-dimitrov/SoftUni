import java.util.Scanner;

public class p04VowelOrDigit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        char symbol = scanner.nextLine().charAt(0);

        if (Character.isDigit(symbol)) {
            System.out.println("digit");
        } else if (isVowel(symbol)) {
            System.out.println("vowel");
        } else {
            System.out.println("other");
        }
    }

    private static boolean isVowel(char symbol) {
        char[] vowels = {'a','e','i','o','u'};
        symbol = Character.toLowerCase(symbol);

        for (char vowel : vowels) {
            if(vowel == symbol){
                return true;
            }
        }

        return false;
    }
}
