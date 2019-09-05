using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam__HOME_
{
	class Program
	{
		static void Main(string[] args)
		{

			int examHour = int.Parse(Console.ReadLine());
			int examMinutes = int.Parse(Console.ReadLine());
			int arriveHour = int.Parse(Console.ReadLine());
			int arriveMinutes = int.Parse(Console.ReadLine());

			int examTime = examHour * 60 + examMinutes;
			int arriveTime = arriveHour * 60 + arriveMinutes;

			if ((examTime - arriveTime >= 0) && (examTime - arriveTime <= 30)) // navreme
			{
				Console.WriteLine("On time");

				if (examTime - arriveTime >= 1)
				{
					Console.WriteLine($"{examTime - arriveTime} minutes before the start");
				}
				
			}
			else if ((examTime - arriveTime > 30) && (examTime - arriveTime < 60)) // podranil
			{
				Console.WriteLine("Early");
				Console.WriteLine($"{examTime - arriveTime} minutes before the start");

				
			}
			else if (examTime - arriveTime >= 60)
			{
				Console.WriteLine("Early");

				double hoursBeforeExam = Math.Truncate((examTime - arriveTime) / 60.0);
				int minutesBeforeExam = (examTime - arriveTime) % 60;
				Console.WriteLine($"{hoursBeforeExam}:{minutesBeforeExam:D2} hours before the start");
			}
			else if (arriveTime - examTime > 0) // zakusnql
			{
				Console.WriteLine("Late");

				if (arriveTime - examTime >=1 && arriveTime - examTime < 60)
				{
					Console.WriteLine($"{arriveTime - examTime} minutes after the start");
				}
				else
				{
					double hoursAfterExam = Math.Truncate((arriveTime - examTime) / 60.0);
					int minutesAfterExam = (arriveTime - examTime) % 60;
					Console.WriteLine($"{hoursAfterExam}:{minutesAfterExam:D2} hours after the start");
				}
			}

			
		}
	}
}
