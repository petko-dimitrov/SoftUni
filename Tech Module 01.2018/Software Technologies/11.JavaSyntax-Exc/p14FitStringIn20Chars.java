import java.util.Scanner;

public class p14FitStringIn20Chars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        String editedText;

        if(text.length() > 20){
            editedText = text.substring(0, 20);
            System.out.println(editedText);
        }
        else if(text.length() < 20){
            editedText = PadRight(text);
            System.out.println(editedText);
        }
    }

    private static String PadRight(String text) {
        StringBuilder sb = new StringBuilder();
        sb.append(text);

        int length = 20 - text.length();

        for (int i = 0; i < length; i++){
            sb.append('*');
        }

        return sb.toString();
    }


}
