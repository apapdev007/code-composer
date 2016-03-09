using System;

namespace CodeComposer.CSharp
{
	/// <summary>
	/// Constants used throughout the C# namespaces.
	/// </summary>
	public static class Constants
	{
		public enum ProtectionLevels { Internal, Private, Protected, Public }
		
		
		public static string ToString(ProtectionLevels value)
		{
			switch (value)
			{
				case ProtectionLevels.Internal:
					return AccessModifiers.Internal;
				case ProtectionLevels.Private:
					return AccessModifiers.Private;
				case ProtectionLevels.Protected:
					return AccessModifiers.Protected;
				case ProtectionLevels.Public:
					return AccessModifiers.Public;
				default:
					throw new ArgumentException("ProtectionLevels value not mapped to a AccessModifier.", "value");
			}
		}
		
		private static class AccessModifiers
		{
			public const string Internal = "internal";
			public const string Private = "private";
			public const string Protected = "protected";
			public const string Public = "public";
		}
	}
}
