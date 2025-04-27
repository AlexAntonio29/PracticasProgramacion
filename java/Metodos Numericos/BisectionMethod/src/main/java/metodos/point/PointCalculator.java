package metodos.point;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class PointCalculator extends JDialog {
    private JTextField functionField, initialGuessField, toleranceField;
    private JTextArea resultArea, stepsArea;

    public PointCalculator(JFrame parent) {
        super(parent, "Calculadora Método de Punto Fijo", true);
        setSize(800, 600);
        setLayout(new BorderLayout());

        // Panel principal
        JPanel mainPanel = new JPanel();
        mainPanel.setLayout(new GridLayout(4, 2, 10, 10));
        mainPanel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));
        mainPanel.setBackground(new Color(60, 63, 65));

        JLabel functionLabel = new JLabel("Función g(x):");
        functionLabel.setForeground(Color.WHITE);
        mainPanel.add(functionLabel);
        functionField = new JTextField();
        mainPanel.add(functionField);

        JLabel initialGuessLabel = new JLabel("Valor inicial x0:");
        initialGuessLabel.setForeground(Color.WHITE);
        mainPanel.add(initialGuessLabel);
        initialGuessField = new JTextField();
        mainPanel.add(initialGuessField);

        JLabel toleranceLabel = new JLabel("Tolerancia:");
        toleranceLabel.setForeground(Color.WHITE);
        mainPanel.add(toleranceLabel);
        toleranceField = new JTextField("0.0001");
        mainPanel.add(toleranceField);

        JButton calculateButton = new JButton("Calcular");
        calculateButton.setFont(new Font("Arial", Font.BOLD, 14));
        calculateButton.setBackground(new Color(0, 153, 76));
        calculateButton.setForeground(Color.WHITE);
        calculateButton.setFocusPainted(false);

        // Efecto de hover
        calculateButton.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                calculateButton.setBackground(new Color(0, 123, 56));
            }

            public void mouseExited(java.awt.event.MouseEvent evt) {
                calculateButton.setBackground(new Color(0, 153, 76));
            }
        });

        // Acción del botón
        calculateButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                calculateFixedPoint();
            }
        });

        mainPanel.add(calculateButton);

        resultArea = new JTextArea();
        resultArea.setEditable(false);
        resultArea.setBorder(BorderFactory.createTitledBorder("Resultado"));
        resultArea.setFont(new Font("Monospaced", Font.PLAIN, 14));

        stepsArea = new JTextArea();
        stepsArea.setEditable(false);
        stepsArea.setBorder(BorderFactory.createTitledBorder("Pasos de la Iteración"));
        stepsArea.setFont(new Font("Monospaced", Font.PLAIN, 14));

        JSplitPane splitPane = new JSplitPane(JSplitPane.HORIZONTAL_SPLIT, new JScrollPane(resultArea), new JScrollPane(stepsArea));
        splitPane.setResizeWeight(0.5);

        add(mainPanel, BorderLayout.NORTH);
        add(splitPane, BorderLayout.CENTER);
    }

    private void calculateFixedPoint() {
        try {
            String function = functionField.getText();
            double x0 = Double.parseDouble(initialGuessField.getText());
            double tolerance = Double.parseDouble(toleranceField.getText());

            PointMethod pointMethod = new PointMethod(function, tolerance, 100);
            pointMethod.setOnStepListener(step -> stepsArea.setText(step));

            double result = pointMethod.solve(x0);
            resultArea.setText("Raíz aproximada: " + result);
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Error en los datos ingresados: " + ex.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        }
    }
}
