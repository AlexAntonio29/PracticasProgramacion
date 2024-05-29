//complejo.c

#include<stdio.h>

typedef struct {
	float real;
	float imag;
	
}TComplejo;


void imprimeComplejo(TComplejo a){
	//a+bi
	printf("%.2f",a.real);
if(a.imag>0) printf("+ %.2f",a.imag);
else printf(" - %.2f", a.imag*(-1));
	
}

TComplejo sumaComplejo(TComplejo c1, TComplejo c2){
	TComplejo aux;
	aux.real=c1.real+c2.real;
	aux.imag=c1.imag+c2.imag;
	
	return aux;
}

void leerComplejo(TComplejo c1, TComplejo c2){
	
	printf("Introduce valor real de c1\n");
	scanf("%f",&(c1.real));
	
	printf("Introduce valor real de c2\n");
	scanf("%f",&(c2.real));
	
	printf("Introduce el valor imaginario de c1");
	scanf("%f",&(c1.imag));
	
	printf("Introduce el valor imaginario de c2");
	scanf("%f",&(c2.imag));
	
	
}





main(){
	
	
	TComplejo n,m,fin;
	
	leerComplejo(n,m);
		fin=sumaComplejo(n,m);
	imprimeComplejo(fin);
	
	
	
}
