package p23AverageGrades;

import java.util.Arrays;

public class Student {
    private String name;
    private double[] grades;
    private double averageGrade;

    public Student(String name, double[] grades) {
        this.name = name;
        this.grades = grades;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public double[] getGrades() {
        return grades;
    }

    public void setGrades(double[] grades) {
        this.grades = grades;
    }

    public double getAverageGrade() {
        return Arrays.stream(this.grades).average().getAsDouble();
    }

}
