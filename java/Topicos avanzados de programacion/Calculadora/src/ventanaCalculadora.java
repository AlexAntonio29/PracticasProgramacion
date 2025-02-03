import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class ventanaCalculadora extends JFrame {


    public ventanaCalculadora() {
    super("Calculadora");
        setResizable(false);
        setSize(250,350);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new FlowLayout());
        Container cp = getContentPane();


        JTextField resultado=new JTextField(25);


        cp.add(resultado);

        String[] cadenaBotones={"7","8","9","+","4","5","6","-","1","2","3","*",".","0","C","/","MR","ML","X^n","RAIZ","M+","M-","="};
        for (int i = 0; i <23; i++) {
    JButton boton=new JButton();
            boton.setFont(new Font("Arial", Font.BOLD, 15));
            boton.setPreferredSize(new Dimension(50, 40)); //
            boton.setMargin(new Insets(3, 3, 3, 3));

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
