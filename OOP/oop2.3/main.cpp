#include <iostream>
int cnt=0;
using namespace std;

class Queue{
    int *q,tail,sz,head,cnt;
public:
    Queue(int s){sz=s;tail=0;head=0;cnt=0;q=new int[sz];}
    ~Queue(){cout<<"Destructor\n";delete[]q;}
    bool isFull(){return GetCount()==sz;}
    bool isEmpty(){return GetCount()==0;}
    void Enq(int x){
        if(!isFull()){
            if(tail==sz)tail=0;
            q[tail++]=x;cnt++;
        }
        else cout<<"Stack is full"<<endl;
        }
    int Deq(){
        if(!isEmpty()){
            if(head==sz)head=0;
            cnt--;return q[head++];
        }
        cout<<"stack is empty"<<endl;
        return -1;
    }
    int peak(){}
    int GetCount(){return cnt;}

};

int main()
{
    Queue q1(5);
    q1.Enq(1);
    q1.Enq(2);
    q1.Enq(3);
    q1.Enq(4);
    q1.Enq(5);
    cout<<q1.Deq()<<endl;
    q1.Enq(6);
    cout<<q1.Deq()<<endl;
    cout<<q1.Deq()<<endl;
    cout<<q1.Deq()<<endl;
    cout<<q1.Deq()<<endl;
    cout<<q1.Deq()<<endl;

    /*
    cout<<"cnt : "<<q1.GetCount()<<endl;

    cout<<q1.Deq()<<endl;
    cout<<"cnt : "<<q1.GetCount()<<endl;

    cout<<q1.Deq()<<endl;
    cout<<"cnt : "<<q1.GetCount()<<endl;


    cout<<q1.Deq()<<endl;
    cout<<"cnt : "<<q1.GetCount()<<endl;

    cout<<q1.Deq()<<endl;
    cout<<"cnt : "<<q1.GetCount()<<endl;
*/
    return 0;
}
