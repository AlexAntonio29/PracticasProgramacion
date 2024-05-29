
/*Diseñar  un  programa  en  donde  se  capture  un  arreglo (o  lista)  de  5  elementos  y  2  números  enteros,  
el  programa tendrá que indicar alguno de los siguientes casos: 
•Los dos números enteros capturados se encuentran en el arreglo 
•Solo el primer número capturado se encuentra en el arreglo 
•Solo el segundo numero capturado se encuentra en el arreglo
•Ninguno de los dos números se encuentra en el arreglo

*/
function validacion(arreg, numero){
let val=0

for(i=0; i<arreg.length ; i++){//esta opcion dentro de for es solamente para arreglos en una variable cualquiera seria for (let i=0,i..5 )
    if(arreg[i]==numero) val++
  
}
return val
}

function into_val(){
let valor=prompt("introduce el valor para verificar","")

//if (valor!=Number) alert("ERROR")
return valor

}

function arrays(){
    let arreglo = []
    
    
    let valMin= (Math.floor(Math.random()* parseInt(100))+parseInt(1))
    if (valMin>=90)return arrays()
    let  valMax=valMin+10
        
       

        alert("se generara una lista del "+ valMin+" al "+valMax)
    let almacen=" "
    let valRang= prompt("Agrega el valor del rango","")
        
    for(i=0; i<valRang; i++)   {
        arreglo[i]=(Math.floor(Math.random()* (parseInt(valMax)-parseInt(valMin)+parseInt(1)))+parseInt(valMin))
     
        almacen=almacen+" "+arreglo[i]
    }
   // alert(arreglo[0])
    alert(almacen)
    return arreglo
    
}



let array=arrays()

let valor1=into_val()
let valor2=into_val()
let val1=validacion(array,valor1)
let val2=validacion(array,valor2)

if (val1 != 0) alert("El valor "+valor1+" se repite "+val1+" veces");
else alert("El valor "+ valor1 +" no aparece en la lista")

if (val2 != 0) alert("El valor "+valor2+" se repite "+val2+" veces");
else alert("El valor "+ valor2 +" no aparece en la lista")





