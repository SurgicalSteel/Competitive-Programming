#include <bits/stdc++.h>
#define psb push_back
using namespace std;
struct keymap
{
    string alp;
    int x,y;
};
int absolutey(int a)
{
    if (a < 0) { return a * -1; }
    else { return a; }
}
vector<keymap> col;
void initialize()
{
  keymap temp;
  temp.alp="a";
  temp.x=0;
  temp.y=1;
  col.psb(temp);
  temp.alp="b";
  temp.x=4;
  temp.y=2;
  col.psb(temp);
  temp.alp="c";
  temp.x=2;
  temp.y=2;
  col.psb(temp);
  temp.alp="d";
  temp.x=2;
  temp.y=1;
  col.psb(temp);
  temp.alp="e";
  temp.x=2;
  temp.y=0;
  col.psb(temp);
  temp.alp="f";
  temp.x=3;
  temp.y=1;
  col.psb(temp);
  temp.alp="g";
  temp.x=4;
  temp.y=1;
  col.psb(temp);
  temp.alp="h";
  temp.x=5;
  temp.y=1;
  col.psb(temp);
  temp.alp="i";
  temp.x=7;
  temp.y=0;
  col.psb(temp);
  temp.alp="j";
  temp.x=6;
  temp.y=1;
  col.psb(temp);
  temp.alp="k";
  temp.x=7;
  temp.y=1;
  col.psb(temp);
  temp.alp="l";
  temp.x=8;
  temp.y=1;
  col.psb(temp);
  temp.alp="m";
  temp.x=6;
  temp.y=2;
  col.psb(temp);
  temp.alp="n";
  temp.x=5;
  temp.y=2;
  col.psb(temp);
  temp.alp="o";
  temp.x=8;
  temp.y=0;
  col.psb(temp);
  temp.alp="p";
  temp.x=9;
  temp.y=0;
  col.psb(temp);
  temp.alp="q";
  temp.x=0;
  temp.y=0;
  col.psb(temp);
  temp.alp="r";
  temp.x=3;
  temp.y=0;
  col.psb(temp);
  temp.alp="s";
  temp.x=1;
  temp.y=1;
  col.psb(temp);
  temp.alp="t";
  temp.x=4;
  temp.y=0;
  col.psb(temp);
  temp.alp="u";
  temp.x=6;
  temp.y=0;
  col.psb(temp);
  temp.alp="v";
  temp.x=3;
  temp.y=2;
  col.psb(temp);
  temp.alp="w";
  temp.x=1;
  temp.y=0;
  col.psb(temp);
  temp.alp="x";
  temp.x=1;
  temp.y=2;
  col.psb(temp);
  temp.alp="y";
  temp.x=5;
  temp.y=0;
  col.psb(temp);
  temp.alp="z";
  temp.x=0;
  temp.y=2;
  col.psb(temp);
}
int getdist(string sa, string du)
{
  int sx,sy,dx,dy;
  bool fa=false,fb=false;
  for(int i=0;i<col.size();i++)
  {
    if(col[i].alp==sa)
    {
        sx=col[i].x;
        sy=col[i].y;
        fa=true;
    }
    if(col[i].alp==du)
    {
        dx=col[i].x;
        dy=col[i].y;
        fb=true;
    }
    if(fa&&fb){break;}
  }
  return absolutey(sy-dy)+absolutey(sx-dx);
}
int getalldist(string sa, string du)
{
  int counter=0;
  for(int i=0;i<sa.length();i++)
  {counter+=(getdist(sa.substr(i,1),du.substr(i,1)));}
  return counter;
}
struct vres
{
  string typing;
  int dist;
};
bool sorter(vres const &va, vres const &vb)
{
  if(va.dist<vb.dist){return true;}
  else if(vb.dist<va.dist){return false;}
  else{
    if(va.typing<vb.typing){return true;}
    else{return false;}
  }
}
int main() {
  initialize();
  int tc;
  cin>>tc;
  string def,temps;
  int ntyping;
  vector<vres> myresult;
  vres tempres;
  for(int z=0;z<tc;z++)
  {
    cin>>def>>ntyping;
    for(int x=0;x<ntyping;x++)
    {
      cin>>temps;
      tempres.typing=temps;
      tempres.dist=getalldist(tempres.typing,def);
      myresult.psb(tempres);
    }
    sort(myresult.begin(),myresult.end(),sorter);
    for(int y=0;y<myresult.size();y++)
    {cout<<myresult[y].typing<<" "<<myresult[y].dist<<"\n";}
    myresult.clear();
  }
  return 0;
}
