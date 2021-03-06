using System;
using NetOffice;
namespace NetOffice.AccessApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Access 10, 11, 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Access", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum AcPrintItemLayout
	{
		 /// <summary>
		 /// SupportByVersion Access 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1953</remarks>
		 [SupportByVersionAttribute("Access", 10,11,12,14,15)]
		 acPRHorizontalColumnLayout = 1953,

		 /// <summary>
		 /// SupportByVersion Access 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>1954</remarks>
		 [SupportByVersionAttribute("Access", 10,11,12,14,15)]
		 acPRVerticalColumnLayout = 1954
	}
}