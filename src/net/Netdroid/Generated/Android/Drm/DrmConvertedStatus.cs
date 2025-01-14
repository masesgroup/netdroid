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

namespace Android.Drm
{
    #region DrmConvertedStatus declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/drm/DrmConvertedStatus.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class DrmConvertedStatus : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DrmConvertedStatus>
    {
        const string _bridgeClassName = "android.drm.DrmConvertedStatus";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DrmConvertedStatus() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DrmConvertedStatus(params object[] args) : base(args) { }
    
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

    #region DrmConvertedStatus implementation
    public partial class DrmConvertedStatus
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmConvertedStatus.html#%3Cinit%3E(int,byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public DrmConvertedStatus(int arg0, byte[] arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmConvertedStatus.html#convertedData"/>
        /// </summary>
        [global::System.Obsolete()]
        public byte[] convertedData { get { if (!_convertedDataReady) { _convertedDataContent = IGetFieldArray<byte>("convertedData"); _convertedDataReady = true; } return _convertedDataContent; } }
        private byte[] _convertedDataContent = default;
        private bool _convertedDataReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmConvertedStatus.html#offset"/>
        /// </summary>
        [global::System.Obsolete()]
        public int offset { get { if (!_offsetReady) { _offsetContent = IGetField<int>("offset"); _offsetReady = true; } return _offsetContent; } }
        private int _offsetContent = default;
        private bool _offsetReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmConvertedStatus.html#statusCode"/>
        /// </summary>
        [global::System.Obsolete()]
        public int statusCode { get { if (!_statusCodeReady) { _statusCodeContent = IGetField<int>("statusCode"); _statusCodeReady = true; } return _statusCodeContent; } }
        private int _statusCodeContent = default;
        private bool _statusCodeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmConvertedStatus.html#STATUS_ERROR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATUS_ERROR { get { if (!_STATUS_ERRORReady) { _STATUS_ERRORContent = SGetField<int>(LocalBridgeClazz, "STATUS_ERROR"); _STATUS_ERRORReady = true; } return _STATUS_ERRORContent; } }
        private static int _STATUS_ERRORContent = default;
        private static bool _STATUS_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmConvertedStatus.html#STATUS_INPUTDATA_ERROR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATUS_INPUTDATA_ERROR { get { if (!_STATUS_INPUTDATA_ERRORReady) { _STATUS_INPUTDATA_ERRORContent = SGetField<int>(LocalBridgeClazz, "STATUS_INPUTDATA_ERROR"); _STATUS_INPUTDATA_ERRORReady = true; } return _STATUS_INPUTDATA_ERRORContent; } }
        private static int _STATUS_INPUTDATA_ERRORContent = default;
        private static bool _STATUS_INPUTDATA_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmConvertedStatus.html#STATUS_OK"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STATUS_OK { get { if (!_STATUS_OKReady) { _STATUS_OKContent = SGetField<int>(LocalBridgeClazz, "STATUS_OK"); _STATUS_OKReady = true; } return _STATUS_OKContent; } }
        private static int _STATUS_OKContent = default;
        private static bool _STATUS_OKReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}