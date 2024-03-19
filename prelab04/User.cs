using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace prelab04
{
	[BindProperties(SupportsGet = true)]
	public class User
	{

		
		[Required(ErrorMessage = "Please enter your first name.")]
		public string Fname { get; set; } = string.Empty;

		[Display(Name = "Password")]
		[Required(ErrorMessage = "Please enter a password.")]
		[MinLength(3, ErrorMessage = "Password must contain more than 3 characters")]
		public string Password { get; set; }

		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		[Required(ErrorMessage = "Please enter your Email Address.")]
		public string EmailAddress { get; set; }
	}
}
