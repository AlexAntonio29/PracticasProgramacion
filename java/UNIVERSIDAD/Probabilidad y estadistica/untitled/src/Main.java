
public class Main {
    public static void main(String[] nousan) {
        DataSet ds = new DataSet();
        DiscreteMaths dm = new DiscreteMaths();
        //double nSumXY = dm.NsumYX(ds.getX(), ds.getY());
        //double sumXSumY = dm.sumX(ds.getX()) * dm.sumY(ds.getY());
        //double NsumXYmenosSumXSumY = nSumXY - sumXSumY;
       // double NSumPowX= dm.powX(ds.getX());
        //double b1=NsumXYmenosSumXSumY/(NSumPowX-dm.sumX(ds.getX()));


        System.out.println(dm.sumX(ds.getX()));//paso 4
        System.out.println(dm.sumY(ds.getY()));//paso5


       // System.out.println("B1 ="+b1);

    }
}