package metodos.point;

import org.mariuszgromada.math.mxparser.Expression;

public class PointMethod {
    private String function;
    private double tolerance;
    private int maxIterations;
    private StringBuilder steps;
    private OnStepListener listener;

    public PointMethod(String function, double tolerance, int maxIterations) {
        this.function = function;
        this.tolerance = tolerance;
        this.maxIterations = maxIterations;
        this.steps = new StringBuilder();
    }

    public String getSteps() {
        return steps.toString();
    }

    public void setOnStepListener(OnStepListener listener) {
        this.listener = listener;
    }

    // Evaluar la función g(x) usando mXparser
    private double evaluate(double x) {
        String expression = function.replace("x", "(" + x + ")");
        Expression e = new Expression(expression);
        return e.calculate();
    }

    public double solve(double x0) {
        double x1;
        int iteration = 0;

        while (iteration < maxIterations) {
            x1 = evaluate(x0);
            double error = Math.abs(x1 - x0);

            // Registrar el paso
            steps.append(String.format("Iteración %d: x = %.6f, g(x) = %.6f, Error = %.6f\n",
                    iteration + 1, x0, x1, error));

            if (listener != null) {
                listener.onStep(steps.toString());
            }

            // Verificar la condición de parada
            if (error < tolerance) {
                return x1;
            }

            x0 = x1;
            iteration++;
        }

        throw new IllegalArgumentException("El método no convergió después de " + maxIterations + " iteraciones.");
    }

    public interface OnStepListener {
        void onStep(String step);
    }
}
