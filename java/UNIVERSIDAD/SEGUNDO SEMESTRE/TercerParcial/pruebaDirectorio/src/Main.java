import java.io.File;
import java.nio.channels.FileChannel;

public class Main {

    private static File dir;
    public static void main(String[] args) {

        try {
            dir = new File("archivo");
            dir.mkdir();
        }catch (Exception e){
            System.out.println(e.getMessage());
        }



    }
}