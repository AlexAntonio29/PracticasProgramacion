package metodos.other;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import org.mariuszgromada.math.mxparser.Expression;

public class RungeKuttaFehlbergCalculator extends JFrame {
    private JTextField functionInput, initialXInput, initialYInput, initialStepInput, toleranceInput;
    private JTextArea resultArea;

    public RungeKuttaFehlbergCalculator(JFrame parent) {
        super("Método Runge-Kutta-Fehlberg (RKF45)");
        setSize(500, 400);
        setLayout(new BorderLayout(10, 10));
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(parent);

        // Panel de entrada
        JPanel inputPanel = new JPanel(new GridLayout(5, 2, 10, 10));

        functionInput = new JTextField();
        inputPanel.add(new JLabel("Ecuación diferencial y' = f(x, y):"));
        inputPanel.add(functionInput);

        initialXInput = new JTextField();
        inputPanel.add(new JLabel("Valor inicial x0:"));
        inputPanel.add(initialXInput);

        initialYInput = new JTextField();
        inputPanel.add(new JLabel("Valor inicial y0:"));
        inputPanel.add(initialYInput);

        initialStepInput = new JTextField("0.1");
        inputPanel.add(new JLabel("Tamaño de paso inicial h:"));
        inputPanel.add(initialStepInput);

        toleranceInput = new JTextField("0.0001");
        inputPanel.add(new JLabel("Tolerancia de error:"));
        inputPanel.add(toleranceInput);

        add(inputPanel, BorderLayout.CENTER);

        // Botón para calcular
        JButton calculateButton = new JButton("Calcular RKF45");
        configureButton(calculateButton, this::calculateRKF45);
        add(calculateButton, BorderLayout.SOUTH);

        // Área de resultados
        resultArea = new JTextArea();
        resultArea.setEditable(false);
        resultArea.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JScrollPane(resultArea), BorderLayout.NORTH);

        setVisible(true);
    }

    private void calculateRKF45(ActionEvent e) {
        try {
            String function = functionInput.getText();
            double x = Double.parseDouble(initialXInput.getText());
            double y = Double.parseDouble(initialYInput.getText());
            double h = Double.parseDouble(initialStepInput.getText());
            double tol = Double.parseDouble(toleranceInput.getText());

            StringBuilder steps = new StringBuilder();
            steps.append("Método Runge-Kutta-Fehlberg (RKF45):\n");

            while (x < 10) { // Ejemplo: iteración hasta x=10
                double k1 = h * evaluate(function, x, y);
                double k2 = h * evaluate(function, x + h / 4, y + k1 / 4);
                double k3 = h * evaluate(function, x + 3 * h / 8, y + 3 * k1 / 32 + 9 * k2 / 32);
                double k4 = h * evaluate(function, x + 12 * h / 13, y + 1932 * k1 / 2197 - 7200 * k2 / 2197 + 7296 * k3 / 2197);
                double k5 = h * evaluate(function, x + h, y + 439 * k1 / 216 - 8 * k2 + 3680 * k3 / 513 - 845 * k4 / 4104);
                double k6 = h * evaluate(function, x + h / 2, y - 8 * k1 / 27 + 2 * k2 - 3544 * k3 / 2565 + 1859 * k4 / 4104 - 11 * k5 / 40);

                double yNew = y + (25 * k1 / 216 + 1408 * k3 / 2565 + 2197 * k4 / 4104 - k5 / 5);
                double error = Math.abs(yNew - (y + (16 * k1 / 135 + 6656 * k3 / 12825 + 28561 * k4 / 56430 - 9 * k5 / 50 + 2 * k6 / 55)));

                if (error > tol) {
                    h *= 0.8 * Math.pow(tol / error, 0.25); // Ajuste adaptativo
                } else {
                    x += h;
                    y = yNew;
                    steps.append(String.format("x = %.6f, y = %.6f, h = %.6f\n", x, y, h));
                    if (error < tol / 10) {
                        h *= 1.2; // Incremento del tamaño de paso
                    }
                }
            }

            resultArea.setText(steps.toString());
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Error en el formato de entrada: " + ex.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        }
    }

    private double evaluate(String function, double x, double y) {
        Expression e = new Expression(function.replace("x", "(" + x + ")").replace("y", "(" + y + ")"));
        return e.calculate();
    }

    private static void configureButton(JButton button, java.awt.event.ActionListener action) {
        button.setFont(new Font("Arial", Font.BOLD, 14));
        button.setBackground(new Color(0, 153, 76));
        button.setForeground(Color.WHITE);
        button.setFocusPainted(false);
        button.addActionListener(action);
    }
}
