package p22IntersectionOfCircles;

import java.util.Scanner;

public class Program {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Circle circle1 = new Circle(new Point(scanner.nextInt(), scanner.nextInt()), scanner.nextInt());
        Circle circle2 = new Circle(new Point(scanner.nextInt(), scanner.nextInt()), scanner.nextInt());

        double distance = Math.sqrt(Math.pow((circle2.getPoint().getX() - circle1.getPoint().getX()), 2) +
                Math.pow((circle2.getPoint().getY() - circle1.getPoint().getY()), 2));

        if(Intersect(circle1, circle2, distance)){
            System.out.println("Yes");
        } else{
            System.out.println("No");
        }
    }

    static boolean Intersect(Circle circle1, Circle circle2, double distance){


        if(distance <= circle1.getRadius() + circle2.getRadius()){
            return true;
        }else{
            return false;
        }
    }
}
