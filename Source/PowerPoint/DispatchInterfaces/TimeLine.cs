using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface TimeLine 
	/// SupportByVersion PowerPoint, 10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class TimeLine : COMObject
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
                    _type = typeof(TimeLine);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TimeLine(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TimeLine(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TimeLine(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TimeLine() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TimeLine(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
		public NetOffice.PowerPointApi.Sequence MainSequence
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MainSequence", paramsArray);
				NetOffice.PowerPointApi.Sequence newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Sequence.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Sequence;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
		public NetOffice.PowerPointApi.Sequences InteractiveSequences
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InteractiveSequences", paramsArray);
				NetOffice.PowerPointApi.Sequences newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Sequences.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Sequences;
				return newObject;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}