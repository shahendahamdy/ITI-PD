#include <stdio.h>
#include <stdlib.h>

int main()
{
    int arr1[100][100],arr2[100][100] ,mul[100][100]={0} ,sm=0;
    int a,b,c,d;
    printf("Enter the first array dimensions\n");
    scanf("%d",&a);
    scanf("%d",&b);
    printf("Enter the first array \n");
    for(int i=0; i<a ;i++){
        for(int j=0;j<b;j++){
            scanf("%d",&arr1[i][j]);

        }
    }

    printf("Enter the second array dimensions\n");
    scanf("%d",&c);
    scanf("%d",&d);
    printf("Enter the second array \n");
    for(int i=0; i<c ;i++){
        for(int j=0;j<d;j++){
            scanf("%d",&arr2[i][j]);
        }
    }

printf(" the output  a*d array \n");
    for(int i=0; i<a ;i++){
        for(int j=0;j<d;j++){
                mul[i][j]=0;
            for(int k=0;k<b;k++){
                mul[i][j]+=(arr1[i][k]*arr2[k][j]);
       // printf("%d * %d = %d \n",arr1[i][k], arr2[j][k],mul[i][j]);
            }
        }
    }
    for(int i=0;i<a;i++){
        for(int j=0;j<d;j++){
            printf("%d ",mul[i][j]);

        }
        printf("\n");
    }

    return 0;
}
