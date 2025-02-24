import javax.swing.*;
import java.awt.*;
import javax.swing.border.EmptyBorder;

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
        mainPanel.setBorder(new EmptyBorder(20, 20, 20, 20));
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

        // Agregar efecto de hover
        calculateButton.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseEntered(java.awt.event.MouseEvent evt) {
                calculateButton.setBackground(new Color(0, 123, 56));
            }

            public void mouseExited(java.awt.event.MouseEvent evt) {
                calculateButton.setBackground(new Color(0, 153, 76));
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

        // Crear un JSplitPane para dividir la ventana en dos partes
        JSplitPane splitPane = new JSplitPane(JSplitPane.HORIZONTAL_SPLIT, new JScrollPane(resultArea), new JScrollPane(stepsArea));
        splitPane.setResizeWeight(0.5); // Dividir igualmente las dos partes

        add(mainPanel, BorderLayout.NORTH);
        add(splitPane, BorderLayout.CENTER);
    }
}