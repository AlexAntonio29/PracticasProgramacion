
/*
 * Crea un programa que simule el comportamiento del sombrero selccionador del
 * universo mágico de Harry Potter.
 * - De ser posible realizará 5 preguntas (como mínimo) a través de la terminal.
 * - Cada pregunta tendrá 4 respuestas posibles (también a selecciona una a través de terminal).
 * - En función de las respuestas a las 5 preguntas deberás diseñar un algoritmo que
 *   coloque al alumno en una de las 4 casas de Hogwarts (Gryffindor, Slytherin , Hufflepuff y Ravenclaw)
 * - Ten en cuenta los rasgos de cada casa para hacer las preguntas y crear el algoritmo seleccionador.
 *   Por ejemplo, en Slytherin se premia la ambición y la astucia.
 * 
 * los Gryffindors son conocidos por ser valientes, 
 * los Ravenclaws son los intelectuales, 
 * los Slytherins son astutos 
 * los Hufflepuffs son leales y trabajadores.
 * 
 * 
 * 
 */


function Gryffindor(respuesta){



}

function Slytherin(respuesta){
}

function Hufflepuff(respuesta){}

function Ravenclaw(respuesta){}



function sombrero(){
    let C_preguntas=1

    //if(C_preguntas)

    console.log("Vamos a ver en cual de las 4 casas quedarías")
    let p=[false,false,false,false,false]
    
    let Gryffindor=0
    let Slytherin=0
    let Hufflepuff=0
    let Ravenclaw=0

    /* * los Gryffindors son conocidos por ser valientes, 
 * los Ravenclaws son los intelectuales, 
 * los Slytherins son astutos 
 * los Hufflepuffs son leales y trabajadores.*/ 
        let respuesta
    switch(C_preguntas){
        case 1:
        if(p==false){console.log("¿Cuál es tu relación con los riesgos?\n1)te gustan las emociones fuertes     2)disfrutas de los desafíos intelectuales\n3)te sientes cómodo/a con lo desconocido    4)Prefieres la seguridad")
        switch(respuesta){
    case "1":
            Gryffindor++
            p[0]=true
    break
    case "2":
           Ravenclaw++
           p[0]=true
    break
    case "3":
        Slytherin++ 
        p[0]=true 
    break
    case "4":
            Hufflepuff++
            p[0]=true
    break
    default:

            console.log("Eso no es una respuesta")
        break;


        }
    }
        break
        case 2:
            if(p==false){console.log("¿Cuál es tu mayor ambición en la vida?\n1)Experimentar nuevas emociones y aventuras      2)Descubrir conocimientos ocultos\n3)alcanzar la fama y el reconocimiento     4)proteger a los que amas")
            switch(respuesta){
                case "1":
                        Gryffindor++
                        p[0]=true
                break
                case "2":
                       Ravenclaw++
                       p[0]=true
                break
                case "3":
                    Slytherin++  
                    p[0]=true
                break
                case "4":
                        Hufflepuff++
                        p[0]=true
                break
                default:

                console.log("Eso no es una respuesta")
            break;
                    }
        }
        break
        case 3:
            if(p==false){console.log("¿Dónde te sientes más en tu elemento?\n1)Explorando nuevos lugares   2)En la biblioteca\n3)En un desafío deportivo     4)Rodeado de amigos cercanos ")
            switch(respuesta){
                case "1":
                        Gryffindor++
                        p[0]=true
                break
                case "2":
                       Ravenclaw++
                       p[0]=true
                break
                case "3":
                    Slytherin++  
                    p[0]=true
                break
                case "4":
                        Hufflepuff++
                        p[0]=true
                break
                default:

                console.log("Eso no es una respuesta")
            break;
                    }
        }
        break
        case 4:
            if(p==false){console.log("¿Cómo reaccionas ante los desafíos o las situaciones desconocidas:\n1)enfrentándolos directamente    2)buscando consejo\n3)planeando cuidadosamente    4)adaptándote sobre la marcha")
            switch(respuesta){
                case "1":
                        Gryffindor++
                        p[0]=true
                break
                case "2":
                       Ravenclaw++
                       p[0]=true
                break
                case "3":
                    Slytherin++  
                    p[0]=true
                break
                case "4":
                        Hufflepuff++
                        p[0]=true
                break
                default:

                console.log("Eso no es una respuesta")
            break;
                    }
        }
        break
        case 5:
            if(p==false){console.log("Que cualidad valoras mas en ti mismo \n1)valentía, 2)sabiduría, 3)Atucia  4)Lealtad")
            switch(respuesta){
                case "1":
                        Gryffindor++
                        p[0]=true
                break
                case "2":
                       Ravenclaw++
                       p[0]=true
                break
                case "3":
                    Slytherin++  
                    p[0]=true
                break
                case "4":
                        Hufflepuff++
                        p[0]=true
                break
                default:

                console.log("Eso no es una respuesta")
            break;
                    }
        }
        break

    }





}

sombrero()