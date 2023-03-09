#include <stdio.h>
#include <stdlib.h>

int main()
{
    char c[10];int i=0;
    char ch;
    printf("please enter your name \n");
    for(i=0;i<10;i++){
            ch=getche();
        if(ch==0x0D){
            c[i]='\0';
            break;
        }
        c[i]=ch;
    }
    printf("\n");

    for(i=0;i<10;i++){
          printf("%c",c[i]);
          if(c[i]=='\0')break;

    }
    return 0;
}
