#include <stdio.h>

//Examen Unidad 1 problema 1

//Generar un algoritmo que te genere los intereses anuales de m cantidad de capital por x% porcentaje


int inversionRecursiva(int m, int n, int x){ //m capital, n años, x porcentaje de interes
	int interes= (m/100)*x;	
	int ganancia_anual= m+interes;
	if (n==0) return m;
	else
		return inversionRecursiva(ganancia_anual, n-1,x);
}


int inversionIte(int m, int n, int x){ //m capital, n años, x porcentaje de interes


for(int i=1;i<=n;i++){
	int interes= (m/100)*x;	
	m=m+interes;
	
}

return m;
}




int main(){
	
	int m=1000;//capital
	int n=5;//años
	int x=15;//interes
	
	int resultadoR=inversionRecursiva(m,n,x);
	int resultadoI=inversionRecursiva(m,n,x);
	
	printf("La ganancia es %d \n", resultadoR );
		printf("La ganancia es %d ", resultadoI );
	
	return 0;
	
	
	
	
	
}