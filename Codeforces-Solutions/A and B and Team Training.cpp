#include <bits/stdc++.h>
using namespace std;

int main() {
    int xp,nb;
    cin>>xp>>nb;
    if(xp>nb&&xp>0&&nb>0)
    {
        if(nb*2<=xp){cout<<nb<<"\n";}
        else
        {cout<<(((xp+nb)-((xp+nb)%3)))/3<<"\n";}
    }
    else if(nb==0||xp==0){cout<<"0\n";}
    else if(xp<nb)
    {
        if((xp*3)<=(xp+nb)){cout<<xp<<"\n";}
        else
        {cout<<(((xp+nb)-((xp+nb)%3)))/3<<"\n";}
    }
    else if(xp+nb<3){cout<<"0\n";}
    else if (xp==nb)
    {
        if((xp*3)<=(xp+nb)){cout<<xp<<"\n";}
        else
        {cout<<(((xp+nb)-((xp+nb)%3)))/3<<"\n";}
    }
    return 0;
}
