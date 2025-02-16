import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.script.ScriptEngine;
import javax.script.ScriptEngineManager;
import javax.script.ScriptException;

public class BisectionCalculator extends JFrame {
    private JTextField functionField, aField, bField, toleranceField;
    private JTextArea resultArea;

    public BisectionCalculator() {
        setTitle("Calculadora Método de Bisección");
        setSize(400, 300);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new GridLayout(6, 2));

        add(new JLabel("Función (ej: x*x - 4):"));
        functionField = new JTextField();
        add(functionField);

        add(new JLabel("Límite inferior (a):"));
        aField = new JTextField();
        add(aField);

        add(new JLabel("Límite superior (b):"));
        bField = new JTextField();
        add(bField);

        add(new JLabel("Tolerancia:"));
        toleranceField = new JTextField("0.0001");
        add(toleranceField);

        JButton calculateButton = new JButton("Calcular");
        add(calculateButton);

        resultArea = new JTextArea();
        resultArea.setEditable(false);
        add(new JScrollPane(resultArea));

        calculateButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                calculateBisection();
            }
        });
    }

    private void calculateBisection() {
        try {
            String function = functionField.getText();
            double a = Double.parseDouble(aField.getText());
            double b = Double.parseDouble(bField.getText());
            double tolerance = Double.parseDouble(toleranceField.getText());

            BisectionMethod solver = new BisectionMethod(function, tolerance);
            double root = solver.solve(a, b);

            resultArea.setText("Raíz aproximada: " + root);
        } catch (Exception ex) {
            resultArea.setText("Error: " + ex.getMessage());
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> new BisectionCalculator().setVisible(true));
    }
}