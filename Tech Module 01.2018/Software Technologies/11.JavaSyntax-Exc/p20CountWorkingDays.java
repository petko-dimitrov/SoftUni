import java.text.ParseException;
import java.time.DayOfWeek;
import java.time.LocalDate;
import java.time.Month;
import java.time.format.DateTimeFormatter;
import java.util.Calendar;
import java.util.Scanner;

public class p20CountWorkingDays {
    public static void main(String[] args) throws ParseException {
        Scanner scanner = new Scanner(System.in);
        String start = scanner.nextLine();
        String end = scanner.nextLine();

        LocalDate startDate = LocalDate
                .parse(start, DateTimeFormatter.ofPattern("dd-MM-yyyy"));
        LocalDate endDate = LocalDate
                .parse(end, DateTimeFormatter.ofPattern("dd-MM-yyyy")).plusDays(1);

        Calendar calendar = Calendar.getInstance();

        int holidays = 0;
        int totalDays = 0;

        for (LocalDate i = startDate; i.isBefore(endDate); i = i.plusDays(1)) {
            totalDays++;

            if (i.getDayOfWeek().equals(DayOfWeek.SATURDAY)
                    || i.getDayOfWeek().equals(DayOfWeek.SUNDAY)) {
                holidays++;
                continue;
            }

            if (i.getDayOfMonth() == 1 && i.getMonth() == Month.JANUARY) {
                holidays++;
            } else if (i.getDayOfMonth() == 3 && i.getMonth() == Month.MARCH) {
                holidays++;
            } else if (i.getDayOfMonth() == 1 && i.getMonth() == Month.MAY) {
                holidays++;
            } else if (i.getDayOfMonth() == 6 && i.getMonth() == Month.MAY) {
                holidays++;
            } else if (i.getDayOfMonth() == 24 && i.getMonth() == Month.MAY) {
                holidays++;
            } else if (i.getDayOfMonth() == 6 && i.getMonth() == Month.SEPTEMBER) {
                holidays++;
            } else if (i.getDayOfMonth() == 22 && i.getMonth() == Month.SEPTEMBER) {
                holidays++;
            }  else if (i.getDayOfMonth() == 1 && i.getMonth() == Month.NOVEMBER) {
                holidays++;
            }  else if (i.getDayOfMonth() == 24 && i.getMonth() == Month.DECEMBER) {
                holidays++;
            } else if (i.getDayOfMonth() == 25 && i.getMonth() == Month.DECEMBER) {
                holidays++;
            } else if (i.getDayOfMonth() == 26 && i.getMonth() == Month.DECEMBER) {
                holidays++;
            }


        }

        System.out.println(totalDays - holidays);
    }

}
