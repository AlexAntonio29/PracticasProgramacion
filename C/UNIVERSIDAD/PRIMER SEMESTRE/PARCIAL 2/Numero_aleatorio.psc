Algoritmo Numero_aleatorio
	Definir na Como Entero
	intentos<-1
	na<-Aleatorio(1,100)
	Escribir "Adivina el numero aleatorio"
	

	Mientras r<>na
		leer r	
		intentos=intentos+1
		
		si r>na Entonces
			Escribir "El numero es menor a " r
			
		FinSi
		si r<na Entonces
			Escribir "El numero es mayor a " r
			
		FinSi
		
		
	FinMientras
	
	Escribir "FELICIDADES..HAS ADIVINADO EL NUMERO en el intento " intentos
	
FinAlgoritmo
