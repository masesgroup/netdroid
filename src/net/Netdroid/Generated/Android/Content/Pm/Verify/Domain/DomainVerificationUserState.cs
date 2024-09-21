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

namespace Android.Content.Pm.Verify.Domain
{
    #region DomainVerificationUserState declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/pm/verify/domain/DomainVerificationUserState.html"/>
    /// </summary>
    public partial class DomainVerificationUserState : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.content.pm.verify.domain.DomainVerificationUserState";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DomainVerificationUserState() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DomainVerificationUserState(params object[] args) : base(args) { }

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

    #region DomainVerificationUserState implementation
    public partial class DomainVerificationUserState
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/verify/domain/DomainVerificationUserState.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/verify/domain/DomainVerificationUserState.html#DOMAIN_STATE_NONE"/>
        /// </summary>
        public static int DOMAIN_STATE_NONE { get { if (!_DOMAIN_STATE_NONEReady) { _DOMAIN_STATE_NONEContent = SGetField<int>(LocalBridgeClazz, "DOMAIN_STATE_NONE"); _DOMAIN_STATE_NONEReady = true; } return _DOMAIN_STATE_NONEContent; } }
        private static int _DOMAIN_STATE_NONEContent = default;
        private static bool _DOMAIN_STATE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/verify/domain/DomainVerificationUserState.html#DOMAIN_STATE_SELECTED"/>
        /// </summary>
        public static int DOMAIN_STATE_SELECTED { get { if (!_DOMAIN_STATE_SELECTEDReady) { _DOMAIN_STATE_SELECTEDContent = SGetField<int>(LocalBridgeClazz, "DOMAIN_STATE_SELECTED"); _DOMAIN_STATE_SELECTEDReady = true; } return _DOMAIN_STATE_SELECTEDContent; } }
        private static int _DOMAIN_STATE_SELECTEDContent = default;
        private static bool _DOMAIN_STATE_SELECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/verify/domain/DomainVerificationUserState.html#DOMAIN_STATE_VERIFIED"/>
        /// </summary>
        public static int DOMAIN_STATE_VERIFIED { get { if (!_DOMAIN_STATE_VERIFIEDReady) { _DOMAIN_STATE_VERIFIEDContent = SGetField<int>(LocalBridgeClazz, "DOMAIN_STATE_VERIFIED"); _DOMAIN_STATE_VERIFIEDReady = true; } return _DOMAIN_STATE_VERIFIEDContent; } }
        private static int _DOMAIN_STATE_VERIFIEDContent = default;
        private static bool _DOMAIN_STATE_VERIFIEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/verify/domain/DomainVerificationUserState.html#getUser()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.UserHandle"/></returns>
        public Android.Os.UserHandle GetUser()
        {
            return IExecuteWithSignature<Android.Os.UserHandle>("getUser", "()Landroid/os/UserHandle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/verify/domain/DomainVerificationUserState.html#isLinkHandlingAllowed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLinkHandlingAllowed()
        {
            return IExecuteWithSignature<bool>("isLinkHandlingAllowed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/verify/domain/DomainVerificationUserState.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/verify/domain/DomainVerificationUserState.html#getPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/verify/domain/DomainVerificationUserState.html#getHostToStateMap()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.Integer> GetHostToStateMap()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.Integer>>("getHostToStateMap", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/verify/domain/DomainVerificationUserState.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}