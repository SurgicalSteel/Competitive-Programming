#include <iostream>
using namespace std;
long long absolutey(long long x)
{
  if(x<0){return x*-1;}
  else{return x;}
}
int main() {
  long long a,b;
  while(cin>>a>>b)
  {
      cout<<absolutey(a-b)<<"\n";
  }
  return 0;
}
