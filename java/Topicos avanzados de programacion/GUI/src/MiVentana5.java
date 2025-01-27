import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionListener;

public class MiVentana5 extends JFrame {

    public static void main(String[] args) {
        new MiVentana5();
    }

    MiVentana5() {
        super("Titulo de ventana");
        setSize(400,300);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new FlowLayout());
        Container cp = getContentPane();
        cp.add(new JLabel("Nombre"));
        JTextField texto = new JTextField(20);

        cp.add(texto);
        JButton botonSaludo = new JButton("Aceptar");
        cp.add(botonSaludo);
        setVisible(true);
        botonSaludo.addActionListener(new EventoSaludo(texto));



    }
}
