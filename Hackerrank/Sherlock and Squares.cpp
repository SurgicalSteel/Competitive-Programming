#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int tc,a,b,ctr,sta,stb;
    cin>>tc;
    for(int x=0;x<tc;x++)
    {
        cin>>a>>b;
        ctr=0;
        bool found=false;
        int i=a,lobo,hibo;
        //lower bound
        while(!found&&i<=b)
        {
            if((int)ceil(sqrt((double) i))==(int)floor(sqrt((double) i)))
            {
                lobo=(int)floor(sqrt((double) i));
                found=true;
            }
            i++;
        }
        if(!found){cout<<"0\n";}
        else
        {
            //higher bound
            i=b;
            found=false;
            while(!found&&i>=a)
            {
                if((int)ceil(sqrt((double) i))==(int)floor(sqrt((double) i)))
                {
                    hibo=(int)floor(sqrt((double) i));
                    found=true;
                }
                i--;
            }                    
            cout<<hibo-lobo+1<<"\n";    
        }
        
    }
    return 0;
}
