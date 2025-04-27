package metodos.gaussGordan;

public class GaussJordanMethod {
    private double[][] matrix;
    private int size;
    private StringBuilder steps;

    public GaussJordanMethod(double[][] matrix) {
        this.matrix = matrix;
        this.size = matrix.length;
        this.steps = new StringBuilder();
    }

    public String getSteps() {
        return steps.toString();
    }

    public double[] solve() {
        for (int i = 0; i < size; i++) {
            normalizeRow(i);
            eliminateOtherRows(i);
        }
        return extractSolution();
    }

    private void normalizeRow(int row) {
        double pivot = matrix[row][row];
        for (int j = 0; j < size + 1; j++) {
            matrix[row][j] /= pivot;
        }
        steps.append(String.format("Normalización de fila %d\n", row));
    }

    private void eliminateOtherRows(int row) {
        for (int i = 0; i < size; i++) {
            if (i != row) {
                double factor = matrix[i][row];
                for (int j = 0; j < size + 1; j++) {
                    matrix[i][j] -= factor * matrix[row][j];
                }
                steps.append(String.format("Eliminación en fila %d\n", i));
            }
        }
    }

    private double[] extractSolution() {
        double[] solution = new double[size];
        for (int i = 0; i < size; i++) {
            solution[i] = matrix[i][size];
        }
        steps.append("Solución extraída.\n");
        return solution;
    }
}
