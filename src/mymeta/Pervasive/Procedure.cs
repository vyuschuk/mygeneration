using System;
using System.Data;
using System.Data.OleDb;

namespace MyMeta.Pervasive
{
#if ENTERPRISE
	using System.Runtime.InteropServices;
	[ComVisible(true), ClassInterface(ClassInterfaceType.AutoDual), ComDefaultInterface(typeof(IProcedure))]
#endif 
	public class PervasiveProcedure : Procedure
	{
		public PervasiveProcedure()
		{

		}
	}
}
