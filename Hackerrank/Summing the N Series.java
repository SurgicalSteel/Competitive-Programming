import java.io.*;
import java.util.*;
import java.math.*;
public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner sc=new Scanner(System.in);
        int a=0,tc=sc.nextInt();
        while(a<tc)
        {
            String s=sc.next();
            BigInteger bi=new BigInteger(s);
            BigInteger md=new BigInteger("1000000007");
            bi=bi.multiply(bi);
            bi=bi.mod(md);
            System.out.println(bi.toString());
            a++;
        }
    }
}
