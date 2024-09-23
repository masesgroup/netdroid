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

namespace Android.Service.Credentials
{
    #region BeginCreateCredentialResponse declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/credentials/BeginCreateCredentialResponse.html"/>
    /// </summary>
    public partial class BeginCreateCredentialResponse : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.service.credentials.BeginCreateCredentialResponse";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BeginCreateCredentialResponse() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BeginCreateCredentialResponse(params object[] args) : base(args) { }
    
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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/BeginCreateCredentialResponse.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.service.credentials.BeginCreateCredentialResponse$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region BeginCreateCredentialResponse implementation
    public partial class BeginCreateCredentialResponse
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/BeginCreateCredentialResponse.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/BeginCreateCredentialResponse.html#getRemoteCreateEntry()"/>
        /// </summary>
        /// <returns><see cref="Android.Service.Credentials.RemoteEntry"/></returns>
        public Android.Service.Credentials.RemoteEntry GetRemoteCreateEntry()
        {
            return IExecuteWithSignature<Android.Service.Credentials.RemoteEntry>("getRemoteCreateEntry", "()Landroid/service/credentials/RemoteEntry;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/BeginCreateCredentialResponse.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/BeginCreateCredentialResponse.html#getCreateEntries()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Service.Credentials.CreateEntry> GetCreateEntries()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Service.Credentials.CreateEntry>>("getCreateEntries", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/credentials/BeginCreateCredentialResponse.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/credentials/BeginCreateCredentialResponse.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Credentials.BeginCreateCredentialResponse"/></returns>
            public Android.Service.Credentials.BeginCreateCredentialResponse Build()
            {
                return IExecuteWithSignature<Android.Service.Credentials.BeginCreateCredentialResponse>("build", "()Landroid/service/credentials/BeginCreateCredentialResponse;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/credentials/BeginCreateCredentialResponse.Builder.html#addCreateEntry(android.service.credentials.CreateEntry)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Credentials.CreateEntry"/></param>
            /// <returns><see cref="Android.Service.Credentials.BeginCreateCredentialResponse.Builder"/></returns>
            public Android.Service.Credentials.BeginCreateCredentialResponse.Builder AddCreateEntry(Android.Service.Credentials.CreateEntry arg0)
            {
                return IExecuteWithSignature<Android.Service.Credentials.BeginCreateCredentialResponse.Builder>("addCreateEntry", "(Landroid/service/credentials/CreateEntry;)Landroid/service/credentials/BeginCreateCredentialResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/credentials/BeginCreateCredentialResponse.Builder.html#setCreateEntries(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Service.Credentials.BeginCreateCredentialResponse.Builder"/></returns>
            public Android.Service.Credentials.BeginCreateCredentialResponse.Builder SetCreateEntries(Java.Util.List<Android.Service.Credentials.CreateEntry> arg0)
            {
                return IExecuteWithSignature<Android.Service.Credentials.BeginCreateCredentialResponse.Builder>("setCreateEntries", "(Ljava/util/List;)Landroid/service/credentials/BeginCreateCredentialResponse$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/credentials/BeginCreateCredentialResponse.Builder.html#setRemoteCreateEntry(android.service.credentials.RemoteEntry)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Credentials.RemoteEntry"/></param>
            /// <returns><see cref="Android.Service.Credentials.BeginCreateCredentialResponse.Builder"/></returns>
            public Android.Service.Credentials.BeginCreateCredentialResponse.Builder SetRemoteCreateEntry(Android.Service.Credentials.RemoteEntry arg0)
            {
                return IExecuteWithSignature<Android.Service.Credentials.BeginCreateCredentialResponse.Builder>("setRemoteCreateEntry", "(Landroid/service/credentials/RemoteEntry;)Landroid/service/credentials/BeginCreateCredentialResponse$Builder;", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}