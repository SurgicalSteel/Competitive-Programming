#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
struct cell{
    int x,y;
};
double dist(cell a, cell b){
    double xt = double(abs(a.x-b.x)*abs(a.x-b.x));
    double yt = double(abs(a.y-b.y)*abs(a.y-b.y));
    return sqrt(xt+yt);
}
int main() {
    cell arr[9];
    int t;
    double tot=0;
    for(int j=0;j<3;j++){
        for(int i=0;i<3;i++){
            cin>>t;
            cell ct;
            ct.x=i;
            ct.y=j;
            arr[t-1]=ct;
        }
    }
    for(int i=0;i<8;i++){
        tot+=dist(arr[i],arr[i+1]);
    }
    printf("%.10f\n",tot);
    return 0;
}
