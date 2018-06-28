package p23AverageGrades;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberOfStudents = Integer.parseInt(scanner.nextLine());
        List<Student> students = new ArrayList<>();

        for (int i = 0; i < numberOfStudents; i++) {
            String[] studentInfo = scanner.nextLine().split(" ");
            double[] grades = new double [studentInfo.length - 1];

            for (int j = 0; j < grades.length; j++) {
                grades[j] = Double.parseDouble(studentInfo[j+1]);
            }

            Student currentStudent = new Student(studentInfo[0], grades);
            students.add(currentStudent);
        }

        students.stream()
                .filter(x -> x.getAverageGrade() >= 5)
                .sorted(Comparator.comparing(Student::getName)
                        .thenComparing(Comparator.comparing(Student::getAverageGrade).reversed()))
                .forEach(s->{
            System.out.printf("%s -> %.2f%n", s.getName(), s.getAverageGrade());
        });

    }
}
