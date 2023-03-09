#include <stdio.h>
#include <stdlib.h>

int main()
{
    int **marks, stdN ,subN ,*sum ,*avg;
    printf("please enter student numbers");
    scanf("%i",&stdN);
    marks= (int**) malloc(stdN*sizeof(int*));
    sum=(int*)malloc(stdN*sizeof(int));
    printf("please enter subject numbers");
    scanf("%i",&subN);
    for(int i=0;i<subN;i++){
        marks[i]=(int*)malloc(subN*sizeof(int));
    }

    avg=(int*)malloc(subN*sizeof(int));
    for(int i=0;i<stdN;i++)sum[i]=0;
    for(int i=0;i<subN;i++)avg[i]=0;
printf("%d  %d \n",stdN,subN);
    for(int i=0;i<stdN;i++){
        for(int j=0;j<subN;j++){
            printf("student %d and subject %d  \n",i+1,j+1);
            scanf("%d",&marks[i][j]);
            //sum[i]+=marks[i][j];
            //avg[j]+=marks[i][j];
        }
    }
    for(int i=0;i<stdN;i++){
        for(int j=0;j<subN;j++){
            sum[i]+=marks[i][j];
            avg[j]+=marks[i][j];
        }
    }

for(int i=0;i<subN;i++)avg[i]/=stdN;
for(int i=0;i<stdN;i++)printf("sum is %d: \n",sum[i]);
for(int i=0;i<subN;i++)printf("avg is %d: \n",avg[i]);

for(int i=0;i<stdN;i++)free(marks[i]);
free(marks);
    return 0;
}
