#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include<windows.h>
#define NormalPen 0x0F
#define HighLightPen 0XF0
#define Enter 0x0D
#define ESC 27
    int id;
    char name[20];
    double salary;
    double tax;
    char address[20];
    int age;
    char gender[20];
    double overtime;
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
struct node{
    int id;
    char name[20];
    double salary;
    double tax;
    char address[20];
    int age;
    char gender[20];
    double overtime;

    struct node* next;
    struct node* prev;

};
struct node* start;
struct node* last;

struct node* newNode(int id,char name[20],double salary,double tax,char  address[20],int age,char gender[20],double overtime){
       // printf("HI00 \n\n");

    struct node *pnew=(struct node*)malloc(sizeof(struct node));
//        printf("HI11 \n\n");

    if(pnew==NULL) exit(0);
    pnew->id=id;
    strcpy(pnew->name,name);
//    pnew->name=name;
    pnew->salary=salary;
    pnew->tax=tax;
    strcpy(pnew->address,address);
    //pnew->address=address;
    pnew->age=age;
    strcpy(pnew->gender,gender);
    //pnew->gender=gender;
    pnew->overtime=overtime;
    pnew->next=pnew->prev=NULL;
    return pnew;
} ;

void AddData(int id,char *name,double salary,double tax,char * address,int age,char *gender,double overtime){
       // printf("HI0 \n\n");

    struct node * pnew=newNode(id,name,salary,tax,address,age,gender,overtime);
  //  printf("HI1 \n\n");

    if(last==NULL){
        last=start=pnew;
    //printf("HI2 \n\n");
}
    else{
        last->next=pnew;
        pnew->prev=last;
        last=pnew;
//            printf("HI3 \n\n");

    }
}
struct node *searchList(int id){
    struct node*psearch=start;
    while(psearch!=NULL){
        if(psearch->id==id)break;
        psearch=psearch->next;
    }
    return psearch;
};
void disply(int key){
    struct node *pdisply=searchList(key);
    if(pdisply==NULL)printf("not found!!\n");
    else {
        printf("Employee ID: %d \n name : %s \n net salary : %ld \n\n",pdisply->id,pdisply->name,pdisply->salary+pdisply->overtime-pdisply->tax);
    }
}
void displyAll(){
    struct node *pdisply =start;
    while(pdisply!=NULL){
        printf("Employee ID: %d \n name : %s \n net salary : %ld \n\n",pdisply->id,pdisply->name,pdisply->salary+pdisply->overtime-pdisply->tax);
        pdisply=pdisply->next;
    }
}
void dlete(int key){
   struct node*pdlete=searchList(key);
   if(pdlete==NULL){
        printf("not found!!\n");
   }
   else {
        if(start==last) start=last=NULL;
        else if(start==pdlete){
            start=start->next;
            start->prev=NULL;
        }
        else if(last==pdlete){
            last=last->prev;
            last->next=NULL;
        }
        else{
            pdlete->prev->next=pdlete->next;
            pdlete->next->prev=pdlete->prev;
        }
        free (pdlete);
    }
}
void insertNode(int id,char *name,double salary,double tax,char * address,int age,char *gender,double overtime){
    struct node * pnew=newNode(id,name,salary,tax,address,age,gender,overtime);
    if(start==NULL){
        start=last=pnew;
    }
    else{
        struct node* psearch =start;
        while(psearch!=NULL &&psearch->id<id){
            psearch=psearch->next;
            if(psearch==NULL){
                last->next =pnew;
                pnew->prev=last;
                last=pnew;
            }
            else if(psearch=start){
                start->prev=pnew;
                pnew->next=start;
                start=pnew;
            }
            else{
                printf("Bla Bla ..\n");
                pnew->prev=psearch->prev;
                pnew->next=psearch;
                psearch->prev->next=pnew;
                psearch->prev=pnew;

            }
        }
    }
}

//struct employee e[3];

void enterData(){
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
    scanf("%d",&id);
    //printf("%d",id);
    gotoxy(15,8);
    _flushall();
    //scanf("%s",name);
    gets(name);
   // printf("%s",name);

    gotoxy(15,11);
    scanf("%ld",&salary);
    //printf("%ld",salary);
    gotoxy(15,14);
    scanf("%ld",&tax);
    //printf("%ld",tax);
    gotoxy(15,17);
    _flushall();

    gets(address);
    //scanf("%s",&address);
    //printf("%s",address);
    gotoxy(50,5);
    scanf("%d",&age);
    //printf("%d",age);
    gotoxy(50,8);
    _flushall();

    gets(gender);
    //scanf("%s",&gender);
    //printf("%s",gender);
    gotoxy(50,11);
    scanf("%ld",&overtime);
    //printf("%ld",overtime);
   //     printf("EOF\n\n");

    AddData(id,name,salary,tax,address,age,gender,overtime);
    //printf("EOF\n\n");
}
/*
void showData(int i){
    printf("------------------- EMPLOYEE %d -------------------\n",i);
    printf("Employee ID: %d \n name : %s \n net salary : %ld \n\n",e[i].id,e[i].name,e[i].salary+e[i].overtime-e[i].tax);di

}
*/
int main()
{

    char menu[3][7]={"New","disply","Exit"};
    int i,current=0,extflag=0;
    char ch;
//    struct employee e[3];

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
                for(int i=0;i<2;i++){
                    system("cls");
                    printf("Employee %d Data",i+1);
                    enterData();
                   // printf("zfttt\n\n");
                    _getch();
                    //printf("zfttt\n\n");

                }
                break;
            case 1:
                system("cls");
                displyAll();
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
