package metodos.secant;

import org.mariuszgromada.math.mxparser.Expression;

public class SecantMethod {
    private String function;
    private double tolerance;
    private int maxIterations;
    private StringBuilder steps;
    private OnStepListener listener;

    public SecantMethod(String function, double tolerance, int maxIterations) {
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

    // Evaluar la función usando mXparser
    private double evaluate(double x) {
        String expression = function.replace("x", "(" + x + ")");
        Expression e = new Expression(expression);
        return e.calculate();
    }

    public double solve(double x0, double x1) {
        double f0 = evaluate(x0);
        double f1 = evaluate(x1);
        double xNext;
        int iter = 0;

        while (Math.abs(f1) > tolerance && iter < maxIterations) {
            if (Math.abs(x1 - x0) < 1e-10) {
                throw new ArithmeticException("División por un número muy pequeño, riesgo de inestabilidad.");
            }

            xNext = x1 - f1 * (x1 - x0) / (f1 - f0);
            steps.append(String.format("Iteración %d: x0 = %.6f, x1 = %.6f, xNext = %.6f\n", iter, x0, x1, xNext));

            if (listener != null) {
                listener.onStep(steps.toString());
            }

            x0 = x1;
            x1 = xNext;
            f0 = f1;
            f1 = evaluate(x1);

            iter++;
        }

        return x1;
    }

    public interface OnStepListener {
        void onStep(String step);
    }
}
