import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class BotonVentana extends JFrame {

    public static void main(String[] args) {
        new BotonVentana();
    }

    public BotonVentana() {
        super("Boton");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container cp= getContentPane();
        cp.setLayout(new FlowLayout());
        JButton boton = new JButton("Push");
        boton.addActionListener(new EventoBotonPulsado());
        cp.add(boton);


setVisible(true);
    }




}
