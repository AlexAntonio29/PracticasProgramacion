import java.io.*;
import java.util.InputMismatchException;
import java.util.Scanner;
import java.util.*;

import java.util.ArrayList;
//s

public class TestFactura {
    public static Scanner scanner = new Scanner(System.in);
    public static File archivoClientes = new File("clientes.txt");
    public static File archivoProductos = new File("productos.txt");
    public static File archivoVendedores = new File("vendedores.txt");


    public static ArrayList<Cliente> clientes = new ArrayList<>();

    public static ArrayList<Vendedor> vendedores = new ArrayList<>();
    public static ArrayList<Productos> productos = new ArrayList<>();

    public static void main(String[] args) {
        int op;


        existFile();


        do {
            System.out.println("Menu:");
            System.out.print("Selecciona una opcion:");
            System.out.println();
            System.out.println("1. Dar de alta un cliente");
            System.out.println("2. Dar de alta un vendedor");
            System.out.println("3. Dar de alta un producto");
            System.out.println("4. Realizar venta");
            System.out.println("5. Listar facturas");
            System.out.println("6. Buscar vendedor");
            System.out.println("0. Salir");
            op = esInt();
            switch (op) {
                case 1:
                    darAltaCliente();
                    break;
                case 2:
                    darAltaVendedor();
                    break;
                case 3:
                    darAltaProducto();
                    break;
                case 4:
                    realizarVenta();

                    break;

                case 5:
                    listarFacturaDeterminadosCliente();
                    break;

                case 6:
                    BuscarVendedor();
                    break;
                case 0:
                    System.out.println("Saliendo");
                    writeFileClientes();
                    break;
                default:
                    System.out.println("Opción inválida. Por favor, ingresa una opción válida.");
            }
        } while (op != 0);
    }

    //METODOS A EVALUAR
    private static void darAltaCliente() {
        boolean clienteExistente;

        clienteExistente = false;

        System.out.println("Dar de alta Cliente");
        System.out.print("RFC: ");

        String rfc = RFCValidation();
        for (Cliente cliente : clientes)
            if ((Objects.equals(cliente.getRfc(), rfc))) {
                clienteExistente = true;
                System.out.println("El Cliente ya ha sido registrado");
                break;
            }

        if (!clienteExistente) {
            System.out.print("Ingrese su domicilio: ");
            String domicilio = scanner.next();
            System.out.println("Ingrese su nombre");
            String nombre = scanner.next();
            System.out.println("Ingrese su apellido Paterno");
            String apellidoPaterno = scanner.next();
            System.out.println("Ingrese su apellido Materno");
            String apellidoMaterno = scanner.next();
            System.out.println("Ingrese su fecha De Nacimiento");
            System.out.println("Ingrese el dia");
            int dia = esDia();
            System.out.println("Ingrese el mes");
            int mes = esMes();
            System.out.println("Ingrese el anio");
            int anio = esAnio(true);
            Fecha fechaDeNacimiento = new Fecha(dia, mes, anio);


            Cliente cliente = new Cliente(nombre, apellidoPaterno, apellidoMaterno, fechaDeNacimiento, rfc, domicilio);
            clientes.add(cliente);
            writeFileClientes();
            System.out.println("Cliente registrado correctamente");
        }


    }

    private static void darAltaVendedor() {
        boolean vendedorExistente;

        vendedorExistente = false;

        System.out.println("Dar de alta Vendedor");
        System.out.print("Ingrese su numero de id: ");
        int id = esInt();


        for (Vendedor vendedor : vendedores)
            if (Objects.equals(vendedor.getId(), id)) {
                vendedorExistente = true;
                System.out.println("El Vendedor ya ha sido registrado");
                break;
            }

        if (!vendedorExistente) {
            System.out.print("Ingrese su area: ");
            String area = scanner.next();
            System.out.print("Ingrese su comision: ");
            int porsentajeComision = esInt();
            System.out.print("Ingrese su sueldo base: ");
            int sueldoBase = esInt();
            System.out.println("Ingrese su nombre");
            String nombre = scanner.next();
            System.out.println("Ingrese su apellido Paterno");
            String apellidoPaterno = scanner.next();
            System.out.println("Ingrese su apellido Materno");
            String apellidoMaterno = scanner.next();
            System.out.println("Ingrese su fecha De Nacimiento");
            System.out.println("Ingrese el dia");
            int dia = esDia();
            System.out.println("Ingrese el mes");
            int mes = esMes();
            System.out.println("Ingrese el año");
            int anio = esAnio(true);
            Fecha fechaDeNacimiento = new Fecha(dia, mes, anio);


            Vendedor vendedor = new Vendedor(nombre, apellidoPaterno, apellidoMaterno, fechaDeNacimiento, id, area, porsentajeComision, sueldoBase);
            vendedores.add(vendedor);
            writeFileVendedor();
            System.out.println("Vendedor registrado correctamente");

        }

    }

    private static void darAltaProducto() {
        boolean productoExistente;

        productoExistente = false;

        System.out.println("Dar de alta Producto");
        System.out.print("Ingrese su numero de id: ");
        int id = esInt();


        for (Productos productos1 : productos)
            if (Objects.equals(productos1.getId(), id)) {
                productoExistente = true;
                System.out.println("El Producto ya ha sido registrado");
                break;
            }

        if (!productoExistente) {
            System.out.print("Ingrese su descripcion: ");
            String descripcion = scanner.next();
            System.out.print("Ingrese el precio del producto: ");
            float precio = esNumeroFlotante();
            Productos producto = new Productos(id, descripcion, precio);
            productos.add(producto);
            writeFileProductos();
            System.out.println("El producto ha sido registrado correctamente");

        }

    }

    public static void realizarVenta() {

        boolean rfcValidation;




            rfcValidation = true;
            System.out.println("Ingrese el id del cliente (rfc)");
            String rfc = RFCValidation();

            for (Cliente c : clientes) {

                if (Objects.equals(String.valueOf(c.getRfc()), String.valueOf(rfc))) {


                    rfcValidation = false;

                    c.comprar();
                }
            }
            if (rfcValidation) {
                System.out.println("No se encontro cliente..");
            }





    }

    public static void listarFacturaDeterminadosCliente() {
        boolean rfcValidation;
        Cliente cliente = new Cliente();
        Factura factura = new Factura();
        do {

            rfcValidation = true;
            System.out.println("Ingrese el id del cliente (rfc)");
            String rfc = scanner.next();
            scanner.nextLine();
            for (Cliente c : clientes) {
                if (Objects.equals(c.getRfc(), rfc)) {
                    rfcValidation = false;
                    cliente = c;
                }
            }
            if (rfcValidation) {
                System.out.println("No se encontro cliente..intente nuevamente");
            }
        } while (rfcValidation);


        for (Factura f : cliente.getCompras()) {

            System.out.print("id: " + f.getId() + " ");
            System.out.print("fecha: " + f.getFechaFactura().getDia() +
                    "/" + f.getFechaFactura().getMes() + "/" +
                    f.getFechaFactura().getAnio() + " ");
            System.out.print("Subtotal: " + f.getSubTotal() + " ");
            System.out.print("Total: " + f.getTotal() + " ");
            System.out.print("Vendedor: " + f.getVendedor(false).getId() + " ");
            System.out.print(f.getVendedor(false).getNombre());
            System.out.println();

            System.out.println(f.getProductos().size());
            for (Productos p : f.getProductos()) {
                System.out.println(p.getId() + " " + p.getDescripcion() + " " + p.getPrecio());
            }


        }


    }

    public static void BuscarVendedor() {

        boolean idVendedorValidation;
        Vendedor vendedor = new Vendedor();

        do {

            idVendedorValidation = true;
            System.out.println("Ingrese el id del vendedor");
            int idVendedor = esInt();

            for (Vendedor v : vendedores) {
                if (v.getId() == idVendedor) {
                    idVendedorValidation = false;
                    vendedor = v;
                }
            }
            if (idVendedorValidation) {
                System.out.println("No se encontro vendedor..intente nuevamente");
            }
        } while (idVendedorValidation);
        float comisionTotal=0;
        float sueldoTotal=0;
        for (Cliente c : clientes) {

            for (Factura f : c.getCompras()) {
                if (vendedor.getId() == f.getVendedor(false).getId()) {

                    System.out.println("IDFacturas:" + f.getId());
                    System.out.print(f.getVendedor(false).getId() + " Vendedor: " + vendedor.getNombre() + " sueldo" + vendedor.getSueldoBase() + " " +
                            f.getIva() + " " + f.getFechaFactura().getDia() + "/" + f.getFechaFactura().getMes() + "/" + f.getFechaFactura().getAnio() + " ");
                    float comision=vendedor.getPorcentajeComision()*.01f;
                    comisionTotal+= (float) (comision*f.getTotal());

                    for (Productos p : f.getProductos()) {

                        System.out.println(p.getId() + " " + p.getDescripcion() + " " + p.getPrecio());
                    }


                    System.out.println();
                }




                System.out.println();
            }
            }
        float sueldoT=vendedor.getSueldoBase()+comisionTotal;
        System.out.println("Comision por ventas: " + comisionTotal);
        System.out.println("Sueldo Total: " +sueldoT);



    }

    //USO DE EXCEPCIONES
    public static int esInt() {
        Scanner lector = new Scanner(System.in);
        int n = 0;
        boolean condicion = true;
        while (condicion) {


            try {

                n = lector.nextInt();

                condicion = false;

                return n;
            } catch (InputMismatchException e) {
                System.out.println("Error al ingresar el numero");
                System.out.println("Intente de nuevo");
                System.out.println("Un numero entero");
                lector.nextLine();
            }
        }
        return n;
    }

    public static int esDia() {
        /*
        * if (dia <= 0 || dia > 31) {
            throw new IllegalArgumentException("El día debe estar entre 1 y 31");
        }
        * */
        Scanner lector = new Scanner(System.in);
        int n = 0;
        boolean condicion = true;
        while (condicion) {


            try {

                n = lector.nextInt();
                if (n <= 0 || n > 31) {
                    throw new IllegalArgumentException();
                }

                condicion = false;

                return n;
            } catch (InputMismatchException e) {
                System.out.println("Error al ingresar el numero");
                System.out.println("Intente de nuevo");
                System.out.println("Un numero entero");
                lector.nextLine();
            } catch (IllegalArgumentException e) {
                System.out.println("El día debe estar entre 1 y 31");
            }

        }


        return n;
    }

    public static int esMes() {
        /*
        * if (dia <= 0 || dia > 31) {
            throw new IllegalArgumentException("El día debe estar entre 1 y 31");
        }
        * */
        Scanner lector = new Scanner(System.in);
        int n = 0;
        boolean condicion = true;
        while (condicion) {


            try {

                n = lector.nextInt();
                if (n <= 0 || n > 12) {
                    throw new IllegalArgumentException();
                }

                condicion = false;

                return n;
            } catch (InputMismatchException e) {
                System.out.println("Error al ingresar el numero");
                System.out.println("Intente de nuevo");
                System.out.println("Un numero entero");
                lector.nextLine();
            } catch (IllegalArgumentException e) {
                System.out.println(("El día debe estar entre 1 y 12"));
            }

        }


        return n;
    }

    public static int esAnio(boolean verificacion) {
        /*
        * if (dia <= 0 || dia > 31) {
            throw new IllegalArgumentException("El día debe estar entre 1 y 31");
        }
        * */
        Scanner lector = new Scanner(System.in);
        int n = 0;
        boolean condicion = true;
        while (condicion) {


            try {

                n = lector.nextInt();
                if (n <= 1900 || n > 2024) {
                    throw new IllegalArgumentException();
                }
                if (verificacion){
                    if(n <= 1900 || n > 2006) {
                        throw new RuntimeException();
                    }
                }

                condicion = false;

                return n;
            } catch (InputMismatchException e) {
                System.out.println("Error al ingresar el numero");
                System.out.println("Intente de nuevo");
                System.out.println("Un numero entero");
                lector.nextLine();
            } catch (IllegalArgumentException e) {
                System.out.println("El anio debe de ser logico o es menor de edad");
            }catch (RuntimeException e) {
                System.out.println("Es Menor de edad");
            }

        }


        return n;
    }

    public static float esNumeroFlotante() {
        Scanner lector = new Scanner(System.in);
        float n = 0;
        boolean condicion = true;
        while (condicion) {


            try {

                n = lector.nextFloat();

                condicion = false;

                return n;
            } catch (InputMismatchException e) {
                System.out.println("Error al ingresar el numero..intente nuevamente");
                lector.nextLine();
            }
        }
        return n;
    }

    private static String RFCValidation() {
        boolean opc = true;
        do {
            try {

                String rfc = scanner.next();
                scanner.nextLine();
                if (rfc.length() != 13) {
                    throw new Exception("El RFC debe tener exactamente 13 dígitos");

                } else {

                    if (!esRFCValidacion(rfc))
                        throw new Exception("Dato de RFC incorrecto Formato = S)letra 0)numero -> SSSS000000SS0");


                    System.out.println("El RFC es válido");
                    opc = false;
                    return rfc;
                }

            } catch (Exception e) {
                System.out.println(e.getMessage());
                //scanner.nextLine();
            }

        } while (opc);
        return null;

    }

    public static boolean esRFCValidacion(String n) {

        for (int i = 0; i < 4; i++) {

            char c = n.charAt(i);
            if (esNumero(c))
                return false;//asdf123456up1

        }
        for (int i = 4; i < 10; i++) {
            char c = n.charAt(i);
            if (!esNumero(c))
                return false;
        }
        for (int i = 10; i < 12; i++) {
            char c = n.charAt(i);
            if (esNumero(c))
                return false;
        }
        for (int i = 12; i < 13; i++) {
            char c = n.charAt(i);
            if (!esNumero(c))
                return false;


        }
        return true;

    }

    public static boolean esNumero(char str) {

        try {
            Double.parseDouble(String.valueOf((str)));
            return true;
        } catch (NumberFormatException e) {
            return false;
        }
    }

    //EXISTENCIA DE ARCHIVOS
    public static void existFile() {

        if (archivoClientes.exists()) readFileCliente();
        if (archivoProductos.exists()) readFileProductos();
        if (archivoVendedores.exists()) readFileVendedores();


    }

    //LEER ARCHIVOS
    public static void readFileVendedores() {
        try {
            FileReader fr = new FileReader(archivoVendedores);//Crear el flujo hacia f
            BufferedReader br = new BufferedReader(fr);//crear la lectura del archivo
            String linea = br.readLine();//genera una lectura por salto de linea


            while (linea != null) {
                //leemos los datos del archivo y se los pasamos al arrayList de acuerdo a cada objeto
                String[] recopilatorio = linea.split(",");


                String nombre = recopilatorio[0];
                String apellidoPaterno = recopilatorio[1];
                String apellidoMaterno = recopilatorio[2];
                int dia = Integer.parseInt(recopilatorio[3]);
                int mes = Integer.parseInt(recopilatorio[4]);
                int anio = Integer.parseInt(recopilatorio[5]);
                Fecha fechaAlta = new Fecha(dia, mes, anio);
                int id = Integer.parseInt(recopilatorio[6]);
                String area = recopilatorio[7];
                float porcentaje = Float.parseFloat(recopilatorio[8]);
                int sueldoBase = Integer.parseInt(recopilatorio[9]);


                vendedores.add(new Vendedor(nombre, apellidoPaterno, apellidoMaterno, fechaAlta, id, area, porcentaje, sueldoBase));
                linea = br.readLine();//Salto de linea

            }

        } catch (IOException e) {
            System.out.println(e.getMessage());//al no acceder el archivo
        }
    }

    public static void readFileProductos() {
        try {
            FileReader fr = new FileReader(archivoProductos);//Crear el flujo hacia f
            BufferedReader br = new BufferedReader(fr);//crear la lectura del archivo
            String linea = br.readLine();//genera una lectura por salto de linea


            while (linea != null) {
                //leemos los datos del archivo y se los pasamos al arrayList de acuerdo a cada objeto
                String[] recopilatorio = linea.split(",");


                int id = Integer.parseInt(recopilatorio[0]);
                String descripcion = recopilatorio[1];
                float precio = Float.parseFloat(recopilatorio[2]);

                productos.add(new Productos(id, descripcion, precio));

                linea = br.readLine();//Salto de linea

            }

        } catch (IOException e) {
            System.out.println(e.getMessage());//al no acceder el archivo
        }

    }

    public static void readFileCliente() {


        try {
            FileReader fr = new FileReader(archivoClientes);//Crear el flujo hacia f
            BufferedReader br = new BufferedReader(fr);//crear la lectura del archivo
            String linea = br.readLine();//genera una lectura por salto de linea


            while (linea != null) {
                //leemos los datos del archivo y se los pasamos al arrayList de acuerdo a cada objeto
                String[] recopilatorio = linea.split(",");


                String nombre = recopilatorio[0];
                String apellidoPaterno = recopilatorio[1];
                String apellidoMaterno = recopilatorio[2];
                int dia = Integer.parseInt(recopilatorio[3]);
                int mes = Integer.parseInt(recopilatorio[4]);
                int anio = Integer.parseInt(recopilatorio[5]);
                Fecha fechaAlta = new Fecha(dia, mes, anio);
                String rfc = recopilatorio[6];
                String domicilio = recopilatorio[7];



                Cliente cliente = new Cliente();

                cliente.setNombre(nombre);
                cliente.setApellidoPaterno(apellidoPaterno);
                cliente.setApellidoMaterno(apellidoMaterno);
                cliente.setFechaNacimiento(fechaAlta);
                cliente.setRfc(rfc);
                cliente.setDomicilio(domicilio);
                ArrayList<Factura> compras = new ArrayList<>();

                int cantidadFacturas=contadorArchivos(rfc);

                for (int i = 0; i < cantidadFacturas; i++) {
                    Factura factura = (readFileFacturas(rfc, i));
                    compras.add(factura);

                }


                cliente.setCompras(compras);


                clientes.add(cliente);


                linea = br.readLine();//Salto de linea

            }

        } catch (IOException e) {
            System.out.println(e.getMessage());//al no acceder el archivo
        }


    }

    //subArrays
    public static int contadorArchivos (String rfcCliente){




        File dir = null;
        try {
            dir = new File("Factura");
            if (!dir.exists())
            dir.mkdir();
        }catch (Exception e){
            System.out.println(e.getMessage());
        }
        File dir2=null;
        try {
            dir2 = new File(dir+"/"+rfcCliente+"/");
            if (!dir2.exists())
            dir2.mkdir();
        }catch (Exception e){
            System.out.println(e.getMessage());
        }


        File f=new File(String.valueOf(dir2));




        if (f.exists() && f.isDirectory()) {
            // Obtener la lista de archivos en la carpeta
            File[] archivos = f.listFiles();

            // Contar la cantidad de archivos en la carpeta
            int cantidadArchivos = 0;
            if (archivos != null) {
                for (File archivo : archivos) {
                    if (archivo.isFile()) {
                        cantidadArchivos++;
                    }
                }
                return cantidadArchivos;
            }
        }


        return 0;
    }

    public static Factura readFileFacturas(String rfcCliente, int idFactura) {
        Factura factura = new Factura();



        File dir = null;
        try {
            dir = new File("Factura");

            if (!dir.exists())
                dir.mkdir();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        File dir2 = null;
        try {
            dir2 = new File(dir + "/" + rfcCliente);
            if (!dir2.exists())
                dir2.mkdir();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }


        File f = new File(dir2 + "/" + rfcCliente + idFactura + ".txt");

        if (f.exists() && f.isDirectory()) {

            File[] archivos = f.listFiles();

            int cantidadArchivos = 0;
            if (archivos != null) {
                for (File archivo : archivos) {
                    if (archivo.isFile()) {
                        cantidadArchivos++;
                    }
                }
            }
        }


        try {

            FileReader fr = new FileReader(f);//Crear el flujo hacia f
            BufferedReader br = new BufferedReader(fr);//crear la lectura del archivo
            String linea = br.readLine();//genera una lectura por salto de linea


            while (linea != null) {
                //leemos los datos del archivo y se los pasamos al arrayList de acuerdo a cada objeto
                String[] recopilatorio = linea.split(",");


                int id = Integer.parseInt(recopilatorio[0]);
                int dia = Integer.parseInt(recopilatorio[1]);
                int mes = Integer.parseInt(recopilatorio[2]);
                int anio = Integer.parseInt(recopilatorio[3]);
                Fecha fechaAlta = new Fecha(dia, mes, anio);

                float subTotal = Float.parseFloat(recopilatorio[4]);
                float iva = Float.parseFloat(recopilatorio[5]);
                float total = Float.parseFloat(recopilatorio[6]);


                String nombre = recopilatorio[7];
                String apellidoPaterno = recopilatorio[8];
                String apellidoMaterno = recopilatorio[9];
                int diaV = Integer.parseInt(recopilatorio[10]);
                int mesV = Integer.parseInt(recopilatorio[11]);
                int anioV = Integer.parseInt(recopilatorio[12]);
                Fecha fechaAltaV = new Fecha(diaV, mesV, anioV);
                int idV = Integer.parseInt(recopilatorio[13]);
                String area = recopilatorio[14];
                Float porcentaje = Float.parseFloat(recopilatorio[15]);
                int sueldoBase = Integer.parseInt(recopilatorio[16]);
                Vendedor v = new Vendedor(nombre, apellidoPaterno, apellidoMaterno, fechaAltaV, idV, area, porcentaje, sueldoBase);


                linea = br.readLine();//Salto de linea
                ArrayList<Productos> p = new ArrayList<>();
                while (linea != null) {
                    String[] recopilatorio2 = linea.split(",");
                    int idProducto = Integer.parseInt(recopilatorio2[0]);
                    String descripcion = recopilatorio2[1];
                    float precio = Float.parseFloat(recopilatorio2[2]);
                    p.add(new Productos(idProducto, descripcion, precio));


                    linea = br.readLine();//Salto de linea


                }


                factura.setId(id);
                factura.setFechaFactura(fechaAlta);
                factura.setSubTotal(subTotal);
                factura.setIva(iva);
                factura.setTotal(total);
                factura.setProductos(p);
                factura.setVendedor(v);


            }

            return factura;
        } catch (IOException e) {
            System.out.println(e.getMessage());//al no acceder el archivo
        }

        return factura;
    }

    //ESCRIBIR ARCHIVOS
    public static void writeFileVendedor() {
        try {
            PrintWriter pw = new PrintWriter(new PrintWriter(archivoVendedores));

            for (Vendedor v : vendedores) {

                pw.print(v.getNombre() + ",");
                pw.print(v.getApellidoPaterno() + ",");
                pw.print(v.getApellidoMaterno() + ",");
                pw.print(v.getFechaNacimiento().getDia() + ",");
                pw.print(v.getFechaNacimiento().getMes() + ",");
                pw.print(v.getFechaNacimiento().getAnio() + ",");
                pw.print(v.getId() + ",");
                pw.print(v.getArea() + ",");
                pw.print(v.getPorcentajeComision() + ",");
                pw.print(v.getSueldoBase());
                pw.println();
            }

            pw.close();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }

    public static void writeFileClientes() {
        try {
            PrintWriter pw = new PrintWriter(new PrintWriter(archivoClientes));

            for (Cliente c : clientes) {

                pw.print(c.getNombre() + ",");

                pw.print(c.getApellidoPaterno() + ",");
                pw.print(c.getApellidoMaterno() + ",");
                pw.print(c.getFechaNacimiento().getDia() + ",");
                pw.print(c.getFechaNacimiento().getMes() + ",");
                pw.print(c.getFechaNacimiento().getAnio() + ",");
                pw.print(c.getRfc() + ",");
                pw.print(c.getDomicilio());

                //System.out.println(clientes.size()+" TamanoClientes");
                //System.out.println(c.getCompras().size()+" cantidad de facturas");
                //System.out.println(cantidadProductos+" Cantidad productos");
                //System.out.println();

                //System.out.println(clientes.size());
                //System.out.println(c.getCompras().size());
                //System.out.println(cantidadProductos);


                pw.println();
            }

            pw.close();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }

    public static void writeFileProductos() {
        try {
            PrintWriter pw = new PrintWriter(new PrintWriter(archivoProductos));

            for (Productos p : productos) {

                pw.print(p.getId() + ",");
                pw.print(p.getDescripcion() + ",");
                pw.print(p.getPrecio());


                pw.println();
            }

            pw.close();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }


}







