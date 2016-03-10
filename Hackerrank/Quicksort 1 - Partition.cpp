#include <map>
#include <set>
#include <list>
#include <cmath>
#include <ctime>
#include <deque>
#include <queue>
#include <stack>
#include <bitset>
#include <cstdio>
#include <vector>
#include <cstdlib>
#include <numeric>
#include <sstream>
#include <iostream>
#include <algorithm>
#define psb push_back
using namespace std;
void partition(vector <int>  ar) {
   // Enter code for partitioning and printing here.
   vector<int> le,ri;
   ri.psb(ar[0]);
   for(int i=1;i<ar.size();i++)
   {
       if(ar[i]>=ar[0])
       {ri.psb(ar[i]);}
       else{le.psb(ar[i]);}
   }
   int ls=le.size();
   int rs=ri.size();
   for(int i=0;i<ls;i++)
   {ar[i]=le[i];}
   for(int i=0;i<rs;i++)
   {ar[ls+i]=ri[i];}
    for(int i=0;i<ar.size();i++)
   {printf("%d ",ar[i]);}
   printf("\n");
}
int main(void) {
   vector <int>  _ar;
   int _ar_size;
   cin >> _ar_size;
    
     for(int _ar_i=0; _ar_i<_ar_size; _ar_i++) {
        int _ar_tmp;
        cin >> _ar_tmp;
        _ar.psb(_ar_tmp); 
    }

   partition(_ar);
   
   return 0;
}
