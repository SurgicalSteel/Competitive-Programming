#include <iostream>
using namespace std;

int main() {
    // your code goes here
    int h,m,less;
    cin>>h>>m;
    if(h==0&&m<45)
    {
        h=23;
        less=45-m;
        m=60-less;
        cout<<h<<" "<<m<<"\n";
    }
    else if(m<45)
    {
        less=45-m;
        m=60-less;
        cout<<h-1<<" "<<m<<"\n";
    }
    else{cout<<h<<" "<<m-45<<"\n";}
    return 0;
}
