import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class p19PhoneBookUpgrade {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line;
        TreeMap<String, String> phoneBook = new TreeMap<>();

        while (!"END".equals(line = scanner.nextLine())) {
            String[] phoneBookInfo = line.split(" ");
            String command = phoneBookInfo[0];

            if (command.equals("A")) {
                String name = phoneBookInfo[1];
                String number = phoneBookInfo[2];
                phoneBook.put(name, number);

            } else if (command.equals("S")) {
                String name = phoneBookInfo[1];
                if (phoneBook.containsKey(name)) {
                    System.out.printf("%s -> %s%n", name, phoneBook.get(name));
                } else {

                    System.out.printf("Contact %s does not exist.%n", name);
                }
            } else {
                for (String key : phoneBook.keySet()) {
                    System.out.printf("%s -> %s%n", key, phoneBook.get(key));
                }
            }
        }
    }
}

