//trabajador2Directo.c      7.3 Alexis Zosimo Antonio Angel 102-B 	


#include<stdio.h>

typedef struct{
	int clave;
	char nombre[50];
	float salario;	
}Trabajador;

void imprimeTrabajador(Trabajador a);
void leeTrabajador(Trabajador *a);
int menu();
void imprimeTabla(FILE *p, int n);
void altaTrabajador(FILE *p, int n);
void bajaTrabajador(FILE *p, int n);
void consultaTrabajador(FILE *p, int n);

main(){
	Trabajador tabla[100]={0,"",0.0},a,b={0,"",0.0};
	int op,i;
	FILE *p;
	
	p = fopen("Registros.bin","r+");
	if(p==NULL){
		printf("No hay ningun archivo, se creara uno\n");
		p=fopen("Registros.bin","w+");
		fseek(p,0,SEEK_SET);
		
		for(i=0;i<100;i++){
			fwrite(&b,sizeof(Trabajador),1,p);
		}
	}
	
	
	//else{
//		while(!feof(p)){
//			fread(&a,sizeof(Trabajador),1,p);
//			tabla[a.clave-1] = a;	
//		}
//		fclose(p);
//	}
	
	do{
		op = menu();
		switch(op){
			case 1: imprimeTabla(p, 100); break;
			case 2: altaTrabajador(p, 100); break;
			case 3: bajaTrabajador(p, 100); break;
			case 4: consultaTrabajador(p, 100); break;
			case 5: break;
			default: printf("opcion no valida"); break;
		}
		
	}while(op!=5);
	
//	p = fopen("tablatrabajadores.bin","w");
//	if(p==NULL){
//		printf("El archivo no s epudo crear...\n");
//	}else{
//		for(i=0; i<100;i++){
//			if(tabla[i].clave != 0){
//				fwrite(&tabla[i], sizeof(Trabajador),1,p);
//			}
//			
//		}
//		fclose(p);
//	}
	fclose(p);
	//}
	return 0;
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
	
	printf("\n\n******* MENU ******\n");
	printf("\n1. Trabajadores");
	printf("\n2.  Alta Trabajador");
	printf("\n3.  Baja Trabajador");
	printf("\n4.  Consulta Trabajador");
	printf("\n5.  Salida\n");
	printf("\nIntroduce tu opcion: ");
	fflush(stdin); scanf("%d", &op);
	
	return op;
}	

void imprimeTabla(FILE *p, int n){
	int i;
	Trabajador a;
	
	fseek(p,0,SEEK_SET);
	for(i=0; i<n; i++){
		fread(&a,sizeof(Trabajador),1,p);
		if(a.clave != 0 ){
			imprimeTrabajador(a);
		}
//		if(t[i].clave != 0 ){
//			imprimeTrabajador(t[i]);
//		}
	}
}	

void altaTrabajador(FILE *p, int n){
	int clave;
	Trabajador a;
	
	printf("Introduce clave: ");
	fflush(stdin); scanf("%d", &clave);
	fseek(p,(clave-1)*sizeof(Trabajador),SEEK_SET);
	fread(&a,sizeof(Trabajador),1,p);
	
	if(a.clave==0){
		a.clave = clave;
		leeTrabajador(&a);
		fseek(p,(clave-1)*sizeof(Trabajador),SEEK_SET);
		fwrite(&a, sizeof(Trabajador),1,p);	
	}else{
		printf("Existe ese registro... ");	
	}
}

void bajaTrabajador(FILE *p, int n){
	Trabajador a,b={0,"",0.0};
	int clave;
	char c;
	
	printf("Introduce clave: ");
	fflush(stdin); scanf("%d", &clave);
	
	fseek(p,(clave-1)*sizeof(Trabajador),SEEK_SET);
	
	fread(&a,sizeof(Trabajador),1,p);

	if(a.clave!=0){
		imprimeTrabajador(a);
		printf("Seguro que lo quieres borrar (s/n): ");
		fflush(stdin); scanf("%c", &c);
		if(c == 's' || c == 'S'){
			fseek(p,(clave-1)*sizeof(Trabajador),SEEK_SET);
			fwrite(&b,sizeof(Trabajador),1,p);
		}
			
	}else{
		printf("NO existe ese registro... ");	
	}
}

void consultaTrabajador(FILE *p, int n){
	Trabajador a,b={0,"",0.0};
	int clave;
	char c;
	
	printf("Introduce clave: ");
	fflush(stdin); scanf("%d", &clave);
	
	fseek(p,(clave-1)*sizeof(Trabajador),SEEK_SET);
	
	fread(&a,sizeof(Trabajador),1,p);
	
	
	if(a.clave!=0){
		imprimeTrabajador(a);
	}else{
		printf("NO existe ese registro... ");	
	}	
}

