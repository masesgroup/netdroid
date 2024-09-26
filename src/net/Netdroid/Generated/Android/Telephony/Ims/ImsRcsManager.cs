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

namespace Android.Telephony.Ims
{
    #region ImsRcsManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRcsManager.html"/>
    /// </summary>
    public partial class ImsRcsManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ImsRcsManager>
    {
        const string _bridgeClassName = "android.telephony.ims.ImsRcsManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ImsRcsManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ImsRcsManager(params object[] args) : base(args) { }

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

    #region ImsRcsManager implementation
    public partial class ImsRcsManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRcsManager.html#CAPABILITY_TYPE_NONE"/>
        /// </summary>
        public static int CAPABILITY_TYPE_NONE { get { if (!_CAPABILITY_TYPE_NONEReady) { _CAPABILITY_TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_TYPE_NONE"); _CAPABILITY_TYPE_NONEReady = true; } return _CAPABILITY_TYPE_NONEContent; } }
        private static int _CAPABILITY_TYPE_NONEContent = default;
        private static bool _CAPABILITY_TYPE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRcsManager.html#CAPABILITY_TYPE_OPTIONS_UCE"/>
        /// </summary>
        public static int CAPABILITY_TYPE_OPTIONS_UCE { get { if (!_CAPABILITY_TYPE_OPTIONS_UCEReady) { _CAPABILITY_TYPE_OPTIONS_UCEContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_TYPE_OPTIONS_UCE"); _CAPABILITY_TYPE_OPTIONS_UCEReady = true; } return _CAPABILITY_TYPE_OPTIONS_UCEContent; } }
        private static int _CAPABILITY_TYPE_OPTIONS_UCEContent = default;
        private static bool _CAPABILITY_TYPE_OPTIONS_UCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRcsManager.html#CAPABILITY_TYPE_PRESENCE_UCE"/>
        /// </summary>
        public static int CAPABILITY_TYPE_PRESENCE_UCE { get { if (!_CAPABILITY_TYPE_PRESENCE_UCEReady) { _CAPABILITY_TYPE_PRESENCE_UCEContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_TYPE_PRESENCE_UCE"); _CAPABILITY_TYPE_PRESENCE_UCEReady = true; } return _CAPABILITY_TYPE_PRESENCE_UCEContent; } }
        private static int _CAPABILITY_TYPE_PRESENCE_UCEContent = default;
        private static bool _CAPABILITY_TYPE_PRESENCE_UCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRcsManager.html#ACTION_SHOW_CAPABILITY_DISCOVERY_OPT_IN"/>
        /// </summary>
        public static Java.Lang.String ACTION_SHOW_CAPABILITY_DISCOVERY_OPT_IN { get { if (!_ACTION_SHOW_CAPABILITY_DISCOVERY_OPT_INReady) { _ACTION_SHOW_CAPABILITY_DISCOVERY_OPT_INContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_SHOW_CAPABILITY_DISCOVERY_OPT_IN"); _ACTION_SHOW_CAPABILITY_DISCOVERY_OPT_INReady = true; } return _ACTION_SHOW_CAPABILITY_DISCOVERY_OPT_INContent; } }
        private static Java.Lang.String _ACTION_SHOW_CAPABILITY_DISCOVERY_OPT_INContent = default;
        private static bool _ACTION_SHOW_CAPABILITY_DISCOVERY_OPT_INReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRcsManager.html#getUceAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Telephony.Ims.RcsUceAdapter"/></returns>
        public Android.Telephony.Ims.RcsUceAdapter GetUceAdapter()
        {
            return IExecuteWithSignature<Android.Telephony.Ims.RcsUceAdapter>("getUceAdapter", "()Landroid/telephony/ims/RcsUceAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRcsManager.html#getRegistrationState(java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public void GetRegistrationState(Java.Util.Concurrent.Executor arg0, Java.Util.Function.Consumer<Java.Lang.Integer> arg1)
        {
            IExecuteWithSignature("getRegistrationState", "(Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRcsManager.html#getRegistrationTransportType(java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public void GetRegistrationTransportType(Java.Util.Concurrent.Executor arg0, Java.Util.Function.Consumer<Java.Lang.Integer> arg1)
        {
            IExecuteWithSignature("getRegistrationTransportType", "(Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRcsManager.html#registerImsRegistrationCallback(java.util.concurrent.Executor,android.telephony.ims.RegistrationManager.RegistrationCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Telephony.Ims.RegistrationManager.RegistrationCallback"/></param>
        /// <exception cref="Android.Telephony.Ims.ImsException"/>
        public void RegisterImsRegistrationCallback(Java.Util.Concurrent.Executor arg0, Android.Telephony.Ims.RegistrationManager.RegistrationCallback arg1)
        {
            IExecuteWithSignature("registerImsRegistrationCallback", "(Ljava/util/concurrent/Executor;Landroid/telephony/ims/RegistrationManager$RegistrationCallback;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRcsManager.html#registerImsStateCallback(java.util.concurrent.Executor,android.telephony.ims.ImsStateCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Telephony.Ims.ImsStateCallback"/></param>
        /// <exception cref="Android.Telephony.Ims.ImsException"/>
        public void RegisterImsStateCallback(Java.Util.Concurrent.Executor arg0, Android.Telephony.Ims.ImsStateCallback arg1)
        {
            IExecuteWithSignature("registerImsStateCallback", "(Ljava/util/concurrent/Executor;Landroid/telephony/ims/ImsStateCallback;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRcsManager.html#unregisterImsRegistrationCallback(android.telephony.ims.RegistrationManager.RegistrationCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.Ims.RegistrationManager.RegistrationCallback"/></param>
        public void UnregisterImsRegistrationCallback(Android.Telephony.Ims.RegistrationManager.RegistrationCallback arg0)
        {
            IExecuteWithSignature("unregisterImsRegistrationCallback", "(Landroid/telephony/ims/RegistrationManager$RegistrationCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/ims/ImsRcsManager.html#unregisterImsStateCallback(android.telephony.ims.ImsStateCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.Ims.ImsStateCallback"/></param>
        public void UnregisterImsStateCallback(Android.Telephony.Ims.ImsStateCallback arg0)
        {
            IExecuteWithSignature("unregisterImsStateCallback", "(Landroid/telephony/ims/ImsStateCallback;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}