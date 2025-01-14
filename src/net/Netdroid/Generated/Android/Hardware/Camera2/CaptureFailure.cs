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

namespace Android.Hardware.Camera2
{
    #region CaptureFailure declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/camera2/CaptureFailure.html"/>
    /// </summary>
    public partial class CaptureFailure : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CaptureFailure>
    {
        const string _bridgeClassName = "android.hardware.camera2.CaptureFailure";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CaptureFailure() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CaptureFailure(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
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

    #region CaptureFailure implementation
    public partial class CaptureFailure
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CaptureFailure.html#REASON_ERROR"/>
        /// </summary>
        public static int REASON_ERROR { get { if (!_REASON_ERRORReady) { _REASON_ERRORContent = SGetField<int>(LocalBridgeClazz, "REASON_ERROR"); _REASON_ERRORReady = true; } return _REASON_ERRORContent; } }
        private static int _REASON_ERRORContent = default;
        private static bool _REASON_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CaptureFailure.html#REASON_FLUSHED"/>
        /// </summary>
        public static int REASON_FLUSHED { get { if (!_REASON_FLUSHEDReady) { _REASON_FLUSHEDContent = SGetField<int>(LocalBridgeClazz, "REASON_FLUSHED"); _REASON_FLUSHEDReady = true; } return _REASON_FLUSHEDContent; } }
        private static int _REASON_FLUSHEDContent = default;
        private static bool _REASON_FLUSHEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CaptureFailure.html#getRequest()"/>
        /// </summary>
        /// <returns><see cref="Android.Hardware.Camera2.CaptureRequest"/></returns>
        public Android.Hardware.Camera2.CaptureRequest GetRequest()
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.CaptureRequest>("getRequest", "()Landroid/hardware/camera2/CaptureRequest;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CaptureFailure.html#wasImageCaptured()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool WasImageCaptured()
        {
            return IExecuteWithSignature<bool>("wasImageCaptured", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CaptureFailure.html#getReason()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetReason()
        {
            return IExecuteWithSignature<int>("getReason", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CaptureFailure.html#getSequenceId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSequenceId()
        {
            return IExecuteWithSignature<int>("getSequenceId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CaptureFailure.html#getPhysicalCameraId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPhysicalCameraId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPhysicalCameraId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CaptureFailure.html#getFrameNumber()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetFrameNumber()
        {
            return IExecuteWithSignature<long>("getFrameNumber", "()J");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}