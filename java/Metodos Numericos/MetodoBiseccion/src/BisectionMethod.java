import javax.script.ScriptEngine;
import javax.script.ScriptEngineManager;
import javax.script.ScriptException;


class BisectionMethod {
    private String function;
    private double tolerance;
    private ScriptEngine engine;

    public BisectionMethod(String function, double tolerance) {
        this.function = function;
        this.tolerance = tolerance;
        engine = new ScriptEngineManager().getEngineByName("JavaScript");
    }

    private double evaluate(double x) throws ScriptException {
        String expression = function.replace("x", "(" + x + ")");
        return ((Number) engine.eval(expression)).doubleValue();
    }

    public double solve(double a, double b) throws ScriptException {
        if (evaluate(a) * evaluate(b) >= 0) {
            throw new IllegalArgumentException("Los valores de a y b no encierran una raíz.");
        }

        double c;
        while ((b - a) / 2 > tolerance) {
            c = (a + b) / 2;
            if (evaluate(c) == 0) return c;
            else if (evaluate(a) * evaluate(c) < 0) b = c;
            else a = c;
        }
        return (a + b) / 2;
    }
}
