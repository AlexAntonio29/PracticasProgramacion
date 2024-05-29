public class DataSet {

    private double[] x;
    private double[] y;


    public DataSet() {
        x = new double[]{6,9,12,14,30,35,40,47,51,55,60};
        y = new double[]{14,28,50,70,89,94,90,75,59,44,27};
    }

    public double[] getX() {
        return this.x;
    }

    public double[] getY() {
        return this.y;
    }
}
