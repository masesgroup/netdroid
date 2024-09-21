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

namespace Android.Drm
{
    #region DrmInfoRequest declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class DrmInfoRequest : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DrmInfoRequest>
    {
        const string _bridgeClassName = "android.drm.DrmInfoRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DrmInfoRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DrmInfoRequest(params object[] args) : base(args) { }

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

    #region DrmInfoRequest implementation
    public partial class DrmInfoRequest
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html#%3Cinit%3E(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public DrmInfoRequest(int arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html#TYPE_REGISTRATION_INFO"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_REGISTRATION_INFO { get { if (!_TYPE_REGISTRATION_INFOReady) { _TYPE_REGISTRATION_INFOContent = SGetField<int>(LocalBridgeClazz, "TYPE_REGISTRATION_INFO"); _TYPE_REGISTRATION_INFOReady = true; } return _TYPE_REGISTRATION_INFOContent; } }
        private static int _TYPE_REGISTRATION_INFOContent = default;
        private static bool _TYPE_REGISTRATION_INFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html#TYPE_RIGHTS_ACQUISITION_INFO"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_RIGHTS_ACQUISITION_INFO { get { if (!_TYPE_RIGHTS_ACQUISITION_INFOReady) { _TYPE_RIGHTS_ACQUISITION_INFOContent = SGetField<int>(LocalBridgeClazz, "TYPE_RIGHTS_ACQUISITION_INFO"); _TYPE_RIGHTS_ACQUISITION_INFOReady = true; } return _TYPE_RIGHTS_ACQUISITION_INFOContent; } }
        private static int _TYPE_RIGHTS_ACQUISITION_INFOContent = default;
        private static bool _TYPE_RIGHTS_ACQUISITION_INFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html#TYPE_RIGHTS_ACQUISITION_PROGRESS_INFO"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_RIGHTS_ACQUISITION_PROGRESS_INFO { get { if (!_TYPE_RIGHTS_ACQUISITION_PROGRESS_INFOReady) { _TYPE_RIGHTS_ACQUISITION_PROGRESS_INFOContent = SGetField<int>(LocalBridgeClazz, "TYPE_RIGHTS_ACQUISITION_PROGRESS_INFO"); _TYPE_RIGHTS_ACQUISITION_PROGRESS_INFOReady = true; } return _TYPE_RIGHTS_ACQUISITION_PROGRESS_INFOContent; } }
        private static int _TYPE_RIGHTS_ACQUISITION_PROGRESS_INFOContent = default;
        private static bool _TYPE_RIGHTS_ACQUISITION_PROGRESS_INFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html#TYPE_UNREGISTRATION_INFO"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_UNREGISTRATION_INFO { get { if (!_TYPE_UNREGISTRATION_INFOReady) { _TYPE_UNREGISTRATION_INFOContent = SGetField<int>(LocalBridgeClazz, "TYPE_UNREGISTRATION_INFO"); _TYPE_UNREGISTRATION_INFOReady = true; } return _TYPE_UNREGISTRATION_INFOContent; } }
        private static int _TYPE_UNREGISTRATION_INFOContent = default;
        private static bool _TYPE_UNREGISTRATION_INFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html#ACCOUNT_ID"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String ACCOUNT_ID { get { if (!_ACCOUNT_IDReady) { _ACCOUNT_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCOUNT_ID"); _ACCOUNT_IDReady = true; } return _ACCOUNT_IDContent; } }
        private static Java.Lang.String _ACCOUNT_IDContent = default;
        private static bool _ACCOUNT_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html#SUBSCRIPTION_ID"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String SUBSCRIPTION_ID { get { if (!_SUBSCRIPTION_IDReady) { _SUBSCRIPTION_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUBSCRIPTION_ID"); _SUBSCRIPTION_IDReady = true; } return _SUBSCRIPTION_IDContent; } }
        private static Java.Lang.String _SUBSCRIPTION_IDContent = default;
        private static bool _SUBSCRIPTION_IDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html#getInfoType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetInfoType()
        {
            return IExecuteWithSignature<int>("getInfoType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        [global::System.Obsolete()]
        public object Get(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("get", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html#getMimeType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetMimeType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMimeType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        [global::System.Obsolete()]
        public Java.Util.Iterator<object> Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<object>>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html#keyIterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        [global::System.Obsolete()]
        public Java.Util.Iterator<Java.Lang.String> KeyIterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<Java.Lang.String>>("keyIterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoRequest.html#put(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        [global::System.Obsolete()]
        public void Put(Java.Lang.String arg0, object arg1)
        {
            IExecute("put", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}