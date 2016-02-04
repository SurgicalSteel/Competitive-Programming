#include <iostream>
#include <sstream>
#include <string.h>
using namespace std;

int main()
{
    int n,k;
    string s,res;
    cin>>n>>s>>k;
    char koleksi[n];
    strcpy(koleksi,s.c_str());
    k=k%26;
    for(int i=0;i<n;i++)
    {
        if((koleksi[i]>=65&&koleksi[i]<=90)||(koleksi[i]>=97&&koleksi[i]<=122))
        {
            if(koleksi[i]>=65&&koleksi[i]<=90)
            {if(koleksi[i]+k>90){koleksi[i]=koleksi[i]+k-26;}else{koleksi[i]+=k;}}
            if(koleksi[i]>=97&&koleksi[i]<=122)
            {if(koleksi[i]+k>122){koleksi[i]=koleksi[i]+k-26;}else{koleksi[i]+=k;}}
        }
    }
    stringstream ss;
    ss<<koleksi;
    ss>>res;
    cout<<res<<endl;
    return 0;
}
