public class Pentagono extends Figura{

    double apotema;
    public Pentagono(){
    }

    public Pentagono(double x, double y,double apotema){
        super(x,y);
        this.apotema=apotema;
    }
    @Override
    public double Area() {
        return (5*x*apotema)/2;
    }

    @Override
    public double Perimetro() {
        return 5*x;
    }
}
