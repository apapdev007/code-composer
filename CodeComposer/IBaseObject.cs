using System;

namespace CodeComposer
{
	/// <summary>
	/// Base interface for objects.
	/// </summary>
	public interface IBaseObject
	{
		string Name { get; set; }
		string Open { get; set; }
		string Close { get; set; }
	}
}
