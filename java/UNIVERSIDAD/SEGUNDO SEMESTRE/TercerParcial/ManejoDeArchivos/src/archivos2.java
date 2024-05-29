import java.io.*;
public class archivos2 {
    public static void main(String[] args) {
     File f=new File("src/numeros.txt");
     try {
         FileWriter fw=new FileWriter(f,true);
         PrintWriter pw=new PrintWriter(fw);
         for (int i=1;i<=20;i++){
             pw.println(i);
             System.out.println(i);

         }


         fw.close();
     }
     catch (IOException e){
         System.out.println("Error");
     }



    }
}
