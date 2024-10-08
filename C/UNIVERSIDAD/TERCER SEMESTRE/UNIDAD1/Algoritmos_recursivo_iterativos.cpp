#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <string.h>
#include <stack>
#include <cmath>
//Alexis Zosimo Antonio Angel 3B ISC 

//Estructura de Datos

using namespace std;
//FACTORIAL
int Factorial(int N)
{
	if (N==0)
	   return 1;	
	else
	   return Factorial (N-1) * N;
};

int FactorialIte( int N )
{
  int i, fact= 1;
  
  for (i=1; i<=N; i++)
      fact= fact * i;
	
  return fact;	   	
};


//FIBONACCI
int Fibonacci(int N){
  if (( N==0 ) || (N==1))
     return N;
  else
     return Fibonacci( N - 1 ) + Fibonacci( N - 2 );
};


int FibonacciIte( int N )
{
	
	int cont1=0,cont2=1;
for(int i=1;i<N;i++){
	
	cont2=cont1+cont2;	
	cont1=cont2-cont1;		
}
		
	return cont2;
};

//MCD

int MCD(int n1, int n2){
	if(n1%n2==0) return n2;
	else 
	return MCD(n2,n1%n2);
}

int MCDIte(int n1,int n2){

	int n3;
	while(n1%n2!=0){

		n3=n2;
		n2=n1%n2;
		n1=n3;	
	}
	
	return n2;
}

//Invertir Cadena 

char* invierte(char *frase,char *fraseinv, int longitud,int i){

	fraseinv[i]=frase[longitud];

	if(longitud==0) return fraseinv;
else return invierte(frase, fraseinv, longitud-1,i+1);



}

char* invierteIte(char *frase){

	char fraseInv[ 20 ];
	strcpy(fraseInv,frase);

	int longitud = strlen(frase);
	int cont=0;
	
	
	for(int i=longitud-1; i>=0;i--){
		frase[cont]=fraseInv[i];
		cont++;
	}
	return frase;
	
}

	
	
	//FUNCION ACKERMAN
	
	int funcionAckerman(int m, int n){ //1 3
		if(m==0) return n+1; //2
		
		
		
		if (m>0 && n==0){
			return funcionAckerman(m-1,n+1);// 0 1
		}
		
		if (m>0&&n>0){
			return funcionAckerman(m-1, funcionAckerman(m,n-1));//1 2, 1 1, 1 0,
		}
		return 0;
		
	}



//TORRES DE HANOI
void moverDisco(char desde, char hasta) {
    cout << "Mover disco de la torre " << desde << " a la torre " << hasta << endl;
}

void HanoiIte(int numDiscos, char torreOrigen, char torreDestino, char torreAuxiliar) {
    int totalMovimientos = pow(2, numDiscos) - 1; // Total de movimientos para n discos

    // Si el número de discos es par, intercambiar las torres de destino y auxiliar
    if (numDiscos % 2 == 0) {
        char temp = torreDestino;
        torreDestino = torreAuxiliar;
        torreAuxiliar = temp;
    }

    for (int movimiento = 1; movimiento <= totalMovimientos; movimiento++) {
        if (movimiento % 3 == 1) {
            moverDisco(torreOrigen, torreDestino); // Mover entre torre origen y torre destino
        } else if (movimiento % 3 == 2) {
            moverDisco(torreOrigen, torreAuxiliar); // Mover entre torre origen y torre auxiliar
        } else if (movimiento % 3 == 0) {
            moverDisco(torreAuxiliar, torreDestino); // Mover entre torre auxiliar y torre destino
        }
    }
}


void Hanoi(int numDiscos, char torreOrigen, char torreDestino, char torreAuxiliar) {
    if (numDiscos == 1) {
        // Caso base: si solo hay un disco, se mueve directamente
        cout << "Mover disco de la torre " << torreOrigen << " a la torre " << torreDestino << endl;
        return;
    }
    
    // Mover los (n-1) discos de torreOrigen a torreAuxiliar usando torreDestino
    Hanoi(numDiscos - 1, torreOrigen, torreAuxiliar, torreDestino);
    
    // Mover el disco restante de torreOrigen a torreDestino
    cout << "Mover disco de la torre " << torreOrigen << " a la torre " << torreDestino << endl;
    
    // Mover los (n-1) discos de torreAuxiliar a torreDestino usando torreOrigen
    Hanoi(numDiscos - 1, torreAuxiliar, torreDestino, torreOrigen);
}




void MenuPrincipal()
{
  int Opc, Num, longitud;
  char Frase[ 20 ];
  //char *Cad="Guadalajara";
  char Orig, Dest, Aux;
  int N, M;
  	char fraseinv[20];
	char Frase2[20];
  
  do {
       system("cls");
       cout << "Ejemplos utilizando algoritmos Recursivos" << endl;
       cout << "1. Factorial." << endl;
       cout << "2. Serie Fibonacci." << endl;
       cout << "3. Euclides." << endl;
       cout << "4. Invierte Cadena." << endl;
       cout << "5. Palindromo." << endl;
       cout << "6. Ackermann." << endl;
       cout << "7. Torres de Hanoi." << endl;
       cout << "0. Salir." << endl;
       
       cout << "Opcion: "; cin >> Opc;
       
       switch (Opc) {
         case 1: // Numero factorial
                 system("cls");
                 cout << "Dame un numero: ";
                 cin >> Num;
                 cout << "Factorial Recursivo:" << endl;
                 cout << "El factorial de " << Num << " es = " << Factorial(Num) << endl;
                 cout << "Factorial Iterativo:" << endl;
                 cout << "El factorial de " << Num << " es = " << FactorialIte(Num) << endl;
                 system("Pause");  
                 break;
                 
        case 2: // Serie fibonacci
                 system("cls");
                 cout << "Dame un numero: ";
                 cin >> Num;
                 cout << "La serie Fibonacci de " << Num << " es = " << Fibonacci(Num) << endl;
                  cout << "La serie Fibonacci de " << Num << " es = " << FibonacciIte(Num) << endl;
                 system("Pause");  
                 break;
                 
        case 3: // Algoritmo de Euclides o MCD
        
        				int Num2;
        			system("cls");
        			cout<< "Inserta el divisor ";
        			cin>> Num;
        			cout <<"Inserta el dividendo ";
        			cin >> Num2;
        			if(Num != 0){
        				int Num3;
        				if(Num2>Num) {Num3=Num; Num2=Num; Num=Num3;}
        				
        				cout << "El Maximo Comum Divisor de "<< Num <<" y "<< Num2<< " es: "<< MCD(Num,Num2) << endl;
        				cout << "El Maximo Comum Divisor de "<< Num <<" y "<< Num2<< " es: "<< MCDIte(Num,Num2) << endl;
					} else
					cout << "el dividendo no puede ser 0";
        			 system("Pause");  
        			break;
        
		case 4: // Invierte Cadena
                system("cls");
                cout << "Escriba una frase: ";
                cin >> Frase;
               longitud = strlen( Frase )-1;
               
                
              strcpy(fraseinv,Frase);
              strcpy(Frase2, Frase);
            
              
               cout << invierteIte(Frase)<<endl;
              cout << invierte( Frase2, fraseinv,strlen( Frase )-1,0 )<<endl;
                system("PAUSE");
                break;
                                  
        case 5: // Palindromo
         system("cls");
              
              	cout << "Escriba una frase: ";
                cin >> Frase;
               longitud = strlen( Frase )-1;
            
                
              strcpy(fraseinv,Frase);
              strcpy(Frase2, Frase);
            
              
               cout << invierteIte(Frase)<<endl;
              cout << invierte( Frase2, fraseinv,strlen( Frase )-1,0 )<<endl;
              
               if (strcmp(Frase,  fraseinv)==0)
			    cout<<"El resultado es un polindromo" <<endl;
			  else cout << "El resultado no es un polindromo"<<endl;
			   
                system("PAUSE");
                
        
        		break;
                

        case 6: // Algoritmo de Ackermann
        system("cls");
        int m,n;
                cout << "Escriba una valor m: ";
                cin >> m;
                cout << "Escriba una valor n: ";
                cin >> n;
                
                cout << "El resultado es "<< funcionAckerman(m,n) <<endl;
                
                
                
                
                
                  system("PAUSE");
        
        
        
        break;
		case 7: // Torres de Hanoi
            	Orig= 'A';
	            Aux= 'B';
	            Dest= 'C';

             	cout << "Numero de discos: ";
	            cin >> N;

	            cout << "\n Los movimientos a realizar son: \n";
                Hanoi( N, Orig, Dest, Aux); 
				cout<< "\nMovimientos de Hanoi Iterativo\n";
				
				  HanoiIte( N, Orig, Dest, Aux);       
	            system("Pause");
                break; 
       };            
      
  } while (Opc!=0);
}
  
int main (){
	
	char[MAX] frase;
	  
  MenuPrincipal(); 
  getchar();
	
  return 0;
}