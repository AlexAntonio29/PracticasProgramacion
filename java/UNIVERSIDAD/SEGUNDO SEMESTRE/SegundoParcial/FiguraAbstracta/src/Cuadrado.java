public class Cuadrado extends figura {

    public Cuadrado(){}
    public Cuadrado(double x,double y){
        super(x, y);
    }
    @Override
    public double Area() {
        return x*x;
    }

    @Override
    public double Perimetro() {
        return 4*x;
    }
}
