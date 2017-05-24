#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
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
int vprocess(vector<int> a, vector<int> b){
    int res=0;
    for(int i=0;i<min(a.size(),b.size());i++){
        res+= (a[i]*b[i]);
    }
    return res;
}
int main() {
    // your code goes here
    int mh,mw,kh,kw,t,ires=0,ikoef=0,xr=0,yr=0,countall=0;
    cin>>mh>>mw>>kh>>kw;
    vector<int> koef,vars;
    int img[mw][mh],ker[kw][kh],res[(mw-kw+1)*(mh-kh+1)];
    for(int j=0;j<mh;j++){
        for(int i=0;i<mw;i++){
            cin>>img[i][j];
        }
    }
    for(int j=0;j<kh;j++){
        for(int i=0;i<kw;i++){
            cin>>t;
            ker[i][j]=t;
            koef.psb(t);
            ikoef++;
        }
    }
    reverse(all(koef));
    vector<int> temp;
    for(int j=0;j<(mh-kh+1);j++){
        for(int i=0;i<(mw-kw+1);i++){
            temp.clear();
            for(int y=j;y<j+kh;y++){
                for(int x=i;x<i+kw;x++){
                    temp.psb(img[x][y]);    
                }   
            }
            cout<<vprocess(temp,koef);
            countall++;
            if (countall%(mw-kw+1)==0){
                cout<<"\n";
            }else{
                cout<<" ";
            }            

        }
    }   


    return 0;
}
