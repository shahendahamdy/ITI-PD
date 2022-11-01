#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
int main()
{
    void gotoxy(int c,int l){
        COORD coord;
        coord.X=c;
        coord.Y=l;
        SetConsoleCursorPosition(
                                 GetStdHandle(STD_OUTPUT_HANDLE),coord
                                 );

    }


    int c,r,n;
    scanf("%i",&n);

    r=1;
    c=n/2+1;
    if(n%2==1&&n>2){
    for(int i=1;i<=n*n;i++){
        gotoxy(c*5,r*5);
        printf("%i",i);
        if(i%n==0){
            r++;
            if(r==n+1)r=1;
            if(r==0)r=n;
        }
        else{
            r--;
            c--;
             if(r==n+1)r=1;
            if(r==0)r=n;
             if(c==n+1)c=1;
            if(c==0)c=n;
        }
       // printf("r=%i   c=%i  \n",r,c);
    }
    }
    else{
    printf("not odd or less than 2");
    }
    return 0;
}
