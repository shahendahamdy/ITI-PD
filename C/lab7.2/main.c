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
        int c; ///no of struct Elements

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

char** LineEditor(int c,int *size ,int *xpos, int *ypos, char *sch ,char *ech ){
    char **res;
    int ext,j=0;
    res=(char**)malloc(c*sizeof(char*));
    for(int i=0;i<c;i++){res[i]=(char*)malloc(size[i]*sizeof(char));}
    for(int i=0;i<c;i++){
            ext=0;
        char*frst,*last,*crnt,ch;
        frst=last=crnt=res[i];
        int indx=0,x=xpos[i],finalX=xpos[0],ext2=0;
        gotoxy(xpos[i],ypos[i]);
        do{
        //if(ext2==1)printf("EXT!!\n");
        gotoxy(x,ypos[i]);
        ch=_getch();
        switch(ch){
            ///-------------------------------
            case Enter:

                //printf("---> %s",res);
                ext2=1;
                i=c+1;
                break;
            ///-------------------------------

            case ESC:
                ext2=1;
                i=c+1;
                ext=1;

                break;
             ///-------------------------------
            case 9: //tap
                if(i==7)i=-1;
                ext2=1;
                break;
            case -32:
                 ch=_getch(); ///get scnd byte from buffer
                switch(ch){
                    //-------------------------------------------v
                    case 72: //up
                       if(i!=0){
                            i--;i--;
                            ext2=1;
                       }
                        break;
                    case 80: //down
                        gotoxy(finalX,ypos[i]);
                        *last='\0';
                        ext2=1;
//printf("---> %s",res[i]);
                        break;


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
                if(ch>=sch[i]&&ch<=ech[i]){
                        if(x-xpos[i]<size[i]){
                        *crnt=ch;
                        crnt++;
                        printf("%c",ch);

                        x++;
                        last++; //last ptr
                        finalX++;
                        }

                }


        }

    }while(!ext2);

    //res[i]=crnt;
if(ext==1){ res[0]="-1";res[1]=" ";}
    }
    return res;
}

void drawBox(int xpos ,int ypos,int sz ){

for(int i=0;i<sz;i++){
    textattr(HighLightPen);
        gotoxy(xpos+i,ypos);
        printf(" ");

    }
        //textattr(NormalPen);
}
void enterData(int i,int c,int *size,struct employee* e,int*xpos,int*ypos,int*sch,int*ech){


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
    for(int i=0;i<c;i++)drawBox(xpos[i],ypos[i],size[i]);
    char **res;
    res=LineEditor(c,size,xpos,ypos,sch,ech);
    e[i].id=atoi(res[0]);
    copyString(e[i].name,res[1] );
    e[i].salary=atoi(res[2]);
    e[i].tax=atoi(res[3]);
    copyString(e[i].address,res[4] );
    e[i].age=atoi(res[5]);
    copyString(e[i].gender,res[6] );
    e[i].overtime=atoi(res[7]);

}

void showData(int i,struct employee* e){
    printf("------------------- EMPLOYEE %d -------------------\n",i+1);
    printf("Employee ID: %d \n name : %s \n net salary : %ld \n\n",e[i].id,e[i].name,e[i].salary+e[i].overtime-e[i].tax);

}
void initArray(struct employee* e){
for(int i=0;i<10;i++){
    e[i].id=-1;
    e[i].name[0]=' ';

}
}
void getEmpById(int id,struct employee* e){
    for(int i=0;i<10;i++){
        if(e[i].id==id) return showData(i,e);
    }
    return printf("ID NOT  FOUND !!");
}
void delById(int id,struct employee* e){
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
void delByName(char n[20],struct employee* e){
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
    char menu[6][20]={"New","Display By ID","Display All","Delete By ID","Delete By Name","Exit"};
    int i,current=0,extflag=0,idx=0,idd=0;
    char ch,n[20];
    int c;
    printf("PLEASE ENTER NUMBER OF EMPLOYEES\n");
    scanf("%d",&c);

        int*size,*xpos,*ypos;
    char *sch,*ech;
    struct employee *e;

    xpos=(int*)malloc(c*sizeof(int));
    ypos=(int*)malloc(c*sizeof(int));
    size=(int*)malloc(c*sizeof(int));

    sch=(char*)malloc(c*sizeof(char));
    ech=(char*)malloc(c*sizeof(char));

    e=(struct employee *)malloc(10*sizeof(struct employee));
    initArray(e);

    size[0]=3;size[1]=10;size[2]=5;size[3]=4;size[4]=15;size[5]=2;size[6]=1;size[7]=4;
    for(int i=0;i<c;i++){
        if(i<5)xpos[i]=15;
        else xpos[i]=50;
    }
    for(int i=0;i<c;i++){
        if(i<5)ypos[i]=5+i*3;
        else ypos[i]=5+(i-5)*3;
    }
    for(int i=0;i<c;i++){
        if(i==0||i==2||i==3||i==5||i==7){
            sch[i]=48;
            ech[i]=57;}
        else{sch[i]=97;ech[i]=123;}
    }
    ///size -> 3,10 ,5,4,15,2,1,4
    ///xpos ->15,15,15,15,15,50,50,50
    ///ypos->5,8,11,14,17,5,8,11
    ///sch ->48,97,48,48,79,48,97,48
    ///ech ->57,123,57,57,123,57,123,57




    ///------------------------------------------------

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
                printf("Please enter the index (1-> %d): ",c);
                scanf("%d",&idx);
                system("cls");

                    printf("Employee %d Data",idx);
                    enterData(idx-1,c,size,e,xpos,ypos,sch,ech);

                    //_getch();


                break;
            case 1:
                system("cls");
                printf("Please enter the ID): ");
                scanf("%d",&idd);
                system("cls");
                getEmpById(idd,e);
                _getch();

                break;
            case 2:
                system("cls");
                for(int i=0;i<10;i++){
                    if(e[i].id!=-1){
                            showData(i,e);
                }}
                _getch();

                break;
            case 3:
                system("cls");

                printf("Please enter the ID: ");
                scanf("%d",&idd);
                system("cls");
                delById(idd,e);
                _getch();

                break;
            case 4:
                system("cls");

                printf("Please enter the name: ");
                scanf("%s",&n);
                system("cls");
                delByName(n,e);
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

free(size);
free(xpos);
free(ypos);
free(sch);
free(ech);
free(size);
free(e);


    return 0;
}



