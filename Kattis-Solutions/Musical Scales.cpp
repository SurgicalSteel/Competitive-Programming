#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
const int sz=12;
string allnotes[12] = {"C","C#","D","D#","E","F","F#","G","G#","A","A#","B"};
bool issexist(vector<string> v, string s){
    vector<string>::iterator iter = find(all(v),s);
    return (iter != v.end());
}
vector< vector < string > > generateallpossible(){
    vector< vector < string > > res;

    for(int csi=0;csi<12;csi++){
        vector < string > tvscale;
        int counter=0;
        int noteprog=csi;
        while(counter<8){
            tvscale.psb(allnotes[noteprog%12]);
            if(counter==2 || counter==6){
                noteprog++;
            }else{
                noteprog+=2;
            }
            counter++;
        }
        res.psb(tvscale);
    }
    return res;
}
int main() {
    // your code goes here
    int nn;
    string ts;
    vector<string> vsin,vres;
    vector < vector < string > > vss = generateallpossible();
    
    cin>>nn;
    
    for(int i=0;i<nn;i++){
        cin>>ts;
        vsin.psb(ts);
    }
    
    for(int i=0;i<vss.size();i++){
        bool allthere=true;
        for(int j=0;j<vsin.size();j++){
            if(!issexist(vss[i],vsin[j])){
                allthere=false;
            }
        }
        
        if (allthere){
            vres.psb(vss[i][0]);
        }
    }
    if (vres.size()>0){
        sort(all(vres));
        for(int i=0;i<vres.size();i++){
            cout<<vres[i]<<" ";
        }
        cout<<"\n";
    }else{
        cout<<"none\n";
    }
    
    
    
//    for (int i=0;i<vss.size();i++){
//        for(int j=0;j<vss[i].size();j++){
//            cout<<vss[i][j]<<" ";
//        }
//        cout<<"\n";
//    }
    return 0;
}
