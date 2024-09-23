/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Media
{
    #region MediaRoute2ProviderService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html"/>
    /// </summary>
    public partial class MediaRoute2ProviderService : Android.App.Service
    {
        const string _bridgeClassName = "android.media.MediaRoute2ProviderService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("MediaRoute2ProviderService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MediaRoute2ProviderService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("MediaRoute2ProviderService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MediaRoute2ProviderService(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region MediaRoute2ProviderService implementation
    public partial class MediaRoute2ProviderService
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#REASON_INVALID_COMMAND"/>
        /// </summary>
        public static int REASON_INVALID_COMMAND { get { if (!_REASON_INVALID_COMMANDReady) { _REASON_INVALID_COMMANDContent = SGetField<int>(LocalBridgeClazz, "REASON_INVALID_COMMAND"); _REASON_INVALID_COMMANDReady = true; } return _REASON_INVALID_COMMANDContent; } }
        private static int _REASON_INVALID_COMMANDContent = default;
        private static bool _REASON_INVALID_COMMANDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#REASON_NETWORK_ERROR"/>
        /// </summary>
        public static int REASON_NETWORK_ERROR { get { if (!_REASON_NETWORK_ERRORReady) { _REASON_NETWORK_ERRORContent = SGetField<int>(LocalBridgeClazz, "REASON_NETWORK_ERROR"); _REASON_NETWORK_ERRORReady = true; } return _REASON_NETWORK_ERRORContent; } }
        private static int _REASON_NETWORK_ERRORContent = default;
        private static bool _REASON_NETWORK_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#REASON_REJECTED"/>
        /// </summary>
        public static int REASON_REJECTED { get { if (!_REASON_REJECTEDReady) { _REASON_REJECTEDContent = SGetField<int>(LocalBridgeClazz, "REASON_REJECTED"); _REASON_REJECTEDReady = true; } return _REASON_REJECTEDContent; } }
        private static int _REASON_REJECTEDContent = default;
        private static bool _REASON_REJECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#REASON_ROUTE_NOT_AVAILABLE"/>
        /// </summary>
        public static int REASON_ROUTE_NOT_AVAILABLE { get { if (!_REASON_ROUTE_NOT_AVAILABLEReady) { _REASON_ROUTE_NOT_AVAILABLEContent = SGetField<int>(LocalBridgeClazz, "REASON_ROUTE_NOT_AVAILABLE"); _REASON_ROUTE_NOT_AVAILABLEReady = true; } return _REASON_ROUTE_NOT_AVAILABLEContent; } }
        private static int _REASON_ROUTE_NOT_AVAILABLEContent = default;
        private static bool _REASON_ROUTE_NOT_AVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#REASON_UNKNOWN_ERROR"/>
        /// </summary>
        public static int REASON_UNKNOWN_ERROR { get { if (!_REASON_UNKNOWN_ERRORReady) { _REASON_UNKNOWN_ERRORContent = SGetField<int>(LocalBridgeClazz, "REASON_UNKNOWN_ERROR"); _REASON_UNKNOWN_ERRORReady = true; } return _REASON_UNKNOWN_ERRORContent; } }
        private static int _REASON_UNKNOWN_ERRORContent = default;
        private static bool _REASON_UNKNOWN_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#REQUEST_ID_NONE"/>
        /// </summary>
        public static long REQUEST_ID_NONE { get { if (!_REQUEST_ID_NONEReady) { _REQUEST_ID_NONEContent = SGetField<long>(LocalBridgeClazz, "REQUEST_ID_NONE"); _REQUEST_ID_NONEReady = true; } return _REQUEST_ID_NONEContent; } }
        private static long _REQUEST_ID_NONEContent = default;
        private static bool _REQUEST_ID_NONEReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#onCreateSession(long,java.lang.String,java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        public void OnCreateSession(long arg0, Java.Lang.String arg1, Java.Lang.String arg2, Android.Os.Bundle arg3)
        {
            IExecute("onCreateSession", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#onDeselectRoute(long,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public void OnDeselectRoute(long arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("onDeselectRoute", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#onReleaseSession(long,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void OnReleaseSession(long arg0, Java.Lang.String arg1)
        {
            IExecute("onReleaseSession", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#onSelectRoute(long,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public void OnSelectRoute(long arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("onSelectRoute", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#onSetRouteVolume(long,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnSetRouteVolume(long arg0, Java.Lang.String arg1, int arg2)
        {
            IExecute("onSetRouteVolume", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#onSetSessionVolume(long,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnSetSessionVolume(long arg0, Java.Lang.String arg1, int arg2)
        {
            IExecute("onSetSessionVolume", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#onTransferToRoute(long,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public void OnTransferToRoute(long arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("onTransferToRoute", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#getSessionInfo(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Media.RoutingSessionInfo"/></returns>
        public Android.Media.RoutingSessionInfo GetSessionInfo(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Media.RoutingSessionInfo>("getSessionInfo", "(Ljava/lang/String;)Landroid/media/RoutingSessionInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#getAllSessionInfo()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Media.RoutingSessionInfo> GetAllSessionInfo()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Media.RoutingSessionInfo>>("getAllSessionInfo", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#notifyRequestFailed(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void NotifyRequestFailed(long arg0, int arg1)
        {
            IExecute("notifyRequestFailed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#notifyRoutes(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void NotifyRoutes(Java.Util.Collection<Android.Media.MediaRoute2Info> arg0)
        {
            IExecuteWithSignature("notifyRoutes", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#notifySessionCreated(long,android.media.RoutingSessionInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Android.Media.RoutingSessionInfo"/></param>
        public void NotifySessionCreated(long arg0, Android.Media.RoutingSessionInfo arg1)
        {
            IExecute("notifySessionCreated", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#notifySessionReleased(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void NotifySessionReleased(Java.Lang.String arg0)
        {
            IExecuteWithSignature("notifySessionReleased", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#notifySessionUpdated(android.media.RoutingSessionInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.RoutingSessionInfo"/></param>
        public void NotifySessionUpdated(Android.Media.RoutingSessionInfo arg0)
        {
            IExecuteWithSignature("notifySessionUpdated", "(Landroid/media/RoutingSessionInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaRoute2ProviderService.html#onDiscoveryPreferenceChanged(android.media.RouteDiscoveryPreference)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.RouteDiscoveryPreference"/></param>
        public void OnDiscoveryPreferenceChanged(Android.Media.RouteDiscoveryPreference arg0)
        {
            IExecuteWithSignature("onDiscoveryPreferenceChanged", "(Landroid/media/RouteDiscoveryPreference;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}