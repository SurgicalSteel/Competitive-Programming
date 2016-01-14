#include <bits/stdc++.h>
#define mas_Bangun using
#define cinta namespace
#define mbak_IsyanaSarasvati std
 
mas_Bangun cinta mbak_IsyanaSarasvati;

string cycle(string s, int num)
{
    string build=s.substr(0,s.length()-num);
    build=s.substr(s.length()-num,num)+build;
    return build;
}
string solve(string s, int l, int r, int k)
{
    string res;
    if(l==1&&r<s.length())
    {
        string temp=s.substr(r,s.length()-r);
        string cy=s.substr(0,r);
        cy=cycle(cy,k%cy.length());
        res=cy+temp;
    }
    else if(l>1&&r==s.length())
    {
        string cy=s.substr(l-1,(r-l)+1);
        string temp=s.substr(0,l-1);
        cy=cycle(cy,k%cy.length());
        res=temp+cy;
    }
    else if(l==1&&r==s.length())
    {
        s=cycle(s,k%s.length());
        res=s;
    }
    else
    {
        string cy=s.substr(l-1,(r-l)+1);
        string tl=s.substr(0,l-1);
        string tr=s.substr(r,s.length()-1);
        cy=cycle(cy,k%cy.length());
        res=tl+cy+tr;
    }
    return res;
}
int main() {
    string s,curr;
    cin>>s;
    int tc,l,r,k;
    cin>>tc;
    curr=s;
    for(int i=0;i<tc;i++)
    {
        cin>>l>>r>>k;
        curr=solve(curr,l,r,k);
    }
    cout<<curr<<"\n";
    return 0;
}
