import java.util.Scanner;

public class p10IndexOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        char[] letters = new char[26];

        for (int i = 0; i < 26; i++) {
            letters[i] = (char)(i + 97);
        }

        String word = scanner.nextLine();

        for (int i = 0; i < word.length(); i++) {
            for (int j = 0; j < letters.length; j++) {
                if(word.charAt(i) == letters[j]){
                    System.out.printf("%c -> %d", letters[j], j);
                    break;
                }
            }
            System.out.println();
        }
    }
}
