//Ejericio 2   Alexis Zosimo Antonio Angel  102-B

#include<stdio.h>
#include<stdlib.h>
typedef struct{
	int clave;
	char  nombre [20];
	char  apellido_p[20];
	char  apellido_m[20];
	char sexo;
	double salario;
}Trabajador;

void nomina(Trabajador tabla[ ], int n);
int busca(Trabajador tabla[ ], int n, int clave);
void menu();
void nuevo_trabajador(Trabajador tabla[],int n);
void leer_tabla(Trabajador *tabla);


main(){
	Trabajador datos_personal[10]={0,"","","",'N',0};
	int val,clave;
	do{
		menu();
		scanf("%d",&val);
		switch(val){
			case 1:nuevo_trabajador(datos_personal,10);break;
			case 2: nomina(datos_personal,10);break;
			case 3: printf("Clave del trabajador\n");scanf("%d",&clave);busca(datos_personal,10,clave);break;
			case 4:break;
			default: printf("Valor erroneo\n\n");
		}
	}while(val!=4);

	
return 0;	
}

void nomina(Trabajador tabla[ ], int n){
int i,j;
	
	for (i=0;i<n;i++){
		if(tabla[i].clave!=0){
			printf("Clave: %d\n",tabla[i].clave);
			printf("Nombre: %s\n", tabla[i].nombre);
			printf("Apellido Paterno: %s\n", tabla[i].apellido_p);
			printf("Apellido Materno: %s\n", tabla[i].apellido_m);
			printf("Sexo: %c\n", tabla[i].sexo);
			printf("Salario: %f\n", tabla[i].salario);
			printf("\n\n\n");
		}
	
	}

}

void menu(){
	
	printf("--------------------------------------------------------------------------------\n");
	printf("MENU DE DATOS\n");
	printf("(1). introducir nuevo trabajador\n");
	printf("(2). imprimir todos los trabajadores\n");
	printf("(3). buscar un trabajador\n");
	printf("(4). Salir\n");
	printf("--------------------------------------------------------------------------------\n");
}



int busca(Trabajador tabla[ ], int n, int clave){
	int a=-1,i;
	
	for(i=0;i<n;i++){
		if(tabla[i].clave==clave){
			printf("----------------------------------------------------\n");
			printf("Datos solicitados:\n");
			printf("Clave: %d\n",tabla[i].clave);
			printf("Nombre: %s\n", tabla[i].nombre);
			printf("Apellido Paterno: %s\n", tabla[i].apellido_p);
			printf("Apellido Materno: %s\n", tabla[i].apellido_m);
			printf("Sexo: %c\n", tabla[i].sexo);
			printf("Salario: %f\n", tabla[i].salario);
			a=i;
			printf("----------------------------------------------------\n");
		}
		
	}
	return a;
}

void nuevo_trabajador(Trabajador tabla[],int n){
	int clave,i=0;
	printf("Clave\n");
			scanf("%d",&clave);

	while (tabla[i].clave!=0&&tabla[i].clave!=clave)i++;
	if(tabla[i].clave==0){
		tabla[i].clave=clave;
		leer_tabla(&tabla[i]);
	}else{
		printf("Esa clave ya existe\n");
	}
	
	
}

void leer_tabla(Trabajador *tabla){
	fflush(stdin);
	printf("Nombre:\n");fflush(stdin);
			gets(tabla->nombre);
				fflush(stdin);
				printf("Apellido paterno:\n");
			gets(tabla->apellido_p);
				fflush(stdin);
			printf("Apellido materno:\n");
			gets(tabla->apellido_m);	fflush(stdin);
			printf("Sexo:\n");
			scanf("%c",&(tabla->sexo));	fflush(stdin);
			printf("Salario:\n");
			scanf("%lf",&(tabla->salario));	fflush(stdin);
}
