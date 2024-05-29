import java.io.*;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.InputMismatchException;
import java.util.Scanner;

public class Cliente extends Persona {
    String rfc;
    String domicilio;
    ArrayList<Factura> compras = new ArrayList();

    //public static File archivoProductos=new File("productos.txt");

    Cliente() {
    }

    Cliente(String nombre, String apellidoPaterno, String apellidoMaterno, Fecha fechaDeNacimiento, String rfc, String domicilio) {
        super(nombre, apellidoPaterno, apellidoMaterno, fechaDeNacimiento);
        this.rfc = rfc;
        this.domicilio = domicilio;
    }

    public String getRfc() {
        return rfc;
    }

    public String getDomicilio() {
        return domicilio;
    }

    public ArrayList<Factura> getCompras() {
        return compras;
    }

    public void setCompras(ArrayList<Factura> compras) {
        this.compras = compras;
    }

    public void setRfc(String rfc) {
        this.rfc = rfc;
    }

    public void setDomicilio(String domicilio) {
        this.domicilio = domicilio;
    }

    public Factura comprar() {
        ArrayList<Productos> listaProductos = new ArrayList();

        System.out.println("Comprando");


        Factura f = new Factura();

        Date date = new Date();
        SimpleDateFormat formatoAnio = new SimpleDateFormat("yyyy");
        SimpleDateFormat formatoMes = new SimpleDateFormat("MM");
        SimpleDateFormat formatoDia = new SimpleDateFormat("dd");


        int id = compras.size();
        System.out.println("id:" + id);
        int dia = Integer.parseInt(formatoDia.format(date));
        int mes = Integer.parseInt(formatoMes.format(date));

        int anio = Integer.parseInt(formatoAnio.format(date));
        Fecha fecha = new Fecha(dia, mes, anio);
        System.out.println("Fecha: " + dia + "/" + mes + "/" + anio);
        System.out.println("IVA:");
        System.out.println("5%");
        float iva = 0.05f;
        System.out.println("Total:");
        float total = 0;

        boolean condicion;

        Vendedor vendedor = f.getVendedor(true);

        do {
            condicion = true;
            System.out.println("Movimiento a realizar:");

            int idProducto = 0;
            System.out.println("1)Agregar Producto");
            System.out.println("2)Eliminar Producto");
            System.out.println("0)Salir");

            int opcion = esNumeroInt();
            if (opcion != 0) {

                System.out.println("Ingrese el id del producto a agregar");
                idProducto = esNumeroInt();
            }

            switch (opcion) {
                case 1:

                    total += f.agregarProducto(idProducto);

                    break;
                case 2:
                    total -= f.eliminarProducto(idProducto);

                    break;
                case 0:
                    condicion = false;
                    iva *= total;
                    break;

                default:
                    System.out.println("Datos incorrectos...Intenta nuevamente");
                    break;
            }


        } while (condicion);
        f.setTotal(total);
        f.setIva(iva);
        System.out.println("iva:" + iva);
        System.out.println("total:" + total);
        float subtotal = f.calcularSubTotal();
        System.out.println("Subtotal: " + subtotal);

        f.setId(id);
        f.setFechaFactura(fecha);
        f.setVendedor(vendedor);
        f.setSubTotal(subtotal);


        this.compras.add(f);
        writeFileFactura(this.rfc, id);
        return f;
    }


    //leer vendedor


    public static double esNumeroDouble() {
        Scanner lector = new Scanner(System.in);
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


    public static int esNumeroInt() {
        Scanner lector = new Scanner(System.in);
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

    public static String esString() {
        Scanner lector = new Scanner(System.in);
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


    public  void writeFileFactura(String rfc, int idFactura) {


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
            dir2 = new File(dir + "/" + rfc);
            if (!dir2.exists())
                dir2.mkdir();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }


        File f = new File(dir2 + "/" + rfc + idFactura + ".txt");
        try {

            PrintWriter pw = new PrintWriter(new PrintWriter(f));

            for (Factura factura : compras) {
                int facturaId = factura.getId();
                if (idFactura == facturaId) {
                    pw.print(factura.getId() + ",");
                    pw.print(factura.getFechaFactura().getDia() + ",");
                    pw.print(factura.getFechaFactura().getMes() + ",");
                    pw.print(factura.getFechaFactura().getAnio() + ",");
                    pw.print(factura.getSubTotal() + ",");
                    pw.print(factura.getIva() + ",");
                    pw.print(factura.getTotal() + ",");
                    pw.print(factura.getVendedor(false).getNombre() + ",");
                    pw.print(factura.getVendedor(false).getApellidoPaterno() + ",");
                    pw.print(factura.getVendedor(false).getApellidoMaterno() + ",");
                    pw.print(factura.getVendedor(false).getFechaNacimiento().getDia() + ",");
                    pw.print(factura.getVendedor(false).getFechaNacimiento().getMes() + ",");
                    pw.print(factura.getVendedor(false).getFechaNacimiento().getAnio() + ",");
                    pw.print(factura.getVendedor(false).getId() + ",");
                    pw.print(factura.getVendedor(false).getArea() + ",");
                    pw.print(factura.getVendedor(false).getPorcentajeComision() + ",");
                    pw.print(factura.getVendedor(false).getSueldoBase());//16

                    pw.println();


                    for (Productos producto : factura.getProductos()) {


                        pw.print(producto.getId() + ",");
                        pw.print(producto.getDescripcion() + ",");
                        pw.println(producto.getPrecio());

                    }
                }


            }
            pw.close();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
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

    public static int esAnio() {
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

                condicion = false;

                return n;
            } catch (InputMismatchException e) {
                System.out.println("Error al ingresar el numero");
                System.out.println("Intente de nuevo");
                System.out.println("Un numero entero");
                lector.nextLine();
            } catch (IllegalArgumentException e) {
                System.out.println("El anio debe de ser logico o es menor de edad");
            }

        }


        return n;
    }


}
