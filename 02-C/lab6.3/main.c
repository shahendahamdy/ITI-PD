#include <stdio.h>
#include <stdlib.h>

int main()
{
    int arr[5];
    int* ptr=arr;
    for(int i=0;i<5;i++){
        scanf("%d",ptr+i);
    }
    for(int i=0;i<5;i++){
        printf("%d  ",* (ptr+i));
    }
    //printf("Hello world!\n");
    return 0;
}
