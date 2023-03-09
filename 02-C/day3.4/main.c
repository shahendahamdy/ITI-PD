#include <stdio.h>
#include <stdlib.h>

int main()
{
    int arr[3][3] ,sm[3]={0};
    for(int i=0; i<3 ;i++){
        printf("enter row %d \n",i+1);

        for(int j=0;j<3;j++){
            scanf("%d",&arr[i][j]);
            sm[j]+=arr[i][j];
        }
    }
    for(int i=0;i<3;i++){
        printf("avg of column %d is : %d \n",i+1,sm[i]/3);
    }

    return 0;
}
