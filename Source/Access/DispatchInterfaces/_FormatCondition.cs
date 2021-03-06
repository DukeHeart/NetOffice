using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface _FormatCondition 
	/// SupportByVersion Access, 9,10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _FormatCondition : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_FormatCondition);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _FormatCondition(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _FormatCondition(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _FormatCondition(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _FormatCondition() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _FormatCondition(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public Int32 ForeColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ForeColor", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ForeColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public Int32 BackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackColor", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public bool FontBold
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FontBold", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FontBold", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public bool FontItalic
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FontItalic", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FontItalic", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public bool FontUnderline
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FontUnderline", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FontUnderline", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public bool Enabled
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Enabled", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Enabled", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public NetOffice.AccessApi.Enums.AcFormatConditionType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.AccessApi.Enums.AcFormatConditionType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public NetOffice.AccessApi.Enums.AcFormatConditionOperator Operator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Operator", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.AccessApi.Enums.AcFormatConditionOperator)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public string Expression1
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Expression1", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public string Expression2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Expression2", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Access 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Access", 14,15)]
		public NetOffice.AccessApi.Enums.AcFormatBarLimits ShortestBarLimit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShortestBarLimit", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.AccessApi.Enums.AcFormatBarLimits)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShortestBarLimit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Access 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Access", 14,15)]
		public string ShortestBarValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShortestBarValue", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShortestBarValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Access 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Access", 14,15)]
		public NetOffice.AccessApi.Enums.AcFormatBarLimits LongestBarLimit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LongestBarLimit", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.AccessApi.Enums.AcFormatBarLimits)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LongestBarLimit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Access 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Access", 14,15)]
		public string LongestBarValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LongestBarValue", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LongestBarValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Access 14, 15
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Access", 14,15)]
		public bool ShowBarOnly
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowBarOnly", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowBarOnly", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="type">NetOffice.AccessApi.Enums.AcFormatConditionType Type</param>
		/// <param name="_operator">optional NetOffice.AccessApi.Enums.AcFormatConditionOperator Operator = 0</param>
		/// <param name="expression1">optional object Expression1</param>
		/// <param name="expression2">optional object Expression2</param>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public void Modify(NetOffice.AccessApi.Enums.AcFormatConditionType type, object _operator, object expression1, object expression2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, expression1, expression2);
			Invoker.Method(this, "Modify", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="type">NetOffice.AccessApi.Enums.AcFormatConditionType Type</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public void Modify(NetOffice.AccessApi.Enums.AcFormatConditionType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			Invoker.Method(this, "Modify", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="type">NetOffice.AccessApi.Enums.AcFormatConditionType Type</param>
		/// <param name="_operator">optional NetOffice.AccessApi.Enums.AcFormatConditionOperator Operator = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public void Modify(NetOffice.AccessApi.Enums.AcFormatConditionType type, object _operator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator);
			Invoker.Method(this, "Modify", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		/// <param name="type">NetOffice.AccessApi.Enums.AcFormatConditionType Type</param>
		/// <param name="_operator">optional NetOffice.AccessApi.Enums.AcFormatConditionOperator Operator = 0</param>
		/// <param name="expression1">optional object Expression1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public void Modify(NetOffice.AccessApi.Enums.AcFormatConditionType type, object _operator, object expression1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, expression1);
			Invoker.Method(this, "Modify", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 9, 10, 11, 12, 14, 15
		/// </summary>
		[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Access 11, 12, 14, 15
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Access", 11,12,14,15)]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}