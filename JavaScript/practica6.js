
// En este proyecto tendremos  se practicara el uso de clases y tambien al uso de array mapas para poder tener un formulario bien estructurado, asi como de condicionadores y switch
/*
Debera de estar estructurado de tal manera que sea facil para el usuario poder interactuar con ella  (ULTIMO EN HACER)

Area y perimetro del circulo, cuadrado, triangulo, rectuangulo paralelogramo, trapezoide               (ESTARA EN LA CLASE OPERACION DENTRO DE UN METODO)
Algunas formulas de trigonometria como el teorema de Pitagoras, la altura y area de un triangulo equilatero
formulas del circulo sector circular, corona cirular, elipse
el area y volumen de algunas figuras




*/

class Formulas{//Datos de cualquier formula
constructor(names){
this._nombre_figura=names


}

get nombre(){
    return this._nombre_figura
}


get formulas2D(){
    
    let name;
    let s=true

    while(s){
        s=false
        name=prompt("De que figura deseas obtener su formula?\n\n1)Cuadrado  \n2)Rectangulo \n3)Paralelogramo  \n4)Trapezoide \n5)Circulo \n6)Triangulo  \n\n 0)SALIR","")
    switch((name)){
       
        case "1":
           // console.log("Aqui")
        this._nombre_figura="cuadrado"
        break
        case "2":
        this._nombre_figura="rectangulo"
        break
        case "3":
         this._nombre_figura="paralelogramo"
        break
        case "4":
        this._nombre_figura="trapezoide"
        break
        case "5":
         this._nombre_figura="circulo"
        break
        case "6":
         this._nombre_figura="triangulo"
        break
        case "0":
            alert("Has salido del programa")
            return
            break
        default:
            alert("HAS SELECCIONADO UN VALOR ERRONEO\n Intene nuevamente..")
            s=true
        break
    }

}
    return this._nombre_figura//este return le dara el nombre de la figura desde la clase formulas
}

get formulas3D(){
  
    let s=true

    let name
    while(s){
        s=false
        name=prompt("De que figura deseas obtener su formula?\n\n1)Paralelepipedo  \n2)Esfera \n3)Cilindro  \n4)Cono \n5)Tronco cono   \n\n 0)SALIR","")
    switch(name){
        case "1":
        this._nombre_figura="paralelepipedo"
        break
        case "2":
        this._nombre_figura="esfera"
        break
        case "3":
         this._nombre_figura="cilindro"
        break
        case "4":
        this._nombre_figura="cono"
        break
        case "5":
         this._nombre_figura="tronco cono"
        break
        case "0":
            alert("Has salido del programa")
            return
            break
        default:
            alert("HAS SELECCIONADO UN VALOR ERRONEO\n Intene nuevamente..")
            s=true
        break
        
    }
}
    return this._nombre_figura//este return le dara el nombre de la figura desde la clase formulas
}

get accion2d(){
        let name_accion
        let select
        let s=true
        
    switch(this._nombre_figura){
            case "cuadrado":
                case "rectangulo":
                    case "paralelogramo":
                        case "trapezoide":
               
            while(s){
                select=prompt(this._nombre_figura+"\n\n\nCual seria la formula?\n\n 1)Area  2)Permietro \n\n 0)SALIR","")
                s=false
            switch(select){
                case "1":
                    
                name_accion="area"
                
                break

                case "2":
                name_accion="perimetro"
                break
                case "0":
                    alert("Se saldra del programa")
                    return
                    break
                 default:
                alert("Valores no definidos.. intente nuevamente")
                s=true
                 break

            }
        }
            break
            
            case "circulo":


                    while(s){
                        s =false

                    
                select=prompt(this._nombre_figura+"\n\n\nCual seria la formula?\n\n 1)area  2)perimetro 3)area sector circular  4)lado sector circular 5)corona circular 6)elipse   \n\n 0)SALIR","")
                switch(select){
                    case "1":
                    name_accion="area"
                    break
    
                    case "2":
                    name_accion="perimetro"
                    break
                    case "3":
                    name_accion="area sector circular"
                    break
                    case "4":
                    name_accion="lado sector circular"
                    break
                    case "5":
                    name_accion="corona circular"
                    break
                    case "6":
                    name_accion="elipse"
                    break
                    case "0":
                        alert("Se saldra del programa")

                        return
                        break

                    default:
                        alert("Valores no definidos.. intente nuevamente")
                    s=true
                    break
                }
            }
             
            break
            case "triangulo":

                while(s){
                    s=false
                select=prompt(this._nombre_figura+"\n\n\nCual seria la formula?\n\n 1)area  2)perimetro 3)teorema de pitagoras  4)triangulo equilatero   \n\n 0)SALIR","")
                switch(select){

                    case "1":
                    name_accion="area"
                    break
                    case "2":
                    name_accion="perimetro"
                    break
                    case "3":
                    name_accion="teorema de piragoras"
                    break
                    case "4":
                    name_accion="triangulo equilatero"
                    break
                    case "0":
                        alert("se saldra del programa")
                        return

                        break
                    default:
                    alert("Valores no definidos.. intente nuevamente")
                    s=true
                    break
                }}
            
            break
            
            


    }
    return name_accion
}

get accion3d(){

    let name_accion
    let select
    let s=true



switch(this._nombre_figura){
        case "paralelepipedo":
            case "esfera":
                case "cilindro":
        
            while(s){
                select=prompt(this._nombre_figura+"\n\n\nCual seria la formula?\n\n1)Area     2)Volumen     0)Salir","")
                s=false
        switch(select){
            case "1":
            name_accion="area"
            break

            case "2":
            name_accion="volumen"
            break
            case "0":
                alert("Se saldra del programa")
                return
                break
            default:
                alert("Se ha ingresado el dato incorrecto... Intente nuevamente")
                s=true
                break

        }}
        
        case "cono":

            while(s){
                s=false
            select=prompt(this._nombre_figura+"\n\n\nCual seria la formula?\n\n1)area     2)volumen     3)altura cono  0)Salir","")

            switch(select){
                case "1":
                name_accion="area"
                break
    
                case "2":
                name_accion="volumen"
                break
                case "3":
                name_accion="altura cono"
                break
                case "0":
                    alert("Se saldra del programa")
                    return
                    break
                default:
                    alert("Se ha ingresado el dato incorrecto... Intente nuevamente")
                    s=true
                    break


                }}

        break

        case "tronco cono":
            name_accion="volumen"

        break
        }


        

        return name_accion



    }




}



class formulas2d extends Formulas{
    //gracias al constructor puedo llamar hacer varias acciones al momento de crear mi variable de este tipo de clase asi optimizando mas mi codigo
    constructor(nombre,accion,resultado){//cree un nuevo parametro de formula2d desde aqui dependiendo de los datos que se agreguen, te dara el resultado que buscas automaticamente
       super(nombre)
       this._accion=accion
        this._resultado=resultado
        
            console.log(this._accion)//desde aqui ya hago que mi propio codigo haga que se resuelva el resultado automaticamente desde el constructor esta puede 
            //hacer que la accion se realice al momento de crear una variable de tipo new clase(new formulas2d())
        switch(nombre){
            case "cuadrado":
                
            this._resultado=this.formula_cuadrado()//aqui llamo a la formula del cuadrado y el return sera el valor de _resultado
            
            break

            case "rectangulo"://rectangulo
            
            this._resultado=this.formula_rectangulo()
            break
            case "paralelogramo":
            this._resultado=this.formula_rectangulo()//aqui se uso la misma funcion ya que las formulas son practicamente las mismas
            break
            case "trapezoide":
            this._resultado=this.formula_trapezoide()
            break
            case "circulo":
            this._resultado=this.formula_circulo()
            break
            case "triangulo":
            this._resultado=this.formula_triangulo()
            break
            




        }

      
      
        
    }

    set accion(nueva_accion){
        this._accion=nueva_accion

        console.log(this._accion)

    }

    formula_cuadrado(){
        
        function area(){
           
            let s=true
            let lado
           
            
            while(s){
                
            lado=prompt("Cual es el lado de la figura?","")
                
              
            if(!isNaN(parseInt(lado)))  s=false 
                
                else alert("El valor introducido es invalido... Intente nuevamente") 
            
              
            }
            
            return (Math.pow(parseInt(lado), 2))
            
        }
        function perimetro(){
            let s=true
            let lado
            let verificador
            while(s){
                
            lado=prompt("Cual es el lado de la figura?","")
          
                    
            if(!isNaN(parseInt(lado)))  s=false 
            else alert("El valor introducido es invalido... Intente nuevamente") 
            }





            return lado*4
        }
        
            switch(this._accion){

                case "area":
                    
                return area()
                break
                case "perimetro":
                return perimetro()
                break
            }


    }
    

    formula_rectangulo(){

       
        function area(){
            let s=true
            let base,altura;
          

            while(s){
                base=prompt("Ingrese el valor de la base","")
                altura=prompt("Ingrese el baso de la altura","")
                
                if(!isNaN(parseInt(base))&&!isNaN(parseInt(altura)))s=false
            
        else alert("El valor ingresado es incorrecto... Intente nuevamente")
            }

            return base*altura


            
        }
        function perimetro(){
            let s=true
            let l1,l2;
           
            while(s){
                l1=prompt("Ingrese el valor de la base","")
                l2=prompt("Ingrese el valor de la altura","")
                
                if(!isNaN(parseInt(l1))&&!isNaN(parseInt(l2)))s =false
                    else alert("El valor ingresado es incorrecto... Intente nuevamente")
            
            }

            return (2*(l1))+(2*(l2))
        }

       

        switch(this._accion){

            case "area":
                
            return area()
            break
            case "perimetro":
            return perimetro()
            break
        }


    }

  

    formula_trapezoide(){
        function area(){
            let s=true

            let a,b,h 
                
                while(s){
                    a= prompt("Inrese el lado mas pequeño del trapezoide","")
                b= prompt("Ingrese el lado mas grande del trapezoide","")
                h=prompt("Ingrese su altura","")
                    
                    if(!isNaN(parseInt(a))&&!isNaN(parseInt(b))&&!isNaN(parseInt(c)))s= false
                       else alert("El valor ingresado es incorrecto... Intente nuevamente")
                
                }
                return (((a+b)/2)*h)
        }
        function perimetro(){
            let s=true

        
            while(s){
                let l1=prompt("Ingrese el lado 1","")
                let l2=prompt("Ingrese el lado 2","")
                let l3=prompt("Ingrese el lado 3","")
                let l4=prompt("Ingrese el lado 4","")
                s=false
                if(!isNaN(parseInt(l1))&&!isNaN(parseInt(l2))&&!isNaN(parseInt(l3))&&!isNaN(parseInt(l4)))s= false
               else alert("El valor ingresado es incorrecto... Intente nuevamente")
            
            }
            return (l1+l2+l3+l4)
        }

        switch(this._accion){

            case "area":
                
            return area()
            break
            case "perimetro":
            return perimetro()
            break
        }

    }

    formula_circulo(){

        function area(){

            let s=true

            let r
            let PI=3.14159

            while(s){
                r=prompt("Ingrese el valor de la radio","")
               
                if(!isNaN(parseInt(r)))s=false
                else alert("El valor ingresado es incorrecto... Intente nuevamente")
               
                
                
            }




            let rpow= Math.pow(r,2);



            return PI*rpow
        }
        function perimetro(){
            let s=true
            let PI=3.14159
            let r

            while(s){
                r=prompt("Ingrese el valor de la radio","")
                
                if(!isNaN(parseInt(r)))s=false
                else alert("El valor ingresado es incorrecto... Intente nuevamente")
                
                
                
            }

             return (2*PI*r)
        }
        function AreasectorCircular(){

            let s=true
            let PI=3.14159
            let r
            let grados
            let rpow=Math.pow(r,2)

            while(s){
                r=prompt("Ingrese el valor de la radio","")
                grados=prompt("Ingrese el valor de los grados","")
                s=false
                if(!isNaN(parseInt(r))&&!isNaN(parseInt(grados)))s=false
                else alert("El valor ingresado es incorrecto... Intente nuevamente")
                
                
                
            }

            return PI*rpow*(grados/360)


        }
        function ladosectorCircular(){

            let s=true
            let PI=3.14159
            let r=9
            let grados=30
            while(s){
                r=prompt("Ingrese el valor de la radio","")
                grados=prompt("Ingrese el valor de los grados","")
                
                if(!isNaN(parseInt(r))&&!isNaN(parseInt(grados)))s=false
                else alert("El valor ingresado es incorrecto... Intente nuevamente")
             
                
                
            }

            return PI*r*(grados/180)


        }
        function coronaCircular(){
            let s=true
            let PI=3.14159
            let R=10
            let r=8
            while(s){
                r=prompt("Ingrese el valor del Radio mayor","")
                R=prompt("Ingrese el valor del radio menor","")
                
                if(!isNaN(parseInt(r))&&!isNaN(parseInt(R)))s=false
               else alert("El valor ingresado es incorrecto... Intente nuevamente")
                
                
                
            }



            let rpow=Math.pow(r,2)
            let Rpow=Math.pow(R,2)

            return PI*(Rpow-rpow)

        }
        function elipse(){
            let s=true
            let PI=3.14159
            let a=10
            let b=8

            while(s){
                a=prompt("Ingrese el valor del lado a","")
                b=prompt("Ingrese el valor del lado b","")
                
                if(!isNaN(parseInt(a))&&!isNaN(parseInt(b)))s=false
                else alert("El valor ingresado es incorrecto... Intente nuevamente")
                
                
                
            }

            return PI*a*b
        }

        switch(this._accion){

            case "area":
            return area()
            break
            case "perimetro":
            return perimetro()
            break
            case "area sector circular":
            return AreasectorCircular()
            break
            case "lado sector circular":
            return ladosectorCircular()
            break
            case "corona circular":
            return coronaCircular()
            break
            case "elipse":
            return elipse()
            break
        }

    }

    formula_triangulo(){
        function area(){
            let s=true
            let base=5
            let altura= 8

            while(s){
              
                base=prompt("Ingresa el valor de la base","")
                altura=prompt("Ingresa el valo de la altura","")
                if(!isNaN(parseInt(base))&&!isNaN(parseInt(altura)))s=false 
                else alert("Error al ingresar los datos.. Intente nuevamente") 
                

            }

            return (base*altura)/2
        }
        function perimetro(){
            let s=true
            let a=4
            let b=3
            let c=6

            while(s){
               
                a=prompt("Ingresa el valor del lado a","")
                b=prompt("Ingresa el valo del lado b","")
                c=prompt("Ingresa el valor del lado c","")
                if(!isNaN(parseInt(a))&&!isNaN(parseInt(b))&&!isNaN(parseInt(c)))s=false
                else alert("Error al ingresar los datos.. Intente nuevamente") 
              

            }

            return a+b+c;
        }
        function teoremaPitagoras(){
            let s=true
            let desicion
            
            let hipotenusa, catetoA,catetoB;
        while(s){
            s=false
            desicion=prompt("Ingese se quiere econtrar el lado de la hipotenusa o el cateto\n\n 1)Hioptenusa   2)Cateto","")
           const valor = desicion=="1"? true: desicion=="2"?false: s=true
        }

                s=true
            

            if(valor){

                while(s){
                    s=false
                catetoA=prompt("Ingrese el valor del cateto A","")
                catetoB=prompt("Ingrese el valor del cateto B","")
                if (!isNaN(parseInt(catetoA))&&!isNaN(parseInt(catetoB)))s=false
                else alert("Datos ingresados incorrectamente.. Intente nuevamente")
                    
                
                
            }
                
                return Math.sqrt((Math.pow(catetoA,2))+Math.pow(catetoB,2))
                
            }
            else{
                hipotenusa=10
                catetoA=4

                while(s){
                   
                hipotenusa=prompt("Ingrese el valor de la hipotenusa","")
                catetoB=prompt("Ingrese el valor del cateto B","")
                if (!isNaN(parseInt(hipotenusa))&&!isNaN(parseInt(catetoB))) s=false
                   else alert("Datos ingresados incorrectamente.. Intente nuevamente")
                   
                
                
            }
                  
                return Math.sqrt((Math.pow(hipotenusa,2))-Math.pow(catetoA,2))

            }
            


        }
        function trianguloEquilatero(){
            let s=true

                function area(){
                    let s=true
                    let lado=4

                    while(s){
                       
                        lado=prompt("agregue el valor del lado del triangulo","")

                        if(!isNaN(parseInt(lado)))s=false
                            else alert("El valor agregado es incorrecto... Intente nuevamente")
                            
                    }
                    let ladopow=Math.pow(lado,2)
                    return ((ladopow)*(Math.sqrt(3)))/4
                }

                function altura(){
                    let s=true
                    let lado=4
                    while(s){
                       
                        lado=prompt("agregue el valor del lado del triangulo","")

                        if(!isNaN(parseInt(lado))) s=false
                          else  alert("El valor agregado es incorrecto... Intente nuevamente")
                           
                        
                    }


                    return (lado*Math.sqrt(3))/2
                }

                while(s){
                    s=false
                    let request= prompt("Que deseas obtener?\n\n1)Area    2)Altura","")

                const desicion= request=="1" ? true: request=="2"?false:s=true //aqui se debe de preguntar si desea el area o altura del tringulo equilatero
            }

                if (desicion)return area()
                else return altura()



                

        }
        switch(this._accion){

            case "area":
            return area()
            break
            case "perimetro":
            return perimetro()
            break
            case "teorema de piragoras":
            return teoremaPitagoras()
            break
            case "triangulo equilatero":
            return trianguloEquilatero()
            break
        }

    }
    
}

class formulas3d extends Formulas{
    constructor(nombre,accion,resultado){
        super(nombre)
        this._accion=accion
        this._resultado=resultado

        switch(nombre){

            case "paralelepipedo":
                this._resultado = this.paralelepipedo()
            break
            
            case "esfera":
                this._resultado = this.esfera()
            break
            
            case "cilindro":
                this._resultado = this.cilindro()
            break
            
            case "cono":
                this._resultado = this.cono()
            break
          
            case "tronco cono":
                this._resultado = this.troncoCono()
            break
        }
    }

    paralelepipedo(){
        let s=true
        let base=4
        let altura=3
        let profundidad=5

        function area(base,altura,profundidad){
        

        return (2*(base*altura)+2*(base*profundidad)+2*(altura*profundidad))
        }
        function volumen(base,altura,profundidad){
       

        return base*altura*profundidad

        }

        while(s){
         
            base= prompt("Cual es el valor de la base?","")
            altura= prompt("Cual es el valor de la altura?","")
            profundidad= prompt("Cual es el valor de la profundidad?","")

            if(!isNaN(parseInt(base))&&!isNaN(parseInt(altura))&&!isNaN(parseInt(profundidad))) s=false
               else alert("El valor agregado es incorrecto.. Intente nuevamente","")
                
            
        }

        switch(this._accion){

            case "area":

            return area(base,altura,profundidad)
            break
            case "volumen":
                return volumen(base,altura,profundidad)
                break
        }
    }
    esfera(){

        let radio
        let s=true
        function area(r){
            let PI=3.14159
           // let r=6
            let rpow=Math.pow(r,2)

            return (4*PI*rpow)
        
        }
        function volumen(r){
            let PI=3.14159
           // let r=9
            let rpow=Math.pow(r,3)

            return (4*PI*rpow)/3



        }

        while(s){
           
            radio=prompt("Ingrese el valor del radio de la esfera","")
            if (!isNaN(parseInt(radio))) s=false
               else alert("Valor agregador incorrectamente... Intente nuevamente","")
                
            
        }

        switch(this._accion){

            case "area":
            return area(radio)
            break
            case "volumen":
                return volumen(radio)
                break
        }
    }
    cilindro(){
        let s=true
        let radio
        let altura
        function area(r,h){
            let PI=3.14159
           // let r=9
            //let h=5

            return 2*PI*r*(r+h)
        }
        function volumen(r,h){
            let PI=3.14159
           // let r=9
            //let h=5
            let rpow=Math.pow(r,2)

            return PI*rpow*h

        }
        while(s){
            s=false
            radio=prompt("Ingrese el valor del radio del cilindro","")
            altura=prompt("Ingrese la altura del cilindro","")
            if (!isNaN(parseInt(radio))&&!isNaN(parseInt(altura))) s=false
              else  alert("Valor agregador incorrectamente... Intente nuevamente","")
                
            
        }


        switch(this._accion){

            case "area":
            return area(radio,altura)
            break
            case "volumen":
                return volumen(radio,altura)
                break
        }
    }
    cono(){
        function area(){
            let s=true
            let PI=3.14159
            let r=9
            let h=5
            let g=8

            while(s){
                r=prompt("Ingrese el valor del radio","")
                h=prompt("Ingrese el valor de la altura","")
                g=prompt("Ingrese el valor de la distancia de la base a la punta del cono","")
             
                if (!isNaN(parseInt(r))&&!isNaN(parseInt(h))&&!isNaN(parseInt(g))) s=false
                    elsealert("Alguno de los datos son incorrector.. Intente nuevamente")
                    
            }

            let rpow=Math.pow(r,2)


            return PI*rpow+PI*r*g

        }
        function volumen(){
            let s=true
            let PI=3.14159
            let r=9
            let h=5
            while(s){
                r=prompt("Ingrese el valor del radio","")
                h=prompt("Ingrese el valor de la altura","")
               
               
                if (!isNaN(parseInt(r))&&!isNaN(parseInt(h))) s=false
                   else alert("Alguno de los datos son incorrector.. Intente nuevamente")
                   
            }


            let rpow=Math.pow(r,2)

            return (PI*rpow*h)/3

        }

        function g(){
            let s=true
            let r=9
            let h=5
            while(s){
                r=prompt("Ingrese el valor del radio","")
                h=prompt("Ingrese el valor de la altura","")
               
              
                if (!isNaN(parseInt(r))&&!isNaN(parseInt(h))) s=false
                    else alert("Alguno de los datos son incorrector.. Intente nuevamente")
                    
                
            }

            return Math.sqrt(Math.pow(r,2)+Math.pow(h,2))
            

        }

        switch(this._accion){

            case "area":
            return area()
            break
            case "volumen":
                return volumen()
                break
            case "altura cono":
                return g()
                break
        }
    }
    troncoCono(){
        
        function volumen(){
            let s=true
            let PI=3.14159
            let r=9
            let h=5
            let R=10
            while(s){
                r=prompt("Ingrese el valor del radio menor","")
                R=prompt("Ingrese el valor del radio Mayor ","")
                h=prompt("Ingrese el valor de la altura","")
               
              
                if (!isNaN(parseInt(r))&&!isNaN(parseInt(h))&&!isNaN(parseInt(R)))  s=false
                    else alert("Alguno de los datos son incorrector.. Intente nuevamente")
                    
            }


            let rpow=Math.pow(r,2)
            
            let Rpow=Math.pow(R,2)

            return ((PI*h)*(rpow+r*R+Rpow))/3

        }
        return volumen();
    }


    
}

    

//let nuevaFormula= new formulas2d("cuadrado","area")
//console.log(nuevaFormula)






let desicion=true

let s=true
let accionF
let newFormula= new Formulas()


while(s){
    s=false
 val=prompt("Ingrese la opcion a considerar \n\n1)Formulas 2D   2)Formulas 3D","")

 if (val=="1")desicion=true
 else if (val=="2")desicion=false
 else { alert("datos ingresados incorrectamente..Intente nuevamente","")
s=true}


}

if(desicion){
    
    newFormula= new formulas2d(newFormula.formulas2D,newFormula.accion2d)
    
    
    /*las clases suelen ser muy curiosas de usar ya que desde una sola linea de codigos puedo
                                                                        hacer que mi clase formula2d interactue con la variable newFormula y que esta misma pueda interactuar con
                                                                        los parametros de la misma variable newFormula pero agregando las clases de la madre "Formulas" 
                                                                        
                                                                        Asi que desde aqui comento que las clases es recomendable que tengan clases heredadas para que desde la clase madre
                                                                        se puedan establecer los patrones de comportamiento para como actuen las clase hijos*/
    
    

}
else{
  
    newFormula= new formulas3d(newFormula.formulas3D,newFormula.accion3d)
    
    
}

alert("Formula del "+newFormula.nombre+":\n\n Del "+newFormula._accion+": "+newFormula._resultado)
console.log(newFormula)


    


