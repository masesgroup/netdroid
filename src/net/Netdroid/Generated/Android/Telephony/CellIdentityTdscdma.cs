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

namespace Android.Telephony
{
    #region CellIdentityTdscdma declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityTdscdma.html"/>
    /// </summary>
    public partial class CellIdentityTdscdma : Android.Telephony.CellIdentity
    {
        const string _bridgeClassName = "android.telephony.CellIdentityTdscdma";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CellIdentityTdscdma() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CellIdentityTdscdma(params object[] args) : base(args) { }
    
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

    #region CellIdentityTdscdma implementation
    public partial class CellIdentityTdscdma
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityTdscdma.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityTdscdma.html#getClosedSubscriberGroupInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Telephony.ClosedSubscriberGroupInfo"/></returns>
        public Android.Telephony.ClosedSubscriberGroupInfo GetClosedSubscriberGroupInfo()
        {
            return IExecuteWithSignature<Android.Telephony.ClosedSubscriberGroupInfo>("getClosedSubscriberGroupInfo", "()Landroid/telephony/ClosedSubscriberGroupInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityTdscdma.html#getCid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCid()
        {
            return IExecuteWithSignature<int>("getCid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityTdscdma.html#getCpid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCpid()
        {
            return IExecuteWithSignature<int>("getCpid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityTdscdma.html#getLac()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLac()
        {
            return IExecuteWithSignature<int>("getLac", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityTdscdma.html#getUarfcn()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetUarfcn()
        {
            return IExecuteWithSignature<int>("getUarfcn", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityTdscdma.html#getMccString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMccString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMccString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityTdscdma.html#getMncString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMncString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMncString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityTdscdma.html#getMobileNetworkOperator()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMobileNetworkOperator()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMobileNetworkOperator", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityTdscdma.html#getAdditionalPlmns()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetAdditionalPlmns()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getAdditionalPlmns", "()Ljava/util/Set;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}