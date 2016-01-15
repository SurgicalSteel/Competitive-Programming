#include <bits/stdc++.h>
using namespace std;

int main() {
    string s;
    cin>>s;
    int p=s.length();
    int row=1,col=p,i=1;
    while(row<=col&&i<=p)
    {
        if(p%i==0&&i>row&&(p/i)>=i){row=i;col=p/i;}
        i++;
    }
    int ctr=0;
    string mat[row][col];
    for(int i=0;i<col;i++)
    {
        for(int j=0;j<row;j++)
        {
            mat[j][i]=s.substr(ctr,1);
            ctr++;
        }
    }
    //test display
    string build="";
    for(int i=0;i<row;i++)
    {
        for(int j=0;j<col;j++)
        {build+=mat[i][j];}
    }
    cout<<build<<"\n";
    return 0;
}
