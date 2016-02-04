#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


long long findbaserow(long long row)
{
  if((row-1)%2==0){return (row-1)*10/2;}
  else{return ((row-2)*10/2)+1;}
}
long long findnum(long long col,long long baserow)
{
  if(col>1)
  {return baserow+(2*(col-1));}
  else{return baserow;}
}
int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    long long r,c;
    cin>>r>>c;
    cout<<findnum(c,findbaserow(r))<<"\n";
    return 0;
}
