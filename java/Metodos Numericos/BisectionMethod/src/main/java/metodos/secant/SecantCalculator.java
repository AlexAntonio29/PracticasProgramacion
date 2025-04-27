package metodos.secant;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class SecantCalculator extends JFrame {
    private JTextField functionInput, x0Input, x1Input, toleranceInput, maxIterationsInput;
    private JTextArea resultArea;

    public SecantCalculator(JFrame parent) {
        super("Método de la Secante");
        setSize(400, 350);
        setLayout(new GridLayout(6, 1, 10, 10));
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(parent);

        // Campo para la función
        functionInput = new JTextField();
        functionInput.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JLabel("Función f(x):"));
        add(functionInput);

        // Campo para el primer valor inicial
        x0Input = new JTextField();
        x0Input.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JLabel("Valor inicial x0:"));
        add(x0Input);

        // Campo para el segundo valor inicial
        x1Input = new JTextField();
        x1Input.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JLabel("Valor inicial x1:"));
        add(x1Input);

        // Campo para la tolerancia
        toleranceInput = new JTextField("0.0001");
        toleranceInput.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JLabel("Tolerancia:"));
        add(toleranceInput);

        // Campo para las iteraciones máximas
        maxIterationsInput = new JTextField("100");
        maxIterationsInput.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JLabel("Iteraciones máximas:"));
        add(maxIterationsInput);

        // Botón para calcular
        JButton calculateButton = new JButton("Calcular");
        calculateButton.setFont(new Font("Arial", Font.BOLD, 14));
        calculateButton.setBackground(new Color(0, 153, 76));
        calculateButton.setForeground(Color.WHITE);
        calculateButton.setFocusPainted(false);
        calculateButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                calculateSecantMethod();
            }
        });
        add(calculateButton);

        // Área para mostrar resultados
        resultArea = new JTextArea();
        resultArea.setEditable(false);
        add(new JScrollPane(resultArea));

        setVisible(true);
    }

    private void calculateSecantMethod() {
        String function = functionInput.getText();
        double x0 = Double.parseDouble(x0Input.getText());
        double x1 = Double.parseDouble(x1Input.getText());
        double tolerance = Double.parseDouble(toleranceInput.getText());
        int maxIterations = Integer.parseInt(maxIterationsInput.getText());

        SecantMethod solver = new SecantMethod(function, tolerance, maxIterations);
        solver.setOnStepListener(step -> resultArea.setText(step));

        try {
            double root = solver.solve(x0, x1);
            resultArea.append("\nRaíz aproximada: " + root);
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Error: " + ex.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        }
    }
}
