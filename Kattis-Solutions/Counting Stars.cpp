#include <bits/stdc++.h>
using namespace std;
#define psb push_back
#define all(x) (x).begin(),(x).end()
struct cell{
    int x,y,d,v;
};
bool validate(int x, int y, int sx,int sy){
    return !(x<0 || y<0 || x>=sx || y>=sy);
}
bool isnv(cell c){
    return (c.v==0);
}
int main() {
    int x,y,ctr,nc=1,it;
    string s;
    while(cin>>y>>x){
        cell m[x][y], tc;
        ctr=0;
        vector<cell> vc;
        for(int j=0;j<y;j++){
            cin>>s;
            for(int i=0;i<s.length();i++){
                tc.x=i;
                tc.y=j;
                if(s.substr(i,1)=="#"){
                    tc.d=0;
                    tc.v=-1;
                }else{
                    tc.d=1;
                    tc.v=0;
                }
                m[i][j]=tc;
                vc.psb(tc);
            }
        }
        if (vc.size()==0){
            cout<<"Case "<<nc<<": 0\n";
        }else{
            it=0;
            while(it<vc.size()){
                if (m[vc[it].x][vc[it].y].v == 1 ||m[vc[it].x][vc[it].y].v == -1){
                    it++;
                }else if (m[vc[it].x][vc[it].y].v == 0){
                    stack<cell> sta;
                    sta.push(vc[it]);
                    while(sta.size()>0){
                        tc = sta.top();    
                        sta.pop();
                        if (m[tc.x][tc.y].v == 0){
                            m[tc.x][tc.y].v++;
                            if (validate(tc.x, tc.y-1,x,y)){
                                if (isnv(m[tc.x][tc.y-1])){sta.push(m[tc.x][tc.y-1]);}
                            }
                            if (validate(tc.x, tc.y+1,x,y)){
                                if (isnv(m[tc.x][tc.y+1])){sta.push(m[tc.x][tc.y+1]);}
                            }
                            if (validate(tc.x-1, tc.y,x,y)){
                                if (isnv(m[tc.x-1][tc.y])){sta.push(m[tc.x-1][tc.y]);}
                            }
                            if (validate(tc.x+1, tc.y,x,y)){
                                if (isnv(m[tc.x+1][tc.y])){sta.push(m[tc.x+1][tc.y]);}
                            }
                        }
                        if(sta.size()==0){ctr++;}
                    }
                    it++;    
                }
            }
            cout<<"Case "<<nc<<": "<<ctr<<"\n";
        }
        nc++;
    }
    return 0;
}
