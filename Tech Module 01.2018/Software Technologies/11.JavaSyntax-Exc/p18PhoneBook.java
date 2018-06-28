import java.util.LinkedHashMap;
import java.util.Scanner;

public class p18PhoneBook {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line;
        LinkedHashMap<String, String> phoneBook = new LinkedHashMap<>();

        while (!"END".equals(line = scanner.nextLine())) {
            String[] phoneBookInfo = line.split(" ");
            String command = phoneBookInfo[0];
            String name = phoneBookInfo[1];

            if (command.equals("A")) {
                String number = phoneBookInfo[2];
                phoneBook.put(name, number);

            } else if (command.equals("S")) {
                if (phoneBook.containsKey(name)) {
                    System.out.printf("%s -> %s%n", name, phoneBook.get(name));
                } else {

                    System.out.printf("Contact %s does not exist.%n", name);
                }
            }
        }
    }
}
