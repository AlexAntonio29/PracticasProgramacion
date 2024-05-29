public class Carro {

    private String matricula;
    private String marca;
    private String kilometrague;

    public Carro(String matricula, String marca , String kilometrague) {//constructor
        this.matricula = matricula;
        this.marca = marca;
        this.kilometrague = kilometrague;
    }

    public void impresionPermiso() {

        System.out.println("Permiso documentacion Matricula: " + matricula + kilometrague);
        System.out.println("Permiso documentacion Marca: " + marca + kilometrague);
        System.out.println("permiso documentacion Kilometrague" + marca +" "+ matricula);
    }


}
