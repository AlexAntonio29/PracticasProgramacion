package metodos.solucionNumericaEcuacionesDiferencialesOrdinarias;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import org.mariuszgromada.math.mxparser.Expression;

public class EulerMethodCalculator extends JFrame {
    private JTextField functionInput, initialXInput, initialYInput, stepSizeInput, iterationsInput;
    private JTextArea resultArea;

    public EulerMethodCalculator(JFrame parent) {
        super("Método de Euler - Solución EDO");
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

        stepSizeInput = new JTextField("0.1");
        inputPanel.add(new JLabel("Tamaño de paso h:"));
        inputPanel.add(stepSizeInput);

        iterationsInput = new JTextField("10");
        inputPanel.add(new JLabel("Número de iteraciones:"));
        inputPanel.add(iterationsInput);

        add(inputPanel, BorderLayout.CENTER);

        // Botón para calcular
        JButton calculateButton = new JButton("Calcular Euler");
        configureButton(calculateButton, this::calculateEuler);
        add(calculateButton, BorderLayout.SOUTH);

        // Área de resultados
        resultArea = new JTextArea();
        resultArea.setEditable(false);
        resultArea.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JScrollPane(resultArea), BorderLayout.NORTH);

        setVisible(true);
    }

    private void calculateEuler(ActionEvent e) {
        try {
            String function = functionInput.getText();
            double x = Double.parseDouble(initialXInput.getText());
            double y = Double.parseDouble(initialYInput.getText());
            double h = Double.parseDouble(stepSizeInput.getText());
            int n = Integer.parseInt(iterationsInput.getText());

            StringBuilder steps = new StringBuilder();
            steps.append("Método de Euler:\n");
            for (int i = 0; i < n; i++) {
                double fxy = evaluate(function, x, y);
                y = y + h * fxy;
                x = x + h;
                steps.append(String.format("Paso %d: x = %.6f, y = %.6f\n", i + 1, x, y));
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
