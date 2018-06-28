package p25BookLibraryModification;

import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        List<Book> books = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            String[] bookInfo = scanner.nextLine().split(" ");
            String title = bookInfo[0];
            String author = bookInfo[1];
            String publisher = bookInfo[2];
            LocalDate releaseDate = LocalDate
                    .parse(bookInfo[3], DateTimeFormatter.ofPattern("dd.MM.yyyy"));
            String isbn = bookInfo[4];
            double price = Double.parseDouble(bookInfo[5]);

            books.add(new Book(title, author, publisher, releaseDate, isbn, price));
        }

        String date = scanner.nextLine();
        LocalDate startDate = LocalDate
                .parse(date, DateTimeFormatter.ofPattern("dd.MM.yyyy"));

        Library library = new Library("library", books);

        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd.MM.yyyy");

        library.getBooks().stream()
                .filter(x -> x.getReleaseDate().isAfter(startDate))
                .sorted(Comparator.comparing(Book::getReleaseDate)
                        .thenComparing(Comparator.comparing(Book::getTitle)))
                .forEach(x -> {
                    System.out.printf("%s -> %s%n", x.getTitle(), formatter.format(x.getReleaseDate()));
                });
    }
}
