public class  Circulo extends Figura{
    double radio;

    public Circulo(){
    }
    public Circulo(double x, double y,double radio){

        super(x,y);
        this.radio=radio;

    }

    @Override
    public double Area() {
        return Math.PI*Math.pow(radio,2);
    }

    @Override
    public double Perimetro() {
        return 2*Math.PI*radio;
    }




}
