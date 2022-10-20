#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include<windows.h>
#define NormalPen 0x0F
#define HighLightPen 0XF0
#define Enter 0x0D
#define ESC 27
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
void textattr (int i)
{
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}
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
struct employee e[3];

void enterData(int i){
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
    scanf("%d",&e[i].id);
    gotoxy(15,8);
    scanf("%s",&e[i].name);

    gotoxy(15,11);
    scanf("%ld",&e[i].salary);
    gotoxy(15,14);
    scanf("%ld",&e[i].tax);
    gotoxy(15,17);
    scanf("%s",&e[i].address);
    gotoxy(50,5);
    scanf("%d",&e[i].age);
    gotoxy(50,8);
    scanf("%s",&e[i].gender);
    gotoxy(50,11);
    scanf("%ld",&e[i].overtime);
}

void showData(i){
    printf("------------------- EMPLOYEE %d -------------------\n",i);
    printf("Employee ID: %d \n name : %s \n net salary : %ld \n\n",e[i].id,e[i].name,e[i].salary+e[i].overtime-e[i].tax);

}
int main()
{

    char menu[3][7]={"New","disply","Exit"};
    int i,current=0,extflag=0;
    char ch;
    struct employee e[3];

    do{
        textattr(NormalPen);
        system("cls");
        for(int i=0;i<3;i++){
            if(current==i)textattr(HighLightPen);
            else textattr(NormalPen);

            gotoxy(15,10+i*3);
            printf("%s",menu[i]);
        }


        ch=_getch();

        switch(ch){
            case Enter :
                switch(current){
            case 0:
                for(int i=0;i<3;i++){
                    system("cls");
                    printf("Employee %d Data",i+1);
                    enterData(i);
                    _getch();

                }
                break;
            case 1:
                system("cls");
                for(int i=0;i<3;i++){
                    showData(i);
                }
                _getch();

                break;
            case 2:
                extflag=1;
                break;
                }
                break;
            case ESC:
                extflag=1;
                break;
            case -32 :
                ch=_getch(); ///get scnd byte from buffer
                switch(ch){
                    case 72: //up
                        current--;
                        if(current<0)current=2;
                        break;
                    case 80: //down
                        current++;
                        if(current>2)current=0;
                        break;
                    case 71: //home
                        current=0;
                        break;
                    case 79: //End
                        current=2;
                        break;
                }
                break;


    }
    }while(!extflag);




    return 0;
}
