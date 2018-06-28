import java.util.Scanner;

public class p06CompareCharArray {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        char[] first = scanner.nextLine().toCharArray();
        char[] second = scanner.nextLine().toCharArray();

        int endIndex = Math.min(first.length, second.length);

        for (int i = 0; i < endIndex; i++) {
            if(first[i] == ' '){
                continue;
            }else if(first[i] < second[i]){
                printArray(first);
                printArray(second);
                break;
            }else if(second[i] < first[i]){
                printArray(second);
                printArray(first);
                break;
            }else if(i == endIndex - 1){
                if(first.length < second.length){
                    printArray(first);
                    printArray(second);
                }else{
                    printArray(second);
                    printArray(first);
                }
            }

        }

    }

    private static void printArray(char[] arr) {
        for (char c : arr) {
            if(c != ' '){
                System.out.printf("%c", c);
            }
        }
        System.out.println();
    }
}
