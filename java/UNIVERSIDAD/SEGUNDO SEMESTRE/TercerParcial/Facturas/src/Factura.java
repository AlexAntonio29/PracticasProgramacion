import java.io.*;
import java.util.ArrayList;
import java.util.*;

public class Factura {

    Scanner lector = new Scanner(System.in);

   public static File archivoProductos=new File("productos.txt");
    public static File archivoVendedores=new File("vendedores.txt");

  int id;
    Fecha fechaFactura;
    float subTotal;
    float iva;
    float total;

     ArrayList<Productos> productos = new ArrayList<>();
    Vendedor vendedor;


    public Factura(){
        productos.clear();
    }
    public void setProductos(ArrayList<Productos> productos) {
       this.productos = productos;
    }


    public int getId() {
        return id;
    }

    public ArrayList<Productos> getProductos() {
        return productos;
    }

    public Fecha getFechaFactura() {
        return fechaFactura;
    }

    public float getTotal() {
        return total;
    }

    public float getIva() {
        return iva;
    }

    public float getSubTotal() {
        return subTotal;
    }


    public Vendedor getVendedor(boolean pase) {
        if (pase){
            boolean opc = true;
            do {
                try {
                    System.out.println("Ingrese el ID del vendedor");
                    int id = esNumeroInt();
                    Vendedor vendedor = existFileVendedor(id);
                    if (vendedor == null) throw new RuntimeException();
                    else return vendedor;
                } catch (RuntimeException e) {
                    System.out.println("No se encontro el Vendedor intente de nuevo");
                }
            } while (opc);


            return null;
        }else {
            return vendedor;
        }
    }

    public  void setId(int id) {
        this.id = id;
    }

    public void setSubTotal(float subTotal) {
        this.subTotal = subTotal;
    }

    public void setFechaFactura(Fecha fechaFactura) {
        this.fechaFactura = fechaFactura;
    }

    public void setIva(float iva) {
        this.iva = iva;
    }

    public void setTotal(float total) {
        this.total = total;
    }


    public void setVendedor(Vendedor vendedor) {
        this.vendedor = vendedor;
    }

    public float agregarProducto(int id) {
        try {
            Productos producto = existFileProducto(id);
            if (producto == null) throw new RuntimeException();
            else {
                System.out.println(producto.getId());
                System.out.println(producto.getDescripcion());
                System.out.println(producto.getPrecio());
                productos.add(producto);
                System.out.println("Producto agregado");
                return producto.getPrecio();
            }
        } catch (RuntimeException e) {
            System.out.println("el producto no existe");
            return 0;
        }




    }

    public float eliminarProducto(int id) {

        boolean condicion = true;
        for (Productos producto : productos) {

            if (producto.getId() == id) {
                System.out.println(producto.getId());
                System.out.println(producto.getDescripcion());
                System.out.println(producto.getPrecio());

                productos.remove(producto);
                condicion = false;
                System.out.println("PRODUCTO eliminado");
                return producto.getPrecio();

            }


        }
        if (condicion) {
            System.out.println("No se encontro el producto");

        }
    return 0;

    }

    public float calcularSubTotal() {

        subTotal = total - iva;

        return subTotal;

    }


    public static Productos existFileProducto(int idProducto) {

       // File archivoProductos = new File("f" + id + ".txt");
        if (archivoProductos.exists()) return IdreadFileProductos(idProducto);
        else return null;
    }

    public static Vendedor existFileVendedor(int idVendedor){
        if (archivoVendedores.exists()) return idreadFileVendedor(idVendedor);
        else return null;

    }


    public static Productos IdreadFileProductos(int idProducto) {
       // File archivoProductos = new File("f" + id + ".txt");
        try {
            FileReader fr = new FileReader(archivoProductos);//Crear el flujo hacia f
            BufferedReader br = new BufferedReader(fr);//crear la lectura del archivo
            String linea = br.readLine();//genera una lectura por salto de linea


            while (linea != null) {
                //leemos los datos del archivo y se los pasamos al arrayList de acuerdo a cada objeto
                String[] recopilatorio = linea.split(",");


                if (Integer.parseInt(recopilatorio[0]) == idProducto) {
                    return new Productos(Integer.parseInt(recopilatorio[0]), recopilatorio[1], Float.parseFloat(recopilatorio[2]));


                }
                linea = br.readLine();//Salto de linea

            }

        } catch (IOException e) {
            System.out.println(e.getMessage());//al no acceder el archivo
        }

        return null;
    }

    public static Vendedor idreadFileVendedor(int idVendedor) {
        // File archivoProductos = new File("f" + id + ".txt");
        try {
            FileReader fr = new FileReader(archivoVendedores);//Crear el flujo hacia f
            BufferedReader br = new BufferedReader(fr);//crear la lectura del archivo
            String linea = br.readLine();//genera una lectura por salto de linea


            while (linea != null) {
                //leemos los datos del archivo y se los pasamos al arrayList de acuerdo a cada objeto
                String[] recopilatorio = linea.split(",");


                if (Integer.parseInt(recopilatorio[6]) == (idVendedor)) {
                    String nombre=recopilatorio[0];
                    String apellidoPaterno = recopilatorio[1];
                    String apellidoMaterno = recopilatorio[2];
                    int dia=Integer.parseInt(recopilatorio[3]);
                    int mes=Integer.parseInt(recopilatorio[4]);
                    int anio=Integer.parseInt(recopilatorio[5]);
                    Fecha fechaAlta=new Fecha(dia, mes,anio);

                    int id=Integer.parseInt(recopilatorio[6]);
                    String area=recopilatorio[7];
                    float porcentaje=Float.parseFloat(recopilatorio[8]);
                    int sueldoBase=Integer.parseInt(recopilatorio[9]);
                    return new Vendedor(nombre,apellidoPaterno,apellidoMaterno,fechaAlta,id,area,porcentaje,sueldoBase);


                }
                linea = br.readLine();//Salto de linea

            }

        } catch (IOException e) {
            System.out.println(e.getMessage());//al no acceder el archivo
        }

        return null;
    }



    public void writeFileProductos(String id) {
        try {
            File f = new File(id + ".txt");
            PrintWriter pw = new PrintWriter(new PrintWriter(f));

            for (Productos p : productos) {

                pw.print(p.getId() + ",");
                pw.print(p.getDescripcion() + ",");
                pw.print(p.getPrecio() + ",");
                pw.println();
            }

            pw.close();
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }


    public static int esNumeroInt() {
        Scanner lector=new Scanner(System.in);
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
