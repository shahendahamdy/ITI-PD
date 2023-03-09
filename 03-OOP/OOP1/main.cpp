#include <iostream>

using namespace std;

class Complex{
private:
    int real;
    int imaginary;
public:
    void setReal(int r){real=r;}

    void setImaginary(int i){imaginary=i;}

    int getReal(){return real;}

    int getImaginary(){return imaginary;}

    Complex sum(Complex C){
        C.real+=real;
        C.imaginary+=imaginary;
        return C;
    }
    void print(){
        if(real==0 && imaginary ==0) {cout<<"number is  "<<0<<endl;}
        else if(real==0) cout<<"number is  "<<imaginary<<"i"<<endl;
        else if(imaginary==0) cout<<"number is  "<<real<<endl;
        else
            if(imaginary<0)cout<<real<<imaginary<<"i"<<endl;
            else cout<<real<<"+"<<imaginary<<"i"<<endl;

    }
};
Complex sub(Complex x ,Complex y){
    x.setReal(x.getReal()-y.getReal());
    x.setImaginary(x.getImaginary()-y.getImaginary());
    return x;
}
int main()
{
    Complex c1 ,c2;
    while(true){
    int x,y;
    cout<<"Enter real and imginary 1"<<endl;
    cin>>x>>y;
    c1.setReal(x);
    c1.setImaginary(y);

    cout<<"Enter real and imginary 2"<<endl;
    cin>>x>>y;
    c2.setReal(x);
    c2.setImaginary(y);
    cout<<"number 1 is  ";
    c1.print();
    cout<<"number 2  is  ";
    c2.print();
    cout<<"sum is ";
    c1.sum(c2).print();
}



    return 0;
}
