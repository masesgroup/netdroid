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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Nfc.Cardemulation
{
    #region HostApduService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/HostApduService.html"/>
    /// </summary>
    public partial class HostApduService : Android.App.Service
    {
        const string _bridgeClassName = "android.nfc.cardemulation.HostApduService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("HostApduService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HostApduService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("HostApduService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HostApduService(params object[] args) : base(args) { }
    
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

    #region HostApduService implementation
    public partial class HostApduService
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/HostApduService.html#DEACTIVATION_DESELECTED"/>
        /// </summary>
        public static int DEACTIVATION_DESELECTED { get { if (!_DEACTIVATION_DESELECTEDReady) { _DEACTIVATION_DESELECTEDContent = SGetField<int>(LocalBridgeClazz, "DEACTIVATION_DESELECTED"); _DEACTIVATION_DESELECTEDReady = true; } return _DEACTIVATION_DESELECTEDContent; } }
        private static int _DEACTIVATION_DESELECTEDContent = default;
        private static bool _DEACTIVATION_DESELECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/HostApduService.html#DEACTIVATION_LINK_LOSS"/>
        /// </summary>
        public static int DEACTIVATION_LINK_LOSS { get { if (!_DEACTIVATION_LINK_LOSSReady) { _DEACTIVATION_LINK_LOSSContent = SGetField<int>(LocalBridgeClazz, "DEACTIVATION_LINK_LOSS"); _DEACTIVATION_LINK_LOSSReady = true; } return _DEACTIVATION_LINK_LOSSContent; } }
        private static int _DEACTIVATION_LINK_LOSSContent = default;
        private static bool _DEACTIVATION_LINK_LOSSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/HostApduService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/HostApduService.html#SERVICE_META_DATA"/>
        /// </summary>
        public static Java.Lang.String SERVICE_META_DATA { get { if (!_SERVICE_META_DATAReady) { _SERVICE_META_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_META_DATA"); _SERVICE_META_DATAReady = true; } return _SERVICE_META_DATAContent; } }
        private static Java.Lang.String _SERVICE_META_DATAContent = default;
        private static bool _SERVICE_META_DATAReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/HostApduService.html#processCommandApdu(byte[],android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] ProcessCommandApdu(byte[] arg0, Android.Os.Bundle arg1)
        {
            return IExecuteWithSignatureArray<byte>("processCommandApdu", "([BLandroid/os/Bundle;)[B", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/HostApduService.html#onDeactivated(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnDeactivated(int arg0)
        {
            IExecuteWithSignature("onDeactivated", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/HostApduService.html#notifyUnhandled()"/>
        /// </summary>
        public void NotifyUnhandled()
        {
            IExecuteWithSignature("notifyUnhandled", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/HostApduService.html#sendResponseApdu(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void SendResponseApdu(byte[] arg0)
        {
            IExecuteWithSignature("sendResponseApdu", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/HostApduService.html#processPollingFrames(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void ProcessPollingFrames(Java.Util.List<Android.Nfc.Cardemulation.PollingFrame> arg0)
        {
            IExecuteWithSignature("processPollingFrames", "(Ljava/util/List;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}