import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
    
    public static BigInteger quad(BigInteger a)
    {return a.multiply(a);}
    
    public static BigInteger fib(int n,int a,int b)
    {
        BigInteger[] bm=new BigInteger[n];
        for(int i=0;i<n;i++){bm[i]=new BigInteger("0");}
        bm[0]=bm[0].add(BigInteger.valueOf(a));
        bm[1]=bm[1].add(BigInteger.valueOf(b));
        BigInteger curr,temp,t,s;
        for(int i=2;i<n;i++)
        {
            temp=bm[i-1];
            //bm[i]=BigInteger.valueOf(0);
            bm[i]=bm[i].add(quad(temp));
            bm[i]=bm[i].add(bm[i-2]);
            //System.out.println(bm[i].toString());
        }
        return bm[n-1];
    }

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner s=new Scanner(System.in);
        int a,b,n;
        a=s.nextInt();
        b=s.nextInt();
        n=s.nextInt();
        System.out.println(fib(n,a,b).toString());
    }
}
