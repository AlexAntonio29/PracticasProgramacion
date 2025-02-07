import javax.swing.*;
import java.awt.*;

class OvalButton extends JButton {
    public OvalButton(String text) {
        super(text);
        setFont(new Font("Arial", Font.BOLD, 15));
        setPreferredSize(new Dimension(50, 40)); //
        setMargin(new Insets(3, 3, 3, 3));

        // boton.setFont(new Font("Arial", Font.BOLD, 20));
        setForeground(Color.WHITE);
        setBackground(new Color(30, 144, 255));  // Azul vibrante
        setFocusPainted(false);
        setBorderPainted(false);
        setContentAreaFilled(false);
        setOpaque(true);
    }

    @Override
    protected void paintComponent(Graphics g) {
        Graphics2D g2 = (Graphics2D) g;
        g2.setColor(new Color(30, 144, 255)); // Azul vibrante
        g2.fillRoundRect(0, 0, getWidth(), getHeight(), 50, 40); // Bordes redondeados

        super.paintComponent(g);
    }
}