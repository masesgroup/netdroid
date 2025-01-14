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

namespace Android.Os
{
    #region Process declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/Process.html"/>
    /// </summary>
    public partial class Process : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Process>
    {
        const string _bridgeClassName = "android.os.Process";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Process() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Process(params object[] args) : base(args) { }
    
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

    #region Process implementation
    public partial class Process
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#BLUETOOTH_UID"/>
        /// </summary>
        public static int BLUETOOTH_UID { get { if (!_BLUETOOTH_UIDReady) { _BLUETOOTH_UIDContent = SGetField<int>(LocalBridgeClazz, "BLUETOOTH_UID"); _BLUETOOTH_UIDReady = true; } return _BLUETOOTH_UIDContent; } }
        private static int _BLUETOOTH_UIDContent = default;
        private static bool _BLUETOOTH_UIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#FIRST_APPLICATION_UID"/>
        /// </summary>
        public static int FIRST_APPLICATION_UID { get { if (!_FIRST_APPLICATION_UIDReady) { _FIRST_APPLICATION_UIDContent = SGetField<int>(LocalBridgeClazz, "FIRST_APPLICATION_UID"); _FIRST_APPLICATION_UIDReady = true; } return _FIRST_APPLICATION_UIDContent; } }
        private static int _FIRST_APPLICATION_UIDContent = default;
        private static bool _FIRST_APPLICATION_UIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#INVALID_PID"/>
        /// </summary>
        public static int INVALID_PID { get { if (!_INVALID_PIDReady) { _INVALID_PIDContent = SGetField<int>(LocalBridgeClazz, "INVALID_PID"); _INVALID_PIDReady = true; } return _INVALID_PIDContent; } }
        private static int _INVALID_PIDContent = default;
        private static bool _INVALID_PIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#INVALID_UID"/>
        /// </summary>
        public static int INVALID_UID { get { if (!_INVALID_UIDReady) { _INVALID_UIDContent = SGetField<int>(LocalBridgeClazz, "INVALID_UID"); _INVALID_UIDReady = true; } return _INVALID_UIDContent; } }
        private static int _INVALID_UIDContent = default;
        private static bool _INVALID_UIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#LAST_APPLICATION_UID"/>
        /// </summary>
        public static int LAST_APPLICATION_UID { get { if (!_LAST_APPLICATION_UIDReady) { _LAST_APPLICATION_UIDContent = SGetField<int>(LocalBridgeClazz, "LAST_APPLICATION_UID"); _LAST_APPLICATION_UIDReady = true; } return _LAST_APPLICATION_UIDContent; } }
        private static int _LAST_APPLICATION_UIDContent = default;
        private static bool _LAST_APPLICATION_UIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#PHONE_UID"/>
        /// </summary>
        public static int PHONE_UID { get { if (!_PHONE_UIDReady) { _PHONE_UIDContent = SGetField<int>(LocalBridgeClazz, "PHONE_UID"); _PHONE_UIDReady = true; } return _PHONE_UIDContent; } }
        private static int _PHONE_UIDContent = default;
        private static bool _PHONE_UIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#ROOT_UID"/>
        /// </summary>
        public static int ROOT_UID { get { if (!_ROOT_UIDReady) { _ROOT_UIDContent = SGetField<int>(LocalBridgeClazz, "ROOT_UID"); _ROOT_UIDReady = true; } return _ROOT_UIDContent; } }
        private static int _ROOT_UIDContent = default;
        private static bool _ROOT_UIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#SHELL_UID"/>
        /// </summary>
        public static int SHELL_UID { get { if (!_SHELL_UIDReady) { _SHELL_UIDContent = SGetField<int>(LocalBridgeClazz, "SHELL_UID"); _SHELL_UIDReady = true; } return _SHELL_UIDContent; } }
        private static int _SHELL_UIDContent = default;
        private static bool _SHELL_UIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#SIGNAL_KILL"/>
        /// </summary>
        public static int SIGNAL_KILL { get { if (!_SIGNAL_KILLReady) { _SIGNAL_KILLContent = SGetField<int>(LocalBridgeClazz, "SIGNAL_KILL"); _SIGNAL_KILLReady = true; } return _SIGNAL_KILLContent; } }
        private static int _SIGNAL_KILLContent = default;
        private static bool _SIGNAL_KILLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#SIGNAL_QUIT"/>
        /// </summary>
        public static int SIGNAL_QUIT { get { if (!_SIGNAL_QUITReady) { _SIGNAL_QUITContent = SGetField<int>(LocalBridgeClazz, "SIGNAL_QUIT"); _SIGNAL_QUITReady = true; } return _SIGNAL_QUITContent; } }
        private static int _SIGNAL_QUITContent = default;
        private static bool _SIGNAL_QUITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#SIGNAL_USR1"/>
        /// </summary>
        public static int SIGNAL_USR1 { get { if (!_SIGNAL_USR1Ready) { _SIGNAL_USR1Content = SGetField<int>(LocalBridgeClazz, "SIGNAL_USR1"); _SIGNAL_USR1Ready = true; } return _SIGNAL_USR1Content; } }
        private static int _SIGNAL_USR1Content = default;
        private static bool _SIGNAL_USR1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#SYSTEM_UID"/>
        /// </summary>
        public static int SYSTEM_UID { get { if (!_SYSTEM_UIDReady) { _SYSTEM_UIDContent = SGetField<int>(LocalBridgeClazz, "SYSTEM_UID"); _SYSTEM_UIDReady = true; } return _SYSTEM_UIDContent; } }
        private static int _SYSTEM_UIDContent = default;
        private static bool _SYSTEM_UIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#THREAD_PRIORITY_AUDIO"/>
        /// </summary>
        public static int THREAD_PRIORITY_AUDIO { get { if (!_THREAD_PRIORITY_AUDIOReady) { _THREAD_PRIORITY_AUDIOContent = SGetField<int>(LocalBridgeClazz, "THREAD_PRIORITY_AUDIO"); _THREAD_PRIORITY_AUDIOReady = true; } return _THREAD_PRIORITY_AUDIOContent; } }
        private static int _THREAD_PRIORITY_AUDIOContent = default;
        private static bool _THREAD_PRIORITY_AUDIOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#THREAD_PRIORITY_BACKGROUND"/>
        /// </summary>
        public static int THREAD_PRIORITY_BACKGROUND { get { if (!_THREAD_PRIORITY_BACKGROUNDReady) { _THREAD_PRIORITY_BACKGROUNDContent = SGetField<int>(LocalBridgeClazz, "THREAD_PRIORITY_BACKGROUND"); _THREAD_PRIORITY_BACKGROUNDReady = true; } return _THREAD_PRIORITY_BACKGROUNDContent; } }
        private static int _THREAD_PRIORITY_BACKGROUNDContent = default;
        private static bool _THREAD_PRIORITY_BACKGROUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#THREAD_PRIORITY_DEFAULT"/>
        /// </summary>
        public static int THREAD_PRIORITY_DEFAULT { get { if (!_THREAD_PRIORITY_DEFAULTReady) { _THREAD_PRIORITY_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "THREAD_PRIORITY_DEFAULT"); _THREAD_PRIORITY_DEFAULTReady = true; } return _THREAD_PRIORITY_DEFAULTContent; } }
        private static int _THREAD_PRIORITY_DEFAULTContent = default;
        private static bool _THREAD_PRIORITY_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#THREAD_PRIORITY_DISPLAY"/>
        /// </summary>
        public static int THREAD_PRIORITY_DISPLAY { get { if (!_THREAD_PRIORITY_DISPLAYReady) { _THREAD_PRIORITY_DISPLAYContent = SGetField<int>(LocalBridgeClazz, "THREAD_PRIORITY_DISPLAY"); _THREAD_PRIORITY_DISPLAYReady = true; } return _THREAD_PRIORITY_DISPLAYContent; } }
        private static int _THREAD_PRIORITY_DISPLAYContent = default;
        private static bool _THREAD_PRIORITY_DISPLAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#THREAD_PRIORITY_FOREGROUND"/>
        /// </summary>
        public static int THREAD_PRIORITY_FOREGROUND { get { if (!_THREAD_PRIORITY_FOREGROUNDReady) { _THREAD_PRIORITY_FOREGROUNDContent = SGetField<int>(LocalBridgeClazz, "THREAD_PRIORITY_FOREGROUND"); _THREAD_PRIORITY_FOREGROUNDReady = true; } return _THREAD_PRIORITY_FOREGROUNDContent; } }
        private static int _THREAD_PRIORITY_FOREGROUNDContent = default;
        private static bool _THREAD_PRIORITY_FOREGROUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#THREAD_PRIORITY_LESS_FAVORABLE"/>
        /// </summary>
        public static int THREAD_PRIORITY_LESS_FAVORABLE { get { if (!_THREAD_PRIORITY_LESS_FAVORABLEReady) { _THREAD_PRIORITY_LESS_FAVORABLEContent = SGetField<int>(LocalBridgeClazz, "THREAD_PRIORITY_LESS_FAVORABLE"); _THREAD_PRIORITY_LESS_FAVORABLEReady = true; } return _THREAD_PRIORITY_LESS_FAVORABLEContent; } }
        private static int _THREAD_PRIORITY_LESS_FAVORABLEContent = default;
        private static bool _THREAD_PRIORITY_LESS_FAVORABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#THREAD_PRIORITY_LOWEST"/>
        /// </summary>
        public static int THREAD_PRIORITY_LOWEST { get { if (!_THREAD_PRIORITY_LOWESTReady) { _THREAD_PRIORITY_LOWESTContent = SGetField<int>(LocalBridgeClazz, "THREAD_PRIORITY_LOWEST"); _THREAD_PRIORITY_LOWESTReady = true; } return _THREAD_PRIORITY_LOWESTContent; } }
        private static int _THREAD_PRIORITY_LOWESTContent = default;
        private static bool _THREAD_PRIORITY_LOWESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#THREAD_PRIORITY_MORE_FAVORABLE"/>
        /// </summary>
        public static int THREAD_PRIORITY_MORE_FAVORABLE { get { if (!_THREAD_PRIORITY_MORE_FAVORABLEReady) { _THREAD_PRIORITY_MORE_FAVORABLEContent = SGetField<int>(LocalBridgeClazz, "THREAD_PRIORITY_MORE_FAVORABLE"); _THREAD_PRIORITY_MORE_FAVORABLEReady = true; } return _THREAD_PRIORITY_MORE_FAVORABLEContent; } }
        private static int _THREAD_PRIORITY_MORE_FAVORABLEContent = default;
        private static bool _THREAD_PRIORITY_MORE_FAVORABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#THREAD_PRIORITY_URGENT_AUDIO"/>
        /// </summary>
        public static int THREAD_PRIORITY_URGENT_AUDIO { get { if (!_THREAD_PRIORITY_URGENT_AUDIOReady) { _THREAD_PRIORITY_URGENT_AUDIOContent = SGetField<int>(LocalBridgeClazz, "THREAD_PRIORITY_URGENT_AUDIO"); _THREAD_PRIORITY_URGENT_AUDIOReady = true; } return _THREAD_PRIORITY_URGENT_AUDIOContent; } }
        private static int _THREAD_PRIORITY_URGENT_AUDIOContent = default;
        private static bool _THREAD_PRIORITY_URGENT_AUDIOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#THREAD_PRIORITY_URGENT_DISPLAY"/>
        /// </summary>
        public static int THREAD_PRIORITY_URGENT_DISPLAY { get { if (!_THREAD_PRIORITY_URGENT_DISPLAYReady) { _THREAD_PRIORITY_URGENT_DISPLAYContent = SGetField<int>(LocalBridgeClazz, "THREAD_PRIORITY_URGENT_DISPLAY"); _THREAD_PRIORITY_URGENT_DISPLAYReady = true; } return _THREAD_PRIORITY_URGENT_DISPLAYContent; } }
        private static int _THREAD_PRIORITY_URGENT_DISPLAYContent = default;
        private static bool _THREAD_PRIORITY_URGENT_DISPLAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#THREAD_PRIORITY_VIDEO"/>
        /// </summary>
        public static int THREAD_PRIORITY_VIDEO { get { if (!_THREAD_PRIORITY_VIDEOReady) { _THREAD_PRIORITY_VIDEOContent = SGetField<int>(LocalBridgeClazz, "THREAD_PRIORITY_VIDEO"); _THREAD_PRIORITY_VIDEOReady = true; } return _THREAD_PRIORITY_VIDEOContent; } }
        private static int _THREAD_PRIORITY_VIDEOContent = default;
        private static bool _THREAD_PRIORITY_VIDEOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#WIFI_UID"/>
        /// </summary>
        public static int WIFI_UID { get { if (!_WIFI_UIDReady) { _WIFI_UIDContent = SGetField<int>(LocalBridgeClazz, "WIFI_UID"); _WIFI_UIDReady = true; } return _WIFI_UIDContent; } }
        private static int _WIFI_UIDContent = default;
        private static bool _WIFI_UIDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#myUserHandle()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.UserHandle"/></returns>
        public static Android.Os.UserHandle MyUserHandle()
        {
            return SExecuteWithSignature<Android.Os.UserHandle>(LocalBridgeClazz, "myUserHandle", "()Landroid/os/UserHandle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#isApplicationUid(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsApplicationUid(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isApplicationUid", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#is64Bit()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool Is64Bit()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "is64Bit", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#isIsolated()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsIsolated()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isIsolated", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#isIsolatedUid(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsIsolatedUid(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isIsolatedUid", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#isSdkSandbox()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSdkSandbox()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isSdkSandbox", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#isSdkSandboxUid(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSdkSandboxUid(int arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isSdkSandboxUid", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#supportsProcesses()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool SupportsProcesses()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "supportsProcesses", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#getAppUidForSdkSandboxUid(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetAppUidForSdkSandboxUid(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getAppUidForSdkSandboxUid", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#getSdkSandboxUidForAppUid(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetSdkSandboxUidForAppUid(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getSdkSandboxUidForAppUid", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#myPid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int MyPid()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "myPid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#myTid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int MyTid()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "myTid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#myUid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int MyUid()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "myUid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#getGidForName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetGidForName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getGidForName", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#getThreadPriority(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public static int GetThreadPriority(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getThreadPriority", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#getUidForName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetUidForName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getUidForName", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#getExclusiveCores()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int[] GetExclusiveCores()
        {
            return SExecuteWithSignatureArray<int>(LocalBridgeClazz, "getExclusiveCores", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#getElapsedCpuTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetElapsedCpuTime()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getElapsedCpuTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#sendSignal(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public static void SendSignal(int arg0, int arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "sendSignal", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#setThreadPriority(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public static void SetThreadPriority(int arg0, int arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setThreadPriority", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#setThreadPriority(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public static void SetThreadPriority(int arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setThreadPriority", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#killProcess(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public static void KillProcess(int arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "killProcess", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#myProcessName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String MyProcessName()
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "myProcessName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#getStartElapsedRealtime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetStartElapsedRealtime()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getStartElapsedRealtime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#getStartRequestedElapsedRealtime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetStartRequestedElapsedRealtime()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getStartRequestedElapsedRealtime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#getStartRequestedUptimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetStartRequestedUptimeMillis()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getStartRequestedUptimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Process.html#getStartUptimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetStartUptimeMillis()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getStartUptimeMillis", "()J");
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