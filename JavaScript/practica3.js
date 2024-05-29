
/**
Problema 3 
 * Codificar un  programa  en  donde  el  usuario  este  capturando  números  positivos;  
 * cuando  se  ingrese  un  número negativo, la captura terminará y se mostrará el 
 * promedio de los números positivos capturados. 
 */

function acumulador(){
    let acum=0
    let num=0
    let cant=0

    while(num>=0){
        num=prompt("Agregue un valor","")
        if(num>=0){acum=(parseInt(acum )+parseInt(num)), cant++}
        
        
    }
    alert("El promedio es " + acum/cant);

}

acumulador()