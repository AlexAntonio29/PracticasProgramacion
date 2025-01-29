import javax.swing.*;
import java.awt.*;

public class Ventana extends JFrame {
    public static void main(String[] args) {
        new Ventana();
    }

    public Ventana() {
        super("Ingresa Edad");

        setSize(400, 300);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container cp = getContentPane();
        cp.setLayout(new FlowLayout());
        JLabel etiqueta = new JLabel("Nombre:");
        JTextField texto = new JTextField();
        JButton boton = new JButton("Saludar");
        cp.add(etiqueta);
        cp.add(texto);
        cp.add(boton);
        setVisible(true);
    }

}
