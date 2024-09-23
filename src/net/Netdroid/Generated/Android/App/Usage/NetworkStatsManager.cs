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

namespace Android.App.Usage
{
    #region NetworkStatsManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html"/>
    /// </summary>
    public partial class NetworkStatsManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<NetworkStatsManager>
    {
        const string _bridgeClassName = "android.app.usage.NetworkStatsManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NetworkStatsManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public NetworkStatsManager(params object[] args) : base(args) { }
    
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
        #region UsageCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.UsageCallback.html"/>
        /// </summary>
        public partial class UsageCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<UsageCallback>
        {
            const string _bridgeClassName = "android.app.usage.NetworkStatsManager$UsageCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("UsageCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public UsageCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("UsageCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public UsageCallback(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
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

    #region NetworkStatsManager implementation
    public partial class NetworkStatsManager
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
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#queryDetails(int,java.lang.String,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats QueryDetails(int arg0, Java.Lang.String arg1, long arg2, long arg3)
        {
            return IExecute<Android.App.Usage.NetworkStats>("queryDetails", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#queryDetailsForUid(int,java.lang.String,long,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats"/></returns>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats QueryDetailsForUid(int arg0, Java.Lang.String arg1, long arg2, long arg3, int arg4)
        {
            return IExecute<Android.App.Usage.NetworkStats>("queryDetailsForUid", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#queryDetailsForUidTag(int,java.lang.String,long,long,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats"/></returns>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats QueryDetailsForUidTag(int arg0, Java.Lang.String arg1, long arg2, long arg3, int arg4, int arg5)
        {
            return IExecute<Android.App.Usage.NetworkStats>("queryDetailsForUidTag", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#queryDetailsForUidTagState(int,java.lang.String,long,long,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats"/></returns>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats QueryDetailsForUidTagState(int arg0, Java.Lang.String arg1, long arg2, long arg3, int arg4, int arg5, int arg6)
        {
            return IExecute<Android.App.Usage.NetworkStats>("queryDetailsForUidTagState", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#querySummary(int,java.lang.String,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats QuerySummary(int arg0, Java.Lang.String arg1, long arg2, long arg3)
        {
            return IExecute<Android.App.Usage.NetworkStats>("querySummary", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#querySummaryForDevice(int,java.lang.String,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats.Bucket"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats.Bucket QuerySummaryForDevice(int arg0, Java.Lang.String arg1, long arg2, long arg3)
        {
            return IExecute<Android.App.Usage.NetworkStats.Bucket>("querySummaryForDevice", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#querySummaryForUser(int,java.lang.String,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="Android.App.Usage.NetworkStats.Bucket"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public Android.App.Usage.NetworkStats.Bucket QuerySummaryForUser(int arg0, Java.Lang.String arg1, long arg2, long arg3)
        {
            return IExecute<Android.App.Usage.NetworkStats.Bucket>("querySummaryForUser", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#registerUsageCallback(int,java.lang.String,long,android.app.usage.NetworkStatsManager.UsageCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Android.App.Usage.NetworkStatsManager.UsageCallback"/></param>
        /// <param name="arg4"><see cref="Android.Os.Handler"/></param>
        public void RegisterUsageCallback(int arg0, Java.Lang.String arg1, long arg2, Android.App.Usage.NetworkStatsManager.UsageCallback arg3, Android.Os.Handler arg4)
        {
            IExecute("registerUsageCallback", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#registerUsageCallback(int,java.lang.String,long,android.app.usage.NetworkStatsManager.UsageCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Android.App.Usage.NetworkStatsManager.UsageCallback"/></param>
        public void RegisterUsageCallback(int arg0, Java.Lang.String arg1, long arg2, Android.App.Usage.NetworkStatsManager.UsageCallback arg3)
        {
            IExecute("registerUsageCallback", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.html#unregisterUsageCallback(android.app.usage.NetworkStatsManager.UsageCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Usage.NetworkStatsManager.UsageCallback"/></param>
        public void UnregisterUsageCallback(Android.App.Usage.NetworkStatsManager.UsageCallback arg0)
        {
            IExecuteWithSignature("unregisterUsageCallback", "(Landroid/app/usage/NetworkStatsManager$UsageCallback;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region UsageCallback implementation
        public partial class UsageCallback
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
            /// <see href="https://developer.android.com/reference/android/app/usage/NetworkStatsManager.UsageCallback.html#onThresholdReached(int,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public void OnThresholdReached(int arg0, Java.Lang.String arg1)
            {
                IExecute("onThresholdReached", arg0, arg1);
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