#include <bits/stdc++.h>
using namespace std;
int main(){
    int h;
    cin >> h;
    int m;
    cin >> m;
    map<int,string> d;
    d.insert(pair<int,string>(0,"o' clock"));
    d.insert(pair<int,string>(1,"one"));
    d.insert(pair<int,string>(2,"two"));
    d.insert(pair<int,string>(3,"three"));
    d.insert(pair<int,string>(4,"four"));
    d.insert(pair<int,string>(5,"five"));
    d.insert(pair<int,string>(6,"six"));
    d.insert(pair<int,string>(7,"seven"));
    d.insert(pair<int,string>(8,"eight"));
    d.insert(pair<int,string>(9,"nine"));
    d.insert(pair<int,string>(10,"ten"));
    d.insert(pair<int,string>(11,"eleven"));
    d.insert(pair<int,string>(12,"twelve"));
    d.insert(pair<int,string>(13,"thirteen"));
    d.insert(pair<int,string>(14,"fourteen"));
    d.insert(pair<int,string>(15,"quarter"));
    d.insert(pair<int,string>(16,"sixteen"));
    d.insert(pair<int,string>(17,"seventeen"));
    d.insert(pair<int,string>(18,"eighteen"));
    d.insert(pair<int,string>(19,"nineteen"));
    d.insert(pair<int,string>(20,"twenty"));
    d.insert(pair<int,string>(21,"twenty one"));
    d.insert(pair<int,string>(22,"twenty two"));
    d.insert(pair<int,string>(23,"twenty three"));
    d.insert(pair<int,string>(24,"twenty four"));
    d.insert(pair<int,string>(25,"twenty five"));
    d.insert(pair<int,string>(26,"twenty six"));
    d.insert(pair<int,string>(27,"twenty seven"));
    d.insert(pair<int,string>(28,"twenty eight"));
    d.insert(pair<int,string>(29,"twenty nine"));
    d.insert(pair<int,string>(30,"half"));
    string sh,sm,res;
    sh=d.find(h)->second;
    if(m>0&&m<=30)
    {
        if(m>=13&&m<30&&m!=15){sm=d.find(m)->second+" minutes past ";}
        else{sm=d.find(m)->second+" past ";}
        cout<<sm<<sh<<"\n";
    }
    else if(m>30)
    {
        if(60-m!=15){sm=d.find(60-m)->second+" minutes to ";}
        else{sm=d.find(60-m)->second+" to ";}
        if(h==12){sh=d.find(1)->second;}
        else{sh=d.find(h+1)->second;}
        cout<<sm<<sh<<"\n";
    }
    else if(m==0)
    {
        sm=d.find(m)->second;
        cout<<sh<<" "<<sm<<"\n";
    }
    return 0;
}
