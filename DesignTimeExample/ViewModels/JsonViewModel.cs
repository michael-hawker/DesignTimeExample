namespace DesignTimeExample.ViewModels
{
	/// <summary>
	/// Reference object for Json design time data source is quite sensitive:
	/// target properties must have public getter and setter and property names must match those in json file.
	/// </summary>
	public class JsonViewModel
	{
		public string Data { get; set; }

		public string Color { get; set; }
	}
}