﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version:2.0.40607.85
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace SortableGenericListBox.Properties
{
	public partial class Settings : System.Configuration.ApplicationSettingsBase
	{
		private static Settings m_Value;

		private static object m_SyncObject = new object();

		public static Settings Value
		{
			get
			{
				if ((Settings.m_Value == null))
				{
					System.Threading.Monitor.Enter(Settings.m_SyncObject);
					if ((Settings.m_Value == null))
					{
						try
						{
							Settings.m_Value = new Settings();
						}
						finally
						{
							System.Threading.Monitor.Exit(Settings.m_SyncObject);
						}
					}
				}
				return Settings.m_Value;
			}
		}
	}
}
