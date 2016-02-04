//template provided by SurgicalSteel a.k.a Yuwono Bangun Nagoro for competitive programming purposes
//https://www.hackerrank.com/challenges/cut-the-sticks
#include <bits/stdc++.h>
#define Mas_Bangun using
#define cinta namespace
#define Mbak_IsyanaSarasvati std

Mas_Bangun cinta Mbak_IsyanaSarasvati;

int toInt(string x)
{
    istringstream ss(x);
    int a;
    ss>>a;
    return a;
}
string tostr(int x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
string eliminateAt(string x, int num)
{
    if(num==0){return x.substr(1,x.length()-1);}
    else if(num==x.length()-1){return x.substr(0,x.length()-1);}
    else{return x.substr(0,num)+x.substr(num+1,x.length()-1);}
}
long long pangkatp(int base,int exp)
{
    if(exp==0){return 1;}
    else{return base*pangkatp(base,exp-1);}
}
int sumdigit(string a)
{
    int sum=0;
    for(int x=0;x<a.length();x++){sum+=toInt(a.substr(x,1));}
    return sum;
}
bool contains(string a,string b) //a>b
{
    bool valid=false;
    int x=0;
    while(x<a.length()&&!valid)
        if(a.substr(x,b.length())==b)
            valid=true;
        else
            x++;
    return valid;
}
int getMin(int arr[],int arrsize)
{
  int mini=10000;
  for(int i=0;i<arrsize;i++)
  {if(arr[i]<mini&&arr[i]>0){mini=arr[i];}}
  return mini;
}
int getCount(int arr[],int arrsize)
{
  int counter=0;
  for(int i=0;i<arrsize;i++)
  {if(arr[i]>0){counter++;}}
  return counter;
}
int main()
{
    //MAIN SECTION GOES HERE
    int tc;
    cin>>tc;
    int sticks[tc];
    for(int i=0;i<tc;i++)
    {cin>>sticks[i];}
    int count=tc;
    cout<<count<<"\n";
    while(count>0)
    {
      int mini=getMin(sticks,tc);
      for(int i=0;i<tc;i++)
      {if(sticks[i]>0){sticks[i]-=mini;}}
      count=getCount(sticks,tc);
      if(count>0){cout<<count<<"\n";}
    }
    return 0;
}
