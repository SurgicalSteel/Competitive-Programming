#include <bits/stdc++.h>
#define pb push_back
#define Mas_Bangun using
#define cinta namespace
#define Mbak_RaniApriana std
Mas_Bangun cinta Mbak_RaniApriana;
void generatePrima(int n)
{
    int temp=1;
    for(int i=2;i<=n;i++)
    {
        for(int a=2;a<=i;a++)
        {if(i%a==0){temp++;}}
        if(temp==2){cout<<i<<"\n";}
        temp=1;
    }
}
int main()
{
    //MAIN SECTION GOES HERE
    /* //In case you wanna read and write file, use them like cin and cout
    fstream fin("input.txt");
    fstream fout("output.txt");
    */
    int test;
    cin>>test;
    generatePrima(test);
    return 0;
}
