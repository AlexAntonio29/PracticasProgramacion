package metodos.newtonRaphson;

import org.mariuszgromada.math.mxparser.Expression;

public class NewtonRaphsonMethod {
    private String function;
    private double tolerance;
    private StringBuilder steps;
    private OnStepListener listener;

    public NewtonRaphsonMethod(String function, double tolerance) {
        this.function = function;
        this.tolerance = tolerance;
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

    // Evaluar la derivada usando mXparser
    private double evaluateDerivative(double x) {
        String expression = "der(" + function + ", x)";
        Expression e = new Expression(expression.replace("x", "(" + x + ")"));
        return e.calculate();
    }

    public double solve(double x0) {
        double x = x0;
        double fx, dfx;
        int iter = 0;

        while (true) {
            fx = evaluate(x);
            dfx = evaluateDerivative(x);

            if (Math.abs(fx) < tolerance) {
                return x;
            }

            if (dfx == 0) {
                throw new ArithmeticException("La derivada se volvió cero, no se puede continuar.");
            }

            double xNext = x - (fx / dfx);
            steps.append(String.format("Iteración %d: x = %.6f, f(x) = %.6f, f'(x) = %.6f\n", iter, x, fx, dfx));

            if (listener != null) {
                listener.onStep(steps.toString());
            }

            if (Math.abs(xNext - x) < tolerance) {
                return xNext;
            }

            x = xNext;
            iter++;
        }
    }

    public interface OnStepListener {
        void onStep(String step);
    }
}
