using System.Runtime.InteropServices;

namespace VSystems
{
	public class VSystem
	{
		/// <summary>
		/// Gets the currently logged in username.
		/// </summary>
		public static string Username => Environment.UserName;
		/// <summary>
		/// Gets the current domain name the current user is connected to.
		/// </summary>
		public static string DomainName => Environment.UserDomainName;

		/// <summary>
		/// Locks the current user and returns to the Windows login screen.
		/// </summary>
		public static void Lock() => LockWorkStation();

		[DllImport("user32.dll")]
		private static extern bool LockWorkStation();

	}
}