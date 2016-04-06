#include <iostream>
using namespace std;

int main() {
    int a,b;
    cin>>a>>b;
    while(a!=0&&b!=0)
    {
        if(a<b){cout<<"0 "<<a<<" / "<<b<<"\n";}
        else if (a==b)
        {cout<<(a-(a%b))/b<<" "<<a%b<<" / "<<b<<"\n";}
        else
        {cout<<(a-(a%b))/b<<" "<<a%b<<" / "<<b<<"\n";}
        cin>>a>>b;
    }
    return 0;
}
