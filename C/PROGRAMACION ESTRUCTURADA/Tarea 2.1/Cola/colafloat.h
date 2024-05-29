//Alexis Zosimo Antonio Angel    202-B    Estructura de datos Tarea 2.1

#ifndef colafloat_h
#define colafloat_h

#include<stdio.h>
#include<stdlib.h>
//Biblioteca de cola estatica

typedef  float TDate;
//Creacion del registro
struct Cola{
	TDate *vector;//Donde se almacenara los datos
	int adelante, atras;//ubicacion
	int size;//Tamaño del vector
	
};

typedef struct Cola TCola;


//-------------------------------------------//


//Creacion del vector de cola
int CreateCola(TCola *vec, int size){
	
	
	vec-> vector=(TDate *)malloc (sizeof (TDate)*size);
	
	if (vec->vector==NULL){
		printf("Error de memoria...\n\n");
		return 0;
	}
	else{
		printf("Cola creada exitosamente...\n");
		vec->adelante=vec->atras=-1;
		vec->size=size;
		return 1;
	}
	
	
}
 
 //-----------------Cola vacia------------------//
 
 int ColaVacia(TCola cola){
 	
 	if (cola.adelante==-1) return 1;
 	else return 0;
 }

//------------Cola Llena------------------//

int ColaLlena(TCola vec){
	
if(vec.adelante==0&&vec.atras==vec.size-1 || vec.atras+1==vec.adelante) return 1;//si el vector de adelante es 0 y el vector atras es el mismo que el de el tamaño maximo
else return 0;
	}


//---------------Agregar Datos-----------------//

 int AddDate(TCola *p, TDate val){
 	
if(ColaLlena(*p)){
	printf("Cola llena...");
	return 0;
}else{
	/*if(ColaVacia(*p)){
		p->adelante=p->atras=0;
		p->vector[p->atras]=val;
		return 1;
	}
	else{*/
	
		
		if(p->atras==p->size-1){
			p->atras=0;
		
			//	p->vector[p->atras]=val;
			//	return 1;
		}
		else{
			p->atras=p->atras+1;
			p->vector[p->atras]=val;
			if(p->adelante==-1) p->adelante=0;
			return 1;
		}
	//}
}
 }
 
 int DeleteCola(TCola *p, TDate *x )  {
	if(ColaVacia(*p)==1){
		printf("Sin espacio...\n");
        return 0;//error
	}else{
		*x = p->vector[p->adelante];
		if(p->adelante == p->atras){
			p->atras = -1;
			p->adelante = -1;
		}else{
			if(p->adelante == (p->size-1))
				p->adelante = 0;
			else
			 	p->adelante = p->adelante + 1;
		}
		return 1;
	}

} 
 	
 
 
 void liberarcola(TCola *p){
 	free(p->vector);
 }
 
 
 





#endif
