package metodos.newtonRaphson;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class NewtonRaphsonCalculator extends JFrame {
    private JTextField functionInput, initialGuessInput, toleranceInput;
    private JTextArea resultArea;

    public NewtonRaphsonCalculator(JFrame parent) {
        super("Método de Newton-Raphson");
        setSize(400, 300);
        setLayout(new GridLayout(5, 1, 10, 10));
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(parent);

        // Campo para la función
        functionInput = new JTextField();
        functionInput.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JLabel("Función f(x):"));
        add(functionInput);

        // Campo para la aproximación inicial
        initialGuessInput = new JTextField();
        initialGuessInput.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JLabel("Aproximación inicial x0:"));
        add(initialGuessInput);

        // Campo para la tolerancia
        toleranceInput = new JTextField("0.0001");
        toleranceInput.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JLabel("Tolerancia:"));
        add(toleranceInput);

        // Botón para calcular
        JButton calculateButton = new JButton("Calcular");
        calculateButton.setFont(new Font("Arial", Font.BOLD, 14));
        calculateButton.setBackground(new Color(0, 153, 76));
        calculateButton.setForeground(Color.WHITE);
        calculateButton.setFocusPainted(false);
        calculateButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                calculateNewtonRaphson();
            }
        });
        add(calculateButton);

        // Área para mostrar resultados
        resultArea = new JTextArea();
        resultArea.setEditable(false);
        add(new JScrollPane(resultArea));

        setVisible(true);
    }

    private void calculateNewtonRaphson() {
        String function = functionInput.getText();
        double x0 = Double.parseDouble(initialGuessInput.getText());
        double tolerance = Double.parseDouble(toleranceInput.getText());

        NewtonRaphsonMethod solver = new NewtonRaphsonMethod(function, tolerance);
        solver.setOnStepListener(step -> resultArea.setText(step));

        try {
            double root = solver.solve(x0);
            resultArea.append("\nRaíz aproximada: " + root);
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Error: " + ex.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        }
    }
}
