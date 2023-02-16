public class MultiplyingMatrices1 {

    static void MathProblem1() {
        // Let's give [1 3] [-5 2] with [2 2] that being for X and Y
        int PointX;
        int PointY;
        PointX = (1 * 2) + (3 * 2);
        PointY = (-5 * 2) + (2 * 2);
        System.out.print("The Solution is: " + "[" + PointX + "," + PointY + "].");
    }

    static void MathProblem2() {
        int PointX;
        int PointY;
        PointX = (2 * 5) + (-2 * 5);
        PointY = (3 * 5) + (-2 * 5);
        System.out.println("The solution is: " + "[" + PointX + "," + PointY + "].");
    }

    public static void main(String[] args) {
        MathProblem1();
        MathProblem2();
    }

}
