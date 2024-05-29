



    
 export function ChangeCharacter(letter){//Siempre que queremos usar una archivo js como un archivo que es llamado en otras scrpt siempre debemos usar  este  comando


   // Aqui se encuentra el diccionario con el lenguaje hacker
    let select
    let CanRename
    let rename
    switch (letter) {//Aqui se encuentra el switch que detecta cada caracter de la letra que enviamos
            case "a":
                case "A":
                rename={ //Rename es una variable que se convierte en objeto porque almacena varias variables dentro
                    1:"4",
                    2:"@"
                }

                break

                case "b":
            case "B":
                rename={
                    1:"8",//Y dependiendo del caracter que detecta el rename va remplazando sus variables
                    2:"ß",
                   
                }
                break
                case "c":
            case "C":
                rename={
                    1:"[",
                    2:"¢",
                    3:"{",
                    4:"<",
                    5:"(",
                    6:"©"
                    
                }
                break
                case "d":
            case "D":
                rename={
                    1:")",
                    2:"?",
                    3:">"
                }
                break
                case "e":
            case "E":
                rename={
                    1:"3",
                    2:"&",
                    3:"£",
                    4:"€",
                    5:"ë"
                }
                break
                case "f":
            case "F":
                rename={
                    1:"ƒ",
                    2:"v"
                }
                break
                case "g":
            case "G":
                rename={
                    1:"&",
                    2:"6",
                    3:"9"
                }
                break
                case "h":
            case "H":
                rename={
                    1:"#"
                }
                break
                case "i":
            case "I":
                rename={
                    1:"!",
                    2:"|"
                }
                break
                case "j":
            case "J":
                rename={
                    1:"]",
                    2:";"
                }
                break
                case "k":
            case "K":
                rename={
                    1:">|",
                    2:"|<",
                    3:"/<",
                    4:"1<",
                    5:"|c",
                    6:"|(",
                    7:"|{"
                }
                break
                case "l":
            case "L":
                rename={
                    1:"£",
                    2:"|_",
                    3:"|",
                    
                }
                break
                case "m":
            case "M":
                rename={
                    1:"JVI",
                    2:"[V]",
                    3:"[]V[]",
                    4:"^^",
                    5:"(v)",
                    6:"(V)",
                    7:"|V|",
                    8:"nn",
                    9:"IVI",
                    10:"1^1",
                    11:"ITI",
                    12:"JTI",
                  
                }
                break
                case "n":
            case "N":
                rename={
                    1:"^/",
                    2:"|V",
                    3:"/V",
                    4:"И",
                    5:"^",
                    6:"ท"
                }
                break
                case "o":
            case "O":
                rename={
                    1:"0",
                    2:"Q",
                    3:"()",
                    4:"oh",
                    5:"[]",
                    6:"p",
                    7:"<>",
                    8:"Ø",
                }
                break
                case "p":
            case "P":
                rename={
                    1:"|*",
                    2:"|o",
                    1:"|º",
                    1:"?",
                    1:"|^",
                    1:"|>",
                    1:"[]D",
                    1:"|°",
                    1:"|7"
                    
                    
                }
                break
                case "q":
            case "Q":
                rename={
                    1:"(_,)",
                    2:"()_",
                    3:"2",
                    4:"0_",
                    5:"<|"
                }
                break
                case "r":
            case "R":
                rename={
                    1:"I2",
                    2:"|`",
                    3:"|~",
                    4:"|?",
                    5:"|^",
                    6:"lz",
                    7:"|9",
                    8:"12",
                    9:"®",
                    10:"[z",
                    11:"Я",
                    12:".-",
                    13:"|2",
                    14:"|-"
                }
                break
                case "s":
            case "S":
                rename={
                    1:"5",
                    2:"$",
                    3:"z",
                    4:"§",
                    5:"ehs",
                    6:"es"
                }
                break
                case "t":
            case "T":
                rename={
                    1:"7",
                    2:"+",
                    3:"-|-",
                    4:"']['",
                    5:"†",
                    6:"~|~"
                }
                break
                case "u":
            case "U":
                rename={
                    1:"(_)",
                    2:"|_|",
                    3:"v",
                    4:"L|",
                    5:"µ",
                    6:"บ"
                }
                break
                case "v":
            case "V":
                rename={
                    1:"|/"
                }
                break
                case "w":
            case "W":
                rename={
                    1:"'//",
                    2:"(n)",
                    3:"Ш",
                    4:"Щ",
                    5:"uu",
                    6:"2u",
                    7:"พ",
                    8:"v²"
                }
                break
                case "x":
            case "X":
                rename={
                    1:"><",
                    2:"Ж",
                    3:"}{",
                    4:"ecks",
                    5:"×",
                    6:")(",
                    7:"]["
                    
                }
                break
                case "y":
            case "Y":
                rename={
                    1:"j",
                    2:"Ч",
                    2:"¥"
                }
                break
                case "z":
            case "Z":
                rename={
                    1:"7_",
                    2:"-/_",
                    3:"%",
                    4:">_",
                    5:"s",
                    6:"~/_",
                    6:"~|_"
                }
                break
    
        

                
            
           
    
        default:

        console.log("Datos incorrecto")
            break;
    }

    letter=rename

    //console.log(rename)


    CanRename=Object.keys(rename).length//Agregamos el limite de rename osea el limite de variables del objeto digamos  que seleccionamos la palabra "a" el rename se convierte en objeto de que contiene 1=4 y 2=@ ya que el lenguaje hacker tiene esos dos caracteres como "a" por lo tanto tiene un limite de 2

    
    select= Math.floor(Math.random()* parseInt(CanRename)-parseInt(1)+1)+1//Aqui para hacer mas interesante el problema hacemos que select genere un numero aleatorio del 1 a la cantidad de limite que tiene el rename que es el objeto que almacena las variables osea la cantidad de variables que tiene dentro
        //Asi que toma 1 numero aleatorio del 1 al limite
    letter= rename[select]//Asignamos que letter va ha ser el valor rename y selecciona la cadena con select dentro la cual es el valor aleatorio
    //por tanto seleccionamos al azar un valor del objeto rename 
     

     return letter // regresamos  la variable letter con el su nuevo caracter en lenguaje hacker



}

let nombre="Alexis" //Aqui hacemos igualmente la prueba pero sin necesidad de llamarlo desde otro archivo sino de manera local
let limitador= (Object.keys(nombre).length)-1//agregamos el limitador
let i
let NombreHaker =""

for(i=0;i<=limitador;i++){
NombreHaker+= ChangeCharacter(nombre[i])//la variable nombre hacker va almacenando los valores que nos esta enviando el nombre pero como tiene [i] va enviando caracter por caracter de cada uno de los string 
}
console.log(NombreHaker) 



