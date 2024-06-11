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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
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
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#getNetwork()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Network"/></returns>
        public Android.Net.Network GetNetwork()
        {
            return IExecuteWithSignature<Android.Net.Network>("getNetwork", "()Landroid/net/Network;");
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
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#getPort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPort()
        {
            return IExecuteWithSignature<int>("getPort", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#getServiceName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetServiceName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getServiceName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#getServiceType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetServiceType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getServiceType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#getHost()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        [global::System.Obsolete()]
        public Java.Net.InetAddress GetHost()
        {
            return IExecuteWithSignature<Java.Net.InetAddress>("getHost", "()Ljava/net/InetAddress;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#getHostAddresses()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Net.InetAddress> GetHostAddresses()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Net.InetAddress>>("getHostAddresses", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#getAttributes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, byte[]> GetAttributes()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, byte[]>>("getAttributes", "()Ljava/util/Map;");
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
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#setHost(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        [global::System.Obsolete()]
        public void SetHost(Java.Net.InetAddress arg0)
        {
            IExecuteWithSignature("setHost", "(Ljava/net/InetAddress;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#setHostAddresses(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void SetHostAddresses(Java.Util.List<Java.Net.InetAddress> arg0)
        {
            IExecuteWithSignature("setHostAddresses", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#setNetwork(android.net.Network)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Network"/></param>
        public void SetNetwork(Android.Net.Network arg0)
        {
            IExecuteWithSignature("setNetwork", "(Landroid/net/Network;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#setPort(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetPort(int arg0)
        {
            IExecuteWithSignature("setPort", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#setServiceName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetServiceName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setServiceName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/nsd/NsdServiceInfo.html#setServiceType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetServiceType(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setServiceType", "(Ljava/lang/String;)V", arg0);
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