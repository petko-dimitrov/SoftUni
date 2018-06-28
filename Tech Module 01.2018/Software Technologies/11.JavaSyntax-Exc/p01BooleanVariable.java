import java.util.Scanner;

public class p01BooleanVariable {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String boolAsString = scanner.nextLine();
        boolean bool = Boolean.parseBoolean(boolAsString);

        if(bool){
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }
}
