#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include<windows.h>
#define NormalPen 0x0F
#define HighLightPen 0XF0
#define Enter 0x0D
#define ESC 27

struct employee{
int id;
char name[20];
double salary;
double tax;
char address[20];
int age;
char gender[20];
double overtime;


};
void gotoxy( int column, int line )
      {
          COORD coord;
          coord.X = column;
          coord.Y = line;
          SetConsoleCursorPosition(
            GetStdHandle( STD_OUTPUT_HANDLE ),
            coord
            );
      }
int main()
{
    struct employee e;
    gotoxy(5,5);
    printf("ID : ");
    gotoxy(5,8);
    printf("Name : ");
    gotoxy(5,11);
    printf("Salary : ");
    gotoxy(5,14);
    printf("Tax : ");
    gotoxy(5,17);
    printf("Address : ");
    gotoxy(40,5);
    printf("Age : ");
    gotoxy(40,8);
    printf("Gender : ");
    gotoxy(40,11);
    printf("Overtime : ");

    gotoxy(15,5);
    scanf("%d",&e.id);
    gotoxy(15,8);
    scanf("%s",&e.name);

    gotoxy(15,11);
    scanf("%ld",&e.salary);
    gotoxy(15,14);
    scanf("%ld",&e.tax);
    gotoxy(15,17);
    scanf("%s",&e.address);
    gotoxy(50,5);
    scanf("%d",&e.age);
    gotoxy(50,8);
    scanf("%s",&e.gender);
    gotoxy(50,11);
    scanf("%ld",&e.overtime);

    system("cls");
    gotoxy(0,0);
    printf("Employee ID: %d \n name : %s \n net salary : %ld ",e.id,e.name,e.salary+e.overtime-e.tax);

    getch();



    return 0;
}
