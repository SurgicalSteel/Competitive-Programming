#include <bits/stdc++.h>
using namespace std;
int main() {
    int tc,a,b;
    string ba,bb;
    scanf("%d",&tc);
    while(tc--)
    {
        scanf("%d",&a);
        b=a;
        while(b%3!=0)
        {b-=5;}
        if(b<0){printf("-1\n");}
        else
        {
            ba="";
            bb="";
            for(int i=0;i<b;++i){ba+="5";}
            for(int i=0;i<abs(a-b);++i){bb+="3";}
            cout<<ba<<bb<<"\n";
        }
    }
    return 0;
}
