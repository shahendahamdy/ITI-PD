#include <stdio.h>
#include <stdlib.h>

int main()
{
    int arr[3][3] ,sm[3]={0};
    for(int i=0; i<3 ;i++){
        printf("enter row %d \n",i+1);

        for(int j=0;j<3;j++){
            scanf("%d",&arr[i][j]);
            sm[i]+=arr[i][j];
        }
    }
    for(int i=0;i<3;i++){
        printf("sm of row %d is : %d \n",i+1,sm[i]);
    }

    return 0;
}
