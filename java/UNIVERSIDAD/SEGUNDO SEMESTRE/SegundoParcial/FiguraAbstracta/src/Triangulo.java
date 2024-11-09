public class Triangulo extends figura {

    public Triangulo(){
    }
    double l1,l2,l3;
    public Triangulo(double x, double y,double l1,double l2, double l3){

        super(x,y);
        this.l1=l1;
        this.l2=l2;
        this.l3=l3;
    }
    @Override
    public double Area() {
        return (x*y)/2;
    }

    @Override
    public double Perimetro() {
        return l1+l2+l3;
    }
}
