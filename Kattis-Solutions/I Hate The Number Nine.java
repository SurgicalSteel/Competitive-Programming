import java.lang.*;
import java.util.*;
import java.math.*;

public class ihtnn {

    static String solve(BigInteger b)
    {
        b =b.subtract(BigInteger.valueOf(1));
        BigInteger tres=(BigInteger.valueOf(8).multiply(BigInteger.valueOf(9).modPow(b, BigInteger.valueOf(1000000007)))).mod(BigInteger.valueOf(1000000007));
        return tres.toString();
    }
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        int tc=sc.nextInt();
        String temp;
        for(int i=0;i<tc;i++)
        {
            temp=sc.next();
            System.out.println(solve(new BigInteger(temp)));
        }
    }
}
