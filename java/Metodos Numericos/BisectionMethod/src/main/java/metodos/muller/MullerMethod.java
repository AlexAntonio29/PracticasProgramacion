package metodos.muller;

import org.mariuszgromada.math.mxparser.Expression;

public class MullerMethod {
    private String function;
    private double tolerance;
    private int maxIterations;
    private StringBuilder steps;
    private OnStepListener listener;

    public MullerMethod(String function, double tolerance, int maxIterations) {
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

    private double evaluate(double x) {
        String expression = function.replace("x", "(" + x + ")");
        Expression e = new Expression(expression);
        return e.calculate();
    }

    public double solve(double x0, double x1, double x2) {
        int iter = 0;
        double h1, h2, d1, d2, a, b, c, xNext;
        double f0, f1, f2;

        while (iter < maxIterations) {
            f0 = evaluate(x0);
            f1 = evaluate(x1);
            f2 = evaluate(x2);

            h1 = x1 - x0;
            h2 = x2 - x1;
            d1 = (f1 - f0) / h1;
            d2 = (f2 - f1) / h2;

            a = (d2 - d1) / (h2 + h1);
            b = d2 + h2 * a;
            c = f2;

            double sqrtTerm = Math.sqrt(b * b - 4 * a * c);
            double denominator = Math.abs(b + sqrtTerm) > Math.abs(b - sqrtTerm) ? b + sqrtTerm : b - sqrtTerm;

            if (denominator == 0) {
                throw new ArithmeticException("Denominador se volvió cero, no se puede continuar.");
            }

            xNext = x2 - (2 * c) / denominator;

            steps.append(String.format("Iteración %d: x0 = %.6f, x1 = %.6f, x2 = %.6f, xNext = %.6f\n", iter, x0, x1, x2, xNext));

            if (listener != null) {
                listener.onStep(steps.toString());
            }

            if (Math.abs(xNext - x2) < tolerance) {
                return xNext;
            }

            x0 = x1;
            x1 = x2;
            x2 = xNext;

            iter++;
        }

        throw new ArithmeticException("El método no convergió en el número máximo de iteraciones.");
    }

    public interface OnStepListener {
        void onStep(String step);
    }
}
