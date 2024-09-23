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

namespace Android.Net
{
    #region StaticIpConfiguration declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.html"/>
    /// </summary>
    public partial class StaticIpConfiguration : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.net.StaticIpConfiguration";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StaticIpConfiguration() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StaticIpConfiguration(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.net.StaticIpConfiguration$Builder";
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

    #region StaticIpConfiguration implementation
    public partial class StaticIpConfiguration
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.html#getIpAddress()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.LinkAddress"/></returns>
        public Android.Net.LinkAddress GetIpAddress()
        {
            return IExecuteWithSignature<Android.Net.LinkAddress>("getIpAddress", "()Landroid/net/LinkAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.html#getDomains()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDomains()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDomains", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.html#getGateway()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        public Java.Net.InetAddress GetGateway()
        {
            return IExecuteWithSignature<Java.Net.InetAddress>("getGateway", "()Ljava/net/InetAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.html#getDnsServers()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Net.InetAddress> GetDnsServers()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Net.InetAddress>>("getDnsServers", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.StaticIpConfiguration"/></returns>
            public Android.Net.StaticIpConfiguration Build()
            {
                return IExecuteWithSignature<Android.Net.StaticIpConfiguration>("build", "()Landroid/net/StaticIpConfiguration;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.Builder.html#setDnsServers(java.lang.Iterable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
            /// <returns><see cref="Android.Net.StaticIpConfiguration.Builder"/></returns>
            public Android.Net.StaticIpConfiguration.Builder SetDnsServers(Java.Lang.Iterable<Java.Net.InetAddress> arg0)
            {
                return IExecuteWithSignature<Android.Net.StaticIpConfiguration.Builder>("setDnsServers", "(Ljava/lang/Iterable;)Landroid/net/StaticIpConfiguration$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.Builder.html#setDomains(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.StaticIpConfiguration.Builder"/></returns>
            public Android.Net.StaticIpConfiguration.Builder SetDomains(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.StaticIpConfiguration.Builder>("setDomains", "(Ljava/lang/String;)Landroid/net/StaticIpConfiguration$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.Builder.html#setGateway(java.net.InetAddress)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
            /// <returns><see cref="Android.Net.StaticIpConfiguration.Builder"/></returns>
            public Android.Net.StaticIpConfiguration.Builder SetGateway(Java.Net.InetAddress arg0)
            {
                return IExecuteWithSignature<Android.Net.StaticIpConfiguration.Builder>("setGateway", "(Ljava/net/InetAddress;)Landroid/net/StaticIpConfiguration$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/StaticIpConfiguration.Builder.html#setIpAddress(android.net.LinkAddress)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.LinkAddress"/></param>
            /// <returns><see cref="Android.Net.StaticIpConfiguration.Builder"/></returns>
            public Android.Net.StaticIpConfiguration.Builder SetIpAddress(Android.Net.LinkAddress arg0)
            {
                return IExecuteWithSignature<Android.Net.StaticIpConfiguration.Builder>("setIpAddress", "(Landroid/net/LinkAddress;)Landroid/net/StaticIpConfiguration$Builder;", arg0);
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