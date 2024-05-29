
import java.io.*;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Scanner;
import java.util.*;

public class TestBanco {
    /*
    para este programa se requiere crear tres archivos
    1 archivo que almacene las cuentas nominas
    1 archivo que almacene cada movimiento de cada cuenta nomina
    1 archivo que almacene la inversion de cada cuenta

    por lo tanto se debe de crear un archivo de movimiento para cada cuenta nomina y este obviamente dependera de cuenta nomina

    y el archivo de inversion sera individual de cada una, sin embargo si se desea simular un proceso real de inversion
    debemos de considerar el tiempo como prioridad por lo tanto desde el tiempo que se creo hasta donde se desea proyectar la
    inversion debe de llevar la cantidad de dinero que esta ganando el usuario de cuenta inversion.

    */
    //TestBanco
    static File listaNomina = new File("cuentaNomina.txt");
    static File listaInversion = new File("cuentaInversion.txt");
    static Scanner lector = new Scanner(System.in);
    static ArrayList<CuentaNomina> listaCuentaNomina = new ArrayList<>();
    static ArrayList<CuentaInversion> listaCuentaInversion = new ArrayList<>();


    public static void main(String[] args) {

        String select = null;
        existFile();
        //Menu

        char s;
        do {

            System.out.println("********************************MENU************************************");
            System.out.println("1)Dar de alta una cuenta Nomina");
            System.out.println("2)Dar de alta una cuenta de inversion");
            System.out.println("3)Buscar Cuenta por su numero de Cuenta");
            System.out.println("4)Listar Cuentas de Nomina");
            System.out.println("5)Listar Cuentas de inversion");
            System.out.println("0)Salir");

            select = lector.next();
            s = select.charAt(0);

            switch (select) {
                case "1":

                    altaCuentaNomina();
                    break;
                case "2":
                    altaCuentaInversion();
                    break;
                case "3":
                    buscarCuenta();
                    break;
                case "4":
                    listarNomina();
                    break;
                case "5":
                    listarInversion();
                    break;
                case "0":
                    System.out.println("Saliendo..");
                    writeFileNomina();
                    writeFileInversion();
                    break;
                default:
                    System.out.println("Dato invalido.. Intente nuevamente");

                    break;
            }


        } while (s != '0');


    }

    //METODOS COMPLEMENTARIOS
    //Rellenar Datos Clientes
    public static Cliente registroCliente() {

        String nombre, apellidos, domicilio, ciudad, telefono;
        System.out.println("Nombre Cliente:");
        nombre = esString();
        System.out.println("Apellido Cliente:");
        apellidos = esString();
        System.out.println("Domicilio Cliente:");
        domicilio = esString();
        System.out.println("ciudad Cliente:");
        ciudad = esString();
        System.out.println("telefono Cliente:");
        telefono = String.valueOf(esNumeroLong(true));

        Cliente cliente = new Cliente(nombre, apellidos, domicilio, ciudad, telefono);

        return cliente;
    }


    public static void altaCuentaNomina() {

        System.out.println("Numero Cliente (id)");
        long numeroCliente = (esNumeroLong(false));

        //Datos Cliente
        Cliente cliente = registroCliente();


        double saldo = 0;
        Date fecha = new Date();
        String fechaAlta = String.valueOf(fecha);

        CuentaNomina usuarioNomina = new CuentaNomina(numeroCliente, saldo, fechaAlta, cliente);
        listaCuentaNomina.add(usuarioNomina);

        System.out.println("Registro Cuenta Nomina Correcto");
        // CuentaNomina cn=new CuentaNomina();
        //CuentaInversion ci=new CuentaInversion();


    }

    public static void altaCuentaInversion() {
        System.out.println("El banco tiene una taza de interes del 5%");
        System.out.println("Numero Cliente (id)");
        long numeroCliente = esNumeroLong(false);
        Cliente cliente = registroCliente();

        System.out.println("Monto inicial");
        double saldo = esNumeroDouble();
        Date fecha = new Date();
        String fechaAlta = String.valueOf(fecha);

        System.out.println("Plazo:");
         int plazo =esNumeroInt();
        CuentaInversion usuarioInversion = new CuentaInversion(numeroCliente, saldo, fechaAlta, cliente, plazo, 5);
        listaCuentaInversion.add(usuarioInversion);


        System.out.println("Registro Cuenta Inversion Correcto");
        //CuentaNomina cn=new CuentaNomina();
        //CuentaInversion ci=new CuentaInversion();
    }

    public static void buscarCuenta() {


        String select = null;
        char s;
        do {

            System.out.println("Ingrese opcion Cuenta:");
            System.out.println("1)Cuenta Nomina");
            System.out.println("2)Cuenta Inversion");
            System.out.println("0)Regresar");

            select = lector.next();
            s = select.charAt(0);
            switch (select) {
                case "1":
                    cuentaNomina();
                    break;
                case "2":
                    cuentaInversion();
                    break;
                case "0":
                    System.out.println("Regresando..");
                    break;
                default:
                    System.out.println("Dato invalido.. Intente nuevamente");
                    break;
            }
        } while (s != '0');
    }

    public static void listarNomina() {
        for (CuentaNomina cuenta : listaCuentaNomina) {
            System.out.print("ID:" + cuenta.numeroCuenta + " ");
            System.out.print("Saldo:$" + cuenta.saldo + " ");
            System.out.print("FechaAlta:" + cuenta.fechaAlta + " ");
            System.out.print("Cliente: " + cuenta.cliente.getNombre() + " ");
            System.out.print(cuenta.cliente.getApellidos() + " ");
            System.out.print("Ciudad:" + cuenta.cliente.getCiudad() + " ");
            System.out.print("Domicilio:" + cuenta.cliente.getDomicilio() + " ");
            System.out.println("Telefono:" + cuenta.cliente.getTelefono() + " ");

        }

    }

    public static void listarInversion() {

        for (CuentaInversion cuenta : listaCuentaInversion) {
            System.out.print("ID:" + cuenta.numeroCuenta + " ");
            System.out.println("Plazo:" + cuenta.plazo + " ");
            System.out.print("Saldo: $" + cuenta.saldo + " ");
            System.out.print("FechaAlta: " + cuenta.fechaAlta + " ");
            System.out.print("Cliente:" + cuenta.cliente.getNombre() + " ");
            System.out.print(cuenta.cliente.getApellidos() + " ");
            System.out.print("Ciudad:" + cuenta.cliente.getCiudad() + " ");
            System.out.print("Domicilio: " + cuenta.cliente.getDomicilio() + " ");
            System.out.println("Telefono: " + cuenta.cliente.getTelefono() + " ");
        }


    }

    //SUBMENUS DE CUENTA A NOMINA E INVERSION

    public static void cuentaNomina() {

        String select = null;
        char s;
        boolean condicion = false;
        System.out.println("Ingrese ID usuario Nomina");
        long id = esNumeroLong(false);

        for (CuentaNomina cn : listaCuentaNomina) {
            if (cn.getNumeroCuenta() == id) {
                condicion = true;
                // clienteTemporal = cn;

                do {

                    System.out.println("ID:" + cn.getNumeroCuenta() + " Nombre:" + cn.cliente.getNombre() + " " + cn.cliente.getApellidos());
                    System.out.println();
                    System.out.println("Ingrese opcion de Nomina:");
                    System.out.println("1)Depositar");
                    System.out.println("2)Retirar");
                    System.out.println("3)Consultar Saldo");
                    System.out.println("4)Imprimir Movimientos");
                    System.out.println("0)Regresar");
                    select = lector.next();
                    s=select.charAt(0);
                    switch (select) {
                        case "1":
                            cn.saldo = depositar(cn);
                            break;
                        case "2":
                            cn.saldo = retirar(cn);
                            break;
                        case "3":
                            consultarSaldo(cn);
                            break;
                        case "4":
                            imprimirMovimientos(cn);
                            break;
                        case "0":
                            System.out.println("Regresando..");
                            break;
                        default:
                            System.out.println("Dato invalido.. Intente nuevamente");
                            break;

                    }
                } while (s!= '0');


                break;

            }

        }


        if (!condicion)
            System.out.println("No se encontro la cuenta");

    }

    public static void cuentaInversion() {
//proyectar inversion


        System.out.println("Ingrese ID usuario Inversion");
        long id = esNumeroLong(false);
        boolean select = false;

        for (CuentaInversion cn : listaCuentaInversion) {
            if (cn.getNumeroCuenta() == id) {
                System.out.println("ID:" + cn.getNumeroCuenta() + " Nombre:" + cn.cliente.getNombre() + " " + cn.cliente.getApellidos());
                cn.proyectarInversion();
                select = true;
                break;


            }

        }

        if (!select) System.out.println("El Usuario no se encuentra registrado");


    }

    //SUBMENU DE CUENTA NOMINA

    public static double depositar(CuentaNomina cliente) {
        System.out.println("Cantidad a depositar:");
        double monto = esNumeroDouble();
        return cliente.depositar(monto);

    }

    public static double retirar(CuentaNomina cliente) {
        System.out.println("Cantidad a Retirar:");
        double monto = esNumeroDouble();
        return cliente.retirar(monto);
    }

    public static void consultarSaldo(CuentaNomina cliente) {
        System.out.println("Datos Cuenta:");
        System.out.print(cliente.getCliente().getNombre() + " ");
        System.out.print(cliente.getCliente().getApellidos() + " ");
        System.out.println("Saldo Disponible: $" + cliente.saldo);
    }

    public static void imprimirMovimientos(CuentaNomina cliente) {

        ArrayList<Movimientos> movimientos = cliente.getListaMovimeinto();

        for (Movimientos movimiento : movimientos) {
            System.out.print("Tipo:" + movimiento.getTipo() + " ");
            System.out.print("Fecha:" + movimiento.getFecha() + " ");
            System.out.print("Monto:" + movimiento.getMonto() + " ");
            System.out.print("Saldo Anterior:" + movimiento.getSaldoAnterior() + " ");
            System.out.println("Saldo Actual:" + movimiento.getSaldoActual());
        }

    }


    //Existencia y uso de archivos .txt

    public static void existFile() {

        if (listaNomina.exists()) readFileNomina();
        if (listaInversion.exists()) readFileInversion();


    }


    //uso del readFile para invocar los datos para cada Arraylist
    public static void readFileNomina() {

//Primero
        try {
            FileReader fr = new FileReader(listaNomina);//Crear el flujo hacia f
            BufferedReader br = new BufferedReader(fr);//crear la lectura del archivo
            String linea = br.readLine();//genera una lectura por salto de linea


            while (linea != null) {
                //leemos los datos del archivo y se los pasamos al arrayList de acuerdo a cada objeto
                String[] recopilatorio = linea.split(",");
                long id = Long.parseLong(recopilatorio[0]);
                double saldo = Double.parseDouble(recopilatorio[1]);
                String fechaAlta = recopilatorio[2];
                String nombre = recopilatorio[3], apellido = recopilatorio[4], domicilio = recopilatorio[5],
                        ciudad = recopilatorio[6], telefono = recopilatorio[7];
                Cliente cliente = new Cliente(nombre, apellido, domicilio, ciudad, telefono);


                CuentaNomina cuentaNomina = new CuentaNomina(id, saldo, fechaAlta, cliente);

                cuentaNomina.setListaMovimeinto(readFileMovimiento(cuentaNomina));

                listaCuentaNomina.add(cuentaNomina);//agrega el objeto persona en la lista


                linea = br.readLine();//Salto de linea

            }

        } catch (IOException e) {
            System.out.println(e.getMessage());//al no acceder el archivo
        }


    }

//se crea un metodo para verificar la existencia de movimientos

    static public ArrayList<Movimientos> readFileMovimiento(CuentaNomina cuentaNomina) {
        ArrayList<Movimientos> listaMovimientoTemporal = new ArrayList<>();

        File movimiento = new File(String.valueOf(cuentaNomina.getNumeroCuenta()) + ".txt");

        if (movimiento.exists()) {
            try {
                FileReader fr = new FileReader(movimiento);//Crear el flujo hacia f
                BufferedReader br = new BufferedReader(fr);//crear la lectura del archivo
                String linea = br.readLine();//genera una lectura por salto de linea


                while (linea != null) {


                    String[] recopilatorio = linea.split(",");
                    String tipo = recopilatorio[0];
                    String fecha = recopilatorio[1];
                    double monto = Double.parseDouble(recopilatorio[2]);
                    double saldoAnterior = Double.parseDouble(recopilatorio[3]);
                    double saldoActual = Double.parseDouble(recopilatorio[4]);

                    Movimientos movimientos = new Movimientos(tipo, fecha, monto, saldoAnterior, saldoActual);

                    listaMovimientoTemporal.add(movimientos);//agrega el objeto persona en la lista


                    linea = br.readLine();//Salto de linea

                }

            } catch (IOException e) {
                System.out.println(e.getMessage());//al no acceder el archivo
            }


        }

        return listaMovimientoTemporal;

    }


    public static void readFileInversion() {

        try {
            FileReader fr = new FileReader(listaInversion);//Crear el flujo hacia f
            BufferedReader br = new BufferedReader(fr);//crear la lectura del archivo
            String linea = br.readLine();//genera una lectura por salto de linea


            while (linea != null) {
                //leemos los datos del archivo y se los pasamos al arrayList de acuerdo a cada objeto
                String[] recopilatorio = linea.split(",");
                long id = Long.parseLong(recopilatorio[0]);
                double saldo = Double.parseDouble(recopilatorio[1]);
                String fechaAlta = recopilatorio[2];
                String nombre = recopilatorio[3], apellido = recopilatorio[4], domicilio = recopilatorio[5],
                        ciudad = recopilatorio[6], telefono = recopilatorio[7];
                int interes = Integer.parseInt(recopilatorio[8]), plazo = Integer.parseInt(recopilatorio[9]);

                Cliente cliente = new Cliente(nombre, apellido, domicilio, ciudad, telefono);



                /*
                *
                * Cliente cliente= new Cliente();
                *
                * cliente.setNombre(nombre);
                * cliente.setApelliddo(apellido);
                * cliente.setDomiciolio(domicilio);
                * cliente.setCiudad(ciudad);
                * cliente.setTelefono(telefono);
                *
                * CuentaInversion ci=new CuentaInversion();
                * ci.setId(recopilatorio[0]);
                * ci.setFechaAlta(recopilatorio[1]);
                * ci.setSaldo(saldo);
                * ci.setInteres(interes);
                * ci.setCliente(cliente);
                *
                * listaCuentaInversion.add(ci);
                *
                *
                *
                * */

                CuentaInversion cuentaInversion = new CuentaInversion(id, saldo, fechaAlta, cliente, plazo, interes);


                listaCuentaInversion.add(cuentaInversion);//agrega el objeto persona en la lista


                linea = br.readLine();//Salto de linea

            }

        } catch (IOException e) {
            System.out.println(e.getMessage());//al no acceder el archivo
        }

    }


    public static void writeFileNomina() {
        try {
            PrintWriter pw = new PrintWriter(new PrintWriter(listaNomina));

            for (CuentaNomina cuenta : listaCuentaNomina) {

                pw.print(cuenta.numeroCuenta + ",");
                pw.print(cuenta.saldo + ",");
                pw.print(cuenta.fechaAlta + ",");
                pw.print(cuenta.cliente.nombre + ",");
                pw.print(cuenta.cliente.apellidos + ",");
                pw.print(cuenta.cliente.domicilio + ",");
                pw.print(cuenta.cliente.ciudad + ",");
                pw.print(cuenta.cliente.telefono);


                pw.println();
            }

            pw.close();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }

    public static void writeFileInversion() {
        try {
            PrintWriter pw = new PrintWriter(new PrintWriter(listaInversion));

            for (CuentaInversion cuenta : listaCuentaInversion) {
                pw.print(cuenta.numeroCuenta + ",");
                pw.print(cuenta.saldo + ",");
                pw.print(cuenta.fechaAlta + ",");
                pw.print(cuenta.cliente.nombre + ",");
                pw.print(cuenta.cliente.apellidos + ",");
                pw.print(cuenta.cliente.domicilio + ",");
                pw.print(cuenta.cliente.ciudad + ",");
                pw.print(cuenta.cliente.telefono + ",");
                pw.print(cuenta.plazo + ",");
                pw.print(cuenta.interes);


                pw.println();
            }

            pw.close();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }

    public static double esNumeroDouble() {
        double n = 0;
        boolean condicion = true;
        while (condicion) {


            try {

                n = lector.nextDouble();

                condicion = false;

                return n;
            } catch (InputMismatchException e) {
                System.out.println("Error al ingresar el numero..intente nuevamente");
                lector.nextLine();
            }
        }
        return n;
    }

    public static long esNumeroLong(boolean esTelefono) {
        long n = 0;
        boolean condicion = true;
        while (condicion) {


            try {
                n = lector.nextLong();

                if (esTelefono) {
                    if (String.valueOf(n).length() != 10)
                        throw new RuntimeException();
                }
                condicion = false;
                return n;
            } catch (InputMismatchException e) {
                System.out.println("Error al ingresar el numero..intente nuevamente");
                lector.nextLine();
            } catch (RuntimeException e) {
                System.out.println("Error al ingresar numero telefonico..intente nuevamente");
                lector.nextLine();
            }
        }
        return n;
    }

    public static String esString() {
        String n = null;
        boolean condicion = true;
        while (condicion) {


            n = lector.next();

            for (int i = 0; i < n.length(); i++) {
                char letra = n.charAt(i);
                if (esNumero(letra)) {
                    System.out.println("La informacion no debe de llevar numeros..Intente nuevamente");
                    condicion = true;
                    break;
                } else condicion = false;
            }
            lector.nextLine();
        }
        return n;
    }


    public static boolean esNumero(char str) {

        try {
            Double.parseDouble(String.valueOf((str)));
            return true;
        } catch (NumberFormatException e) {
            return false;
        }
    }

    public static int esNumeroInt() {
        int n = 0;
        boolean condicion = true;
        while (condicion) {


            try {

                n = lector.nextInt();

                condicion = false;

                return n;
            } catch (InputMismatchException e) {
                System.out.println("Error al ingresar el numero..intente nuevamente");
                lector.nextLine();
            }
        }
        return n;
    }



}



