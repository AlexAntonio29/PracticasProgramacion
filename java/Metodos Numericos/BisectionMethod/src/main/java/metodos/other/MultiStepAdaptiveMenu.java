package metodos.other;

import javax.swing.*;
import java.awt.*;

public class MultiStepAdaptiveMenu extends JFrame {
    public MultiStepAdaptiveMenu(JFrame parent) {
        super("Métodos de Pasos Múltiples y Adaptativos");
        setSize(400, 300);
        setLayout(new GridLayout(3, 1, 10, 10));
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(parent);

        // Botón para abrir el método Adams-Bashforth
        JButton adamsBashforthButton = new JButton("Método Adams-Bashforth");
        configureButton(adamsBashforthButton, e -> new AdamsBashforthCalculator(this).setVisible(true));

        // Botón para abrir el método Adams-Moulton
        JButton adamsMoultonButton = new JButton("Método Adams-Moulton");
        configureButton(adamsMoultonButton, e -> new AdamsMoultonCalculator(this).setVisible(true));

        // Botón para abrir el método Runge-Kutta-Fehlberg (RKF45)
        JButton rkfButton = new JButton("Método Runge-Kutta-Fehlberg (RKF45)");
        configureButton(rkfButton, e -> new RungeKuttaFehlbergCalculator(this).setVisible(true));

        // Agregar botones al frame
        add(adamsBashforthButton);
        add(adamsMoultonButton);
        add(rkfButton);

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
