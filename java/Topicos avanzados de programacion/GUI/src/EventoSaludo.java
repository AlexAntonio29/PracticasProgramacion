import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

 class EventoSaludo extends JFrame implements ActionListener {



     private JTextField cuadroTexto;

     public EventoSaludo(JTextField jt){
        this.cuadroTexto = jt;
     }
    public  void actionPerformed(ActionEvent e) {
        JOptionPane.showMessageDialog(null, "Hola "+
            cuadroTexto.getText()+"!");
    }
}
