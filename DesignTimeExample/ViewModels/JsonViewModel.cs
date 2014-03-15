namespace DesignTimeExample.ViewModels
{
	/// <summary>
	/// Json files are deserialized into design time data source using internal data serializer,
	/// that is quite sensitive to reference object type.
	/// </summary>
	public class JsonViewModel
	{
		public string Data { get { return null; } }
		public string Color { get { return null; } }
	}
}