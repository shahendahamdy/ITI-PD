#include <stdio.h>
#include <stdlib.h>

int main()
{
    int x,sm=0;
    while(1){
        scanf("%d",&x);
        sm+=x;
        if(sm>100)break;
    }

    printf("sum is %i",sm);
    return 0;
}
