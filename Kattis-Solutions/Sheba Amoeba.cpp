#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
bool isvalid (int xc, int yc, int x, int y){
    return xc >= 0 && xc<x && yc >= 0 && yc < y;
}
struct cell{
    int x,y,vd;
    bool sg;
};
int main() {
    // your code goes here
    int y,x,vi,actr=0;
    string s;
    cin>>y>>x;
    cell mat[x][y],tcell;
    vector<cell> vc;
    for(int j=0;j<y;j++){
        cin>>s;
        for(int i=0;i<s.length();i++){
            tcell.vd=0;
            tcell.x=i;
            tcell.y=j;
            tcell.sg= (s.substr(i,1)=="#");
            mat[i][j]=tcell;
            if (tcell.sg){
                vc.psb(tcell);
            }
        }
    }
    if (vc.size()>0){
        vi=0;
        while(vi<vc.size()){
            if (mat[vc[vi].x][vc[vi].y].vd == 1){
                vi++;
            }else{
                stack<cell> sta;
                sta.push(vc[vi]);
                while(!sta.empty()){
                    tcell = sta.top();
                    sta.pop();
                    if (mat[tcell.x][tcell.y].vd == 0){
                        mat[tcell.x][tcell.y].vd++;
                        if (isvalid(tcell.x-1,tcell.y+1,x,y)){
                            if (mat[tcell.x-1][tcell.y+1].sg){
                                sta.push(mat[tcell.x-1][tcell.y+1]);
                            }
                        }
                        if (isvalid(tcell.x,tcell.y+1,x,y)){
                            if (mat[tcell.x][tcell.y+1].sg){
                                sta.push(mat[tcell.x][tcell.y+1]);
                            }
                        }
                        if (isvalid(tcell.x+1,tcell.y+1,x,y)){
                            if (mat[tcell.x+1][tcell.y+1].sg){
                                sta.push(mat[tcell.x+1][tcell.y+1]);
                            }
                        }
                        if (isvalid(tcell.x-1,tcell.y,x,y)){
                            if (mat[tcell.x-1][tcell.y].sg){
                                sta.push(mat[tcell.x-1][tcell.y]);
                            }
                        }
                        if (isvalid(tcell.x+1,tcell.y,x,y)){
                            if (mat[tcell.x+1][tcell.y].sg){
                                sta.push(mat[tcell.x+1][tcell.y]);
                            }
                        }
                        if (isvalid(tcell.x-1,tcell.y-1,x,y)){
                            if (mat[tcell.x-1][tcell.y-1].sg){
                                sta.push(mat[tcell.x-1][tcell.y-1]);
                            }
                        }
                        if (isvalid(tcell.x,tcell.y-1,x,y)){
                            if (mat[tcell.x][tcell.y-1].sg){
                                sta.push(mat[tcell.x][tcell.y-1]);
                            }
                        }
                        if (isvalid(tcell.x+1,tcell.y-1,x,y)){
                            if (mat[tcell.x+1][tcell.y-1].sg){
                                sta.push(mat[tcell.x+1][tcell.y-1]);
                            }
                        }
                    }
                }
                actr++;
            }
        }
    }
    cout<<actr<<"\n";
    return 0;
}
