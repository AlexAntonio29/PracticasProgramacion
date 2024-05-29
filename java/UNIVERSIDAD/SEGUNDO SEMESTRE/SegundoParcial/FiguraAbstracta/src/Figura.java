public abstract class Figura {
    protected double x;
    protected double y;

    public Figura(double x, double y){
        this.x=x;
        this.y=y;
    }



    public Figura(){}
    public abstract double Area();
    public abstract double Perimetro();

}
