import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
    public static BigInteger pangkatp(int base,int exp)
    {
        if(exp==0){return BigInteger.valueOf(1);}
        else{return BigInteger.valueOf(base).multiply(pangkatp(base,exp-1));}
    }
    public static BigInteger sumdigit(String s)
    {
        BigInteger counter=BigInteger.valueOf(0);
        for(int i=0;i<s.length();i++)
        {counter=counter.add(BigInteger.valueOf(Integer.parseInt(s.substring(i,i+1))));}
        return counter;
    }
    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner s=new Scanner(System.in);
        int tc=s.nextInt();
        String[] res=new String[tc];
        for(int i=0;i<tc;i++)
        {
            int n=s.nextInt();
            String temp=sumdigit(pangkatp(2,n).toString()).toString();
            res[i]=temp;
        }
        for(int i=0;i<tc;i++)
        {System.out.println(res[i]);}
    }
}
