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


int c,r;
c=2;;
r=1;

    for(int i=1;i<=9;i++){
        gotoxy(c*5,r*5);
        printf("%i",i);
        if(i%3==0){
            r++;
            if(r==4)r=1;
            if(r==0)r=3;
        }
        else{
            r--;
            c--;
             if(r==4)r=1;
            if(r==0)r=3;
             if(c==4)c=1;
            if(c==0)c=3;
        }
       // printf("r=%i   c=%i  \n",r,c);
    }
    return 0;
}
