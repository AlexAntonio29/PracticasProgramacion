package metodos.diferenciacionNumerica;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import org.mariuszgromada.math.mxparser.Expression;

public class NumericalDerivationCalculator extends JFrame {
    private JTextField functionInput, pointInput, stepSizeInput;
    private JTextArea resultArea;

    public NumericalDerivationCalculator(JFrame parent) {
        super("Métodos de Derivación Numérica");
        setSize(500, 350);
        setLayout(new BorderLayout(10, 10));
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(parent);

        // Panel de entrada
        JPanel inputPanel = new JPanel(new GridLayout(3, 2, 10, 10));

        functionInput = new JTextField();
        inputPanel.add(new JLabel("Función f(x):"));
        inputPanel.add(functionInput);

        pointInput = new JTextField();
        inputPanel.add(new JLabel("Punto x:"));
        inputPanel.add(pointInput);

        stepSizeInput = new JTextField("0.01");
        inputPanel.add(new JLabel("Tamaño de paso h:"));
        inputPanel.add(stepSizeInput);

        add(inputPanel, BorderLayout.CENTER);

        // Botón para calcular
        JButton calculateButton = new JButton("Calcular Derivada");
        calculateButton.setFont(new Font("Arial", Font.BOLD, 14));
        calculateButton.setBackground(new Color(0, 153, 76));
        calculateButton.setForeground(Color.WHITE);
        calculateButton.setFocusPainted(false);
        calculateButton.addActionListener(this::calculateDerivatives);
        add(calculateButton, BorderLayout.SOUTH);

        // Área para mostrar resultados
        resultArea = new JTextArea();
        resultArea.setEditable(false);
        resultArea.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JScrollPane(resultArea), BorderLayout.NORTH);

        setVisible(true);
    }

    private void calculateDerivatives(ActionEvent e) {
        try {
            String function = functionInput.getText();
            double x = Double.parseDouble(pointInput.getText());
            double h = Double.parseDouble(stepSizeInput.getText());

            double forwardDiff = (evaluate(function, x + h) - evaluate(function, x)) / h;
            double backwardDiff = (evaluate(function, x) - evaluate(function, x - h)) / h;
            double centeredDiff = (evaluate(function, x + h) - evaluate(function, x - h)) / (2 * h);

            resultArea.setText(String.format(
                    "Diferencia Adelante: %.6f\nDiferencia Atrás: %.6f\nDiferencia Centrada: %.6f",
                    forwardDiff, backwardDiff, centeredDiff));
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Error: " + ex.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        }
    }

    private double evaluate(String function, double x) {
        Expression e = new Expression(function.replace("x", "(" + x + ")"));
        return e.calculate();
    }
}
