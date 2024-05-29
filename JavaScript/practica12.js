/*
 * Escribe un programa que sea capaz de generar contraseñas de forma aleatoria.
 * Podrás configurar generar contraseñas con los siguientes parámetros:
 * - Longitud: Entre 8 y 16.
 * - Con o sin letras mayúsculas.
 * - Con o sin números.
 * - Con o sin símbolos.
 * (Pudiendo combinar todos estos parámetros entre ellos)
 */

let String_Pass=""
let NumbAle
let CaracterAle
let SimbolAle
let Rango


function Caracter(){
const Caracter=Aleatorio(1,26)
const MayOrMin=Aleatorio(1,2)

switch(Caracter){
        case 1:
            if (MayOrMin==1) return "a"
            else return "A"
        
        break
        case 2:
            if (MayOrMin==1) return "b"
            else return "B"
        break
        case 3:
            if (MayOrMin==1) return "c"
            else return "C"
        break
        case 4:
            if (MayOrMin==1) return "d"
            else return "D"
        break
        case 5:
            if (MayOrMin==1) return "e"
            else return "E"
        break
        case 6:
            if (MayOrMin==1) return "f"
            else return "F"
        break
        case 7:
            if (MayOrMin==1) return "g"
            else return "G"
        break
        case 8:
            if (MayOrMin==1) return "h"
            else return "H"
        break
        case 9:
            if (MayOrMin==1) return "i"
            else return "I"
        break
        case 10:
            if (MayOrMin==1) return "j"
            else return "J"
        break
        case 11:
            if (MayOrMin==1) return "k"
            else return "K"
        break
        case 12:
            if (MayOrMin==1) return "l"
            else return "L"
        break
        case 13:
            if (MayOrMin==1) return "ñ"
            else return "Ñ"
        break
        case 14:
            if (MayOrMin==1) return "o"
            else return "O"
        break
        case 15:
            if (MayOrMin==1) return "p"
            else return "P"
        break
        case 16:
            if (MayOrMin==1) return "q"
            else return "Q"
        break
        case 17:
            if (MayOrMin==1) return "r"
            else return "R"
        break
        case 18:
            if (MayOrMin==1) return "s"
            else return "S"
        break
        case 19:
            if (MayOrMin==1) return "t"
            else return "T"
        break
        case 20:
            if (MayOrMin==1) return "u"
            else return "U"
        break
        case 21:
            if (MayOrMin==1) return "v"
            else return "V"
        break
        case 22:
            if (MayOrMin==1) return "w"
            else return "W"
        break
        case 23:
            if (MayOrMin==1) return "x"
            else return "X"
        break
        case 24:
            if (MayOrMin==1) return "y"
            else return "Y"
        break
        case 25:
            if (MayOrMin==1) return "z"
            else return "Z"
        break
        case 26:
            if (MayOrMin==1) return "m"
            else return "M"
        break
        case 26:
            if (MayOrMin==1) return "n"
            else return "N"
        break
        default:
            return "A"
            break
}
   
}
function Simbolo(){

    let AleSimb=Aleatorio(1,15)

    switch(AleSimb){
        case 1:
        return "!"
        break
        case 2:
        return "#"
        break
        case 3:
        return "$"
        break
        case 4:
        return "%"
        break
        case 5:
        return "^"
        break
        case 6:
        return "&"
        break
        case 7:
        return "*"
        break
        case 8:
        return "("
        break
        case 9:
        return ")"
        break
        case 10:
        return "_"
        break
        case 11:
            return "="
        break
        case 12:
        return "<"
        break
        case 13:
        return ">"
        break
        case 14:
        return "?"
        break
        case 15:
        return "{"
        break
      default:
        return "&"
      break
    }
}
function RangoPassword(){

    let ran=prompt("1)Contraseña corta  2)Contraseña media  3)Contraseña Larga\n Introduce el Rango de la Contraseña","")

    switch (ran){
        case "1":
            return 8
            break
            case "2":
            return 12
            break
            case "3":
            return 16
            break
            default:
                alert("Dato ingresada incorrectamente.. Intente nuevamente")
                return RangoPassword()
                break
    }
    
}



function Aleatorio(valMin, valMax) {
    return Math.floor(Math.random()*parseInt(valMax)-parseInt(valMin)+1)+parseInt(valMin)

}

let AlParam
let i
Rango=RangoPassword()//Introducir rango de la contraseña




for (i=0; i<Rango;i++){
    AlParam=Aleatorio(1,3)//AlParam almacenara los datos aleatorios del 1 al 3 dependiendo de que valor salga ese sera el dato de Numero, Caracter o simbolo
   switch(AlParam){
    case 1:
        String_Pass+=Simbolo()
        break
        case 2:
            String_Pass+=Caracter()
        break
        case 3:
        String_Pass+=Aleatorio(1,9)
        break
   }
}
alert("New Password: "+ String_Pass)
console.log(String_Pass)

