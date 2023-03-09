#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Hello world!\n");
    int x,y,z;
    printf("please enter x,y,z\n");
    scanf("%d",&x);
    scanf("%d",&y);
    scanf("%d",&z);
    printf(" numbers in hex are : x -> %x y-> %x z-> %x\n",x,y,z);
    printf(" numbers in char are : x -> %c y-> %c z-> %c\n",x,y,z);
 char a,b,c;
    printf("please enter a,b,c \n");
    scanf("%c",&a);
    scanf("%c",&b);
    scanf("%c",&c);
    printf(" chars in ASCI are : a -> %d b-> %d c-> %d",a,b,c);
    return 0;
}
