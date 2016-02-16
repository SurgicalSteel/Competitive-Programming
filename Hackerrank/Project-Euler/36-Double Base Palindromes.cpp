//template provided by SurgicalSteel a.k.a Yuwono Bangun Nagoro for competitive programming purposes
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
long long factorial(int num)
{
  if(num==0){return 1;}
  else{return num*factorial(num-1);}
}
int pangkatp(int base,int exp)
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
char toCharSingle(string x)//single substring as input
{
  char a[1];
  strcpy(a,x.c_str());
  return a[0];
}
string reverse(string a)
{
  string x;
  for(int y=a.length()-1;y>=0;y--)
  {x+=a.substr(y,1);}
  return x;
}
string tobase(int num,int base)
{
  string a;
  while(num>0)
  {
    a+=tostr(num%base);
    num=(num-(num%base))/base;
  }
  return reverse(a);
}
int testing(int num,int base) //return 0 if not both palindrome
{
  if(reverse(tostr(num))==tostr(num)&&(tobase(num,base)==reverse(tobase(num,base)))){return num;}
  else{return 0;}
}

int main()
{
    //MAIN SECTION GOES HERE
    int n,k,starting=1,counter=0;
    cin>>n>>k;
    while(starting<n)
    {
      counter+=testing(starting,k);
      starting++;
    }
    cout<<counter<<"\n";
    return 0;
}
