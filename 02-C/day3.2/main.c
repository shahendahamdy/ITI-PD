#include <stdio.h>
#include <stdlib.h>

int main()
{
    int arr[5] , min = 1e9+7 , mx = -1e9 + 7;
    for(int i=0;i<5;i++)
    {
        //printf("Enter Element %d : \n",i);
        scanf("%d",&arr[i]);
        if(arr[i] > mx) mx = arr[i];
        if(arr[i] < min) min = arr[i];
    }

    printf(" max is :  %d  ----  min is :  %d ",mx,min);

    return 0;
}
