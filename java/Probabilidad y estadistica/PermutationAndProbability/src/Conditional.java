public class Conditional extends Permutation{


    public Conditional() {
    }

    void getConditional(int[] marginalX,int[] marginalY, int[] joint){

    int p=0,r=0,t=0;
        System.out.println("Probability Conditional");
    for(int i=0;i<marginalX.length;i++){
        float divisor= Float.parseFloat(String.valueOf(joint[p]));
        float dividendo= Float.parseFloat(String.valueOf(marginalX[r]));
        float dividendo2= Float.parseFloat(String.valueOf(marginalY[r]));

        t++;
        System.out.println(t+")"+joint[p]+"/"+marginalY[r]+"= "+divisor/dividendo2);
        t++;
       System.out.println(t+")"+joint[p]+"/"+marginalX[r]+"= "+divisor/dividendo);
        p++;

    }
    r++;
       t++;
        for(int i=0;i<marginalX.length;i++){
            float divisor= Float.parseFloat(String.valueOf(joint[p]));
            float dividendo= Float.parseFloat(String.valueOf(marginalX[r]));
            float dividendo2= Float.parseFloat(String.valueOf(marginalY[r]));
            System.out.println(t+")"+joint[p]+"/"+marginalY[r]+"= "+divisor/dividendo2);
            t++;
            System.out.println(t+")"+joint[p]+"/"+marginalX[r]+"= "+divisor/dividendo);
            t++;
            p++;

        }


    }

}
