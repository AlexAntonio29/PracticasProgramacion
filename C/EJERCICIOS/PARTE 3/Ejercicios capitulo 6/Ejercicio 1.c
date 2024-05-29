//Ejericio 1        Alexis Zosimo Antonio Angel   102-B

#include<stdio.h>
#include<stdlib.h>

typedef struct {
	double a;
	double b;
}TComplejo;

TComplejo** reserv_memory(int ren, int col);
void print_date(TComplejo n);
void leeComplejo(TComplejo *c);
TComplejo sumaComplejos(TComplejo c1, TComplejo c2);
//FUNCION MAIN
main(){
	TComplejo **r, c1,c2,cf;
	int col, ren,i,j;

	

	printf("Introduce el numero de renglones\n");
	scanf("%d",&ren);
	
	printf("Intoduce el numero de columnas\n");
	scanf("%d",&col);
	
	
	ren=2; col=2;
	r=reserv_memory(ren, col);
	
	
	
	r[0][0].a=1;	r[0][0].b=5;
	r[0][1].a=2;	r[0][1].b=6;
	r[1][0].a=3;	r[1][0].b=7;
	r[1][1].a=4;	r[1][1].b=8;
	
	for (i=0;i<ren;i++){
		
		for(j=0;j<col;j++){
			print_date(r[i][j]);
		}
		printf("\n\n");
	}
	
	leeComplejo(&c1);
	leeComplejo(&c2);
	print_date(c1);
	print_date(c2);


  cf=sumaComplejos(c1,c2);
  printf("\n\n");
print_date(cf);

	return 0;
}
//Funcion para reservar memoria
TComplejo** reserv_memory(int ren, int col){
	TComplejo **matriz;
	int i,j;
		matriz=(TComplejo**)malloc(sizeof(TComplejo*)*ren);
	if(matriz==NULL) return NULL;
	for(i=0;i<ren;i++){
			matriz[i]=(TComplejo*)malloc(sizeof(TComplejo*)*col);
			if (matriz[i]==NULL) return NULL;
	}
	return (matriz);
}


//Funcion para imprimir datos de cada arreglo 

void print_date(TComplejo n){
	if(n.b<0)
	printf(" (%f - %f)\t",n.a,n.b);
	else
	printf("(%f + %f)\t",n.a,n.b);
}

//funcion para leer datos de el arreglo

void leeComplejo(TComplejo *c){
	
	printf("Introduce los datos a\n");
	fflush(stdin);scanf("%lf",&(c->a));
	printf("Introduce los datos b\n");
	fflush(stdin);scanf("%lf",&(c->b));
	
		//printf("(%f , %f)\n",(&c.a),(&c.b);
	

}

//funcion para sumarComplejos

TComplejo sumaComplejos(TComplejo c1, TComplejo c2){
	TComplejo suma;
	suma.a=c1.a+c2.a;
	suma.b=c1.b+ c2.b;
	
	return suma;
	
}
