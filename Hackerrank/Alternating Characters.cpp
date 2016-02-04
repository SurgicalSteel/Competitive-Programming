#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;
bool isUnique(string x)
{
    bool unik=true;
    if(x.length()>1)
    {
        int i=0;
        while (i<x.length()-1&&unik)
        {
            if(x.substr(i,1)==x.substr(i+1,1)){unik=false;}
            else{i++;}
        }
        return unik;
    }
    else{return unik;}
}
string eliminateAt(string x, int num)
{
    if(num==0){return x.substr(1,x.length()-1);}
    else if(num==x.length()-1){return x.substr(0,x.length()-1);}
    else{return x.substr(0,num)+x.substr(num+1,x.length()-1);}
}

int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int jml=0,nmove=0,i=0;
    cin>>jml;
    string susunan[jml];
    for(int i=0;i<jml;i++){cin>>susunan[i];}
    for(int j=0;j<jml;j++)
    {
        int i=0,counter=0;
        while(i<susunan[j].length()-1)
        {
            if(susunan[j].substr(i,1)==susunan[j].substr(i+1,1)){counter++;}
            i++;
        }
        cout<<counter<<"\n";
    }
    return 0;
}
