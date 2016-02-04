import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner s=new Scanner(System.in);
        int tc,temp;
        tc=s.nextInt();
        BigInteger[] res=new BigInteger[tc];
        for(int i=0;i<tc;i++)
        {
            temp=s.nextInt();
            BigInteger b=BigInteger.valueOf(temp);
            if(b.mod(BigInteger.valueOf(2))==BigInteger.valueOf(0)){res[i]=b.multiply(b).divide(BigInteger.valueOf(4));}
            else
            {
                BigInteger a=b.subtract(BigInteger.valueOf(1));
                a=a.divide(BigInteger.valueOf(2));
                BigInteger x=a.add(BigInteger.valueOf(1));
                res[i]=a.multiply(x);
            }
        }
        for(int i=0;i<tc;i++)
        {System.out.println(res[i].toString());}
    }
}
