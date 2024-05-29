public class DiscreteMaths {

    double sum = 0;
    private double[] x, y;

    public DiscreteMaths(double[] x, double[] y) {

        this.x=x;
        this.y=y;


    }

    public  DiscreteMaths(){}

    public double[] getX(){
        return x;
    }

    public double[] getY() {
        return y;
    }

    public double SumX() {
        sum = 0;
        for (double i : x)
            sum += i;

       // System.out.println("X= "+sum);

        return sum;

    }

    public double SumY() {
        sum = 0;
        for (double i : y)
            sum += i;
      //  System.out.println("Y= "+sum);

        return sum;
    }

    public double SumX2() {
        sum = 0;
        for (double i : x)
            sum += Math.pow(i, 2);
       // System.out.println("X2= "+sum);

        return sum;

    }

    public double SumX3() {
        sum = 0;
        for (double i : x)
            sum += Math.pow(i, 3);
       // System.out.println("X3= "+sum);

        return sum;
    }

    public double SumX4() {
        sum = 0;
        for (double i : x)
            sum += Math.pow(i, 4);
     //   System.out.println("X4= "+sum);
        return sum;


    }

    public double SumXY() {
        sum = 0;
        int s = 0;

        for (double i : x) {
            // System.out.println("i= "+i+" y[s]= "+y[s]);
            sum += (i) * y[s];
            s++;
        }
       // System.out.println("XY= "+sum);


        return sum;

    }

    public double SumX2Y() {
        sum = 0;
        int s = 0;
        for (double i : x) {

            sum += Math.pow(i, 2) * y[s];


            s++;
        }

       // System.out.println("X2Y= "+sum);

        return sum;

    }


}
