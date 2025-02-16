import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.border.EmptyBorder;
import org.mariuszgromada.math.mxparser.Expression;

public class BisectionCalculator extends JFrame {
    private JTextField functionField, aField, bField, toleranceField;
    private JTextArea resultArea, stepsArea;

    public BisectionCalculator() {
        setTitle("Calculadora Método de Bisección");
        setSize(800, 600);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new BorderLayout());

        // Panel principal
        JPanel mainPanel = new JPanel();
        mainPanel.setLayout(new GridLayout(5, 2, 10, 10));
        mainPanel.setBorder(new EmptyBorder(20, 20, 20, 20));
        mainPanel.setBackground(new Color(60, 63, 65));

        JLabel functionLabel = new JLabel("Función (ej: x*x - 4):");
        functionLabel.setForeground(Color.WHITE);
        mainPanel.add(functionLabel);
        functionField = new JTextField();
        mainPanel.add(functionField);

        JLabel aLabel = new JLabel("Límite inferior (a):");
        aLabel.setForeground(Color.WHITE);
        mainPanel.add(aLabel);
        aField = new JTextField();
        mainPanel.add(aField);

        JLabel bLabel = new JLabel("Límite superior (b):");
        bLabel.setForeground(Color.WHITE);
        mainPanel.add(bLabel);
        bField = new JTextField();
        mainPanel.add(bField);

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

        calculateButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                new Thread(() -> calculateBisection()).start();
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
            solver.setOnStepListener(step -> SwingUtilities.invokeLater(() -> stepsArea.setText(step)));

            double root = solver.solve(a, b);

            SwingUtilities.invokeLater(() -> resultArea.setText("Raíz aproximada: " + root));
        } catch (Exception ex) {
            SwingUtilities.invokeLater(() -> resultArea.setText("Error: " + ex.getMessage()));
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> new BisectionCalculator().setVisible(true));
    }
}
