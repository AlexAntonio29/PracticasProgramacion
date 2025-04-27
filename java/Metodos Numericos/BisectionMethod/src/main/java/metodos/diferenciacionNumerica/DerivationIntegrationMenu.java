package metodos.diferenciacionNumerica;

import javax.swing.*;
import java.awt.*;

public class DerivationIntegrationMenu extends JFrame {
    public DerivationIntegrationMenu(JFrame parent) {
        super("Derivación e Integración Numérica");
        setSize(400, 250);
        setLayout(new GridLayout(2, 1, 10, 10));
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(parent);

        // Botón para abrir el método de Derivación Numérica
        JButton derivationButton = new JButton("Métodos de Derivación Numérica");
        configureButton(derivationButton, e -> new NumericalDerivationCalculator(this).setVisible(true));

        // Botón para abrir el método de Integración Numérica
        JButton integrationButton = new JButton("Métodos de Integración Numérica");
        configureButton(integrationButton, e -> new NumericalIntegrationCalculator(this).setVisible(true));

        // Agregar botones al frame
        add(derivationButton);
        add(integrationButton);

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
