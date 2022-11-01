#include <iostream>

using namespace std;

class intArray{
    int *arr;
    int sz;
public:
    intArray(int s){
        sz=s;
        arr=new int[sz];

        /// Initialization -1
         for(int i=0;i<sz;i++){
            arr[i]= -1;
        }

    }
    ~intArray(){
        delete[]arr;
    }
    intArray( const intArray& a){
        delete []arr;
        sz=a.sz;
        arr=new int[sz];
        for(int i=0;i<sz;i++){
            arr[i]=a.arr[i];
        }
    }

    int getSize(){return sz;}
    void setVal(int indx,int val){
        if(indx>=0&&indx<sz)arr[indx]=val;
    }
    int getVal(int indx){
        if(indx>=0 && indx<sz)return arr[indx];
    }
    void setval(int indx,int val){
        arr[indx]=val;
    }
    intArray& operator=(const intArray &a){
        delete[]arr;
        sz=a.sz;
        arr=new int[sz];
        for(int i=0;i<sz;i++){
            arr[i]=a.arr[i];
        }
    return *this;
    }
    int & operator[](int indx){
        if(indx>=0 && indx<sz);return arr[indx];
    }
   intArray operator +(const intArray& a){
        intArray res(sz);
        for(int i=0;i<sz;i++){
            res.arr[i]=arr[i]+a.arr[i];
            // cout<<arr[i]<<" "<<a.arr[i]<<" "<<res.arr[i]<<endl;;
            }
        return res;
    }

};
//------------------------------------
/*intArray operator +( intArray& a, intArray& b){
        intArray res(a.getSize());
        for(int i=0;i<a.getSize();i++){
            res.setVal(i,a.getVal(i)+b.getVal(i));
            cout<<a.getVal(i)<<" "<<b.getVal(i)<<" "<<res.getVal(i)<<endl;
            }
            cout<<"gg"<<endl;
        return res;
    }
*/
int main()
{
    intArray a1(7),a2(7),a3(7);
    a1.setVal(0,3);
    a1.setVal(1,5);
    a1.setVal(2,7);

    a2.setVal(0,3);
    a2.setVal(1,5);
    a2.setVal(2,7);
    //cout<<"s" <<endl;

    a3=a1+a2;

   for(int i=0;i<a3.getSize();i++){
        if(a3.getVal(i) < 0)break;
        cout<<"element "<< i+1 <<" = "<<a3[i]<<endl;
   }

    a1[3]=9;
    cout<<a1[0]<<endl;
    cout<<a1[3]<<endl;


    return 0;
}
