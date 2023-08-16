/*
 * Programmer:      Corey Jenkins
 * Date:            August 15, 2023
 * Filename:        areaRectangleFunction.java
 * Purpose:         A program in which returns the area of a rectangle.
*/

import java.util.Scanner;

public class areaRectangleFunction {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int rectangleLength, rectangleWidth, areaReturnFunction;
        System.out.println("Enter the length of a rectangle: ");
        rectangleLength = input.nextInt();

        System.out.println("Enter the height of the rectangle: ");
        rectangleWidth = input.nextInt();

        areaReturnFunction = area(rectangleLength, rectangleWidth);
        System.out.println(areaReturnFunction);

    }

    public static int area(int num1, int num2) {
        int areaRectangle;
        areaRectangle = num1 * num2;
        return areaRectangle;
    }
}