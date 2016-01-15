#include <bits/stdc++.h>
using namespace std;
string solve(string enc)
{
    int res =(int) sqrt((double) enc.length());
    int curr,counter=0;
    string builder="";
    int pos=res-1;
    int awal=pos;
    while(counter<enc.length())
    {
        while(pos<enc.length())
        {
            
            builder+=enc.substr(pos,1);
            //cout<<enc.substr(pos,1);
            counter++;
            if(counter==enc.length()){break;}
            pos+=res;
        }
        awal--;
        pos=awal;
    }
    return builder;
}
int main() {
    int tc;
    string inp;
    cin>>tc;
    for(int i=0;i<tc;i++)
    {
        cin>>inp;
        cout<<solve(inp)<<"\n";
    }
    return 0;
}
