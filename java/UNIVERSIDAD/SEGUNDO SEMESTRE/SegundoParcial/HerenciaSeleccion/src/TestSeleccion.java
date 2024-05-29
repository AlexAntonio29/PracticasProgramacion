import java.util.ArrayList;
import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class TestSeleccion {

    public static ArrayList<SeleccionFutbol> seleccion = new ArrayList<>();
    public static Scanner lector = new Scanner(System.in);
    public static Futbolista futbolista = new Futbolista();
    public static Masajista masajista = new Masajista();
    public static Entrenador entrenador = new Entrenador();


    public static void main(String[] args) {

        int id;
        int opc;

        do {

            System.out.println("*********************MENU*********************");
            System.out.println("1) Agregar Futbolista ");
            System.out.println("2) Agregar Entrenador");
            System.out.println("3) Agregar Masajista");
            System.out.println("4) Buscar");
            System.out.println("0)Salir");
            System.out.println("************************************************");
            opc = lector.nextInt();
            switch (opc) {
                case 1:
                    registrarFutbolista();
                    break;
                case 2:
                    registrarEntrenador();
                    break;
                case 3:
                    registrarMasajista();
                    break;
                case 4:

                    System.out.println("ID integrante");
                    id = lector.nextInt();
                    buscarIntegrante(id);
                    break;


                case 0:
                    System.out.println("Saliendo");
                    break;

            }


        } while (opc != 0);


    }

    static void registrarFutbolista() {

        int id, edad, dorsal;
        String nombre, apellidos, demarcacion;

        System.out.println("ID:");
        id = lector.nextInt();
        System.out.println("NOMBRE:");
        nombre = lector.next();
        System.out.println("APELLIDOS:");
        apellidos = lector.next();
        System.out.println("EDAD");
        edad = lector.nextInt();
        System.out.println("DORSAL:");
        dorsal = lector.nextInt();

        System.out.println("DEMARCACION:");
        demarcacion = lector.next();

        futbolista.setId(id);
        futbolista.setEdad(edad);
        futbolista.setNombre(nombre);
        futbolista.setApellidos(apellidos);
        futbolista.setDorsal(dorsal);
        futbolista.setDemarcacion(demarcacion);

        seleccion.add(futbolista);
    }

    static void registrarMasajista() {

        int id, edad;
        String nombre, apellidos, Titulacion;

        System.out.println("ID:");
        id = lector.nextInt();
        System.out.println("NOMBRE:");
        nombre = lector.next();
        System.out.println("APELLIDOS:");
        apellidos = lector.next();
        System.out.println("EDAD");
        edad = lector.nextInt();


        System.out.println("TITULACION:");
        Titulacion = lector.next();

        masajista.setId(id);
        masajista.setEdad(edad);
        masajista.setNombre(nombre);
        masajista.setApellidos(apellidos);
        masajista.setTitulacion(Titulacion);

        seleccion.add(masajista);
    }

    static void registrarEntrenador() {

        int id, edad;
        String nombre, apellidos, idFederacion;

        System.out.println("ID:");
        id = lector.nextInt();
        System.out.println("NOMBRE:");
        nombre = lector.next();
        System.out.println("APELLIDOS:");
        apellidos = lector.next();
        System.out.println("EDAD");
        edad = lector.nextInt();
        System.out.println("ifFederacion:");
        idFederacion = lector.next();


        entrenador.setId(id);
        entrenador.setEdad(edad);
        entrenador.setNombre(nombre);
        entrenador.setApellidos(apellidos);
        entrenador.setIdFederacion(idFederacion);


        seleccion.add(entrenador);
    }


    static void buscarIntegrante(int id) {

        for (SeleccionFutbol integrante : seleccion) {
            if (integrante.getId() == id)

                if (integrante instanceof Entrenador) {

                    ((Entrenador) integrante).dirigirPartido();
                    ((Entrenador) integrante).dirigirEntrenamiento();

                } else if (integrante instanceof Futbolista) {
                    ((Futbolista) integrante).jugarPartido();
                    ((Futbolista) integrante).entrenar();


                } else {
                    ((Masajista) integrante).darMasaje();
                }

        }
    }

}
