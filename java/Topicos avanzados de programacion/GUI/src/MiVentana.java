import javax.swing.*;

public class MiVentana extends JFrame {
    public static void main(String[] args) {
        new MiVentana();
    }
    public MiVentana() {
        super("Texto");
        setSize(400, 200);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);


    }
}
