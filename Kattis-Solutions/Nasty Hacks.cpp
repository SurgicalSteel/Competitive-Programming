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
    int n,cwoa,cwa,ca;
    cin>>n;
    for(int i=0;i<n;i++){
        cin>>cwoa>>cwa>>ca;
        if(ca+cwoa==cwa){
            cout<<"does not matter\n";
        }else if (ca+cwoa<cwa){
            cout<<"advertise\n";
        }else{cout<<"do not advertise\n";}
    }
	return 0;
}
