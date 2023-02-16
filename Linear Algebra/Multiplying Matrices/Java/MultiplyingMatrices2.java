/*
 * Programmer:      Corey Jenkins
 * Date:            August 31, 2022
 * Program Name:    Multiplying Matrices.java
 * Purpose:         A second demonstration in multiplying matrices in Java. Please use Visual Studio Code to run.
 */

public class MultiplyingMatrices2 {

    public static void main(String[] args) {
        // These variables will give the product for the coordinates on the X, Y, and Z
        // axis.
        // [(2 -1 0), (3 2 -1), (-3, 1, 2)] and [(1,4,3)] Multiply then add. Dot
        // Product.
        int PointX, PointY, PointZ;
        PointX = (2 * 1) + (-1 * 4) + (0 * 3);
        PointY = (3 * 1) + (2 * 4) + (-1 * 3);
        PointZ = (-3 * 1) + (1 * 4) + (2 * 3);

        System.out.println("The solution is: " + "[" + PointX + "," + PointY + "," + PointZ + "]");

    }

}
