#include <bits/stdc++.h>
#include <chrono>

using namespace std;

long long toll(string x)
{
    istringstream ss(x);
    long long a;
    ss>>a;
    return a;
}

string tostr(long long x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}

long long sumchar(long long x){
    long long r=0;
    string s = tostr(x);
    for(int i=0;i<s.length();i++){
        r+=toll(s.substr(i,1));
    }
    return r;
}

bool isHarshad(long long x){
    long long sc = sumchar(x);
    return ((x%sc) == 0);
}

int main()
{
    //auto start = chrono::high_resolution_clock::now();
    long long n;
    cin>>n;
    bool stop = false;
    if(isHarshad(n)){
        cout<<n<<"\n";
    }else{
        n++;
        while(!stop){
            if(isHarshad(n)){
                cout<<n<<"\n";
                stop=true;
            }else{
                n++;
            }
        }
    }
    //auto finish = chrono::high_resolution_clock::now();
    //chrono::duration <double> timestamper = finish - start;
    //cout<<"timestamper "<<timestamper.count()<<" \n";
    return 0;
}
