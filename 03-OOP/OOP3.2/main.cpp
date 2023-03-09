#include <iostream>

using namespace std;
int cnt=0;
class MyStack{
int *stk,tos,sz;
public:
    MyStack(){sz=5;tos=0;stk=new int[5];}
    MyStack(int s){sz=s; tos=0;stk=new int[sz];}

    /*MyStack(MyStack& s){
        sz=s.sz;
        tos=s.tos;
        stk=new int[sz];
        for(int i=0;i<tos;i++){
            stk[i]=s.stk[i];
        }
    }*/
    ~MyStack(){
        cout<<"Destructor\n";

        for(int i=0;i<tos;i++){
            stk[i]=-1;
        }
        delete[]stk;
        }
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
    MyStack Reverse(){
        MyStack r;
        int i=tos,x=0;
        while(i--){
            //cout<<"hi "<<i<<" "<<endl;
            r.push(stk[i]);
        }
       // while(!r.isEmpty())cout<<"-> "<<r.pop()<<endl;

        return r;
    }

    friend    void viewContent(MyStack s);

};

    void viewContent(MyStack s){
        for(int i=0;i<s.tos ;i++){
            cout<<s.stk[i]<<" ";
        }

        cout<<endl;
    }


int main()
{
    /*
    MyStack s1(7);
    s1.push(3);
    s1.push(4);
    s1.push(5);
    cout<<s1.pop()<<endl; ///5
    cout<<s1.peak()<<endl; ///4
    cout<<s1.pop()<<endl; ///4
    cout<<s1.pop()<<endl; ///3
*/
MyStack s1(5),s2;
s1.push(2);
s1.push(4);
s1.push(6);
//v
viewContent(s1);
cout<<s1.Reverse().peak()<<endl;

//cout<<"HI !"<<endl;
//cout<<s1.pop()<<endl; ///5
  //  cout<<s1.pop()<<endl; ///4
    //cout<<s1.pop()<<endl; ///3

    return 0;
}
