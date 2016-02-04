#include <iostream>

using namespace std;

int main()
{
    int n,res=0;
    cin>>n;
    int arrnum[n];
    for(int i=0;i<n;i++){cin>>arrnum[i];}
    if(n>2)
    {
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                if(arrnum[i]<arrnum[j])
                {
                    int temp=arrnum[i];
                    arrnum[i]=arrnum[j];
                    arrnum[j]=temp;
                }}}
        bool finder=false;
        int i=0;
        while(i<n&&!finder)
        {
            if(arrnum[i]==arrnum[i+1]){i+=2;}
            else{res=arrnum[i];finder=true;}
        }
    }else{res=arrnum[0];}
    cout<<res<<endl;
    return 0;
}
