public class DiscreteMaths {

    public DiscreteMaths() {



    }

    public int sumX(int x[]) {
        int totalX = 0;

        for (int i = 0; i < x.length; i++)
            totalX += x[i];
        return totalX;
    }

    public int sumY(int y[]) {
        int totalY = 0;

        for (int i = 0; i < y.length; i++)
            totalY += y[i];

        return totalY;
    }


    public int NsumYX(int y[], int x[]){
        int totalXY=0;
        for(int i=0; i< x.length;i++){
            totalXY+= (x[i]*y[i]);
        }
        return totalXY*x.length;
    }
     public int powX(int x[]){
        int SumXPow=0;

        for (int i=0;i<x.length;i++){
            SumXPow+=Math.pow(x[i],2);
        }
        return SumXPow*x.length;

     }

}
