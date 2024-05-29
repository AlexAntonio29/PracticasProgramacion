import java.util.ArrayList;

public class Libro {
    private int isbm;
    private String titulo;
    private String edicion;
    private String genero;
    private Editorial editorial;
    private ArrayList<Autor> autores;

    public Libro(int isbn, String titulo, String edicion, String genero, Editorial editorial, ArrayList<Autor> autores) {
        this.isbm=isbn;
        this.titulo=titulo;
        this.edicion=edicion;
        this.genero=genero;
        this.editorial=editorial;
        this.autores=autores;
    }
    public Libro(){}


    public int getIsbm(){
        return isbm;
    }
    public String gettitulo(){
        return titulo;
    }
    public String getEdicion(){
        return edicion;
    }
    public String getGenero(){
        return genero;
    }
    public Editorial getEditorial(){
        return editorial;
    }

    public ArrayList<Autor> getAutores(){
        return autores;
    }
    //Los set
    public void setIsbm(int isbm){
        this.isbm=isbm;

    }
    public void setTitulo(String titulo){
        this.titulo=titulo;

    }
    public void setEdicion(String edicion){
        this.edicion=edicion;

    }
    public void setGenero(String genero){
        this.genero=genero;

    }
    public void setEditorial(Editorial editorial){
        this.editorial=editorial;

    }

    public void setAutores(ArrayList<Autor> autores){
        this.autores = autores;
    }





}
