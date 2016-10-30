#include <bits/stdc++.h>
using namespace std;
string tostr(long long int x) //converts long long int to string
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
string reverse(string a) //reverses a given string
{
  string x;
  for(int y=a.length()-1;y>=0;y--)
  {x+=a.substr(y,1);}
  return x;
}
string tobase(long long int num,int base) //translates bitmask from decimal number to base n. 2<=n<=9
{
  string a;
  while(num>0)
  {
    a+=tostr(num%base);
    num=(num-(num%base))/base;
  }
  return reverse(a);
}
long long int pangkatp(int base,int exp) //powers base by exponent
{
    if(exp==0){return 1;}
    else{return base*pangkatp(base,exp-1);}
}

int main() {
    long long int inp;
    int nn=0;
    cin>>inp;
    string s=tobase(inp,2);
    for(int i=0;i<s.length();i++)
    {
        if(s.substr(i,1)=="0")
        {nn++;}
    }
    long long int res=pangkatp(2,nn);
    cout<<res<<"\n";
    return 0;
}
