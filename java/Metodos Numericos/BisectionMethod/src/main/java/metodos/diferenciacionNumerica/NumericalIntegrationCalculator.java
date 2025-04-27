package metodos.diferenciacionNumerica;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import org.mariuszgromada.math.mxparser.Expression;

public class NumericalIntegrationCalculator extends JFrame {
    private JTextField functionInput, lowerLimitInput, upperLimitInput, intervalsInput;
    private JTextArea resultArea;

    public NumericalIntegrationCalculator(JFrame parent) {
        super("Métodos de Integración Numérica");
        setSize(500, 350);
        setLayout(new BorderLayout(10, 10));
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(parent);

        // Panel de entrada
        JPanel inputPanel = new JPanel(new GridLayout(4, 2, 10, 10));

        functionInput = new JTextField();
        inputPanel.add(new JLabel("Función f(x):"));
        inputPanel.add(functionInput);

        lowerLimitInput = new JTextField();
        inputPanel.add(new JLabel("Límite inferior a:"));
        inputPanel.add(lowerLimitInput);

        upperLimitInput = new JTextField();
        inputPanel.add(new JLabel("Límite superior b:"));
        inputPanel.add(upperLimitInput);

        intervalsInput = new JTextField("10");
        inputPanel.add(new JLabel("Número de intervalos:"));
        inputPanel.add(intervalsInput);

        add(inputPanel, BorderLayout.CENTER);

        // Botón para calcular
        JButton calculateButton = new JButton("Calcular Integral");
        calculateButton.setFont(new Font("Arial", Font.BOLD, 14));
        calculateButton.setBackground(new Color(0, 153, 76));
        calculateButton.setForeground(Color.WHITE);
        calculateButton.setFocusPainted(false);
        calculateButton.addActionListener(this::calculateIntegrals);
        add(calculateButton, BorderLayout.SOUTH);

        // Área para mostrar resultados
        resultArea = new JTextArea();
        resultArea.setEditable(false);
        resultArea.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JScrollPane(resultArea), BorderLayout.NORTH);

        setVisible(true);
    }

    private void calculateIntegrals(ActionEvent e) {
        try {
            String function = functionInput.getText();
            double a = Double.parseDouble(lowerLimitInput.getText());
            double b = Double.parseDouble(upperLimitInput.getText());
            int n = Integer.parseInt(intervalsInput.getText());

            double trapecio = trapezoidalRule(function, a, b, n);
            double simpson = simpsonRule(function, a, b, n);

            resultArea.setText(String.format(
                    "Método del Trapecio: %.6f\nMétodo de Simpson: %.6f",
                    trapecio, simpson));
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Error: " + ex.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        }
    }

    private double evaluate(String function, double x) {
        Expression e = new Expression(function.replace("x", "(" + x + ")"));
        return e.calculate();
    }

    private double trapezoidalRule(String function, double a, double b, int n) {
        double h = (b - a) / n;
        double sum = (evaluate(function, a) + evaluate(function, b)) / 2;
        for (int i = 1; i < n; i++) {
            sum += evaluate(function, a + i * h);
        }
        return h * sum;
    }

    private double simpsonRule(String function, double a, double b, int n) {
        if (n % 2 != 0) n++; // Simpson requiere un número par de subintervalos
        double h = (b - a) / n;
        double sum = evaluate(function, a) + evaluate(function, b);

        for (int i = 1; i < n; i++) {
            sum += (i % 2 == 0 ? 2 : 4) * evaluate(function, a + i * h);
        }
        return (h / 3) * sum;
    }
}
