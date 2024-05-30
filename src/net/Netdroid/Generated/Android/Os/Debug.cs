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

namespace Android.Os
{
    #region Debug
    public partial class Debug
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#SHOW_CLASSLOADER"/>
        /// </summary>
        public static int SHOW_CLASSLOADER { get { if (!_SHOW_CLASSLOADERReady) { _SHOW_CLASSLOADERContent = SGetField<int>(LocalBridgeClazz, "SHOW_CLASSLOADER"); _SHOW_CLASSLOADERReady = true; } return _SHOW_CLASSLOADERContent; } }
        private static int _SHOW_CLASSLOADERContent = default;
        private static bool _SHOW_CLASSLOADERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#SHOW_FULL_DETAIL"/>
        /// </summary>
        public static int SHOW_FULL_DETAIL { get { if (!_SHOW_FULL_DETAILReady) { _SHOW_FULL_DETAILContent = SGetField<int>(LocalBridgeClazz, "SHOW_FULL_DETAIL"); _SHOW_FULL_DETAILReady = true; } return _SHOW_FULL_DETAILContent; } }
        private static int _SHOW_FULL_DETAILContent = default;
        private static bool _SHOW_FULL_DETAILReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#SHOW_INITIALIZED"/>
        /// </summary>
        public static int SHOW_INITIALIZED { get { if (!_SHOW_INITIALIZEDReady) { _SHOW_INITIALIZEDContent = SGetField<int>(LocalBridgeClazz, "SHOW_INITIALIZED"); _SHOW_INITIALIZEDReady = true; } return _SHOW_INITIALIZEDContent; } }
        private static int _SHOW_INITIALIZEDContent = default;
        private static bool _SHOW_INITIALIZEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#getBinderDeathObjectCount()"/> 
        /// </summary>
        public static int BinderDeathObjectCount
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getBinderDeathObjectCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#getBinderLocalObjectCount()"/> 
        /// </summary>
        public static int BinderLocalObjectCount
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getBinderLocalObjectCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#getBinderProxyObjectCount()"/> 
        /// </summary>
        public static int BinderProxyObjectCount
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getBinderProxyObjectCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#getBinderReceivedTransactions()"/> 
        /// </summary>
        public static int BinderReceivedTransactions
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getBinderReceivedTransactions", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#getBinderSentTransactions()"/> 
        /// </summary>
        public static int BinderSentTransactions
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getBinderSentTransactions", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#getLoadedClassCount()"/> 
        /// </summary>
        public static int LoadedClassCount
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getLoadedClassCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#getNativeHeapAllocatedSize()"/> 
        /// </summary>
        public static long NativeHeapAllocatedSize
        {
            get { return SExecuteWithSignature<long>(LocalBridgeClazz, "getNativeHeapAllocatedSize", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#getNativeHeapFreeSize()"/> 
        /// </summary>
        public static long NativeHeapFreeSize
        {
            get { return SExecuteWithSignature<long>(LocalBridgeClazz, "getNativeHeapFreeSize", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#getNativeHeapSize()"/> 
        /// </summary>
        public static long NativeHeapSize
        {
            get { return SExecuteWithSignature<long>(LocalBridgeClazz, "getNativeHeapSize", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#getPss()"/> 
        /// </summary>
        public static long Pss
        {
            get { return SExecuteWithSignature<long>(LocalBridgeClazz, "getPss", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#getRuntimeStats()"/> 
        /// </summary>
        public static Java.Util.Map<Java.Lang.String, Java.Lang.String> RuntimeStats
        {
            get { return SExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>(LocalBridgeClazz, "getRuntimeStats", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#dumpService(java.lang.String,java.io.FileDescriptor,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool DumpService(Java.Lang.String arg0, Java.Io.FileDescriptor arg1, Java.Lang.String[] arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "dumpService", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#isDebuggerConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsDebuggerConnected()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isDebuggerConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#waitingForDebugger()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool WaitingForDebugger()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "waitingForDebugger", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#getRuntimeStat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetRuntimeStat(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getRuntimeStat", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#threadCpuTimeNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long ThreadCpuTimeNanos()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "threadCpuTimeNanos", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#getMemoryInfo(android.os.Debug.MemoryInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Debug.MemoryInfo"/></param>
        public static void GetMemoryInfo(Android.Os.Debug.MemoryInfo arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "getMemoryInfo", "(Landroid/os/Debug$MemoryInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#attachJvmtiAgent(java.lang.String,java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void AttachJvmtiAgent(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.ClassLoader arg2)
        {
            SExecute(LocalBridgeClazz, "attachJvmtiAgent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#dumpHprofData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void DumpHprofData(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "dumpHprofData", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#printLoadedClasses(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public static void PrintLoadedClasses(int arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "printLoadedClasses", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#startMethodTracing()"/>
        /// </summary>
        public static void StartMethodTracing()
        {
            SExecuteWithSignature(LocalBridgeClazz, "startMethodTracing", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#startMethodTracing(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public static void StartMethodTracing(Java.Lang.String arg0, int arg1, int arg2)
        {
            SExecute(LocalBridgeClazz, "startMethodTracing", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#startMethodTracing(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public static void StartMethodTracing(Java.Lang.String arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "startMethodTracing", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#startMethodTracing(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void StartMethodTracing(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "startMethodTracing", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#startMethodTracingSampling(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public static void StartMethodTracingSampling(Java.Lang.String arg0, int arg1, int arg2)
        {
            SExecute(LocalBridgeClazz, "startMethodTracingSampling", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#startNativeTracing()"/>
        /// </summary>
        public static void StartNativeTracing()
        {
            SExecuteWithSignature(LocalBridgeClazz, "startNativeTracing", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#stopMethodTracing()"/>
        /// </summary>
        public static void StopMethodTracing()
        {
            SExecuteWithSignature(LocalBridgeClazz, "stopMethodTracing", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#stopNativeTracing()"/>
        /// </summary>
        public static void StopNativeTracing()
        {
            SExecuteWithSignature(LocalBridgeClazz, "stopNativeTracing", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Debug.html#waitForDebugger()"/>
        /// </summary>
        public static void WaitForDebugger()
        {
            SExecuteWithSignature(LocalBridgeClazz, "waitForDebugger", "()V");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region MemoryInfo
        public partial class MemoryInfo
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#dalvikPrivateDirty"/>
            /// </summary>
            public int dalvikPrivateDirty { get { return IGetField<int>("dalvikPrivateDirty"); } set { ISetField("dalvikPrivateDirty", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#dalvikPss"/>
            /// </summary>
            public int dalvikPss { get { return IGetField<int>("dalvikPss"); } set { ISetField("dalvikPss", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#dalvikSharedDirty"/>
            /// </summary>
            public int dalvikSharedDirty { get { return IGetField<int>("dalvikSharedDirty"); } set { ISetField("dalvikSharedDirty", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#nativePrivateDirty"/>
            /// </summary>
            public int nativePrivateDirty { get { return IGetField<int>("nativePrivateDirty"); } set { ISetField("nativePrivateDirty", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#nativePss"/>
            /// </summary>
            public int nativePss { get { return IGetField<int>("nativePss"); } set { ISetField("nativePss", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#nativeSharedDirty"/>
            /// </summary>
            public int nativeSharedDirty { get { return IGetField<int>("nativeSharedDirty"); } set { ISetField("nativeSharedDirty", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#otherPrivateDirty"/>
            /// </summary>
            public int otherPrivateDirty { get { return IGetField<int>("otherPrivateDirty"); } set { ISetField("otherPrivateDirty", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#otherPss"/>
            /// </summary>
            public int otherPss { get { return IGetField<int>("otherPss"); } set { ISetField("otherPss", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#otherSharedDirty"/>
            /// </summary>
            public int otherSharedDirty { get { return IGetField<int>("otherSharedDirty"); } set { ISetField("otherSharedDirty", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#getMemoryStats()"/> 
            /// </summary>
            public Java.Util.Map<Java.Lang.String, Java.Lang.String> MemoryStats
            {
                get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("getMemoryStats", "()Ljava/util/Map;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#getTotalPrivateClean()"/> 
            /// </summary>
            public int TotalPrivateClean
            {
                get { return IExecuteWithSignature<int>("getTotalPrivateClean", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#getTotalPrivateDirty()"/> 
            /// </summary>
            public int TotalPrivateDirty
            {
                get { return IExecuteWithSignature<int>("getTotalPrivateDirty", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#getTotalPss()"/> 
            /// </summary>
            public int TotalPss
            {
                get { return IExecuteWithSignature<int>("getTotalPss", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#getTotalSharedClean()"/> 
            /// </summary>
            public int TotalSharedClean
            {
                get { return IExecuteWithSignature<int>("getTotalSharedClean", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#getTotalSharedDirty()"/> 
            /// </summary>
            public int TotalSharedDirty
            {
                get { return IExecuteWithSignature<int>("getTotalSharedDirty", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#getTotalSwappablePss()"/> 
            /// </summary>
            public int TotalSwappablePss
            {
                get { return IExecuteWithSignature<int>("getTotalSwappablePss", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#getMemoryStat(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetMemoryStat(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Java.Lang.String>("getMemoryStat", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#readFromParcel(android.os.Parcel)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            public void ReadFromParcel(Android.Os.Parcel arg0)
            {
                IExecuteWithSignature("readFromParcel", "(Landroid/os/Parcel;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Debug.MemoryInfo.html#writeToParcel(android.os.Parcel,int)"/>
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}