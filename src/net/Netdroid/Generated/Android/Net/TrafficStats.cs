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

namespace Android.Net
{
    #region TrafficStats declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html"/>
    /// </summary>
    public partial class TrafficStats : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TrafficStats>
    {
        const string _bridgeClassName = "android.net.TrafficStats";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TrafficStats() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TrafficStats(params object[] args) : base(args) { }
    
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

    #region TrafficStats implementation
    public partial class TrafficStats
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#UNSUPPORTED"/>
        /// </summary>
        public static int UNSUPPORTED { get { if (!_UNSUPPORTEDReady) { _UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "UNSUPPORTED"); _UNSUPPORTEDReady = true; } return _UNSUPPORTEDContent; } }
        private static int _UNSUPPORTEDContent = default;
        private static bool _UNSUPPORTEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getAndSetThreadStatsTag(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetAndSetThreadStatsTag(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getAndSetThreadStatsTag", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getThreadStatsTag()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetThreadStatsTag()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getThreadStatsTag", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getThreadStatsUid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetThreadStatsUid()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getThreadStatsUid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getMobileRxBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetMobileRxBytes()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getMobileRxBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getMobileRxPackets()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetMobileRxPackets()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getMobileRxPackets", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getMobileTxBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetMobileTxBytes()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getMobileTxBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getMobileTxPackets()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetMobileTxPackets()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getMobileTxPackets", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getRxBytes(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="long"/></returns>
        public static long GetRxBytes(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getRxBytes", "(Ljava/lang/String;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getRxPackets(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="long"/></returns>
        public static long GetRxPackets(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getRxPackets", "(Ljava/lang/String;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getTotalRxBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetTotalRxBytes()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getTotalRxBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getTotalRxPackets()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetTotalRxPackets()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getTotalRxPackets", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getTotalTxBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetTotalTxBytes()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getTotalTxBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getTotalTxPackets()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetTotalTxPackets()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getTotalTxPackets", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getTxBytes(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="long"/></returns>
        public static long GetTxBytes(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getTxBytes", "(Ljava/lang/String;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getTxPackets(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="long"/></returns>
        public static long GetTxPackets(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getTxPackets", "(Ljava/lang/String;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getUidRxBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long GetUidRxBytes(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getUidRxBytes", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getUidRxPackets(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long GetUidRxPackets(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getUidRxPackets", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getUidTcpRxBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public static long GetUidTcpRxBytes(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getUidTcpRxBytes", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getUidTcpRxSegments(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public static long GetUidTcpRxSegments(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getUidTcpRxSegments", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getUidTcpTxBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public static long GetUidTcpTxBytes(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getUidTcpTxBytes", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getUidTcpTxSegments(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public static long GetUidTcpTxSegments(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getUidTcpTxSegments", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getUidTxBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long GetUidTxBytes(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getUidTxBytes", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getUidTxPackets(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long GetUidTxPackets(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getUidTxPackets", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getUidUdpRxBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public static long GetUidUdpRxBytes(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getUidUdpRxBytes", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getUidUdpRxPackets(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public static long GetUidUdpRxPackets(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getUidUdpRxPackets", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getUidUdpTxBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public static long GetUidUdpTxBytes(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getUidUdpTxBytes", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#getUidUdpTxPackets(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public static long GetUidUdpTxPackets(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getUidUdpTxPackets", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#clearThreadStatsTag()"/>
        /// </summary>
        public static void ClearThreadStatsTag()
        {
            SExecuteWithSignature(LocalBridgeClazz, "clearThreadStatsTag", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#clearThreadStatsUid()"/>
        /// </summary>
        public static void ClearThreadStatsUid()
        {
            SExecuteWithSignature(LocalBridgeClazz, "clearThreadStatsUid", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#incrementOperationCount(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public static void IncrementOperationCount(int arg0, int arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "incrementOperationCount", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#incrementOperationCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public static void IncrementOperationCount(int arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "incrementOperationCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#setThreadStatsTag(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public static void SetThreadStatsTag(int arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setThreadStatsTag", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#setThreadStatsUid(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public static void SetThreadStatsUid(int arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setThreadStatsUid", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#tagDatagramSocket(java.net.DatagramSocket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.DatagramSocket"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public static void TagDatagramSocket(Java.Net.DatagramSocket arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "tagDatagramSocket", "(Ljava/net/DatagramSocket;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#tagFileDescriptor(java.io.FileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void TagFileDescriptor(Java.Io.FileDescriptor arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "tagFileDescriptor", "(Ljava/io/FileDescriptor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#tagSocket(java.net.Socket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Socket"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public static void TagSocket(Java.Net.Socket arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "tagSocket", "(Ljava/net/Socket;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#untagDatagramSocket(java.net.DatagramSocket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.DatagramSocket"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public static void UntagDatagramSocket(Java.Net.DatagramSocket arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "untagDatagramSocket", "(Ljava/net/DatagramSocket;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#untagFileDescriptor(java.io.FileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void UntagFileDescriptor(Java.Io.FileDescriptor arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "untagFileDescriptor", "(Ljava/io/FileDescriptor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/TrafficStats.html#untagSocket(java.net.Socket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Socket"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public static void UntagSocket(Java.Net.Socket arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "untagSocket", "(Ljava/net/Socket;)V", arg0);
        }
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}