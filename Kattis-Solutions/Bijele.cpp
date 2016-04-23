#include <bits/stdc++.h>
//created by Yuwono Bangun Nagoro a.k.a SurgicalSteel
#define psb push_back
#define Mas_Bangun using
#define cinta namespace
#define Mbak_GitaGutawa std
Mas_Bangun cinta Mbak_GitaGutawa;
int main() {
    int ki,qu,ro,bi,kn,pa;
    cin>>ki>>qu>>ro>>bi>>kn>>pa;
    if(ki==0){ki=1;}
    else if (ki==1){ki=0;}
    else {ki=1-ki;}
    if(qu==0){qu=1;}
    else if (qu==1){qu=0;}
    else {qu=1-qu;}
    if(ro<2){ro=2-ro;}
    else if (ro==2){ro=0;}
    else {ro=2-ro;}
    if(bi<2){bi=2-bi;}
    else if (bi==2){bi=0;}
    else {bi=2-bi;}
    if(kn<2){kn=2-kn;}
    else if (kn==2){kn=0;}
    else {kn=2-kn;}
    if(pa<8){pa=8-pa;}
    else if (pa==8){pa=0;}
    else {pa=8-pa;}
    cout<<ki<<" "<<qu<<" "<<ro<<" "<<bi<<" "<<kn<<" "<<pa<<"\n";
    return 0;
}
