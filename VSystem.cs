using System.Runtime.InteropServices;

namespace VSystems
{
	public class VSystem
	{


		/// <summary>
		/// Locks the current user and returns to the Windows login screen.
		/// </summary>
		public static void Lock() => LockWorkStation();

		[DllImport("user32.dll")]
		private static extern bool LockWorkStation();

	}
}
