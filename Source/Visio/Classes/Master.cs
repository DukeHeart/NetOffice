using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.VisioApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Master_MasterChangedEventHandler(NetOffice.VisioApi.IVMaster Master);
	public delegate void Master_BeforeMasterDeleteEventHandler(NetOffice.VisioApi.IVMaster Master);
	public delegate void Master_ShapeAddedEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Master_BeforeSelectionDeleteEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Master_ShapeChangedEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Master_SelectionAddedEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Master_BeforeShapeDeleteEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Master_TextChangedEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Master_CellChangedEventHandler(NetOffice.VisioApi.IVCell Cell);
	public delegate void Master_FormulaChangedEventHandler(NetOffice.VisioApi.IVCell Cell);
	public delegate void Master_ConnectionsAddedEventHandler(NetOffice.VisioApi.IVConnects Connects);
	public delegate void Master_ConnectionsDeletedEventHandler(NetOffice.VisioApi.IVConnects Connects);
	public delegate void Master_QueryCancelMasterDeleteEventHandler(NetOffice.VisioApi.IVMaster Master);
	public delegate void Master_MasterDeleteCanceledEventHandler(NetOffice.VisioApi.IVMaster Master);
	public delegate void Master_ShapeParentChangedEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Master_BeforeShapeTextEditEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Master_ShapeExitedTextEditEventHandler(NetOffice.VisioApi.IVShape Shape);
	public delegate void Master_QueryCancelSelectionDeleteEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Master_SelectionDeleteCanceledEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Master_QueryCancelUngroupEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Master_UngroupCanceledEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Master_QueryCancelConvertToGroupEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Master_ConvertToGroupCanceledEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Master_QueryCancelGroupEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Master_GroupCanceledEventHandler(NetOffice.VisioApi.IVSelection Selection);
	public delegate void Master_ShapeDataGraphicChangedEventHandler(NetOffice.VisioApi.IVShape Shape);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Master 
	/// SupportByVersion Visio, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Master : IVMaster,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		EMaster_SinkHelper _eMaster_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Master);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public Master(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Master(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Master(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Master 
        /// </summary>		
		public Master():base("Visio.Master")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Master
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public Master(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods

		/// <summary>
        /// returns all running Visio.Master objects from the running object table(ROT)
        /// </summary>
        /// <returns>an Visio.Master array</returns>
		public static NetOffice.VisioApi.Master[] GetActiveInstances()
		{		
			NetRuntimeSystem.Collections.Generic.List<object> proxyList = NetOffice.RunningObjectTable.GetActiveProxiesFromROT("Visio","Master");
			NetRuntimeSystem.Collections.Generic.List<NetOffice.VisioApi.Master> resultList = new NetRuntimeSystem.Collections.Generic.List<NetOffice.VisioApi.Master>();
			foreach(object proxy in proxyList)
				resultList.Add( new NetOffice.VisioApi.Master(null, proxy) );
			return resultList.ToArray();
		}

		/// <summary>
        /// returns a running Visio.Master object from the running object table(ROT). the method takes the first element from the table
        /// </summary>
        /// <returns>an Visio.Master object or null</returns>
		public static NetOffice.VisioApi.Master GetActiveInstance()
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Visio","Master", false);
			if(null != proxy)
				return new NetOffice.VisioApi.Master(null, proxy);
			else
				return null;
		}

		/// <summary>
        /// returns a running Visio.Master object from the running object table(ROT).  the method takes the first element from the table
        /// </summary>
	    /// <param name="throwOnError">throw an exception if no object was found</param>
        /// <returns>an Visio.Master object or null</returns>
		public static NetOffice.VisioApi.Master GetActiveInstance(bool throwOnError)
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Visio","Master", throwOnError);
			if(null != proxy)
				return new NetOffice.VisioApi.Master(null, proxy);
			else
				return null;
		}
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_MasterChangedEventHandler _MasterChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_MasterChangedEventHandler MasterChangedEvent
		{
			add
			{
				CreateEventBridge();
				_MasterChangedEvent += value;
			}
			remove
			{
				_MasterChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_BeforeMasterDeleteEventHandler _BeforeMasterDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_BeforeMasterDeleteEventHandler BeforeMasterDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeMasterDeleteEvent += value;
			}
			remove
			{
				_BeforeMasterDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_ShapeAddedEventHandler _ShapeAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_ShapeAddedEventHandler ShapeAddedEvent
		{
			add
			{
				CreateEventBridge();
				_ShapeAddedEvent += value;
			}
			remove
			{
				_ShapeAddedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_BeforeSelectionDeleteEventHandler _BeforeSelectionDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_BeforeSelectionDeleteEventHandler BeforeSelectionDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeSelectionDeleteEvent += value;
			}
			remove
			{
				_BeforeSelectionDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_ShapeChangedEventHandler _ShapeChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_ShapeChangedEventHandler ShapeChangedEvent
		{
			add
			{
				CreateEventBridge();
				_ShapeChangedEvent += value;
			}
			remove
			{
				_ShapeChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_SelectionAddedEventHandler _SelectionAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_SelectionAddedEventHandler SelectionAddedEvent
		{
			add
			{
				CreateEventBridge();
				_SelectionAddedEvent += value;
			}
			remove
			{
				_SelectionAddedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_BeforeShapeDeleteEventHandler _BeforeShapeDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_BeforeShapeDeleteEventHandler BeforeShapeDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeShapeDeleteEvent += value;
			}
			remove
			{
				_BeforeShapeDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_TextChangedEventHandler _TextChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_TextChangedEventHandler TextChangedEvent
		{
			add
			{
				CreateEventBridge();
				_TextChangedEvent += value;
			}
			remove
			{
				_TextChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_CellChangedEventHandler _CellChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_CellChangedEventHandler CellChangedEvent
		{
			add
			{
				CreateEventBridge();
				_CellChangedEvent += value;
			}
			remove
			{
				_CellChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_FormulaChangedEventHandler _FormulaChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_FormulaChangedEventHandler FormulaChangedEvent
		{
			add
			{
				CreateEventBridge();
				_FormulaChangedEvent += value;
			}
			remove
			{
				_FormulaChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_ConnectionsAddedEventHandler _ConnectionsAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_ConnectionsAddedEventHandler ConnectionsAddedEvent
		{
			add
			{
				CreateEventBridge();
				_ConnectionsAddedEvent += value;
			}
			remove
			{
				_ConnectionsAddedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_ConnectionsDeletedEventHandler _ConnectionsDeletedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_ConnectionsDeletedEventHandler ConnectionsDeletedEvent
		{
			add
			{
				CreateEventBridge();
				_ConnectionsDeletedEvent += value;
			}
			remove
			{
				_ConnectionsDeletedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_QueryCancelMasterDeleteEventHandler _QueryCancelMasterDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_QueryCancelMasterDeleteEventHandler QueryCancelMasterDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_QueryCancelMasterDeleteEvent += value;
			}
			remove
			{
				_QueryCancelMasterDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_MasterDeleteCanceledEventHandler _MasterDeleteCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_MasterDeleteCanceledEventHandler MasterDeleteCanceledEvent
		{
			add
			{
				CreateEventBridge();
				_MasterDeleteCanceledEvent += value;
			}
			remove
			{
				_MasterDeleteCanceledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_ShapeParentChangedEventHandler _ShapeParentChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_ShapeParentChangedEventHandler ShapeParentChangedEvent
		{
			add
			{
				CreateEventBridge();
				_ShapeParentChangedEvent += value;
			}
			remove
			{
				_ShapeParentChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_BeforeShapeTextEditEventHandler _BeforeShapeTextEditEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_BeforeShapeTextEditEventHandler BeforeShapeTextEditEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeShapeTextEditEvent += value;
			}
			remove
			{
				_BeforeShapeTextEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_ShapeExitedTextEditEventHandler _ShapeExitedTextEditEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_ShapeExitedTextEditEventHandler ShapeExitedTextEditEvent
		{
			add
			{
				CreateEventBridge();
				_ShapeExitedTextEditEvent += value;
			}
			remove
			{
				_ShapeExitedTextEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_QueryCancelSelectionDeleteEventHandler _QueryCancelSelectionDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_QueryCancelSelectionDeleteEventHandler QueryCancelSelectionDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_QueryCancelSelectionDeleteEvent += value;
			}
			remove
			{
				_QueryCancelSelectionDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_SelectionDeleteCanceledEventHandler _SelectionDeleteCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_SelectionDeleteCanceledEventHandler SelectionDeleteCanceledEvent
		{
			add
			{
				CreateEventBridge();
				_SelectionDeleteCanceledEvent += value;
			}
			remove
			{
				_SelectionDeleteCanceledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_QueryCancelUngroupEventHandler _QueryCancelUngroupEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_QueryCancelUngroupEventHandler QueryCancelUngroupEvent
		{
			add
			{
				CreateEventBridge();
				_QueryCancelUngroupEvent += value;
			}
			remove
			{
				_QueryCancelUngroupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_UngroupCanceledEventHandler _UngroupCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_UngroupCanceledEventHandler UngroupCanceledEvent
		{
			add
			{
				CreateEventBridge();
				_UngroupCanceledEvent += value;
			}
			remove
			{
				_UngroupCanceledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_QueryCancelConvertToGroupEventHandler _QueryCancelConvertToGroupEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_QueryCancelConvertToGroupEventHandler QueryCancelConvertToGroupEvent
		{
			add
			{
				CreateEventBridge();
				_QueryCancelConvertToGroupEvent += value;
			}
			remove
			{
				_QueryCancelConvertToGroupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15
		/// </summary>
		private event Master_ConvertToGroupCanceledEventHandler _ConvertToGroupCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 11,12,14,15)]
		public event Master_ConvertToGroupCanceledEventHandler ConvertToGroupCanceledEvent
		{
			add
			{
				CreateEventBridge();
				_ConvertToGroupCanceledEvent += value;
			}
			remove
			{
				_ConvertToGroupCanceledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 12,14,15
		/// </summary>
		private event Master_QueryCancelGroupEventHandler _QueryCancelGroupEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 12,14,15)]
		public event Master_QueryCancelGroupEventHandler QueryCancelGroupEvent
		{
			add
			{
				CreateEventBridge();
				_QueryCancelGroupEvent += value;
			}
			remove
			{
				_QueryCancelGroupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 12,14,15
		/// </summary>
		private event Master_GroupCanceledEventHandler _GroupCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 12,14,15)]
		public event Master_GroupCanceledEventHandler GroupCanceledEvent
		{
			add
			{
				CreateEventBridge();
				_GroupCanceledEvent += value;
			}
			remove
			{
				_GroupCanceledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 12,14,15
		/// </summary>
		private event Master_ShapeDataGraphicChangedEventHandler _ShapeDataGraphicChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14 15
		/// </summary>
		[SupportByVersion("Visio", 12,14,15)]
		public event Master_ShapeDataGraphicChangedEventHandler ShapeDataGraphicChangedEvent
		{
			add
			{
				CreateEventBridge();
				_ShapeDataGraphicChangedEvent += value;
			}
			remove
			{
				_ShapeDataGraphicChangedEvent -= value;
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, EMaster_SinkHelper.Id);


			if(EMaster_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_eMaster_SinkHelper = new EMaster_SinkHelper(this, _connectPoint);
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
			if( null != _eMaster_SinkHelper)
			{
				_eMaster_SinkHelper.Dispose();
				_eMaster_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}