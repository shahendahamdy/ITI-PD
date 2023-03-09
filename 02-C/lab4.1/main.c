#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include<windows.h>
#define NormalPen 0x0F
#define HighLightPen 0XF0
#define Enter 0x0D
#define ESC 27
int main()
{
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


    char menu[3][5]={"New","Save","Exit"};
    int i,current=0,extflag=0;
    char ch;

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
                system("cls");
                printf("enter new data");
                _getch();
                break;
            case 1:
                system("cls");
                printf(" data is saved");
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
