package p24BookLibrary;

import p24BookLibrary.Book;
import p24BookLibrary.Library;

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
            String releaseDate = bookInfo[3];
            String isbn = bookInfo[4];
            double price = Double.parseDouble(bookInfo[5]);

            books.add(new Book(title, author, publisher, releaseDate, isbn, price));
        }

        Library library = new Library("library", books);

        Map<String, Double> authors = new LinkedHashMap<>();

        for (Book book : library.getBooks()) {
            if (!authors.containsKey(book.getAuthor())) {
                authors.put(book.getAuthor(), book.getPrice());
            } else {
                authors.put(book.getAuthor(), authors.get(book.getAuthor()) + book.getPrice());
            }
        }

        authors.entrySet().stream()
                .sorted((a1, a2) ->{
                            int compareResult = Double.compare(a2.getValue(), a1.getValue());

                            if(compareResult == 0){
                                compareResult = a1.getKey().compareTo(a2.getKey());
                            }

                            return compareResult;
                })
                .forEach(a -> System.out.printf("%s -> %.2f%n", a.getKey(), a.getValue()));
    }
}
