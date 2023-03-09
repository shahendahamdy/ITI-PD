/*
1) Using ES6 new Syntax & features:
 Write a script to create different shapes (rectangle, square, circle, triangle) make all of them inherits from polygon.
 Display the area and each object parameter in your console by overriding toString()
 Draw your created shapes to a canvas element.
*/
var c = document.getElementById("myCanvas");
var ctx = c.getContext("2d");
var posX=10,posY=10;
function drawShape(obj){
    if(obj.name=="rect"||obj.name=="sq"){
        ctx.beginPath();
        ctx.rect(posX, posY, obj.x, obj.y);
        posX+=obj.x +10;
        posY=obj.y+10;
        ctx.stroke();
    }
    else if(obj.name=="circle"){
        ctx.beginPath();
        posX+=(obj.x *2);
        posY+=(obj.x *2);
        ctx.arc(posX, posY, obj.x, 0, 2 * Math.PI);
        posX+=obj.x +10;
        posY=obj.y+10;
        ctx.stroke();
    }
    else if(obj.name=="triangle"){
        console.log('iam  triangle'+"  "+posX+"  "+posY +" "+obj.x +" "+obj.y)
        ctx.beginPath();
        ctx.moveTo(posX, posY);
        ctx.lineTo(posX, posY+obj.y);
        ctx.lineTo(posX+obj.x, posY+obj.y);
        
        posX+=obj.x +10;
        posY=obj.y+10;
        ctx.closePath();
        ctx.lineWidth = 10;
        ctx.strokeStyle = '#666666';
        ctx.stroke();
    }
    console.log("x->  "+posX);

}

class polygon{
    constructor(_x,_y,shape="polygon"){
        this.x=_x
        this.y=_y
        this.name=shape
    }
     calcArea(){
        return this.x*this.y   
    }
    toString(){
        return this.calcArea();
    }
}

class triangle extends polygon{
    constructor(_x,_y,shape="triangle"){
        super(_x,_y,shape="triangle");
        drawShape(this);

    }
     calcArea(){
        return 0.5 *this.x*this.y;
     }
}
class rectangle extends polygon{
    constructor(_x,_y,shape="rect"){
        super(_x,_y,shape="rect");
        drawShape(this);
    }
}
class square extends polygon{
    constructor(_x,_y,shape="sq"){
        super(_x,_y,shape="sq");
        drawShape(this);

    }
}
class circle extends polygon{
    constructor(_x,_y,shape="circle"){
        super(_x,_y,shape="circle");
        drawShape(this);

    }
    calcArea(){
        return Math.PI*this.x**2;
     }
}
r1=new rectangle(30,70)
s1=new square(30,30)
c1=new circle(50,50,"circle");
t1=new triangle(60,60)

console.log(r1.toString());
console.log(s1.toString());
console.log(c1.toString());
console.log(t1.toString());