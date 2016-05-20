#include <bits/stdc++.h>
using namespace std;
int main() {
    int a,b,c;
    scanf("%d %d %d",&a,&b,&c);
    printf("%d\n",(max(abs(b-c),abs(a-b))-1));
    return 0;
}
