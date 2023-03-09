#include <stdio.h>
#include <stdlib.h>

void swap1(int x,int y){
int temp=x;
x=y;
y=temp;
}
void swap2(int* x,int* y){
int temp=*x;
*x=*y;
*y=temp;
}
int main()
{
    int x=3,y=5;
    swap1(x,y);
    printf("A= %d  b=%d\n",x,y);
    swap2(&x,&y);
    printf("A= %d  b=%d\n",x,y);

    return 0;
}
