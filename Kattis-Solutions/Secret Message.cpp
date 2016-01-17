#include <bits/stdc++.h>
using namespace std;
string solve(string s)
{
    string builder="";
    int l=s.length();
    int x=(int)ceil(sqrt((double) l));
    string mat[x][x];
    int pos=0;
    for(int j=0;j<x;j++)
    {
        for(int i=0;i<x;i++)
        {
            if(pos<l)
            {mat[i][j]=s.substr(pos,1);pos++;}
            else{mat[i][j]="*";}
        }
    }
    for(int i=0;i<x;i++)
    {
        for(int j=x-1;j>=0;j--)
        {
            if(mat[i][j]!="*"){builder+=mat[i][j];}
        }
    }
    return builder;
}
int main() {
    int tc;
    cin>>tc;
    string s;
    for(int i=0;i<tc;i++)
    {
        cin>>s;
        cout<<solve(s)<<"\n";
    }
    return 0;
}
