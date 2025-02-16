import org.mariuszgromada.math.mxparser.Expression;

public class BisectionMethod {
    private String function;
    private double tolerance;
    private StringBuilder steps;
    private OnStepListener listener;

    public BisectionMethod(String function, double tolerance) {
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

    public double solve(double a, double b) {
        double fa = evaluate(a);
        double fb = evaluate(b);

        if (fa * fb >= 0) {
            throw new IllegalArgumentException("Los valores de a y b no encierran una raíz.");
        }

        double c, fc;
        while ((b - a) / 2 > tolerance) {
            c = (a + b) / 2;
            fc = evaluate(c);

            // Registrar los pasos de la iteración
            steps.append(String.format("a: %.6f, b: %.6f, c: %.6f, f(c): %.6f\n", a, b, c, fc));
            if (listener != null) {
                listener.onStep(steps.toString());
            }

            if (fc == 0 || (b - a) / 2 < tolerance) {
                return c;
            } else if (fa * fc < 0) {
                b = c;
                fb = fc;
            } else {
                a = c;
                fa = fc;
            }
        }
        return (a + b) / 2;
    }

    public interface OnStepListener {
        void onStep(String step);
    }
}
