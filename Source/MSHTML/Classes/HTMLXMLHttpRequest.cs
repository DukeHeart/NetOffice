using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.MSHTMLApi
{

	#region Delegates

	#pragma warning disable
	public delegate void HTMLXMLHttpRequest_ontimeoutEventHandler();
	public delegate void HTMLXMLHttpRequest_onreadystatechangeEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass HTMLXMLHttpRequest 
	/// SupportByVersion MSHTML, 4
	///</summary>
	[SupportByVersionAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class HTMLXMLHttpRequest : DispHTMLXMLHttpRequest,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		HTMLXMLHttpRequestEvents_SinkHelper _hTMLXMLHttpRequestEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(HTMLXMLHttpRequest);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public HTMLXMLHttpRequest(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLXMLHttpRequest(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLXMLHttpRequest(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of HTMLXMLHttpRequest 
        /// </summary>		
		public HTMLXMLHttpRequest():base("MSHTML.HTMLXMLHttpRequest")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of HTMLXMLHttpRequest
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public HTMLXMLHttpRequest(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods

		/// <summary>
        /// returns all running MSHTML.HTMLXMLHttpRequest objects from the running object table(ROT)
        /// </summary>
        /// <returns>an MSHTML.HTMLXMLHttpRequest array</returns>
		public static NetOffice.MSHTMLApi.HTMLXMLHttpRequest[] GetActiveInstances()
		{		
			NetRuntimeSystem.Collections.Generic.List<object> proxyList = NetOffice.RunningObjectTable.GetActiveProxiesFromROT("MSHTML","HTMLXMLHttpRequest");
			NetRuntimeSystem.Collections.Generic.List<NetOffice.MSHTMLApi.HTMLXMLHttpRequest> resultList = new NetRuntimeSystem.Collections.Generic.List<NetOffice.MSHTMLApi.HTMLXMLHttpRequest>();
			foreach(object proxy in proxyList)
				resultList.Add( new NetOffice.MSHTMLApi.HTMLXMLHttpRequest(null, proxy) );
			return resultList.ToArray();
		}

		/// <summary>
        /// returns a running MSHTML.HTMLXMLHttpRequest object from the running object table(ROT). the method takes the first element from the table
        /// </summary>
        /// <returns>an MSHTML.HTMLXMLHttpRequest object or null</returns>
		public static NetOffice.MSHTMLApi.HTMLXMLHttpRequest GetActiveInstance()
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("MSHTML","HTMLXMLHttpRequest", false);
			if(null != proxy)
				return new NetOffice.MSHTMLApi.HTMLXMLHttpRequest(null, proxy);
			else
				return null;
		}

		/// <summary>
        /// returns a running MSHTML.HTMLXMLHttpRequest object from the running object table(ROT).  the method takes the first element from the table
        /// </summary>
	    /// <param name="throwOnError">throw an exception if no object was found</param>
        /// <returns>an MSHTML.HTMLXMLHttpRequest object or null</returns>
		public static NetOffice.MSHTMLApi.HTMLXMLHttpRequest GetActiveInstance(bool throwOnError)
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("MSHTML","HTMLXMLHttpRequest", throwOnError);
			if(null != proxy)
				return new NetOffice.MSHTMLApi.HTMLXMLHttpRequest(null, proxy);
			else
				return null;
		}
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion MSHTML, 4
		/// </summary>
		private event HTMLXMLHttpRequest_ontimeoutEventHandler _ontimeoutEvent;

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public event HTMLXMLHttpRequest_ontimeoutEventHandler ontimeoutEvent
		{
			add
			{
				CreateEventBridge();
				_ontimeoutEvent += value;
			}
			remove
			{
				_ontimeoutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML, 4
		/// </summary>
		private event HTMLXMLHttpRequest_onreadystatechangeEventHandler _onreadystatechangeEvent;

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public event HTMLXMLHttpRequest_onreadystatechangeEventHandler onreadystatechangeEvent
		{
			add
			{
				CreateEventBridge();
				_onreadystatechangeEvent += value;
			}
			remove
			{
				_onreadystatechangeEvent -= value;
			}
		}

		#endregion
       
	    #region IEventBinding Member
        
		/// <summary>
        /// creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void CreateEventBridge()
        {
			if(false == NetOffice.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, HTMLXMLHttpRequestEvents_SinkHelper.Id);


			if(HTMLXMLHttpRequestEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_hTMLXMLHttpRequestEvents_SinkHelper = new HTMLXMLHttpRequestEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()       
        {
			if(null == _thisType)
				_thisType = this.GetType();
					
			foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
			{
				MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
				if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
					return false;
			}
				
			return false;
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates.Length;
            }
            else
                return 0;
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
		{
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                foreach (var item in delegates)
                {
                    try
                    {
                        item.Method.Invoke(item.Target, paramsArray);
                    }
                    catch (NetRuntimeSystem.Exception exception)
                    {
                        DebugConsole.WriteException(exception);
                    }
                }
                return delegates.Length;
            }
            else
                return 0;
		}

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
			if( null != _hTMLXMLHttpRequestEvents_SinkHelper)
			{
				_hTMLXMLHttpRequestEvents_SinkHelper.Dispose();
				_hTMLXMLHttpRequestEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}