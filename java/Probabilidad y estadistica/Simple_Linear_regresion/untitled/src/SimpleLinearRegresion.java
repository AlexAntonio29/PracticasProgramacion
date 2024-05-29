public class SimpleLinearRegresion {

    int[] x;
    int[] y;
    DiscreteMaths dm=new DiscreteMaths();

    double b1, b0;


    public SimpleLinearRegresion() {
    }

    public SimpleLinearRegresion( int[] x, int[] y) {
        //Proceso para encontrar B1
        this.x = x;
        this.y = y;



    }


    public double B1() {
        double nSumXY = dm.NsumYX(x, y);
        double sumXSumY = dm.sumX(x) * dm.sumY(y);
        double NsumXYmenosSumXSumY = nSumXY - sumXSumY;
        double NSumPowX = dm.powX(x);
        b1 = NsumXYmenosSumXSumY / (NSumPowX - Math.pow(dm.sumX(x), 2));
        return b1;
    }

    public double B0() {
//Proceso para encontrar B0
        double SigYimB1SigXi = dm.sumY(y) - (this.b1 * dm.sumX(x));
        b0 = SigYimB1SigXi / x.length;
        return b0;
    }
}
