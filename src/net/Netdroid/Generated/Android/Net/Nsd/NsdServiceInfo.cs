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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Net.Nsd
{
    #region NsdServiceInfo
    public partial class NsdServiceInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#getAttributes()"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.String, byte[]> Attributes
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, byte[]>>("getAttributes", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#getHostAddresses()"/> <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#setHostAddresses(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Java.Net.InetAddress> HostAddresses
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Net.InetAddress>>("getHostAddresses", "()Ljava/util/List;"); } set { IExecuteWithSignature("setHostAddresses", "(Ljava/util/List;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#getNetwork()"/> <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#setNetwork(android.net.Network)"/>
        /// </summary>
        public Android.Net.Network Network
        {
            get { return IExecuteWithSignature<Android.Net.Network>("getNetwork", "()Landroid/net/Network;"); } set { IExecuteWithSignature("setNetwork", "(Landroid/net/Network;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#getPort()"/> <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#setPort(int)"/>
        /// </summary>
        public int Port
        {
            get { return IExecuteWithSignature<int>("getPort", "()I"); } set { IExecuteWithSignature("setPort", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#getServiceName()"/> <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#setServiceName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ServiceName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getServiceName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setServiceName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#getServiceType()"/> <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#setServiceType(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ServiceType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getServiceType", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setServiceType", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#removeAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemoveAttribute(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeAttribute", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#setAttribute(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetAttribute(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("setAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#writeToParcel(android.os.Parcel,int)"/>
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