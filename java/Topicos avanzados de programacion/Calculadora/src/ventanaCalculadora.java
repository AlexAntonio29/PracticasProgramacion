import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;

public class ventanaCalculadora extends JFrame {


    public ventanaCalculadora() {
    super("Calculadora");
        setResizable(false);
        setSize(250,400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new FlowLayout());
        Container cp = getContentPane();
        cp.setBackground(new Color(33, 57, 122));


        JTextField resultado=new JTextField(25);
        resultado.setHorizontalAlignment(JTextField.RIGHT);
        resultado.setEditable(false);
        //resultado.setFont(new Font("Arial", Font.BOLD,10));
       // resultado.setEnabled(false);
        resultado.setFocusable(false);
        resultado.setPreferredSize(new Dimension(250,50));
        resultado.setBackground(Color.white);
        resultado.setForeground(Color.gray);


        cp.add(resultado);


        String[] cadenaBotones={"7","8","9","+","4","5",
                "6","-","1","2","3","x",".","0","C","/",
                "MR","ML","X^n","√","M+","M-","="};
        for (int i = 0; i <23; i++) {
   // JButton boton=new JButton();

            OvalButton boton= new OvalButton("");



            boton.setText(cadenaBotones[i]);
            if (cadenaBotones[i].equals("=")) boton.setPreferredSize(new Dimension(106, 40));
            int geti=i;
            boton.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {

                    eventoPulsado action =new eventoPulsado(cadenaBotones[geti],resultado.getText());
                    action.action();
                    resultado.setText(action.getCadenaRes());


                }
            });

            boton.addMouseListener(new java.awt.event.MouseAdapter() {
                public void mousePressed(java.awt.event.MouseEvent evt) {
                    boton.setBackground(new Color(25, 25, 112)); // Azul más oscuro al presionar
                }
                public void mouseReleased(java.awt.event.MouseEvent evt) {
                    boton.setBackground(new Color(30, 144, 255)); // Azul original al soltar
                }
            });


            cp.add(boton);




        }




    setVisible(true);


    }
}
