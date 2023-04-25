using System.ComponentModel.DataAnnotations;

namespace HomeWork5.Models
{
	public class FriendModel
	{
		[Required]
		public string FriendId { get; set; }

		[StringLength(255, MinimumLength =2, ErrorMessage ="Name can not be empty`")]
		public string FriendName { get; set; }

		[StringLength(25, ErrorMessage = "Length can't be more than 25 characters.")]
		public string Place { get; set; }
	}
}
