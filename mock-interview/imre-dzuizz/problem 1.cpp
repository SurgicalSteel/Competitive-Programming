#include <bits/stdc++.h>
using namespace std;
string tostr(int x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
// 1 * 3 4 * 6 * 8 9 * 11

int main(){
    int n;
    bool stateOne, stateStar, stateTwo;
    stateOne=true;
    stateStar=false;
    stateTwo=false;
    cin>>n;
    int counterTwo = 0;
    string s = "";
    for(int i=1;i<=n;i++){
        if(stateOne && !stateStar){
            s += tostr(i) + " ";
            stateStar=true;
        }else if(stateOne && stateStar){
            s += "* ";
            stateTwo=true;
            stateOne=false;
            stateStar=false;
        }else if (stateTwo && !stateStar && counterTwo<2){
            s += tostr(i) + " ";
            counterTwo++;
            if(counterTwo==2){
                stateStar=true;
                counterTwo=0;
            }
        }
        // else if (stateTwo && !stateStar && counterTwo==2){
        //     s += tostr(i) + " ";
        //     counterTwo=0;
        //     stateStar=true;
        // }
        else if(stateTwo && stateStar){
            s += "* ";
            stateTwo=false;
            stateOne=true;
            stateStar=false;
        }
    }
    cout<<s<<"\n";
    return 0;
}
