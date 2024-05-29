
function ascendente(){

    let numMin=prompt("introduzca valor minimo","")
    let numMay=prompt("introduzca valor mayor","")
  
    acum=""
    if (parseInt(numMin)>parseInt(numMay)){alert ("ERROR: numero mayor es menor")
        return ascendente()
}
   
    while(parseInt(numMin)<=parseInt(numMay)) {//el parseint es para justificar que realmente es un entero y no un string u otro valor
        acum= (acum+" "+numMin+" ")
      
        numMin++
       
    
    }
   
    console.log(acum)
   
    alert(acum)
    return
}

function descendente(){

    let numMin=prompt("introduzca valor minimo","")
    let numMay=prompt("introduzca valor mayor","")
    if (parseInt(numMin)>parseInt(numMay)){alert ("ERROR: numero mayor es menor")
    return descendente()
}
    acum=""
   
    while(parseInt(numMay)>=parseInt(numMin)) {//el parseint es para justificar que realmente es un entero y no un string u otro valor
        acum= (acum+" "+numMay+" ")
      
        numMay--
       
        
    }

    console.log(acum)
   
    alert(acum)
    return

}
function add(){
    let option=prompt("Escoge una opcion        1)ascendente    2)descendente" ,"")

switch(option){
    case "1":
        ascendente()
        break
    case "2":
        descendente()
        break
    default:

    alert("valor incorrecto")
    add()
    return
}
}

add()