#include <iostream>

using namespace std;

int main()
{
    int n,suma=0,sumb=0;
    cin>>n;
    int matriks[n][n];
    for(int j=0;j<n;j++)
    {
        for(int i=0;i<n;i++)
        {
            cin>>matriks[j][i];
        }
    }
    for(int j=0;j<n;j++)
    {
        for(int i=0;i<n;i++)
        {
            if(i+j==n-1){suma+=matriks[j][i];}
            if(i==j){sumb+=matriks[j][i];}
        }
    }
    cout<<max(suma,sumb)-min(suma,sumb)<<endl;
    return 0;
}
