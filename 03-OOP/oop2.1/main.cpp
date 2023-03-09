#include <iostream>

using namespace std;
int cnt=0;

///class
class Complex{
private:
    int real;
    int img;
public:
    Complex(int r,int i){real=r;img=i;cnt++;cout<<"\n No. of Object created:\t"<<cnt;}
    Complex(int n){real=n;img=n;cnt++;cout<<"\n No. of Object created:\t"<<cnt;}
    Complex(){cnt++;cout<<"\n No. of Object created:\t"<<cnt;}
    //~Complex(){cout<<"\n No. of Object destroyed:\t"<<cnt;--cnt;}
    void setReal(int r){real=r;}
    void setimg(int i){img=i;}
    int getReal(){return real;}
    int getimg(){return img;}

    Complex sum(Complex C){
        C.real+=real;
        C.img+=img;
        return C;
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
};


int main()
{
    ///#of objects  #of ctors #ofdestructors
    Complex c1(1,2),c2(5),c3;
    c3=c1.sum(c2);
    c3.print();



    return 0;
}
