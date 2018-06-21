using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace CSharpTutA
{
		class Program
		{

				static void Main(string[] args)
				{
					BankAcct acct = new BankAcct(10);
					Thread[] threads = new Thread[15];

					Thread.CurrentThread.Name = "main";

					for (int i = 0; i < 15; i++)
					{
							Thread t = new Thread(new ThreadStart(acct.IssueWithdraw));
							t.Name = i.ToString();
							threads[i] = t;
					}

					for (int i = 0; i < 15; i++)
					{
							System.Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);

							threads[i].Start();

							System.Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
					}

					System.Console.WriteLine("Current Priority {0}", Thread.CurrentThread.Priority);

					System.Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name);
					
					Console.ReadLine();
				}
		}
}

class BankAcct
{
	private Object acctLock = new object();
	double Balance {set; get;}		

	public BankAcct(double bal)
	{
			Balance = bal;
	}

	public double Withdraw(double amt)
	{
		if ((Balance - amt) < 0)
		{
				System.Console.WriteLine($"Sorrt ${Balance} in Account");
				return Balance;
		}
		lock(acctLock)
		{
			if (Balance >= amt)
			{
					System.Console.WriteLine("Removed {0} and {1} left in Account", amt, (Balance - amt));
					Balance -= amt;
			}
			return Balance;
		}	
	}
	public void IssueWithdraw()
	{
		Withdraw(1);
	}
}
