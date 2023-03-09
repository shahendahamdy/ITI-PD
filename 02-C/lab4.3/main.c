#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    char s1[10],s2[10];
    printf("Enter first name\n");

    scanf("%s",&s1);
    printf("Enter second name\n");

    scanf("%s",&s2);
    strcat(s1, " ");

    strcat(s1,s2);
    printf("full name is %s \n",s1);
    return 0;
}
