using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
	 /// </summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlScaleType
	{
		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-4132</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlScaleLinear = -4132,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14, 15
		 /// </summary>
		 /// <remarks>-4133</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14,15)]
		 xlScaleLogarithmic = -4133
	}
}