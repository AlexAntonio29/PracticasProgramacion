/*
 * Escribe un programa que reciba un texto y transforme lenguaje natural a
 * "lenguaje hacker" (conocido realmente como "leet" o "1337"). Este lenguaje
 *  se caracteriza por sustituir caracteres alfanuméricos.
 * - Utiliza esta tabla (https://www.gamehouse.com/blog/leet-speak-cheat-sheet/) 
 *   con el alfabeto y los números en "leet".
 *   (Usa la primera opción de cada transformación. Por ejemplo "4" para la "a")
 * 
 * Aqui haremos una pequeña introduccion a a ECMAScript 2015 (ES6)
 * 

 */
import {ChangeCharacter} from './practica10_1.js'//Se importa el archivo practiaca10_1.js a este js ESTO ES GRACIAS AL SC6
//Aqui ya se empieza a usar SC6 de javasctipt que son metodos que se implementaron en 2015 
//Para que funcione de manera correcta es necesario tener que hacer algunos procesos
//ejecutarlo desde un html es distinto, ya que llamo a un script dento de otro script
//por lo tanto si el navegador detecta que lo intentas ejecutar de manera local, te bloquea el acceso
//para que puedas usarlo como practica y mas que nada para comprobar que el programa funciona
//se necesita desbloquear la seguridad del navegador para que pueda funcionar el programa
//Esto no es recomendado para hacer pero para practicar es una solucion facil
//Recuerda dejar las cosas en su lugar cuando termines de hacer la practica
//accede en el navegador el comando about:config te saldra un mensaje que dice que es peligroso configurar las opciones le das en aceptar
//despues dentro del navegador agregamos las palabras security.fileuri.strict_origin_policy esto buscara la configuracion que deseamos desactivar
//despues cambiamos de true a false

//Y asi se podra probar este programa sin problemas como si de un script normal se tratara

//OJO: RECUERDA DEJAS LA OPCION EN TRUE CUANDO TERMINES






function NewWord(word, limite,acum){//En esta funcion hacemos que la palabra que mandemos rote las letras y utilizando la recursion hacemos que se coloquen uno detras del otro
    // por ejemplo la palabra Alex va a rotar => Alex -lexA - exAl - xelA
    //colocando en primer caracter el siguiente

    let letter=word[0]
    let lim=(Object.keys(word).length)// AQUI TAMBIEN SE UTILIZA LOS METODOS SC6 DE OBJECT LO QUE HACE ES DETECTAR EL STRING LAS PALABRAS QUE SE ENCUENTREN DENTRO DE ELLAS Y CON EL COMPLEMENTO .length se puede comprobar la cantidad de caracteres(letras) que tiene dicho sting
    let firstWord=word[0]
    let newWord=""
    let i
    console.log(word[0])
   


    acum+=ChangeCharacter(word[0])//AQUI LLLAMAOS A LA FUNCION DENTRO DE practica10_1.js y le damos com datos el word[0]=>que es la primera palabra de word
    //Pero recuerden que word va rotando por cada recursion que hace
    acum+=" "



    for(i=0;i<lim;i++){  //Con el for hacermos que las palabras roten
        if(i!=lim-1)newWord+=word[i+1]
           
        if(i==lim-1) newWord+=firstWord
            

    }

   word=newWord

   
 
    return limite==0? acum : NewWord(word,limite-1,acum)//aqui utilizamos una recursion ternaria para ahorrar codigo y hacer que puedan tener dos posibles return
    //que si el limite que le tenermos (la cantidad de palabras) llega a 0 esta mande acum(varible que ha estado acumulando las cadenas que convierten la una palabra en palabra "Hacker")
    //si no se cumple la funcion, hacemos que recursion tome nuevamente a la funcion NewWord para que vuelva a repetir e proceso
    //pero con el cambio de que word rote sus palabras y que limite se este eliminado hasta llegar a 0  y acum sumando los string que esta acumulando


}





let name=prompt("Introduce tu nombre","")
let name2=""
let newName;
let i
for(i=(Object.keys(name).length)-1; i>=0;i--){ //Esto es de prueba para ver como funcionaba el Object.keys para tomar los caracteres que estan en la variable y con el .length hacemos que nos diga cuantos caracteres tiene

    name2+=name[i]//name2 va sumando la rotacion 
}
console.log(name2) //name2 debe arrojar el nombre que asignemos pero invertido  Alex =>xelA
alert(name2)

let numName=(Object.keys(name).length)-1//Aqui agregamos el limite y le restamos 1 para que no de errores ya que recordemos que un string es un arreglo de cadenas por lo tanto un arreglo siempre empieza su primer valor almacenado con 0 y el segundo con 1 y asi sucesivamente


newName=NewWord(name, numName,"")//nos vamos a la funcion mandando el nombre (name) el limite que es la cantidad de arreglos dentro de nuestro string ejemplo alex(3) a=0 l=1 e=2 x=3 por tanto el limite es 3 y una cadena vacia para que se convierta en el acumulador y asi limita a la funcion de manera recursiva de solo pasar hasta que todas las letras ya esten modificada y que no se pase.


alert("Tu nuevo nombre en lenguaje Hacker es "+name+": "+newName)//Resultado




