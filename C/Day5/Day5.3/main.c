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
struct employee e[10];

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
    printf("------------------- EMPLOYEE %d -------------------\n",i+1);
    printf("Employee ID: %d \n name : %s \n net salary : %ld \n\n",e[i].id,e[i].name,e[i].salary+e[i].overtime-e[i].tax);

}
void initArray(){
for(int i=0;i<10;i++){
    e[i].id=-1;
    e[i].name[0]=' ';

}
}
void getEmpById(int id){
    for(int i=0;i<10;i++){
        if(e[i].id==id) return showData(i);
    }
    return printf("ID NOT  FOUND !!");
}
void delById(int id){
    for(int i=0;i<10;i++){
        if(e[i].id==id){
            e[i].id=-1;
            e[i].name[0]=' ';
            printf("User with ID %d is removed \n",id);
            return;
    }
    }
    printf("ID NOT  FOUND !!\n");

}
void delByName(char n[20]){
    for(int i=0;i<10;i++){
        if( strcmp(n, e[i].name)==0){
            e[i].id=-1;
            e[i].name[0]=' ';
            printf("User with name %s is removed \n",e[i].name);
            return;
    }
    }
    printf("name NOT  FOUND !!\n");

}

int main()
{
    initArray();
    char menu[6][20]={"New","Display By ID","Display All","Delete By ID","Delete By Name","Exit"};
    int i,current=0,extflag=0,idx=0,idd=0;
    char ch,n[20];

    do{
        textattr(NormalPen);
        system("cls");
        for(int i=0;i<6;i++){
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
                system("cls");
                printf("Please enter the index (1->10): ");
                scanf("%d",&idx);
                system("cls");

                    printf("Employee %d Data",idx);
                    enterData(idx-1);
                    _getch();


                break;
            case 1:
                system("cls");
                printf("Please enter the ID): ");
                scanf("%d",&idd);
                system("cls");
                getEmpById(idd);
                _getch();

                break;
            case 2:
                system("cls");
                for(int i=0;i<10;i++){
                    if(e[i].id!=-1)showData(i);
                }
                _getch();

                break;
            case 3:
                system("cls");

                printf("Please enter the ID: ");
                scanf("%d",&idd);
                system("cls");
                delById(idd);
                _getch();

                break;
            case 4:
                system("cls");

                printf("Please enter the name: ");
                scanf("%s",&n);
                system("cls");
                delByName(n);
                _getch();
                break;
            case 5:
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
                        if(current<0)current=5;
                        break;
                    case 80: //down
                        current++;
                        if(current>5)current=0;
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

/*
                system("cls");
                printf("Please enter the index (0->9): ");
                scanf("%d",idx);
                _getch();
               // system("cls");
                enterData(idx);
                    _getch();
*/
