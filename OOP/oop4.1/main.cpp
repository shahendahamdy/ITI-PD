#include <iostream>
#include <string>
#include <bits/stdc++.h>
using namespace std;


///class
class Complex{
private:
    int real;
    int img;
public:
    Complex(int r=0,int i=0){
        real=r;img=i;//cout<<"\n No. of Object created:\t"<<cnt;
        }

    Complex(int n){
        real=n;img=n;//cout<<"\n No. of Object created:\t"<<cnt;
        }

    ~Complex(){//cout<<"\n No. of Object destroyed:\t"<<cnt;
        }
    //copy ctor
    Complex( Complex &oldC){
        real=oldC.real;
        img=oldC.img;
    }
    void setReal(int r){real=r;}
    void setimg(int i){img=i;}
    int getReal(){return real;}
    int getimg(){return img;}
//4 constructed , 6 destructed
    Complex sum(Complex C){
        Complex ans;
        ans.real=C.real+real;
        ans.img=C.img+img;
        return ans;
    }
    void print(){
        cout<<endl;
        if(real==0 && img ==0) {cout<<"number is  "<<0<<endl;}
        else if(real==0) cout<<"number is  "<<img<<"i"<<endl;
        else if(img==0) cout<<"number is  "<<real<<endl;
        else
            if(img<0)cout<<real<<img<<"i"<<endl;
            else cout<<real<<"+"<<img<<"i"<<endl;

    }
    ///1->  c3=c1-c2
    Complex operator -(const Complex& c){
        Complex x(real-c.real,img-c.img);
        return x;

    }
    ///3-> c3=c2-7
    Complex operator -(int x){
        Complex xx(real-x,img);
        return xx;

    }
    ///4-> c1-=c2
    Complex &operator -=(const Complex& c){
        real=real-c.real;
        img=img-c.img;

        return *this;

    }
    ///5-> c-=7
    Complex &operator -=(int x){
        real=real-x;

        return *this;

    }
    ///7-> --c1 perfix
    Complex &operator --(){
       --real;

        return *this;

    }
    ///8-> c1-- perfix

    Complex operator --(int){
        Complex temp(*this);
       real--;

        return temp;

    }
    ///9-> c1==c2
    bool operator==(const Complex& c){
        return ((real==c.real)&&img==c.img);
    }
    ///10-> c1!=c2

    bool operator!=(const Complex& c){
        return !((real==c.real)&&img==c.img);
    }
    ///11> c1>c2
    bool operator>(const Complex& c){
        return (real>c.real);

    }
    ///11> c1>=c2
    bool operator>=(const Complex& c){
        return (real>=c.real);
    }
    ///12> c1<c2
    bool operator <(const Complex& c){
        return (real<c.real);
    }
    ///12> c1<=c2
    bool operator<=(const Complex& c){
        return (real<=c.real);
    }
    ///13-> (int) c1
    operator int (){
        return real;
    }
    ///13-> (int) c1
    /*operator char* (){
        char *c="";
        char str1[100],str2[100]="+";
        sprintf(str1,"%d", real);
        strcat(str1,str2);
  printf("the string is : %s\n",str1);


        return str1;
    }*/
    string toS(int k){
    stringstream ss;
    ss<<k;
    string s;
    ss>>s;
    return s;
}
    operator char* (){
        char *c;int idx=0;
        c=new char[100];
        string s=toS(real);
        for(int i=0;i<s.length();i++){
            c[idx]=s[i];
            idx++;
        }
        if(img>=0)c[idx++]='+';
        s=toS(img);
        for(int i=0;i<s.length();i++){
            c[idx]=s[i];
            idx++;
        }
        c[idx++]='i';

        return c;
    }

};

//-----------------------------------end of class
    ///2-> c3=7-c2
    Complex operator -(int real, Complex& c){
        Complex x(real-c.getReal(),0-c.getimg());
        return x;
    }
int main()
{
    bool b;
    ///#of objects  #of ctors #ofdestructors
    Complex c1(33,-4),c2(7,6),c3;
    Complex c4(1,2),c5(3,4),temp;
    char*ch;

    c3=c2-c1;
    c3.print();

    c3=c2-3;
    c3.print();

    c3=3-c2;
    c3.print();

    c2-=c1;
    c2.print();

    c2-=1;
    c2.print();

    --c2;
    c2.print();
    temp= c2--;
    temp.print();


    cout<<"----"<<endl;
    cout<<(c2==c1 )<<endl;
    cout<<(c2!=c1) <<endl;
    int x=(int) c1;
    cout<<"x-> "<<x<<endl;;

    char* xx;
    xx=(char*) c1;
    cout<<"xx-> "<<xx<<endl;;

    return 0;
}
