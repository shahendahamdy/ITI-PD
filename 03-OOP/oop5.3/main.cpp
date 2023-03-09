#include <iostream>
int cnt=0;
using namespace std;
template <class T>

class Queue{
    T *q;
    int tail,sz,head,cnt;
public:
    Queue(int s){sz=s;tail=0;head=0;cnt=0;q=new T[sz];}
    ~Queue(){cout<<"Destructor\n";delete[]q;}
    bool isFull(){return GetCount()==sz;}
    bool isEmpty(){return GetCount()==0;}
    void Enq(T x){
        if(!isFull()){
            if(tail==sz)tail=0;
            q[tail++]=x;cnt++;
        }
        else cout<<"Stack is full"<<endl;
        }
    T Deq(){
        if(!isEmpty()){
            if(head==sz)head=0;
            cnt--;return q[head++];
        }
        cout<<"stack is empty"<<endl;
        return -1;
    }
    T peak(){}
    int GetCount(){return cnt;}

};

int main()
{
    Queue<int> q1(5);
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
cout<<"char   "<<endl;

 Queue<char> q(5);
    q.Enq('a');
    q.Enq('b');
    q.Enq('c');
    q.Enq('d');
    q.Enq('e');
    cout<<q.Deq()<<endl;
    q.Enq('f');
    cout<<q.Deq()<<endl;
    cout<<q.Deq()<<endl;
    cout<<q.Deq()<<endl;
    cout<<q.Deq()<<endl;
    cout<<q.Deq()<<endl;

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
