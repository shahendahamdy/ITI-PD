#include <iostream>
int cnt=0;
using namespace std;

class Queue{
    int *q,tail,sz,cnt;
public:
    Queue(int s){sz=s;tail=0;cnt=0;q=new int[sz];}
    ~Queue(){cout<<"Destructor\n";delete[]q;}
    bool isFull(){return GetCount()==sz;}
    bool isEmpty(){return GetCount()==0;}

    void Enq(int x){
        if(!isFull()){
            q[tail++]=x;cnt++;
        }
        else cout<<"Stack is full"<<endl;
        }

    int Deq(){
        if(!isEmpty()){
             int temp=q[0];
            // cout<<"tail "<<tail<<endl;
             for(int i=0;i<tail-1;i++){
                q[i]=q[i+1];
             }
             tail--;
             cnt--;
            return temp;
        }
        cout<<"d stack is empty"<<endl;
        return -1;
    }
    int peak(){return q[tail];}
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
