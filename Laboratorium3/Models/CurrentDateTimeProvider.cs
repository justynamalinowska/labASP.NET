using System;
namespace Laboratorium3.Models
{
	public class CurrentDateTimeProvider : IDateTimeProvider
	{
		public DateTime GetDateTime() => DateTime.Now;
	}
}

