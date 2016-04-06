#include <bits/stdc++.h>
using namespace std;
int getnext(int n)
{
    if(n<8){return n+1;}
    else{return 1;}
}
int main() {
    // your code goes here
    int init,num,timetot=210,dur;
    string stat;
    cin>>init>>num;
    for(int i=0;i<num;i++)
    {
        cin>>dur>>stat;
        if(timetot-dur>0&&stat=="T"){init=getnext(init);timetot-=dur;}
        else if(timetot-dur<=0){break;}
        else if(stat=="N"||stat=="P"){timetot-=dur;}
    }
    cout<<init<<"\n";
    return 0;
}
