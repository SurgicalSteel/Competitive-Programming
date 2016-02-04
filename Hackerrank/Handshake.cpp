#include <iostream>

using namespace std;

int main()
{
    int tc;
    cin>>tc;
    int num[tc];
    for(int i=0;i<tc;i++)
    {
        cin>>num[i];
        int x=num[i];
        if(x==1){num[i]=0;}
        else{num[i]=(x*(x-1))/2;}
    }
    for(int i=0;i<tc;i++)
    {
        cout<<num[i]<<endl;
    }
    return 0;
}
