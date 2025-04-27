package metodos.muller;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;

public class MullerCalculator extends JFrame {
    private JTextField functionInput, x0Input, x1Input, x2Input, toleranceInput, maxIterationsInput;
    private JTextArea resultArea;

    public MullerCalculator(JFrame parent) {
        super("Método de Müller");
        setSize(450, 400);
        setLayout(new BorderLayout(10, 10));
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(parent);

        // Panel principal
        JPanel inputPanel = new JPanel(new GridLayout(6, 2, 10, 10));

        // Campos de entrada
        functionInput = new JTextField();
        inputPanel.add(new JLabel("Función f(x):"));
        inputPanel.add(functionInput);

        x0Input = new JTextField();
        inputPanel.add(new JLabel("Valor inicial x0:"));
        inputPanel.add(x0Input);

        x1Input = new JTextField();
        inputPanel.add(new JLabel("Valor inicial x1:"));
        inputPanel.add(x1Input);

        x2Input = new JTextField();
        inputPanel.add(new JLabel("Valor inicial x2:"));
        inputPanel.add(x2Input);

        toleranceInput = new JTextField("0.0001");
        inputPanel.add(new JLabel("Tolerancia:"));
        inputPanel.add(toleranceInput);

        maxIterationsInput = new JTextField("100");
        inputPanel.add(new JLabel("Iteraciones máximas:"));
        inputPanel.add(maxIterationsInput);

        add(inputPanel, BorderLayout.CENTER);

        // Botón para calcular
        JButton calculateButton = new JButton("Calcular");
        calculateButton.setFont(new Font("Arial", Font.BOLD, 14));
        calculateButton.setBackground(new Color(0, 153, 76));
        calculateButton.setForeground(Color.WHITE);
        calculateButton.setFocusPainted(false);
        calculateButton.addActionListener(e -> calculateMullerMethod());
        add(calculateButton, BorderLayout.SOUTH);

        // Área para mostrar resultados
        resultArea = new JTextArea();
        resultArea.setEditable(false);
        resultArea.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JScrollPane(resultArea), BorderLayout.NORTH);

        setVisible(true);
    }

    private void calculateMullerMethod() {
        String function = functionInput.getText();
        try {
            double x0 = Double.parseDouble(x0Input.getText());
            double x1 = Double.parseDouble(x1Input.getText());
            double x2 = Double.parseDouble(x2Input.getText());
            double tolerance = Double.parseDouble(toleranceInput.getText());
            int maxIterations = Integer.parseInt(maxIterationsInput.getText());

            MullerMethod solver = new MullerMethod(function, tolerance, maxIterations);
            solver.setOnStepListener(resultArea::setText);

            double root = solver.solve(x0, x1, x2);
            resultArea.append("\nRaíz aproximada: " + root);
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Error: " + ex.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        }
    }
}
