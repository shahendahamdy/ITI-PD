#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("enter number from 1 to 3\n");
    int x;
    scanf("%i",&x);
    switch(x){
        case 1:
        printf("orange");
        break;
        case 2:
        printf("guava");
        break;
        case 3:
        printf("apple");
        break;

    }
    return 0;
}
