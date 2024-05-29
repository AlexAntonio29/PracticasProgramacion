//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] nousan) {
        Object b0,b1,b2;
        DataSet ds= new DataSet();
        DiscreteMaths dm = new DiscreteMaths(ds.getX(), ds.getY());
        QuadraticLinearRegresion qlr= new QuadraticLinearRegresion(dm);

        b0=qlr.B0();
        b1=qlr.B1();
        b2=qlr.B2();
        double B0= (double) b0,B1= (double) b1,B2= (double) b2;


        System.out.println("DB0= "+B0);
        System.out.println("DB1= "+B1);
        System.out.println("DB2= "+B2);

        System.out.println("");
        System.out.println("****************************ECUACION DE REGRESION CUADRATICA**********************");
        System.out.println("YHAT= B0+B1X+B2X^2");
        System.out.println("YHAT= "+B0+"+"+B1+"SALES + "+B2+" SALES^2");
        System.out.println("");
        System.out.println("Si Tenemos 3 predicciones de acuerdo a las variables exogena entonces asiganmos a x1=6,x2=8,x3=10");
        System.out.println("");
        double x1=6.0,x2=8.0,x3=10.0;
        System.out.println("*********************X1***********************");
        System.out.println("YHAT1= " +(B0+(B1*x1)+(B2+Math.pow(x1,2))));
        System.out.println("*********************X2***********************");
        System.out.println("YHAT2= " +(B0+(B1*x2)+(B2+Math.pow(x2,2))));
        System.out.println("*********************X3***********************");
        System.out.println("YHAT3= " +(B0+(B1*x3)+(B2+Math.pow(x3,2))));

    }
}