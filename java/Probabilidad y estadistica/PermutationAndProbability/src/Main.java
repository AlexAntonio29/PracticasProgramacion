public class Main {
    public static void main(String[] args) {
//permutacion de abecedario
        System.out.println("PERMUTACION DE ALFABETO");
        DataSetPermutation dataset = new DataSetPermutation();
        String[] ds = dataset.getX2();
        Marginal marginal = new Marginal();
        Joint joint= new Joint();
        Conditional conditional = new Conditional();
        Permutation p = new Permutation();
        p.permutar(ds, 0);
        System.out.println();
        System.out.println();
        System.out.println();

        //probabilidades
        System.out.println("PROBABILIDAD DE UN EVENTO");
        DataSetProbability dataSetProbability = new DataSetProbability();
        int [][] dsp = dataSetProbability.getX1();
        int total = 0;
        for (int i = 0; i < dsp.length; i++)
            for (int j = 0; j < dsp[i].length; j++)
                total += dsp[i][j];


        int[] marginalX=marginal.getMarginalX(dsp, total);
        int[] marginalY=marginal.getMarginalY(dsp, total);
       int[] jointt= joint.getJoint(dsp,total);

        conditional.getConditional(marginalX,marginalY,jointt);


    }
}