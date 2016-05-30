#include <bits/stdc++.h>
using namespace std;
int toInt(string x)
{
    istringstream ss(x);
    int a;
    ss>>a;
    return a;
}
int main() {
    int sz;
    string s;
    cin>>sz;
    int mat[sz][sz];
    for(int i=0;i<sz;++i)
    {
        cin>>s;
        for(int x=0;x<sz;++x)
        {mat[i][x]=toInt(s.substr(x,1));}
    }
    for(int j=0;j<sz;++j)
    {
        for(int i=0;i<sz;++i)
        {
            if(i>0&&i<sz-1&&j>0&&j<sz-1)
            {
                if(mat[j][i]>mat[j-1][i]&&mat[j][i]>mat[j+1][i]&&mat[j][i]>mat[j][i-1]&&mat[j][i]>mat[j][i+1])
                {cout<<"X";}else{cout<<mat[j][i];}
            }
            else{cout<<mat[j][i];}
        }
        cout<<"\n";
    }
    return 0;
}
