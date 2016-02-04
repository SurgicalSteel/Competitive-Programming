#include <bits/stdc++.h>
using namespace std;

int main(){
    string s;
    cin >> s;
    int row=(int) floor(sqrt((double) s.length())),col=(int) ceil(sqrt((double) s.length())),ctr=0;
    if(row*col<s.length()){row++;}
    string matrix[row][col];
    for(int j=0;j<row;j++)
    {
        for(int i=0;i<col;i++)
        {
            if(ctr<s.length())
            {matrix[j][i]=s.substr(ctr,1);ctr++;}
        }
    }
    for(int j=0;j<col;j++)
    {
        for(int i=0;i<row;i++)
        {cout<<matrix[i][j];}
        if(j+1==col){cout<<"\n";}else{cout<<" ";}
    }
    
    return 0;
}
