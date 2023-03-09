#include <iostream>

using namespace std;

class GeoShape{
protected :
    int Dim1 ,Dim2;
public:
    GeoShape(int d1=0,int d2=0){
        Dim1=d1;Dim2=d2;
        cout<<"GeoShape constructor\n";
    }
    ~GeoShape(){
        cout<<"GeoShape Destructed \n";
    }
    int getDim1(){return Dim1;}
    int getDim2(){return Dim2;}
    void setDim1(int d){Dim1=d;}
    void setDim2(int d){Dim2=d;}
    virtual double cArea(){return 0;}
    //not implementing cArea in Geoshape
    //delegate , cArea implementation to derived class
};
///------RECTANGLE--------------
class Rect : public GeoShape{

public:
    Rect(int w,int h)
        :GeoShape(w,h){
        cout<<"rect constructor\n";
    }
    Rect(){}
    ~Rect(){
        cout<<"rect Destructed \n";
    }
     double cArea(){return Dim1*Dim2;}

};
///------SQUARE--------------
class Square : public Rect{

public:
    Square(int L)
        :Rect(L,L){
        cout<<"SQUARE constructor\n";
    }
    Square(){}
    ~Square(){
        cout<<"SQUARE Destructed \n";
    }
    int getDim1(){return Dim1;}
    int getDim2(){return Dim2;}
    void setDim1(int d){Dim1=Dim2=d;}
    void setDim2(int d){Dim2=Dim1=d;}
    double cArea(){return Dim1*Dim2;}

};

///------CIRCLE--------------
class Circle : public GeoShape{

public:
    Circle(int r)
        :GeoShape(r,r){
        cout<<"CIRCLE constructor\n";
    }
    Circle(){}

    ~Circle(){
        cout<<"CIRCLE Destructed \n";
    }
    int getDim1(){return Dim1;}
    int getDim2(){return Dim2;}
    void setDim1(int d){Dim1=Dim2=d;}
    void setDim2(int d){Dim2=Dim1=d;}
    double cArea(){return 3.14* Dim1*Dim2;}

};
///------TRIANGLE--------------
class Triangle : public GeoShape{

public:
    Triangle(int b,int h)
        :GeoShape(b,h){
        cout<<"TRIANGLE constructor\n";
    }
    Triangle(){}
    ~Triangle(){
        cout<<"TRIANGLE Destructed \n";
    }
    double cArea(){return 0.5* Dim1*Dim2;}

};

double sumAreas(Rect r,Square s,Circle c,Triangle t){
    double sm=0;
    sm=r.cArea()+s.cArea()+c.cArea()+t.cArea();
    return sm;
}
///iterating  over Each shape
double sumAreas(Rect *r,Square* s,Circle* c,Triangle* t,int sz1,int sz2,int sz3,int sz4){
    double sm=0;
    for(int i=0;i<sz1;i++)sm+=r[i].cArea();
    for(int i=0;i<sz2;i++)sm+=s[i].cArea();
    for(int i=0;i<sz3;i++)sm+=c[i].cArea();
    for(int i=0;i<sz4;i++)sm+=t[i].cArea();
    return sm;
}
double sumAreas(GeoShape ** g,int sz){
    double sm=0;
    for(int i=0;i<sz;i++)sm+=g[i]->cArea();

    return sm;
}
int main()
{

    Rect *R=new Rect[2];
    Square *S=new Square[2];
    Circle *C=new Circle[2];;
    Triangle *T=new Triangle[2];;

    R[0].setDim1(5);R[0].setDim2(6);
    R[1].setDim1(5);R[1].setDim2(6);
    S[0].setDim1(6);S[0].setDim2(5);
    S[1].setDim1(3);S[1].setDim2(5);
    C[0].setDim1(6);C[0].setDim2(3);
    C[1].setDim1(5);C[1].setDim2(3);
    T[0].setDim1(6);T[0].setDim2(4);
    T[1].setDim1(6);T[1].setDim2(4);
    cout<<"SM"<<endl;
    cout<<"----------------------------\nSum Of Areas using 4 for loops   ->>  "<<endl;

    cout << R[0].cArea()*2<<"  "<<S[0].cArea()*2<<"  "<<C[0].cArea()*2<<"  "<<T[0].cArea()*2<<"  "<<sumAreas(R,S,C,T,2,2,2,2)<< endl;
    cout<<"----------------------------------------"<<endl;
    GeoShape *g[8]={&R[0],&R[1],&S[0],&S[1],&C[0],&C[1],&T[0],&T[1]};
    cout<<"Sum Of Areas using Geoshape pointer  ->>  "<<sumAreas(g,8)<<endl;

    return 0;
}
