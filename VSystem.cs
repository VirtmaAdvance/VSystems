using System.Runtime.InteropServices;

namespace VSystems
{
	/// <summary>
	/// Manages system operations and information.
	/// </summary>
	public class VSystem
	{
		/// <summary>
		/// Gets the currently logged in username.
		/// </summary>
		public static string Username => Environment.UserName;
		/// <summary>
		/// Gets teh current working directory.
		/// </summary>
		public static string CurrentDirectory => Environment.CurrentDirectory;
		/// <summary>
		/// Gets the current domain name the current user is connected to.
		/// </summary>
		public static string DomainName => Environment.UserDomainName;
		/// <summary>
		/// Gets the machine name.
		/// </summary>
		public static string MachineName => Environment.MachineName;

		/// <summary>
		/// Locks the current user and returns to the Windows login screen.
		/// </summary>
		public static void Lock() => LockWorkStation();
		/// <summary>
		/// Locks the machine.
		/// </summary>
		/// <returns>a <see cref="bool"/> value representing the status of the operation.</returns>
		[DllImport("user32.dll")]
		private static extern bool LockWorkStation();

	}
}