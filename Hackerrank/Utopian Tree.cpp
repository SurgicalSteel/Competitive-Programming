#include <iostream>

using namespace std;

int main()
{
    int height=1,testcases;
    cin>>testcases;
    int arresult[testcases],tampung[testcases];
    for(int i=0;i<testcases;i++)
    {cin>>tampung[i];}
    for(int i=0;i<testcases;i++)
    {
        height=1;
        for(int j=1;j<=tampung[i];j++)
        {
            if(j%2!=0){height=height*2;}
            else{height++;}
        }
        arresult[i]=height;
    }
    for(int i=0;i<testcases;i++)
    {
        cout<<arresult[i]<<endl;
    }
    return 0;
}
