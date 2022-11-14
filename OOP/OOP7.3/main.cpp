#include <iostream>
#include "C:\Program Files\CodeBlocks\MinGW\include\graphics.h"
#include <conio.h>

using namespace std;


class shape{
protected:
    int color;
public:
    shape(int c=1){color =c;}
    ~shape(){cout<<"dectructor\n";}
    virtual void draw()=0;


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
class Rect: public shape{     //20 byte 8+8+4
    Point UL;  //8byte
    Point LR;  //8 byte
public:
    Rect(){ //reserved 20 bytes //initialized only 4 bytes
        cout<< "rect constructor 1"<<endl;
    }
    Rect (int x1,int y1,int x2,int y2 ,int c)
        :UL(x1,y1),LR(x2,y2),shape(c)         ///constructor chaining  from rect ctor to point constructor(int,int) for initializing UL TL
    {
        cout<< "rect constructor 2"<<endl;

        //Ul.x=x1   WRONG we have no access x is private we should use setter and getter

    }
    ~Rect(){ //reserved 20 bytes //initialized only 4 bytes

        cout<< "rect DESTRUCRED"<<endl;
    }
    void draw()override{
        setcolor(color);
        //built in
        rectangle(UL.getX(),UL.getY(),LR.getX(),LR.getY());

    }

};
///----------LINE-----------///composition
class Line: public shape{     //20 byte 8+8+4
    Point p1;  //8byte
    Point p2;  //8 byte
public:
    Line(){
    }
    Line (int x1,int y1,int x2,int y2 ,int c)
        :p1(x1,y1),p2(x2,y2),shape(c)
    {
    }
    ~Line(){ //reserved 20 bytes //initialized only 4 bytes
    }
    void draw()override{
        setcolor(color);
        //built in
        line(p1.getX(),p1.getY(),p2.getX(),p2.getY());

    }

};
///----------circle-----------///composition
class Circle :public shape{
    Point p1;
    int R;
public:
    Circle(){
    }
    Circle (int x1,int y1,int raduis,int clr)
        :p1(x1,y1),shape(clr)
    {
        R=raduis;
        //color=clr;
    }
    ~Circle(){ //reserved 20 bytes //initialized only 4 bytes
    }
    void draw()override{
        //built in
        setcolor(color);
        circle(p1.getX(),p1.getY(),R);

    }
};
///----------TRIANGLE-----------///composition
class Triangle :public shape{
    Line l1;
    Line l2;
    Line l3;
public:
    Triangle(){
    }

    Triangle (int x1,int y1,int x2,int y2,int x3,int y3 ,int c)
        :l1(x1,y1,x2,y2,c),l2(x2,y2,x3,y3,c),l3(x3,y3,x1,y1,c),shape(c)
    {
       // color=c;
    }
    ~Triangle(){ //reserved 20 bytes //initialized only 4 bytes
    }
    void draw()override{
        //built in
        setcolor(color);

        l1.draw();
        l2.draw();
        l3.draw();
    }

};
class Pic2{
    shape **sh;
    int sz;
public:
    Pic2()
    {
        cout<<"Pic2 Ctor01 \n";
    }
    Pic2( shape ** sshh,int szz)
    {
        sh=sshh;
        sz=szz;
        cout<<"Pic2 Ctor02 \n";
    }
    ~Pic2() {cout <<"Pic2 Destructor \n";}


    void Paint()
    {
        for ( int i=0 ; i < sz; i++)sh[i]->draw();
    }


};



int main()
{
    initgraph();
    int x[100]={115,370,200,200,290,290,245,200,215,290,275,245,125,140,155};
    int y[100]={500,566,500,400,500,400,400,400,300,400,300,300,555,520,555};
    for(int i=0;i<15;i++)x[i]+=300;
    for(int i=0;i<15;i++)y[i]-=1;
    Rect* R;Circle *C ;Line* L;Triangle* T;
    R=new Rect[1];
    C=new Circle[2];
    L=new Line[4];
    T=new Triangle[1];
    //Pic p(R,L,C,T,1,4,2,1);

    R[0]=Rect(x[0],y[0],x[1],y[1],6);
    L[0]=Line(x[2],y[2],x[3],y[3],7); L[1]=Line(x[4],y[4],x[5],y[5],7);L[2]=Line(x[7],y[7],x[8],y[8],2); L[3]=Line(x[9],y[9],x[10],y[10],2);
    C[0]=Circle(x[6],y[6],90,8);C[1]=Circle(x[11],y[11],60,7);
    T[0]=Triangle(x[12],y[12],x[13],y[13],x[14],y[14],6);

    //p.Paint();

    shape *sh[8]={&R[0],&L[0],&L[1],&L[2],&L[3],&C[0],&C[1],&T[0]};
    Pic2 *p=new Pic2(sh,10);
    p->Paint();
   // rectangle(5,5,200,200);
    //line(150, 250, 450, 250);
    getch();
    //circle(300,300,50);
    return 0;
}
