#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main(){
    int t;
    cin >> t;
    for(int a0 = 0; a0 < t; a0++){
        bool exstat=false,found=false;
        int R;
        int C;
        cin >> R >> C;
        vector<string> G(R);
        for(int G_i = 0;G_i < R;G_i++){
           cin >> G[G_i];
        }
        int r;
        int c;
        cin >> r >> c;
        vector<string> P(r);
        for(int P_i = 0;P_i < r;P_i++){
           cin >> P[P_i];
        }
        
        int itr=0,itc=0,sr;
        while(itr<=R-r&&!found)
        {
        	itc=0;
            while(itc<=C-c&&!found)
            {
                if(G[itr].substr(itc,c)==P[0])
                { 
                    sr=0;
                    int tempitr=itr;
                    int tempitc=itc;
                    exstat=true;
                    //check for the next lines
                    while(sr<r&&exstat)
                    {
                        if(G[tempitr+sr].substr(tempitc,c)!=P[sr])
                        {exstat=false;}
                        else
                        {sr++;}
                    }
                }else{exstat=false;}
                if(exstat){cout<<"YES\n";found=true;}else{itc++;}
            }
            itr++;
        }
        if(!found){cout<<"NO\n";}
    }
    return 0;
}
