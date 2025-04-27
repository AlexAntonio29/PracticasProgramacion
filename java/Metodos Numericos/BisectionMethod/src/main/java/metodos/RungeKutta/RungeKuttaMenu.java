package metodos.RungeKutta;

import javax.swing.*;
import java.awt.*;

public class RungeKuttaMenu extends JFrame {
    public RungeKuttaMenu(JFrame parent) {
        super("Métodos de Runge-Kutta");
        setSize(400, 250);
        setLayout(new GridLayout(2, 1, 10, 10));
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(parent);

        // Botón para abrir el método de Runge-Kutta de Segundo Orden (RK2)
        JButton rk2Button = new JButton("Método Runge-Kutta Segundo Orden (RK2)");
        configureButton(rk2Button, e -> new RungeKutta2Calculator(this).setVisible(true));

        // Botón para abrir el método de Runge-Kutta de Cuarto Orden (RK4)
        JButton rk4Button = new JButton("Método Runge-Kutta Cuarto Orden (RK4)");
        configureButton(rk4Button, e -> new RungeKutta4Calculator(this).setVisible(true));

        // Agregar botones al frame
        add(rk2Button);
        add(rk4Button);

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
