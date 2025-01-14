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

namespace Android.Bluetooth.Le
{
    #region ScanCallback declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanCallback.html"/>
    /// </summary>
    public partial class ScanCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ScanCallback>
    {
        const string _bridgeClassName = "android.bluetooth.le.ScanCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ScanCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ScanCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ScanCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ScanCallback(params object[] args) : base(args) { }
    
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

    #region ScanCallback implementation
    public partial class ScanCallback
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanCallback.html#SCAN_FAILED_ALREADY_STARTED"/>
        /// </summary>
        public static int SCAN_FAILED_ALREADY_STARTED { get { if (!_SCAN_FAILED_ALREADY_STARTEDReady) { _SCAN_FAILED_ALREADY_STARTEDContent = SGetField<int>(LocalBridgeClazz, "SCAN_FAILED_ALREADY_STARTED"); _SCAN_FAILED_ALREADY_STARTEDReady = true; } return _SCAN_FAILED_ALREADY_STARTEDContent; } }
        private static int _SCAN_FAILED_ALREADY_STARTEDContent = default;
        private static bool _SCAN_FAILED_ALREADY_STARTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanCallback.html#SCAN_FAILED_APPLICATION_REGISTRATION_FAILED"/>
        /// </summary>
        public static int SCAN_FAILED_APPLICATION_REGISTRATION_FAILED { get { if (!_SCAN_FAILED_APPLICATION_REGISTRATION_FAILEDReady) { _SCAN_FAILED_APPLICATION_REGISTRATION_FAILEDContent = SGetField<int>(LocalBridgeClazz, "SCAN_FAILED_APPLICATION_REGISTRATION_FAILED"); _SCAN_FAILED_APPLICATION_REGISTRATION_FAILEDReady = true; } return _SCAN_FAILED_APPLICATION_REGISTRATION_FAILEDContent; } }
        private static int _SCAN_FAILED_APPLICATION_REGISTRATION_FAILEDContent = default;
        private static bool _SCAN_FAILED_APPLICATION_REGISTRATION_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanCallback.html#SCAN_FAILED_FEATURE_UNSUPPORTED"/>
        /// </summary>
        public static int SCAN_FAILED_FEATURE_UNSUPPORTED { get { if (!_SCAN_FAILED_FEATURE_UNSUPPORTEDReady) { _SCAN_FAILED_FEATURE_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "SCAN_FAILED_FEATURE_UNSUPPORTED"); _SCAN_FAILED_FEATURE_UNSUPPORTEDReady = true; } return _SCAN_FAILED_FEATURE_UNSUPPORTEDContent; } }
        private static int _SCAN_FAILED_FEATURE_UNSUPPORTEDContent = default;
        private static bool _SCAN_FAILED_FEATURE_UNSUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanCallback.html#SCAN_FAILED_INTERNAL_ERROR"/>
        /// </summary>
        public static int SCAN_FAILED_INTERNAL_ERROR { get { if (!_SCAN_FAILED_INTERNAL_ERRORReady) { _SCAN_FAILED_INTERNAL_ERRORContent = SGetField<int>(LocalBridgeClazz, "SCAN_FAILED_INTERNAL_ERROR"); _SCAN_FAILED_INTERNAL_ERRORReady = true; } return _SCAN_FAILED_INTERNAL_ERRORContent; } }
        private static int _SCAN_FAILED_INTERNAL_ERRORContent = default;
        private static bool _SCAN_FAILED_INTERNAL_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanCallback.html#SCAN_FAILED_OUT_OF_HARDWARE_RESOURCES"/>
        /// </summary>
        public static int SCAN_FAILED_OUT_OF_HARDWARE_RESOURCES { get { if (!_SCAN_FAILED_OUT_OF_HARDWARE_RESOURCESReady) { _SCAN_FAILED_OUT_OF_HARDWARE_RESOURCESContent = SGetField<int>(LocalBridgeClazz, "SCAN_FAILED_OUT_OF_HARDWARE_RESOURCES"); _SCAN_FAILED_OUT_OF_HARDWARE_RESOURCESReady = true; } return _SCAN_FAILED_OUT_OF_HARDWARE_RESOURCESContent; } }
        private static int _SCAN_FAILED_OUT_OF_HARDWARE_RESOURCESContent = default;
        private static bool _SCAN_FAILED_OUT_OF_HARDWARE_RESOURCESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanCallback.html#SCAN_FAILED_SCANNING_TOO_FREQUENTLY"/>
        /// </summary>
        public static int SCAN_FAILED_SCANNING_TOO_FREQUENTLY { get { if (!_SCAN_FAILED_SCANNING_TOO_FREQUENTLYReady) { _SCAN_FAILED_SCANNING_TOO_FREQUENTLYContent = SGetField<int>(LocalBridgeClazz, "SCAN_FAILED_SCANNING_TOO_FREQUENTLY"); _SCAN_FAILED_SCANNING_TOO_FREQUENTLYReady = true; } return _SCAN_FAILED_SCANNING_TOO_FREQUENTLYContent; } }
        private static int _SCAN_FAILED_SCANNING_TOO_FREQUENTLYContent = default;
        private static bool _SCAN_FAILED_SCANNING_TOO_FREQUENTLYReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanCallback.html#onBatchScanResults(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void OnBatchScanResults(Java.Util.List<Android.Bluetooth.Le.ScanResult> arg0)
        {
            IExecuteWithSignature("onBatchScanResults", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanCallback.html#onScanFailed(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnScanFailed(int arg0)
        {
            IExecuteWithSignature("onScanFailed", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanCallback.html#onScanResult(int,android.bluetooth.le.ScanResult)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Bluetooth.Le.ScanResult"/></param>
        public void OnScanResult(int arg0, Android.Bluetooth.Le.ScanResult arg1)
        {
            IExecuteWithSignature("onScanResult", "(ILandroid/bluetooth/le/ScanResult;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}