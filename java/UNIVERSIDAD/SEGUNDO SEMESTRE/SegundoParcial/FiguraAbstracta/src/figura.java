public abstract class figura {
    protected double x;
    protected double y;

    public figura(double x, double y){
        this.x=x;
        this.y=y;
    }



    public figura(){}
    public abstract double Area();
    public abstract double Perimetro();

}
