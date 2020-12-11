using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace NewApp.Skia.Tizen
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = new TizenHost(() => new NewApp.App(), args);
			host.Run();
		}
	}
}
