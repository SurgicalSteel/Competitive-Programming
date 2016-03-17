#include <bits/stdc++.h>
#include <algorithm>
using namespace std;
string tostr(long long int x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
int getbitlength(long long int num) //get bit length of a num on base 2
{
  string a;
  while(num>0)
  {
    a+=tostr(num%2);
    num=(num-(num%2))/2;
  }
  return a.length();
}
string reverse(string a) //reverses a given string
{
  string x;
  for(int y=a.length()-1;y>=0;y--)
  {x+=a.substr(y,1);}
  return x;
}
string getbitstring(long long int num)
{
  string a;
  while(num>0)
  {
    a+=tostr(num%2);
    num=(num-(num%2))/2;
  }
  return reverse(a);
}
long long int pangkatp(int base,int exp) //powers base by exponent
{
    if(exp==0){return 1;}
    else{return base*pangkatp(base,exp-1);}
}
long long int bittonum(string a)
{
    long long int res=0;
    for(int i=0;i<a.length();++i)
    {
        if(a.substr(i,1)=="1")
        {
            res+=(pangkatp(2,a.length()-i-1));
        }
    }
    return res;
}
int main() {
    int tc,xa,xb;
    scanf("%d",&tc);
    long long int a,b;
    while(tc--)
    {
        scanf("%lld %lld",&a,&b);
        xa=getbitlength(a);
        xb=getbitlength(b);
        if(xa!=xb)
        {printf("0\n");}
        else
        {
            string sa=getbitstring(a),sb=getbitstring(b);
            int idx=0;
            string build="";
            bool breaker=false;
            while(idx<sa.length())
            {
                if(breaker){build+="0";}
                else if(sa.substr(idx,1)!=sb.substr(idx,1)&&!breaker){breaker=true;build+="0";}
                else if(sa.substr(idx,1)==sb.substr(idx,1)&&!breaker){build+=sa.substr(idx,1);}
                idx++;
            }
            //cout<<build<<"\n";
            printf("%lld\n",bittonum(build));
        }
    }
    return 0;
}
