#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
int form(int a, int b){
    if (a>=b){
        return (a*10)+b;
    }
    return (b*10)+a;
}
bool ismia(int a, int b){
    return ((a==2&&b==1)||(a==1&&b==2));
}
void psw(){
    cout<<"Player 1 wins.\n";
}
void pdw(){
    cout<<"Player 2 wins.\n";
}
void t(){
    cout<<"Tie.\n";
}
int main() {
    // your code goes here
    int as,ad,bs,bd,aa,bb;
    cin>>as>>ad>>bs>>bd;
    while(as!=0&&ad!=0&&bs!=0&&bd!=0){
        if (ismia(as,ad)&&!ismia(bs,bd)){
            psw();
        }else if (!ismia(as,ad)&&ismia(bs,bd)){
            pdw();
        }else if (ismia(as,ad)&&ismia(bs,bd)){
            t();
        }else{
            aa= form(as,ad);
            bb= form(bs,bd);
            if (((aa%11==0)&&(bb%11!=0)) || ((aa%11==0)&&(bb%11==0)&&(aa>bb))){
                psw();
            }else if (((aa%11!=0)&&(bb%11==0)) || ((aa%11==0)&&(bb%11==0)&&(aa<bb))){
                pdw();
            }else if ((aa%11==0)&&(bb%11==0)&&(aa==bb)){
                t();
            }else{
                if(aa>bb){
                    psw();
                }else if(aa<bb){
                    pdw();
                }else{
                    t();
                }
            }
        }
        cin>>as>>ad>>bs>>bd;
    }
    return 0;
}
