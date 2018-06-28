import java.util.Scanner;

public class p15CensorEmailAddress {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String email = scanner.nextLine();
        String text = scanner.nextLine();

        String[] emailInfo = email.split("@");
        String userName = emailInfo[0];
        String replacement = addAsterisks(userName);
        replacement += emailInfo[1];
        text = text.replace(email, replacement);
        System.out.println(text);
    }

    private static String addAsterisks(String userName) {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < userName.length(); i++) {
            sb.append('*');
        }

        sb.append('@');
        return  sb.toString();
    }


}
