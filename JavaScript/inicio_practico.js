//Practica Simples para comprender la estructura de JavaScript

    console.log("Hola mundo")// ingreso de comentario dentro del programa que sirve como anotacion
    console.log("Como estas")// con esto puedo generar una impresion de texto dentro de la consola

//generacion de variables
let cadena= "este es una cadena"
let numero=6 //este es un numero entero int
let numero2=5.2 //este es un flotante
let seleccion=true //este es un boleano verdadero o falso
//estos son los mas basicos

//se pueden añadir los valores variables dentro del console.log

console.log(cadena);
console.log(numero);
console.log("este es la suma de numero y numero2 "+ (numero+numero2));
console.log("y aqui se encuentra el valor boolenano "+ seleccion);

console.log(typeof seleccion)//el typeof nos sirve para saber dentro de la consola el tipo de variable que es.

//tambien existen cierto tipo de condicionadores por asi decirlo donde si cumplen cierta condicion puede hacer algo o si no pues hace otra
numero2= 7 //una variable puede cambiar de valor

if ( numero >= numero2){
    console.log(numero + " es mayor a " + numero2 )
}else  console.log(numero2+" es mayor a "+numero)

for (let i=0; i<=3; i++){
numero++
}

console.log(numero)

while(numero2<numero){
    numero2++
}

if(numero>numero2) console.log("El numero mayor es " + numero)
else console.log("el numero mayor es "+ numero2)

//uso de arreglo o arrays

let arreglo1 = (["hola","hola2","hola3","hola4"])
let arreglo2 = [1,2,3,4,5]
console.log(arreglo1[3])

arreglo1[4]="hola"
console.log(arreglo1)
console.log(arreglo1[4])
console.log(arreglo1)
console.log(arreglo2[4])
arreglo2[4]++
console.log(arreglo2[4])

console.log(arreglo1)

//uso de sets similar a array solo que este no acepta repetidos

let lista1= new Set(["hola","hola2","hola3","hola"])
console.log(lista1)//no aparece el ultimo hola

//uso de mapas, son como arreglos dobles pero igual que el set, estas no se pueden repetir

let mapa1= new Map([["valor1",5],["valor2",6],["valor3",7]])
let mapa2= new Map ([[1,"Alexis"],[2,"Alexis2"],[3,"Alexis3"]])

console.log(mapa1)

console.log(mapa1.get('valor1'))//para obtener el resultado de dicho texto
console.log(mapa2.get(2))

//Tambien se pueden añadir nuevos valores
mapa1.set("valor4",8)
console.log(mapa1)

//uso de for y while en arreglos
for(const valor of arreglo1){
    console.log(valor)
}
let contador=0
while(contador <arreglo1.length){
    console.log(arreglo1[contador])
    contador++
}

//uso de clases en javascript
//se hara el uso de un constructor. Sirve para dar los valores que que se agregen dentro de una nueva variable que tendra el nombre de N_persona
//lo que hace el constructor que generaremos nos sirve para generar valores con un orden establecido
class N_persona{
constructor(name,year,gene,genero){//En conclusion el constructor genera parametros establecidos dentro de una clase antes de usarla
    //es como decir que lo ocupamos con el fin de que solo si tiene estos datos, se puede utilizar esta clase
 this.name=name
 this.year=year
 this.gene=gene
 this.genero=genero
 if (this.gene)  this.genero="Femenino"//aqui se genera otro parametro para la persona en este caso es por el paramatro gene si es verdadero es femenino si es falso es masculino
 else this.genero="Masculino"
}

Analisis_p(){
    console.log(this)
    console.log((this.name) +" tiene la edad de "+ (this.year)+ " años")
}


}

let persona1= new N_persona("Alexis", 21, false)
let persona2=new N_persona("Pedro", 24, false)
let persona3=new N_persona("Laura",23, true)





 


 persona2.Analisis_p()
 persona1.Analisis_p()
 persona3.Analisis_p()

 console.log("La persona "+ persona1.name+ " es "+ persona1.genero)
 
 console.log("La persona "+ persona3.name+ " es " + persona3.genero)
 console.log(persona1.name)
 console.log(persona2.name)


//uso de constantes 
const constantes = {
    PI:3.14159,
    g:9.8
    
}
console.log(constantes.PI)

//Se usa la formula para calcula el perimetro de un circulo con una radio de 4

let P_circulo=2*(constantes.PI)*4
console.log("El perimetro del circulo es "+ (P_circulo))

//las funciones que estan dentro de una clase se le llama metodo y en javascript no es necesario que se escriba function si esta dentro de una clase
//y solo interactuan si son llamadas desde el repertorio principal

function Fun_1(){
    console.log("Me han ejecutado");
    
    }
    
    Fun_1()

    //ahora se vera la imporancia de las funciones

    function sumar(val1,val2){
        console.log(val1+val2)
    }
    function restar(val1,val2){
        console.log(val1-val2)
    }

    let oper1=5
    let oper2=6

    sumar(oper1,oper2)
    restar(oper1,oper2)
    //aqui se hizo un uso de la funcion suma y resta, pero que pasa si quiero usar esta funcion varias veces
    let oper3=8
    let oper4=4

    restar(oper3,oper4)//se uso otra vez la funcion restar y sin necesidad de tener que utilizar el codigo, es una buena manera de utilizar menos codigo y hacer varias operaciones similares
    //pero si vas hacer varias funciones similares entre si, las clases seguiran siendo la mejor opcion que tener que hacer todo solo
    class calculator{
        constructor(valor1, valor2){
    
            this.valor1=valor1
            this.valor2=valor2  
    
        }

        oper_suma(valor1,valor2){
          
          return (this.valor1+this.valor2)
    
        }
        oper_resta(valor1,valor2){
            return (this.valor1-this.valor2)
        }
        oper_division(valor1,valor2){
            return (this.valor1/this.valor2) 
        }
    
         oper_multiplicacion(valor1,valor2){
            return (this.valor1*this.valor2)
        }
        
        
    

    }

    let operation=new calculator (0,0)
    oper1=10
    oper2=15
    operation.valor1=oper1
    operation.valor2=oper2

    console.log(operation.oper_suma())
    console.log(operation.oper_resta())
    console.log(operation.oper_division())
    console.log(operation.oper_multiplicacion())

   //Asi se puede llamar en cualquier momento a los metodo y asi quedaria mucho mas ordenado y si por alguna razon si quisiese modificar el valor o hacer una operacion distinta
   // se hace lo siguiente
   operation.valor1=13
   operation.valor2=11
   console.log(operation.oper_suma())
   //Asi quedaria mucho mas ordenado


   //Uso de switch

   let calificacion = 5

   switch(calificacion) {

    case 0:
        case 1:
            case 2:
                case 3:
                    case 4:
                        case 5:
                            case 6:
                                case 7:
        console.log("El alumno reprobo")
        break
    case 8:
        console.log("El alumno aprobo")
        break
    case 10:
    case 9:
        console.log("El alumno obtuvo buenas notas")
        break
   }

   
    
    