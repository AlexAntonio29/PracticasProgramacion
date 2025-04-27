package metodos.diferenciacionNumerica;

import javax.swing.*;
import java.awt.*;

public class DifferentiationErrorsMenu extends JFrame {
    public DifferentiationErrorsMenu(JFrame parent) {
        super("Errores en la Diferenciación Numérica");
        setSize(400, 250);
        setLayout(new GridLayout(2, 1, 10, 10));
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(parent);

        // Botón para abrir el análisis de errores de redondeo
        JButton roundingErrorsButton = new JButton("Errores de Redondeo");
        configureButton(roundingErrorsButton, e -> new RoundingErrorsCalculator(this).setVisible(true));

        // Botón para abrir el análisis de errores de truncamiento
        JButton truncationErrorsButton = new JButton("Errores de Truncamiento");
        configureButton(truncationErrorsButton, e -> new TruncationErrorsCalculator(this).setVisible(true));

        // Agregar botones al frame
        add(roundingErrorsButton);
        add(truncationErrorsButton);

        // Hacer visible la ventana
        setLocationRelativeTo(null);
        setVisible(true);
    }

    private static void configureButton(JButton button, java.awt.event.ActionListener action) {
        button.setFont(new Font("Arial", Font.BOLD, 14));
        button.setBackground(new Color(0, 153, 76));
        button.setForeground(Color.WHITE);
        button.setFocusPainted(false);
        button.addActionListener(action);
    }
}
