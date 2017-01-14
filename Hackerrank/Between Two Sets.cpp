#include <bits/stdc++.h>
using namespace std;
#define psb push_back
#define all(x) (x).begin(),(x).end()
vector<int> ff;
int ctr=0;
bool finder(int a){
    vector<int>::iterator iter=ff.begin();
    iter =find(all(ff),a);
    return iter!=ff.end();
}
void processb(vector<int> vb){
    for(int i=0;i<vb.size();i++){
        for(int j=1;j<sqrt(vb[i])+1;j++){
            if(vb[i]%j==0){
                if(!finder(j)){ff.psb(j);}
                if(!finder(vb[i]/j)){ff.psb(vb[i]/j);}
            }
        }
    }
}
void checka(vector<int> va){
    for(int i=0;i<ff.size();i++){
        for(int j=0;j<va.size();j++){
            if(ff[i]%va[j]!=0){
                ff[i]=-1;
            }
        }
    }
}
void checkb(vector<int> vb){
    for(int i=0;i<ff.size();i++){
        for(int j=0;j<vb.size();j++){
            if(vb[j]%ff[i]!=0){
                ff[i]=-1;
            }
        }
    }
}
void print(){
    for(int i=0;i<ff.size();i++){
        if(ff[i]!=-1){
            ctr++;
        }
    }
    printf("%d\n",ctr);
}
int main(){
    int n;
    int m;
    cin >> n >> m;
    vector<int> a(n);
    for(int a_i = 0;a_i < n;a_i++){
       cin >> a[a_i];
    }
    vector<int> b(m);
    for(int b_i = 0;b_i < m;b_i++){
       cin >> b[b_i];
    }
    processb(b);
    checka(a);
    checkb(b);
    print();
    return 0;
}
