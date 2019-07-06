using System.ComponentModel.DataAnnotations;


namespace SwmsApi.Users.Authorization
{
	public class LoginDto
	{
		[Required]
		public string UserName { get; set; }

		[Required]
		public string Password { get; set; }
	}
}