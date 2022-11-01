#include <iostream>

using namespace std;
int cnt=0;
template <class T>

class MyStack{
    T *stk;
    int tos,sz;
    static int sNum;
public:
    MyStack(int s){sz=s; tos=0;stk=new T[sz];sNum++;}
    ~MyStack(){cout<<"Destructor\n";delete[]stk;sNum--;}
    bool isFull(){return tos==sz;}
    bool isEmpty(){return tos==0;}
    void push(T n){
        if(!isFull())stk[tos++]=n;
        else cout<<"Stack is full"<<endl;
    }
    T pop(){
        if(!isEmpty())return stk[--tos];
        cout<<"stack is empty"<<endl;
        return -1;
    }
    T peak(){
        if(!isEmpty())return  stk[tos-1];
        cout<<"stack is empty"<<endl;
    }
    static int getsNum(){return sNum;}

};
template <class T>

int MyStack<T>::sNum=0;
int main()
{
    cout<<"INT STK"<<endl;

    MyStack<int> s1(7),s3(5);
    s1.push(3);
    s1.push(4);
    s1.push(5);
    cout<<"num of int objects iss  "<<MyStack<int>::getsNum()<<endl;
    cout<<s1.pop()<<endl; ///5
    cout<<s1.peak()<<endl; ///4
    cout<<s1.pop()<<endl; ///4
    cout<<s1.pop()<<endl; ///3
///char
cout<<"CHARACTER STK"<<endl;
    MyStack<char> s2(7);
    cout<<"num of char objects iss  "<<MyStack<char>::getsNum()<<endl;

    s2.push('a');
    s2.push('b');
    s2.push('c');
    cout<<s2.pop()<<endl; ///5
    cout<<s2.peak()<<endl; ///4
    cout<<s2.pop()<<endl; ///4
    cout<<s2.pop()<<endl; ///3
    return 0;
}
