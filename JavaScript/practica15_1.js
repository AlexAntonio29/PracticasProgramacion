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
 * preguntas
 * 1. Qué cualidad valoras más en ti mismo?
 *  1)valentía   2)astucia   3)lealtad  4)sabiduría   
 * 
 * 2.¿Dónde te sientes más en tu elemento?
 *  1)explorando nuevos lugares   2)En un desafío deportivo   3)en la biblioteca  4)rodeado de amigos cercanos
 * 
 * 3. ¿Cómo reaccionas ante los desafíos o las situaciones desconocidas?
 *  1)enfrentándolos directamente 2)planeando cuidadosamente   3)buscando consejo  4)adaptándote sobre la marcha?
 * 
 * 
 * 4. ¿Qué tipo de magia te atrae más?
 *  la magia curativa   2)los hechizos poderosos   3)la transformación de objetos  4)La comunicación con criaturas mágicas?
 * 
 * 
 * 5. En una situación de conflicto, ¿qué te guía más?
 * 
 *  1)tu capacidad para encontrar soluciones prácticas 2)tu intuición   3)Tu lógica  4)Tus emociones
 * 
 * 6. Si tuvieras que elegir una mascota mágica? 
 * 1)Un hipogrifo  2)Optarías por un fénix   3)kneazle inteligente  4)un dragón bebé
 * 
 * 7.¿Cuál es tu mayor ambición en la vida?  
 * 
 * 1)experimentar nuevas emociones y aventuras   2)alcanzar la fama y el reconocimiento    3)descubrir conocimientos ocultos  4)proteger a los que amas 
 * 
 * 
 * 8.¿Qué lugar te parece más intrigante?
 * 1)océano profundo e inexplorado  2)Una selva densa y misteriosa    3)un castillo antiguo lleno de secretos   4)una montaña elevada y majestuosa
 * 
 * 
 * 9. ¿Qué te inspira más?
 * 1)la justicia y la equidad  2)El arte y la creatividad  3)el conocimiento profundo  4)la conexión con la naturaleza?
 * 
 * 
 * 10. ¿Cuál es tu relación con los riesgos?
 * 1)te gustan las emociones fuertes   2)te sientes cómodo/a con lo desconocido  3)disfrutas de los desafíos intelectuales   4)prefieres la seguridad 
 * 
 */


function pregunta(Question, key){
    let i
    let NumbAle=Math.floor(Math.random()* parseInt(10)-parseInt(0)+0)+parseInt(0)
 if(key[NumbAle]==false){
    for(i=0;i<=9;i++){
        if (key[i]) {NumbAle}
    }
 }

    switch(NumbAle){
        case 0:
        if(key[NumbAle]) {Question="¿Qué cualidad valoras más en ti mismo?"
        key[NumbAle]=false
            }

        break
        case 1:
            if(key[NumbAle]) {Question="¿Dónde te sientes más en tu elemento?"
            key[NumbAle]=false
                }
        break
        case 2:
            if(key[NumbAle]) {Question="¿Cómo reaccionas ante los desafíos o las situaciones desconocidas?"
            key[NumbAle]=false
                }
        break
        case 3:
            if(key[NumbAle]) {Question="¿Qué tipo de magia te atrae más?"
            key[NumbAle]=false
                }
        break
        case 4:
            if(key[NumbAle]) {Question="¿En una situación de conflicto, ¿qué te guía más?"
            key[NumbAle]=false
                }
        break
        case 5:
            if(key[NumbAle]) {Question="¿Si tuvieras que elegir una mascota mágica?"
            key[NumbAle]=false
                }
        break
        case 6:
            if(key[NumbAle]) {Question="¿Cuál es tu mayor ambición en la vida?"
            key[NumbAle]=false
                }
        break
        case 7:
            if(key[NumbAle]) {Question="¿Qué lugar te parece más intrigante?"
            key[NumbAle]=false
                }
        break
        case 8:
            if(key[NumbAle]) {Question="¿Qué te inspira más?"
            key[NumbAle]=false
                }
        break
        case 9:
            if(key[NumbAle]) {Question="¿Cuál es tu relación con los riesgos?"
            key[NumbAle]=false
                }
        break

        default:
            return pregunta(Question, key)

    }
 

    console.log(NumbAle+"  "+Question+"\n")
    return Question

}
let key=[]
let i;
for(i=0;i<=9;i++) key[i]=true

let valor=key

console.log(key.length)


for(i=0;i<=9;i++)
pregunta("", key)    





console.log(key)                                                        

