//template provided by SurgicalSteel a.k.a Yuwono Bangun Nagoro for competitive programming purposes
#include <bits/stdc++.h>
#include <algorithm>
#define Mas_Bangun using
#define cinta namespace
#define Mbak_IsyanaSarasvati std
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
#define psb push_back
#define mkp make_pair

Mas_Bangun cinta Mbak_IsyanaSarasvati;
/*
	Leave the sleep and let the springtime talk
	In tongues from the time before man
	Listen to a daffodil tell her tale
	Let the guest in, walk out, be the first to greet the morn

	The meadows of heaven await harvest
	The cliffs unjumped, cold waters untouched
	The elsewhere creatures yet unseen
	Finally your number came up, free fall awaits the brave

	Come
	Taste the wine, race the blind
	They will guide you from the light
	Writing noughts till the end of time
	
	Come
	Surf the clouds, race the dark
	It feeds from the runs undone
	Meet me where the cliff greets the sea
*/
struct point{int x,y;};
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
string low(string inp)
{
	string res;
	locale loc;
	for(string::size_type i=0;i<inp.length();i++)
	{res+=tolower(inp[i],loc);}
	return res;
}
bool isprime(int a) { //this prime test function was originally authored by Egor Suvorov a.k.a yeputons
    if(a==1){return false;}
    for (int i=2;i*i<=a;i++)
        if(a%i==0)
            return false;
    return true;
}
vector<int> sieve(int n)
{
    vector <int> res;
    int temp=1;
    for(int i=2;i<=n;i++)
    {
        for(int a=2;a<=i;a++)
        {if(i%a==0){temp++;}}
        if(temp==2){res.psb(i);}
        temp=1;
    }
    return res;
}
string eliminateAt(string x, int num)//eliminates a single substring of a string in a given position
{
    if(num==0){return x.substr(1,x.length()-1);}
    else if(num==x.length()-1){return x.substr(0,x.length()-1);}
    else{return x.substr(0,num)+x.substr(num+1,x.length()-1);}
}
long long factorial(int num) //finds factorial of given integer
{
  if(num==0){return 1;}
  else{return num*factorial(num-1);}
}
long long pangkatp(int base,int exp) //powers base by exponen
{
    if(exp==0){return 1;}
    else{return base*pangkatp(base,exp-1);}
}
int sumdigit(string a) //sums all digit on given string (if the string only contains digits)
{
    int sum=0;
    for(int x=0;x<a.length();x++){sum+=toInt(a.substr(x,1));}
    return sum;
}
int absolutey(int a) //returns absolute value of an integer
{if(a<0){return a*-1;}else{return a;}}
bool contains(string a,string b) //Checks if string a contains string b, where a.length()>=b.length()
{
    bool valid=false;
    int x=0;
    while(x<a.length()-b.length()&&!valid)
    {
        if(a.substr(x,b.length())==b){valid=true;}
        else{x++;}
    }
    return valid;
}
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
string tobase(int num,int base) //translates bitmask from decimal number to base n. 2<=n<=9
{
  string a;
  while(num>0)
  {
    a+=tostr(num%base);
    num=(num-(num%base))/base;
  }
  return reverse(a);
}
int binarysearch(vector<int> a, int val) //requires a sorted vector, will return -1 if there's no such element exists in the vector
{
    if (a.size() == 0) { return -1; }
    int l = 0;
    int r = a.size() - 1;
    while (l < r)
    {
        int m = (l + r) / 2;
        if (a[m] > val)
        {
        	if (m == r) { m--; }
    	    r = m;
        }
        if (a[m] < val)
        {
            if (m == l) { m++; }
            l = m;
        }
        if (a[m] == val) { return m; }//return the index
    }
    return -1;
}
int main()
{
    //MAIN SECTION GOES HERE
    /* //In case you need, use them like cin and cout
    fstream fin("input.txt");
    fstream fout("output.txt");
    */

    return 0;
}
