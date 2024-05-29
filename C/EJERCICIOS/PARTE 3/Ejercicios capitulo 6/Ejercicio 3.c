//Ejericio 3		Alexis Zosimo Antonio Angel   102-B

#include<stdio.h>

typedef struct {
int x, y;
}TPunto;

typedef struct {
TPunto centro;
float radio;
}TCirculo;


typedef struct {
TCirculo base;
double altura;
}TCilindro;


void imprime_punto(TPunto p);
void imprime_circulo(TCirculo c);
void imprime_cilindro(TCilindro cil);

void lee_punto(TPunto *p);
void lee_circulo(TCirculo *c);
void lee_cilindro(TCilindro *cil);
main(){
TPunto p;
TCirculo c;
TCilindro cil;

p.x=4;
p.y=5;

c.centro.x=6;
c.centro.y=7;
c.radio=10.5;

cil.altura=25.675;
cil.base.centro.x=6;
cil.base.centro.y=4;
cil.base.radio=10.7;

imprime_punto(p);
imprime_circulo(c);
imprime_cilindro(cil);

lee_punto(&p);
lee_circulo(&c);
lee_cilindro(&cil);

printf("\n\n\n\n");
imprime_punto(p);
imprime_circulo(c);
imprime_cilindro(cil);


}

void imprime_punto(TPunto p){
	printf("---------------------------------------------------\nPUNTO\n\n");
	printf("%d\n",p.x);
	printf("%d\n",p.y);
	printf("---------------------------------------------------\n");
}

void imprime_circulo(TCirculo c){
	printf("---------------------------------------------------\nCIRCULO\n\n");
	printf("%d\n",c.centro.x);
	printf("%d\n",c.centro.y);
	printf("\n");
	printf("%f\n",c.radio);
	printf("---------------------------------------------------\n");
}

void imprime_cilindro(TCilindro cil){
	printf("---------------------------------------------------\nCILINDRO\n\n");
	printf("%f\n",cil.altura);
	printf("\n");
	printf("%d\n",cil.base.centro.x);
	printf("%d\n",cil.base.centro.y);
	printf("\n");
	printf("%f\n",cil.base.radio);
	printf("---------------------------------------------------\n");
}

void lee_punto(TPunto *p){
		printf("---------------------------------------------------\nPUNTO\n\n");
		printf("Introduce el valor de la coordenada del punto x\n");
		scanf("%d", &(p->x));
		printf("Introduce el valor de la coordenada del punto y\n");
		scanf("%d", &(p->y));
		printf("---------------------------------------------------\n");
	
}

void lee_circulo(TCirculo *c){
	printf("---------------------------------------------------\nCIRCULO\n\n");
	printf("Introduce la coordenada en x del centro del circulo\n");
	scanf("%d",&(*c).centro.x);
	printf("Introduce la coordenada en y del centro del circulo\n");
	scanf("%d",&(*c).centro.y);
	printf("Introduce el valor del radio del circulo\n");
	scanf("%f",&(c->radio));
	printf("---------------------------------------------------\n");
}

void lee_cilindro(TCilindro *cil){
	printf("---------------------------------------------------\nCILINDRO\n\n");
	printf("Introduce la altura del cilindro\n");
	scanf("%lf",&(*cil).altura);
	printf("Introduce la coordenada en x del centro del circulo del cilindro\n");
	scanf("%d",&(*cil).base.centro.x);
	printf("Introduce la coordenada en y del centro del circulo del cilindro\n");
	scanf("%d",&(*cil).base.centro.y);
	printf("Introduce el valor del radio del circulo del cilindro\n");
	scanf("%f",&(*cil).base.radio);

	printf("---------------------------------------------------\n");
}
