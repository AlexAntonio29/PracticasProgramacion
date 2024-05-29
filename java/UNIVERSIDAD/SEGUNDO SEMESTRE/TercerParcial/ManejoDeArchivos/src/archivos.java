

import java.io.*;
public class archivos {

    public static void main(String[] args) {

        File f=new File("src/numeros.txt");//cargar nuevo archivo
        try{
            FileReader fr=new FileReader(f);//Crear el flujo hacia f
            BufferedReader br=new BufferedReader(fr);
            String linea= br.readLine();
            while (linea!=null){
                System.out.println(linea);//impresion de linea
                linea= br.readLine();//Salto de linea

            }
            fr.close();//cerrar el archivo
        }
        catch (IOException e){
            System.out.println(e.getMessage());//al no acceder el archivo
        }


    }
}
