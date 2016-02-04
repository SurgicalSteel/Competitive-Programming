#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    int da,ma,ya,de,me,ye;
    cin>>da>>ma>>ya>>de>>me>>ye;
    if(ya<ye||(ya==ye&&ma<me)||(ya==ye&&ma==me&&da<=de)){cout<<"0\n";}
    else
    {
        if(ya>ye){cout<<"10000\n";}
        else
        {
            if(ma>me)
            {
                cout<<(ma-me)*500<<"\n";
            }
            else
            {
                if(da>de)
                {
                    cout<<(da-de)*15;
                }
            }
        }
    }
    return 0;
}
