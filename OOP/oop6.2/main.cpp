#include <iostream>
#include "C:\Program Files\CodeBlocks\MinGW\include\graphics.h"
#include <conio.h>

using namespace std;

class shapeColor{
protected:
    int color;
public:
    shapeColor(int c=1){color =c;}
    ~shapeColor(){cout<<"dectructor\n";}


};
///-----POINT----------
class Point{
    int x,y;
public:
    Point(){
        x=y=0;
        cout<<"point parameterless constructor 1"<<endl;
    }
    Point(int _x,int _y){
        x=_x;
        y=_y;
        cout<<"point constructor 2"<<endl;
    }
    ~Point(){
        cout<<"point Destructed!"<<endl;
    }
    int getX(){return x;}
    int getY(){return y;}
    void setX(int _x){x=_x;}
    void setY(int _y){y=_y;}
    void show(){cout<<"("<<x<<","<<y<<")"<<endl;}

};
///----------RECT-----------///composition
class Rect: public shapeColor{     //20 byte 8+8+4
    Point UL;  //8byte
    Point LR;  //8 byte
public:
    Rect(){ //reserved 20 bytes //initialized only 4 bytes
        cout<< "rect constructor 1"<<endl;
    }
    Rect (int x1,int y1,int x2,int y2 ,int c)
        :UL(x1,y1),LR(x2,y2),shapeColor(c)         ///constructor chaining  from rect ctor to point constructor(int,int) for initializing UL TL
    {
        cout<< "rect constructor 2"<<endl;

        //Ul.x=x1   WRONG we have no access x is private we should use setter and getter

    }
    ~Rect(){ //reserved 20 bytes //initialized only 4 bytes

        cout<< "rect DESTRUCRED"<<endl;
    }
    void draw(){
        setcolor(color);
        //built in
        rectangle(UL.getX(),UL.getY(),LR.getX(),LR.getY());

    }

};
///----------LINE-----------///composition
class Line: public shapeColor{     //20 byte 8+8+4
    Point p1;  //8byte
    Point p2;  //8 byte
public:
    Line(){
    }
    Line (int x1,int y1,int x2,int y2 ,int c)
        :p1(x1,y1),p2(x2,y2),shapeColor(c)
    {
    }
    ~Line(){ //reserved 20 bytes //initialized only 4 bytes
    }
    void draw(){
        setcolor(color);
        //built in
        line(p1.getX(),p1.getY(),p2.getX(),p2.getY());

    }

};
///----------circle-----------///composition
class Circle :public shapeColor{
    Point p1;
    int R;
public:
    Circle(){
    }
    Circle (int x1,int y1,int raduis,int clr)
        :p1(x1,y1),shapeColor(clr)
    {
        R=raduis;
        //color=clr;
    }
    ~Circle(){ //reserved 20 bytes //initialized only 4 bytes
    }
    void draw(){
        //built in
        setcolor(color);
        circle(p1.getX(),p1.getY(),R);

    }
};
///----------TRIANGLE-----------///composition
class Triangle :public shapeColor{
    Line l1;
    Line l2;
    Line l3;
public:
    Triangle(){
    }

    Triangle (int x1,int y1,int x2,int y2,int x3,int y3 ,int c)
        :l1(x1,y1,x2,y2,c),l2(x2,y2,x3,y3,c),l3(x3,y3,x1,y1,c),shapeColor(c)
    {
       // color=c;
    }
    ~Triangle(){ //reserved 20 bytes //initialized only 4 bytes
    }
    void draw(){
        //built in
        setcolor(color);

        l1.draw();
        l2.draw();
        l3.draw();
    }

};



int main()
{
    initgraph();
    int x[100]={115,370,200,200,290,290,245,200,215,290,275,245,125,140,155};
    int y[100]={500,566,500,400,500,400,400,400,300,400,300,300,555,520,555};
    //Point p1(10,10);
    //p1.show();
    //20 byte 8+8+4
    Rect R1(x[0],y[0],x[1],y[1],6);
    Line L1(x[2],y[2],x[3],y[3],7);
    Line L2(x[4],y[4],x[5],y[5],7);
    Circle C1(x[6],y[6],90,8);
    Line L3(x[7],y[7],x[8],y[8],2);
    Line L4(x[9],y[9],x[10],y[10],2);
    Circle C2(x[11],y[11],60,7);
    Triangle T1 (x[12],y[12],x[13],y[13],x[14],y[14],6);

    R1.draw();
    L1.draw();
    L2.draw();
    C1.draw();

    L3.draw();
    L4.draw();
    C2.draw();
    T1.draw();
   // rectangle(5,5,200,200);
    //line(150, 250, 450, 250);
    getch();
    //circle(300,300,50);
    return 0;
}
