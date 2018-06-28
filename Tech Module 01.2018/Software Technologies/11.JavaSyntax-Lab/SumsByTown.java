import java.util.Scanner;
import java.util.TreeMap;

public class SumsByTown {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        TreeMap<String, Double> towns = new TreeMap<>();

        for (int i = 0; i < n; i++) {
            String[] townInfo = scanner.nextLine().split("\\|");
            String town = townInfo[0].trim();
            Double income = Double.parseDouble(townInfo[1].trim());

            if(towns.containsKey(town)){
                towns.put(town, towns.get(town) + income);
            } else{
                towns.put(town, income);
            }
        }

        for (String town : towns.keySet()) {
            System.out.println(town + " -> " + towns.get(town));
        }
    }
}
