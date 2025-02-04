import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

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
        resultado.setForeground(Color.gray);


        cp.add(resultado);

        String[] cadenaBotones={"7","8","9","+","4","5","6","-","1","2","3","x",".","0","C","/","MR","ML","X^n","√","M+","M-","="};
        for (int i = 0; i <23; i++) {
    JButton boton=new JButton();
            boton.setFont(new Font("Arial", Font.BOLD, 15));
            boton.setPreferredSize(new Dimension(50, 40)); //
            boton.setMargin(new Insets(3, 3, 3, 3));

           // boton.setFont(new Font("Arial", Font.BOLD, 20));
            boton.setForeground(Color.WHITE);
            boton.setBackground(new Color(30, 144, 255));  // Azul vibrante
            boton.setFocusPainted(false);
            boton.setBorderPainted(false);
            boton.setContentAreaFilled(false);
            boton.setOpaque(true);
           // boton.setPreferredSize(new Dimension(60, 60));

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

            cp.add(boton);




        }


    setVisible(true);


    }
}
