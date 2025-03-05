import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class main {
    public static void main(String[] args) {

        //Diseñar

        // Crear la ventana principal
        JFrame frame = new JFrame("Métodos Numéricos");
        frame.setSize(400, 200);
        frame.setLayout(new GridLayout(5, 2, 10, 10));
        frame.setBackground(new Color(60, 63, 65));
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setLayout(new GridLayout(2, 1, 10, 10));

        // Botón para abrir la calculadora de bisección
        JButton bisectionButton = new JButton("Método de Bisección");
        bisectionButton.setFont(new Font("Arial", Font.BOLD, 14));
        bisectionButton.setBackground(new Color(0, 153, 76));
        bisectionButton.setForeground(Color.WHITE);
        bisectionButton.setFocusPainted(false);
        bisectionButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                new BisectionCalculator(frame).setVisible(true);
            }
        });

        // Botón para abrir la calculadora de punto fijo (aún por implementar)
        JButton fixedPointButton = new JButton("Método de Punto Fijo");
        fixedPointButton.setFont(new Font("Arial", Font.BOLD, 14));
        fixedPointButton.setBackground(new Color(0, 153, 76));
        fixedPointButton.setForeground(Color.WHITE);
        fixedPointButton.setFocusPainted(false);
        fixedPointButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {

                new PointCalculator(frame).setVisible(true);
                //JOptionPane.showMessageDialog(frame, "Método de Punto Fijo aún no implementado", "Info", JOptionPane.INFORMATION_MESSAGE);
            }
        });

        // Agregar botones al frame
        frame.add(bisectionButton);
        frame.add(fixedPointButton);

        // Hacer visible la ventana principal
        frame.setLocationRelativeTo(null);
        frame.setVisible(true);
    }
}


