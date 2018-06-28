import java.util.Scanner;

public class p17ChangeToUpper {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();

        while (true) {
            int openTagIndex = text.indexOf("<upcase>");
            int closeTagIndex = text.indexOf("</upcase>");

            if (closeTagIndex < 0 || openTagIndex < 0) {
                break;
            }

            String textToReplace = text.substring(openTagIndex, closeTagIndex + 9);

            text = text.replace(textToReplace, textToReplace.substring(8, textToReplace.length() - 9).toUpperCase());
        }

        System.out.println(text);
    }
}
