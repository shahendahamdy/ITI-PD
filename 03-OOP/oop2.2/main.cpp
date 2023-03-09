#include <iostream>

using namespace std;
int cnt=0;
class MyStack{
int *stk,tos,sz;
public:
    MyStack(int s){sz=s; tos=0;stk=new int[sz];}
    ~MyStack(){cout<<"Destructor\n";delete[]stk;}
    bool isFull(){return tos==sz;}
    bool isEmpty(){return tos==0;}
    void push(int n){
        if(!isFull())stk[tos++]=n;
        else cout<<"Stack is full"<<endl;
    }
    int pop(){
        if(!isEmpty())return stk[--tos];
        cout<<"stack is empty"<<endl;
        return -1;
    }
    int peak(){
        if(!isEmpty())return  stk[tos-1];
        cout<<"stack is empty"<<endl;
        return -1;
    }


};

int main()
{
    MyStack s1(7);
    s1.push(3);
    s1.push(4);
    s1.push(5);
    cout<<s1.pop()<<endl; ///5
    cout<<s1.peak()<<endl; ///4
    cout<<s1.pop()<<endl; ///4
    cout<<s1.pop()<<endl; ///3

    return 0;
}
