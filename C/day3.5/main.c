#include <stdio.h>
#include <stdlib.h>

int main()
{
    int arr1[3][2],arr2[2][1] ,mul[3][1]={0} ,sm=0;
    printf("Enter the 3*2 array \n");
    for(int i=0; i<3 ;i++){
        for(int j=0;j<2;j++){
            scanf("%d",&arr1[i][j]);
        }
    }
    printf("Enter the 2*1 array \n");

    for(int i=0; i<2 ;i++){
        for(int j=0;j<1;j++){
            scanf("%d",&arr2[i][j]);
        }
    }

    printf(" the out put 3*1 array \n");
    for(int i=0; i<3 ;i++){
        for(int j=0;j<2;j++){
            for(int k=0;k<1;k++){
                mul[i][k]+=arr1[i][j]*arr2[k][j];

           // printf("%d  \n",mul[i][k]);
            }
        }
    }

 for(int i=0; i<3 ;i++){
        for(int j=0;j<1;j++){
            printf("%d ",mul[i][j]);
        }
        printf("\n");
    }



    return 0;
}
