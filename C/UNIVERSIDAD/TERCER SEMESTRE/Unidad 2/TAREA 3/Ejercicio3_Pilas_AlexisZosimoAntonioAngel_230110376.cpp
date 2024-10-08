//ALEXIS ZOSIMO ANTONIO ANGEL;
 
 #include <stdio.h>
 #include <string.h>
 #include "pilachar.h"
 #define lim 20
 

 int tope;
 
bool estaBalanceado(char *n){
	
	TPila p;
	
	
	initPila(&p, lim);
	
	
	for(int i=0; i<strlen(n);i++){
		char elem;
		if(n[i]=='['||n[i]=='{'||n[i]=='(') push(&p,n[i]); 
		if(n[i]==']'||n[i]=='}'||n[i]==')') {
			char caracter=n[i];
			char caracterOpuesto;
			
			if (caracter==']') caracterOpuesto='[';
			if (caracter=='}') caracterOpuesto='{';
			if (caracter==')') caracterOpuesto='(';
			
			pop(&p, &elem);
			
			if (!(elem==caracterOpuesto)) push(&p,elem);
				
			
		}		
		
	}


if(pilaVacia(p)==1) return false;
else return true;
}
 
 
 int main(){
 	
 	
	char frase[lim];
	
	printf("ingresa una cadena de caracteres\n");		
	scanf("%s",&frase);
	
	
	if(estaBalanceado(frase))
		printf("La expresion esta balanceada");
	else printf("La expresion no esta balanceada");
	
 	return 0;
 }
 
 void topePila(){
 	
 	
 }
 
 
 
 
 