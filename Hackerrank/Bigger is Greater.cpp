#include <bits/stdc++.h>
#include <algorithm>
using namespace std;
int main() {
    char str[100];
    int tc;
    scanf("%d",&tc);
    for(int i=0;i<tc;i++)
    {
        cin>>str;
        if(next_permutation(str,str+strlen(str)))
        {cout<<str<<"\n";}
        else{cout<<"no answer\n";}
    }
    return 0;
}
