
public class Main {
    public static void main(String[] nousan) {
        DataSet ds = new DataSet();
        SimpleLinearRegresion slr= new SimpleLinearRegresion( ds.getX(), ds.getY());
        double b1=slr.B1();
        double b0=slr.B0();


        System.out.println("B1 =" + b1);
        System.out.println("B0 =" + b0);
        System.out.println("");
        System.out.println("Si X=70 entonces de acuerdo a la formula fórmula de la regresión lineal simple predecimos Y");
        System.out.println("YHat= "+b0+" + "+b1+" Advertising(X)");
        System.out.println("");
        double x=70;
        System.out.println("YHat = "+(b0+( b1*x)));
    }
}