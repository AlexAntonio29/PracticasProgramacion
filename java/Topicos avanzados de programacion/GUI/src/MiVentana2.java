import javax.swing.*;
import java.awt.*;

public class MiVentana2 extends JFrame {
    public static void main(String[] args) {
        new MiVentana2();
    }

    public MiVentana2() {

        super("Titulo de ventana");

        setSize(400, 200);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container cp = getContentPane();
        GridLayout gl = new GridLayout(4, 3);
        gl.setHgap(5);
        gl.setVgap(5);

        cp.setLayout(gl);
        for (int i = 1; i <= 9; i++) {

            cp.add(new Button(String.valueOf(i)));

        }
        cp.add(new JButton("*"));
        cp.add(new JButton("0"));
        cp.add(new JButton("#"));

    }
}
