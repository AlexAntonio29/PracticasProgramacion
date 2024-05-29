Algoritmo CalcularPrecio
	
	Escribir "Introduce el valor del precio 1"
	leer precio1
	Escribir "Introduce el valor del precio 2"
	leer precio2
	Escribir "Introduce el valor del precio 3"
	leer precio3
	//Si los tres precios son diferentes
	si precio3>precio2 Entonces
		si precio2>precio1
			preciof<-precio3+precio2
		FinSi
	FinSi
	
	si precio2>precio3 Entonces
		si precio3>precio1
			preciof<-precio3+precio2
		FinSi
	FinSi
	
	si precio1>precio2 Entonces
		si precio2>precio3
			preciof<-precio1+precio2
		FinSi
	FinSi
	
	si precio2>precio1 Entonces
		si precio1>precio3
			preciof<-precio1+precio2
		FinSi
	FinSi
	
	si precio3>precio1 Entonces
		si precio1>precio2
			preciof<-precio1+precio3
		FinSi
	FinSi
	
	si precio1>precio3 Entonces
		si precio3>precio1
			preciof<-precio1+precio3
		FinSi
	FinSi
	
	
	
	//si los dos precios son igules y uno desigual
	si precio1==precio2 Entonces
		si precio2>precio3
			preciof<-precio1+precio2
		SiNo
			preciof<-precio3+precio2
		FinSi
	FinSi
	
	si precio2==precio3 Entonces
		si precio3>precio1
			preciof<-precio3+precio2
		SiNo
			preciof<-precio3+precio1
		
		FinSi
	FinSi
	
	si precio1==precio3 Entonces
		si precio3>precio2
			preciof<-precio1+precio3
		SiNo
			preciof<-precio2+precio1
		FinSi
	FinSi
	//Si los tres precios son iguales
	si precio1==precio2&&precio2==precio3 Entonces
		preciof<- precio1*2
	FinSi
	
	Escribir "		Precio1: " precio1 
	Escribir "		Precio2: " precio2
	Escribir "		Precio3: " precio3 
	Escribir "Precio Final: " preciof 
	
FinAlgoritmo
