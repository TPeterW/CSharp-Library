//  A program to check whether a given number is an ugly number.
//  
//  Ugly numbers are positive numbers whose prime factors only include 2, 3, 5. For example, 6, 8 are ugly while 14 is not ugly since it includes another prime factor 7.
//  
//  Note that 1 is typically treated as an ugly number.

public class NumberOperator
{
    public bool IsUgly(int num)
	{
        int[] listPrime = new int[20000];
		int count = 0;
		
        for (int i = 7; i <= num; i++)
		{
			if(isPrime(i)){
				listPrime[count] = i;
				count++;
			}
		}
			
		for(int i = 0; i < count; i++)
		{
			if(num % listPrime[i] == 0)
			{
				return false;
			}	
		}
		
		return true;
    }
	
	private bool isPrime(int n)
	{
		for(int i = 2; i <= n /2 ; i++)
		{
            if(n % i == 0){
                return false;
            }
        }
        return true;
	}
}