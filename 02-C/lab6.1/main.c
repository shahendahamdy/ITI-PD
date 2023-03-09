#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include<windows.h>
#define NormalPen 0x0F
#define HighLightPen 0XF0
#define Enter 0x0D
#define ESC 27
int extflag=0,num,ext2=0;
char res[11];
char out[10];
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
void copyString(char* t, char* s)
{
    while (*t++ = *s++)
        ;
}
struct employee{
int id;
char name[10];
int salary;
int tax;
char address[10];
int age;
char gender[10];
int overtime;


};
struct employee e[10];
char* LineEditor(int xpos, int ypos, char sch ,char ech ){
    ext2=0;
    gotoxy(xpos,ypos);

    char ch ;

    for(int i=0;i<11;i++)res[i]="";
    int indx=0,x=xpos,finalX=xpos;
    char*frst,*last,*crnt;
    frst=last=crnt=&res[0];
    do{
        //if(ext2==1)printf("EXT!!\n");
        gotoxy(x,ypos);
        ch=_getch();
        switch(ch){
            ///-------------------------------
            case Enter:
                gotoxy(finalX,ypos);
                *last='\0';
                //printf("---> %s",res);
                ext2=1;
                break;
            ///-------------------------------

            case ESC:
                ext2=1;

                break;
             ///-------------------------------

            case -32:
                 ch=_getch(); ///get scnd byte from buffer
                switch(ch){
                    //-------------------------------------------v

                    case 75: //left
                        if(crnt!=frst){
                        crnt--;
                        x--;
                        }
                        break;
                    //-------------------------------------------
                    case 77: //right
                        if(crnt!=last){
                        crnt++;
                        x++;
                        }
                        break;
                    ////-------------------------------------------
                    case 71: //home
                        crnt=frst;
                        x=xpos;

                        break;
                    //-------------------------------------------
                    case 79: //End
                        crnt=last;
                        x=finalX;
                        break;
            }

                break;
            ///-------------------------------------------

            default:
                if(ch>=sch&&ch<=ech){
                       /*
                        if(crnt!=last){
                            char *temp;

                        }*/
                        *crnt=ch;
                        crnt++;
                        printf("%c",ch);

                        x++;
                        last++; //last ptr
                        finalX++;

        }


        }
    }while(!ext2);
return res;
}
void drawBox(int xpos ,int ypos ){
for(int i=0;i<10;i++){
    textattr(HighLightPen);
        gotoxy(xpos+i,ypos);
        printf(" ");
    }
        //textattr(NormalPen);
}
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
    drawBox(15,5);
    drawBox(15,8);
    drawBox(15,11);
    drawBox(15,14);
    drawBox(15,17);
    drawBox(50,5);
    drawBox(50,8);
    drawBox(50,11);

    e[i].id=atoi(LineEditor(15,5,48,57));
//printf("res ->%d",e[i].id);
    copyString(e[i].name, LineEditor(15,8,97,123));
//printf("res ->%s",e[i].name);

    e[i].salary=atoi(LineEditor(15,11,48,57));
//printf("res ->%s",res);
//printf("res ->%d",e[i].salary);


    e[i].tax=atoi(LineEditor(15,14,48,57));
    copyString(e[i].address, LineEditor(15,17,97,123));
    e[i].age=atoi(LineEditor(50,5,48,57));

    copyString(e[i].gender, LineEditor(50,8,97,123));


        e[i].overtime=atoi(LineEditor(50,11,48,57));

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


/**
switch(ch):
     case:27    ///ESC
        break;
     case:37     ///LEFT
        break;
     case:39      ///RIGHT
        break;
     case:13        ///Enter
        break;
     case:36        ///home
        break;
     case:13        ///end
        break;
     default:
        break;
**/
