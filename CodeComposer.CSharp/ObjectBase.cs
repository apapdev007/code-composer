/*
 * Created by SharpDevelop.
 * User: jking
 * Date: 3/9/2016
 * Time: 10:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CodeComposer.CSharp
{
	/// <summary>
	/// Description of ObjectBase.
	/// </summary>
	public abstract class ObjectBase : IBaseObject
	{
		public Constants.ProtectionLevels ProtectionLevel { get; set; }
		
		protected bool isStatic;
		public bool Static 
		{
			get { return isStatic; }
			
		}
		
		protected bool isConst;
		public bool Constant
		{
			
		}
		
		public string Name { get; set; }
		public string Open { get; set; }
		public string Close { get; set; }
		
		protected ObjectBase(string name)
		{
			Name = name;
			Open = "{";
			Close = "{";
		}
	}
}
