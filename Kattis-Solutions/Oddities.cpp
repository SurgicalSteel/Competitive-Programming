    #include <iostream>
    using namespace std;
     
    int main() {
        // your code goes here
        int tc,x;
        cin>>tc;
        for(int i=0;i<tc;i++)
        {
            cin>>x;
            if(x%2==0){cout<<x<<" is even\n";}else{cout<<x<<" is odd\n";}
        }
        return 0;
}
