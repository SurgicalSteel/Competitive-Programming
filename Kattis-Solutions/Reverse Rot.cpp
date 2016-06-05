#include <bits/stdc++.h>
#include <algorithm>
#include <vector>
#define pb push_back
using namespace std;
char toCharSingle(string x)//single substring as input. Converts single substring to single char
{
  char a[1];
  strncpy(a,x.c_str(),sizeof(a));
  return a[0];
}
string toStringSingle(char x) //converts single char to single substring
{
  string c;
  stringstream ss;
  ss<<x;
  ss>>c;
  return c;
}
string reverse(string a) //reverses a given string
{
  string x;
  for(int y=a.length()-1;y>=0;y--)
  {x+=a.substr(y,1);}
  return x;
}

int findindex(vector<char> vc, char x)
{
    vector<char>::iterator iter=vc.begin();
    iter=find(vc.begin(),vc.end(),x);
    return distance(vc.begin(),iter);
}
int main() {
    vector<char> vc;
    char sk;
    for(int i=65;i<91;i++)
    {
        sk=i;
        vc.pb(sk);
    }
    vc.pb('_');
    vc.pb('.');
    int k;
    string sa;
    cin>>k;
    while(k!=0)
    {
        cin>>sa;
        string build="";
        string s=reverse(sa);
        int l=sa.length();
        for(int i=0;i<l;i++)
        {
            char c,cb;
            c=toCharSingle(s.substr(i,1));
            int posfinal=((findindex(vc,c)+k)%28);
            build+=toStringSingle(vc[posfinal]);
        }
        cout<<build<<"\n";
        cin>>k;
    }
    return 0;
}
