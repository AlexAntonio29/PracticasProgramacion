package metodos.gaussElimination;

public class GaussEliminationMethod {
    private double[][] matrix;
    private int size;
    private StringBuilder steps;

    public GaussEliminationMethod(double[][] matrix) {
        this.matrix = matrix;
        this.size = matrix.length;
        this.steps = new StringBuilder();
    }

    public String getSteps() {
        return steps.toString();
    }

    public double[] solve() {
        for (int i = 0; i < size; i++) {
            pivoting(i);
            normalizeRow(i);
            eliminateBelow(i);
        }
        return backSubstitution();
    }

    private void pivoting(int row) {
        int maxRow = row;
        for (int i = row + 1; i < size; i++) {
            if (Math.abs(matrix[i][row]) > Math.abs(matrix[maxRow][row])) {
                maxRow = i;
            }
        }
        double[] temp = matrix[row];
        matrix[row] = matrix[maxRow];
        matrix[maxRow] = temp;
        steps.append(String.format("Intercambio de filas %d y %d\n", row, maxRow));
    }

    private void normalizeRow(int row) {
        double pivot = matrix[row][row];
        for (int j = row; j < size + 1; j++) {
            matrix[row][j] /= pivot;
        }
        steps.append(String.format("Normalización de fila %d\n", row));
    }

    private void eliminateBelow(int row) {
        for (int i = row + 1; i < size; i++) {
            double factor = matrix[i][row];
            for (int j = row; j < size + 1; j++) {
                matrix[i][j] -= factor * matrix[row][j];
            }
            steps.append(String.format("Eliminación debajo de fila %d\n", row));
        }
    }

    private double[] backSubstitution() {
        double[] solution = new double[size];
        for (int i = size - 1; i >= 0; i--) {
            solution[i] = matrix[i][size];
            for (int j = i + 1; j < size; j++) {
                solution[i] -= matrix[i][j] * solution[j];
            }
        }
        steps.append("Sustitución regresiva completada.\n");
        return solution;
    }
}
