import java.util.Random;

public class probabilidad_ocurrencias {

    public static int[] probabilidad_ocurrencias =new int[6];

    public static void main(String[] args) {

        for (int i=0;i<100;i++){//lanzamiento de 100 veces el dado
            lanzamiento();
        }
        for (int i=0;i<6;i++){
            System.out.println((i+1)+": "+probabilidad_ocurrencias[i]);
        }




    }
    public static void lanzamiento(){
        int valor=  new Random().nextInt(6)+1;//Generar los valores aleatorios
        switch (valor){//Agregar valor a cuantas veces cayo a cada lado del dado
            case 1:
                probabilidad_ocurrencias[0]++;
                break;

            case 2:
                probabilidad_ocurrencias[1]++;
                break;
            case 3:
                probabilidad_ocurrencias[2]++;
                break;
            case 4:
                probabilidad_ocurrencias[3]++;
                break;
            case 5:
                probabilidad_ocurrencias[4]++;
                break;
            case 6:
                probabilidad_ocurrencias[5]++;
                break;
            default:
                System.out.println(valor);
                break;

        }
    }

}
