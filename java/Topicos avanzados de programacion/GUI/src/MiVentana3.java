import javax.swing.*;
import java.awt.*;

public class MiVentana3 extends JFrame {

    public static void main(String[] args) {
        new MiVentana3();
    }
   public MiVentana3(){
       super ("añadir usuario");
       setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
       //panel de fecha

       JPanel panelFecha=  new JPanel();
       panelFecha.setLayout(new FlowLayout());

       panelFecha.add(new JTextField(2));
       panelFecha.add(new JLabel("/"));
       panelFecha.add(new JTextField(2));
       panelFecha.add(new JLabel("/"));
       panelFecha.add(new JTextField(2));

       //panel de control
       JPanel panelDatos =  new JPanel();
       GridLayout gl= new GridLayout(3,2,0,5);
       panelDatos.setLayout(gl);


       panelFecha.add(new JLabel("Nombre:",SwingConstants.CENTER));
       panelFecha.add(new JTextField(10));
       panelFecha.add(new JLabel("DNI:"));
       panelFecha.add(new JTextField(10));
       panelFecha.add(new JLabel("Fecha de nacimiento"));
       panelFecha.add(panelFecha);








       //panel de botones
       JPanel panelBotones = new JPanel();
       panelBotones.setLayout(new FlowLayout());
       panelBotones.add(new JButton("Aceptar"));
       panelBotones.add(new JButton("Cancelar"));

       Container cp = getContentPane();
       cp.add(panelDatos, BorderLayout.CENTER);
       cp.add(panelBotones, BorderLayout.SOUTH);

       //configuracion de la ventana
       setSize(400,200);
       setVisible(true);

   }


}
