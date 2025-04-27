package metodos.diferenciacionNumerica;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;

public class RoundingErrorsCalculator extends JFrame {
    private JTextField inputValue;
    private JTextArea resultArea;
    private JButton calculateButton;

    public RoundingErrorsCalculator(JFrame parent) {
        super("Errores de Redondeo");
        setSize(500, 300);
        setLayout(new BorderLayout(10, 10));
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(parent);

        // Panel de entrada
        JPanel inputPanel = new JPanel(new GridLayout(2, 2, 10, 10));

        inputValue = new JTextField();
        inputPanel.add(new JLabel("Ingrese un número real:"));
        inputPanel.add(inputValue);

        calculateButton = new JButton("Calcular Error");
        configureButton(calculateButton, this::calculateErrors);
        inputPanel.add(calculateButton);

        add(inputPanel, BorderLayout.CENTER);

        // Área para mostrar resultados
        resultArea = new JTextArea();
        resultArea.setEditable(false);
        resultArea.setBorder(new EmptyBorder(5, 5, 5, 5));
        add(new JScrollPane(resultArea), BorderLayout.SOUTH);

        setVisible(true);
    }

    private void calculateErrors(ActionEvent e) {
        try {
            double realValue = Double.parseDouble(inputValue.getText());

            float floatValue = (float) realValue;
            double absoluteError = Math.abs(realValue - floatValue);
            double relativeError = absoluteError / Math.abs(realValue);

            resultArea.setText(String.format(
                    "Valor ingresado: %.15f\n" +
                            "Representación en float: %.7f\n" +
                            "Error absoluto: %.15f\n" +
                            "Error relativo: %.15f",
                    realValue, floatValue, absoluteError, relativeError));
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Error en el formato del número: " + ex.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
        }
    }

    private static void configureButton(JButton button, java.awt.event.ActionListener action) {
        button.setFont(new Font("Arial", Font.BOLD, 14));
        button.setBackground(new Color(0, 153, 76));
        button.setForeground(Color.WHITE);
        button.setFocusPainted(false);
        button.addActionListener(action);
    }
}
