#include <bits/stdc++.h>
#include <algorithm>
using namespace std;

int main() {
    map<string,string> keys;
    keys.insert(make_pair("W","Q"));
    keys.insert(make_pair("E","W"));
    keys.insert(make_pair("R","E"));
    keys.insert(make_pair("T","R"));
    keys.insert(make_pair("Y","T"));
    keys.insert(make_pair("U","Y"));
    keys.insert(make_pair("I","U"));
    keys.insert(make_pair("O","I"));
    keys.insert(make_pair("P","O"));
    keys.insert(make_pair("[","P"));
    keys.insert(make_pair("S","A"));
    keys.insert(make_pair("D","S"));
    keys.insert(make_pair("F","D"));
    keys.insert(make_pair("G","F"));
    keys.insert(make_pair("H","G"));
    keys.insert(make_pair("J","H"));
    keys.insert(make_pair("K","J"));
    keys.insert(make_pair("L","K"));
    keys.insert(make_pair(";","L"));
    keys.insert(make_pair("X","Z"));
    keys.insert(make_pair("C","X"));
    keys.insert(make_pair("V","C"));
    keys.insert(make_pair("B","V"));
    keys.insert(make_pair("N","B"));
    keys.insert(make_pair("M","N"));
    keys.insert(make_pair(",","M"));
    keys.insert(make_pair("2","1"));
    keys.insert(make_pair("3","2"));
    keys.insert(make_pair("4","3"));
    keys.insert(make_pair("5","4"));
    keys.insert(make_pair("6","5"));
    keys.insert(make_pair("7","6"));
    keys.insert(make_pair("8","7"));
    keys.insert(make_pair("9","8"));
    keys.insert(make_pair("0","9"));
    keys.insert(make_pair("-","0"));
    keys.insert(make_pair("=","-"));
    keys.insert(make_pair("]","["));
    keys.insert(make_pair("\\","]"));
    keys.insert(make_pair(".",","));
    keys.insert(make_pair("/","."));
    keys.insert(make_pair("'",";"));
    keys.insert(make_pair("1","`"));
    string s;
    while(cin>>s)
    {
        string build="";
        for(int i=0;i<s.length();i++)
        {
            map<string,string>::iterator iter=keys.find(s.substr(i,1));
            if(iter!=keys.end())
            {build+=iter->second;}
        }
        cout<<build<<" ";
    }
    cout<<"\n";
    return 0;
}
