package metodos.solucionNumericaEcuacionesDiferencialesOrdinarias;

import javax.swing.*;
import java.awt.*;

public class OrdinaryDifferentialEquationsMenu extends JFrame {
    public OrdinaryDifferentialEquationsMenu(JFrame parent) {
        super("Solución Numérica de Ecuaciones Diferenciales Ordinarias");
        setSize(400, 250);
        setLayout(new GridLayout(2, 1, 10, 10));
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(parent);

        // Botón para abrir el método de Euler
        JButton eulerButton = new JButton("Método de Euler");
        configureButton(eulerButton, e -> new EulerMethodCalculator(this).setVisible(true));

        // Botón para abrir el método de Euler Mejorado (Heun)
        JButton improvedEulerButton = new JButton("Método de Euler Mejorado (Heun)");
        configureButton(improvedEulerButton, e -> new ImprovedEulerMethodCalculator(this).setVisible(true));

        // Agregar botones al frame
        add(eulerButton);
        add(improvedEulerButton);

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
