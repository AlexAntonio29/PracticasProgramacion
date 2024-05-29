
public class Main {
    public static void main(String[] args) {

        DataSet dataSet = new DataSet();
        DescriptiveStatics descriptiveStatics = new DescriptiveStatics();
        DescriptiveTable descriptiveTable = new DescriptiveTable();

        double[][] conjuntoDataSet = new double[1][];


        for (int i = 0; i < conjuntoDataSet.length; i++) {
            conjuntoDataSet[i] = dataSet.getDataset(i + 1);
        }

        for (int i=0;i<conjuntoDataSet.length;i++){

            double rango = descriptiveStatics.getRango(conjuntoDataSet[i]);
            int intervalo = descriptiveStatics.getIntervalo(conjuntoDataSet[i]);
            int amplitud = descriptiveStatics.getAmplitud(intervalo, rango);
            double[][] clases = descriptiveStatics.getClases(conjuntoDataSet[i], intervalo, amplitud);

            System.out.println();
            System.out.println();
            System.out.println("Rango: "+rango+"     Intervalo: "+intervalo+"      Numero de Clases: "+clases.length+"      Amplitud: "+amplitud+"            CantidadDatos: "+conjuntoDataSet[i].length);


            double[][] DescriptiveTable = descriptiveTable.getTablaDescriptiva(clases, conjuntoDataSet[i]);
            String[] s = {"Clases", "Limiteinferior", "LimiteSuperior", "Frecuencia", " PuntoMedio", "FrecuenciaAcumulada", "FrecuenciaRelativa", "FrecuenciaRelativaAcum", "Porcentaje"};
            System.out.println("Clases          Limiteinferior          LimiteSuperior          Frecuencia             PuntoMedio          FrecuenciaAcumulada          FrecuenciaRelativa          FrecuenciaRelativaAcum          Porcentaje");
            for (int k = 0; k < DescriptiveTable.length; k++) {
                for (int l = 0; l < 9; l++) {
                    double value = DescriptiveTable[k][l];
                    System.out.print(value);

                    int numEspacios = s[l].length() - (String.valueOf(value).length());

                    for (int m = 0; m <= numEspacios+9; m++) {
                        System.out.print(" ");
                    }

                }
                System.out.println();
            }

        }




        return;
    }
}