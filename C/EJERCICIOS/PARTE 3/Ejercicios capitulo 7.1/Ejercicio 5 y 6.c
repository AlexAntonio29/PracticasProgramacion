//trabajador3Archivo.c   Ejercicio 5 y 6 		Alexis Zosimo Antonio Angel    102-B
#include<stdio.h>

typedef struct{
	int clave;
	char nombre[50];
	float salario;	
}Trabajador;

void imprimeTrabajador(Trabajador a);
void leeTrabajador(Trabajador *a);
int menu();
void imprimeTabla(Trabajador t[], int n);
void altaTrabajador(Trabajador t[], int n);
void bajaTrabajador(Trabajador t[], int n);
void consultaTrabajador(Trabajador t[], int n);
void abrirTrabajador(Trabajador t[], int n);
void guardarTrabajador(Trabajador t[], int n);
main(){
	Trabajador tabla[100]={0,"",0.0};
	int op, i=0;

	
	
	do{
		op = menu();
		switch(op){
			case 1: imprimeTabla(tabla, 100); break;
			case 2: altaTrabajador(tabla, 100); break;
			case 3: bajaTrabajador(tabla, 100); break;
			case 4: consultaTrabajador(tabla, 100); break;
			case 5: abrirTrabajador(tabla, 100); break;
			case 6: guardarTrabajador(tabla, 100);break;
			case 7: break;
			default: printf("opción no válida"); break;
		}
		
	}while(op!=7);

	
	return 0;
}
void guardarTrabajador(Trabajador t[], int n){
	int i;
	char guardar_archivo[30];
	
	printf("Introduce el nombre del archivo");
	scanf("%s", &guardar_archivo);
	
	FILE *p;
	p = fopen(guardar_archivo, "w");
	
	if(p!=NULL){
		
		printf("\nDatos guardados\n");
		i=0;
		while(t[i].clave != 0){
			fprintf(p,"%d %s %f\n", t[i].clave,t[i].nombre,t[i].salario);
			i++;
		}
		fclose(p);
	} else {
		printf("No pudo guardar los datos en el archivo...");
	}
}

void imprimeTrabajador(Trabajador a){
	printf("%d\t%s\t%f\n", a.clave, a.nombre, a.salario);
}

void leeTrabajador(Trabajador *a){
	//printf("Introduce clave: ");
	//fflush(stdin); scanf("%d", &(a->clave));
	
	printf("introduce nombre: ");
	fflush(stdin); gets(a->nombre);
	printf("Introduce salario: ");
	fflush(stdin); scanf("%f", &(a->salario));	
	printf("\n");
}

int menu(){
	int op;
	
	printf("\n\n******* MENÚ ******\n");
	printf("\n1. Trabajadores");
	printf("\n2.  Alta Trabajador");
	printf("\n3.  Baja Trabajador");
	printf("\n4.  Consulta Trabajador");
	printf("\n5.  Abrir archivo");
	printf("\n6.  Guardar archivo");
	printf("\n7.  Salida\n");
	printf("\nIntroduce tu opcion: ");
	fflush(stdin); scanf("%d", &op);
	
	return op;
}	

void abrirTrabajador (Trabajador t[], int n){
	int i=0; 
	char buscar_archivo[30];
	FILE *p;
	
	printf("\nCual es el nombre del archivo\n");
	scanf("%s",&buscar_archivo);
	
	p = fopen(buscar_archivo, "r");
	if(p!=NULL){
			printf("\n\nArchivo cargado exitosamente\n");
		while(!feof(p)){
			fscanf(p,"%d%s%f", &(t[i].clave), t[i].nombre,&(t[i].salario));
			i++;
		}
	}else{
		printf("Error al abrir el archivo...");
	}
	fclose(p);
}

void imprimeTabla(Trabajador t[], int n){
	int i = 0;
	
		while(t[i].clave != 0 ){
			imprimeTrabajador(t[i]);
			i++;
		}
}	

void altaTrabajador(Trabajador t[], int n){
	int clave, i=0;
	
	printf("Introduce clave: ");
	fflush(stdin); scanf("%d", &clave);
	
	while(t[i].clave != 0 && clave != t[i].clave ) i++;
	
	if(t[i].clave==0){
		t[i].clave = clave;
		leeTrabajador(&t[i]);
	}else{
		printf(" ya existe esa clave... ");	
	}
}

void bajaTrabajador(Trabajador t[], int n){
	Trabajador a={0,"",0.0};
	int clave, i=0;
	char c;
	
	printf("Introduce clave: ");
	fflush(stdin); scanf("%d", &clave);
	
	while(t[i].clave != 0 && clave != t[i].clave ) i++;
	
	if(t[i].clave!=0){
		imprimeTrabajador(t[i]);
		printf("Seguro que lo quieres borrar (s/n): ");
		fflush(stdin); scanf("%c", &c);
		if(c == 's' || c == 'S')
			while(t[i+1].clave != 0){
				t[i] = t[i+1];
				i++;
			}
			t[i] = a;
	}else{
		printf("NO existe ese registro... ");	
	}
}

void consultaTrabajador(Trabajador t[], int n){
	Trabajador a={0,"",0.0};
	int clave, i=0;
	char c;
	
	printf("Introduce clave: ");
	fflush(stdin); scanf("%d", &clave);
		
	while(t[i].clave != 0 && clave != t[i].clave ) i++;
	
	if(t[i].clave!=0){
		imprimeTrabajador(t[i]);
	}else{
		printf("NO existe ese registro... ");	
	}	
}

