
import java.io.*;
import java.util.*;

public class TestPersona {

    static File archivo = new File("persona.txt");
    static Scanner lector = new Scanner(System.in);
    static ArrayList<Persona> listaPersona = new ArrayList<>();

    public static void main(String[] args) {

        existFile();
       /* registrarPersona();
        salir();*/

        int select;
        do {


            System.out.println("*******************MENU************************");
            System.out.println("1)Registrar Persona");
            System.out.println("2)Buscar persona");
            System.out.println("3)Eliminar Persona");
            System.out.println("4)Modificar Persona");
            System.out.println("0)Salir");

            select=lector.nextInt();

            switch (select){
                case 1:
                    registrarPersona();
                    break;
                case 2:
                    buscarPersona(0);
                    break;
                case 3:
                    eliminarPersona();
                    break;
                case 4:
                    modificarPersona();
                    break;
                case 0:
                    System.out.println("Saliendo..");
                    salir();
                    break;
            }
        }while (select!=0);


    }

    public static void registrarPersona() {
        System.out.println("id:");
        int id = lector.nextInt();
        System.out.println("nombre");
        String nombre = lector.next();
        System.out.println("apellido Paterno");
        String apellidoP = lector.next();
        ;
        System.out.println("apellido Materno:");
        String apellidoM = lector.next();
        ;
        System.out.println("Ciudad:");
        String ciudad = lector.next();
        ;

        Persona persona = new Persona(id, nombre, apellidoP, apellidoM, ciudad);
        listaPersona.add(persona);

    }

    public static void eliminarPersona(){

        buscarPersona(1);
    }


    public static void modificarPersona(){
        buscarPersona(2);
    }

    public static void buscarPersona(int n){

        System.out.println("Agrega id persona:");
        int id=lector.nextInt();
        boolean busqueda=false;
        for (Persona persona:listaPersona){

            if (id== persona.id){
                busqueda=true;
                System.out.println(persona.id);
                System.out.println(persona.nombre);
                System.out.println(persona.apellidoP);
                System.out.println(persona.apellidoM);
                System.out.println(persona.ciudad);


                if (n==1){//ir directo a eliminar
                    listaPersona.remove(persona);
                    System.out.println("Persona eliminada..");
                    break;
                }
                if (n==2) {
                    //ir a modificar
                    System.out.println("id:");
                    int id_modificar = lector.nextInt();
                    System.out.println("nombre");
                    String nombre = lector.next();
                    System.out.println("apellido Paterno");
                    String apellidoP = lector.next();
                    ;
                    System.out.println("apellido Materno:");
                    String apellidoM = lector.next();
                    ;
                    System.out.println("apellido Ciudad:");
                    String ciudad = lector.next();

                    persona.setId(id_modificar);
                    persona.setNombre(nombre);
                    persona.setApellidoP(apellidoP);
                    persona.setApellidoM(apellidoM);
                    persona.setCiudad(ciudad);
                    System.out.println("Persona Modificada");


                }


            }

        }
        if (!busqueda) System.out.println("No se encontro a la persona");






    }


    public static void existFile() {


        if (archivo.exists()) {
            readFile();
        } else {
            System.out.println("No existe el archivo");

        }


    }


    public static void readFile() {


        try {
            FileReader fr = new FileReader(archivo);//Crear el flujo hacia f
            BufferedReader br = new BufferedReader(fr);//crear la lectura del archivo
            String linea = br.readLine();
            ;//genera una lectura por salto de linea
            Persona persona=null;

            while (linea != null) {

                String[] recopilatorio = linea.split(",");
                persona = new Persona(Integer.parseInt(recopilatorio[0]), recopilatorio[1], recopilatorio[2], recopilatorio[3], recopilatorio[4]);
                /* for (int i = 0; i < 5; i++) {

                    switch (i) {
                        case 0:

                            persona.setId(Integer.parseInt(recopilatorio[0]));//agrega id
                            break;
                        case 1:

                            persona.setNombre(recopilatorio[1]);//agrega nombre
                            break;
                        case 2:

                            persona.setApellidoP(recopilatorio[2]);//agrega apellido paterno
                            break;
                        case 3:
                            persona.setApellidoM(recopilatorio[3]);//agrega apellido materno
                            break;
                        case 4:
                            persona.setCiudad(recopilatorio[4]);//agrega ciudad
                            break;
                    }
                    */
                listaPersona.add(persona);//agrega el objeto persona en la lista
                linea = br.readLine();//Salto de linea
            }
        }

        catch (IOException e) {
            System.out.println(e.getMessage());//al no acceder el archivo
        }


    }



    public static void salir(){

try {
    PrintWriter pw=new PrintWriter(new PrintWriter(archivo));

    for (Persona persona:listaPersona){
            pw.print(persona.id+",");
            pw.print(persona.nombre+",");
            pw.print(persona.apellidoP+",");
            pw.print(persona.apellidoM+",");
            pw.print(persona.ciudad);


        pw.println();
    }

    pw.close();
}catch (IOException e){
    System.out.println(e.getMessage());
}
    }


}