#include <iostream>
using namespace std;

int main() {
    string s;
    cin>>s;
    int init=1;
    for(int x=0;x<s.length();x++)
    {
        if(init==1&&s.substr(x,1)=="A")
        {init++;}
        else if(init==1&&s.substr(x,1)=="C")
        {init+=2;}
        else if(init==2&&s.substr(x,1)=="B")
        {init++;}
        else if(init==2&&s.substr(x,1)=="A")
        {init--;}
        else if(init==3&&s.substr(x,1)=="B")
        {init--;}
        else if(init==3&&s.substr(x,1)=="C")
        {init-=2;}
    }
    printf("%d\n",init);
    return 0;
}
