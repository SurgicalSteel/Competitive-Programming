#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
int main() {
	// your code goes here
    int x,y;
    cin>>x>>y;
    if(x>0&&y>0){cout<<"1\n";}
    else if(x>0&&y<0){cout<<"4\n";}
    else if(x<0&&y<0){cout<<"3\n";}
    else if(x<0&&y>0){cout<<"2\n";}
	return 0;
}
