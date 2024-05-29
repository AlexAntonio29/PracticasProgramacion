public class Main {
    public static void main(String[] args) {

        int v1=5,v2=6;
        String name="Alex";
        String n;
        Carro carro1 = new Carro("Ferrari", "MAMON12", "150KM");
        Carro carro2= new Carro("Ford","MAMON50","90KM");
        Carro carro3= new Carro("Chayane", "MAMON13" ,"300KM" );

        System.out.println("Edad "+(v1+v2));
        n=impresion(name);
        System.out.println("Nombre: "+n);

         carro1.impresionPermiso();
         carro2.impresionPermiso();
         carro3.impresionPermiso();


    }

    public static String  impresion(String n) {

        return  n;
    }
}


