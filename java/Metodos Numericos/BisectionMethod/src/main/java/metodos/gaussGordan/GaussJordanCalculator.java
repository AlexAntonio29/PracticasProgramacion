package metodos.gaussGordan;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;

public class GaussJordanCalculator extends JFrame {
    private JTextArea matrixInput, resultArea;
    private JButton calculateButton;

    public GaussJordanCalculator(JFrame parent) {
        super("Método de Gauss-Jordan");
        setSize(500, 400);
        setLayout(new BorderLayout(10, 10));
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(parent);

        // Panel de entrada
        JPanel inputPanel = new JPanel(new BorderLayout(10, 10));
        matrixInput = new JTextArea(5, 30);
        matrixInput.setBorder(new EmptyBorder(5, 5, 5, 5));
        inputPanel.add(new JLabel("Ingrese la matriz aumentada (valores separados por espacios, filas con saltos de línea):"), BorderLayout.NORTH);
        inputPanel.add(new JScrollPane(matrixInput), BorderLayout.CENTER);

        add(inputPanel, BorderLayout.CENTER);

        // Botón para calcular
        calculateButton = new JButton("Resolver");
        calculateButton.setFont(new Font("Arial", Font.BOLD, 14));
        calculateButton.setBackground(new Color(0, 153, 76));
        calculateButton.setForeground(Color.WHITE);
        calculateButton.setFocusPainted(false);
        calculateButton.addActionListener(this::calculateGaussJordan);
        add(calculateButton, BorderLayout.SOUTH);

        // Área para mostrar resultados
        resultArea = new JTextArea();
        resultArea.setEditable(false);
        resultArea.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JScrollPane(resultArea), BorderLayout.NORTH);

        setVisible(true);
    }

    private void calculateGaussJordan(ActionEvent e) {
        try {
            double[][] matrix = parseMatrix(matrixInput.getText());
            GaussJordanMethod solver = new GaussJordanMethod(matrix);
            double[] solution = solver.solve();

            resultArea.setText("Pasos:\n" + solver.getSteps() + "\nSolución:\n");
            for (int i = 0; i < solution.length; i++) {
                resultArea.append(String.format("x%d = %.6f\n", i + 1, solution[i]));
            }
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Error en el formato de la matriz: " + ex.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        }
    }

    private double[][] parseMatrix(String input) throws Exception {
        String[] rows = input.split("\n");
        int size = rows.length;
        double[][] matrix = new double[size][size + 1];

        for (int i = 0; i < size; i++) {
            String[] values = rows[i].trim().split("\\s+");
            if (values.length != size + 1) {
                throw new Exception("Cada fila debe contener " + (size + 1) + " valores.");
            }
            for (int j = 0; j < values.length; j++) {
                matrix[i][j] = Double.parseDouble(values[j]);
            }
        }
        return matrix;
    }
}
