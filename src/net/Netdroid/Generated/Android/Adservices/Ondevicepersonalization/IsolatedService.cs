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

namespace Android.Adservices.Ondevicepersonalization
{
    #region IsolatedService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html"/>
    /// </summary>
    public partial class IsolatedService : Android.App.Service
    {
        const string _bridgeClassName = "android.adservices.ondevicepersonalization.IsolatedService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("IsolatedService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public IsolatedService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("IsolatedService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public IsolatedService(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region IsolatedService implementation
    public partial class IsolatedService
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
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#onRequest(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.IsolatedWorker"/></returns>
        public Android.Adservices.Ondevicepersonalization.IsolatedWorker OnRequest(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.IsolatedWorker>("onRequest", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/IsolatedWorker;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getEventUrlProvider(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.EventUrlProvider"/></returns>
        public Android.Adservices.Ondevicepersonalization.EventUrlProvider GetEventUrlProvider(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.EventUrlProvider>("getEventUrlProvider", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/EventUrlProvider;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getFederatedComputeScheduler(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.FederatedComputeScheduler"/></returns>
        public Android.Adservices.Ondevicepersonalization.FederatedComputeScheduler GetFederatedComputeScheduler(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.FederatedComputeScheduler>("getFederatedComputeScheduler", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/FederatedComputeScheduler;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getRemoteData(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.KeyValueStore"/></returns>
        public Android.Adservices.Ondevicepersonalization.KeyValueStore GetRemoteData(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.KeyValueStore>("getRemoteData", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/KeyValueStore;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getLogReader(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.LogReader"/></returns>
        public Android.Adservices.Ondevicepersonalization.LogReader GetLogReader(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.LogReader>("getLogReader", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/LogReader;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getModelManager(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.ModelManager"/></returns>
        public Android.Adservices.Ondevicepersonalization.ModelManager GetModelManager(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.ModelManager>("getModelManager", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/ModelManager;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getLocalData(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.MutableKeyValueStore"/></returns>
        public Android.Adservices.Ondevicepersonalization.MutableKeyValueStore GetLocalData(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.MutableKeyValueStore>("getLocalData", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/MutableKeyValueStore;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/IsolatedService.html#getUserData(android.adservices.ondevicepersonalization.RequestToken)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestToken"/></param>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.UserData"/></returns>
        public Android.Adservices.Ondevicepersonalization.UserData GetUserData(Android.Adservices.Ondevicepersonalization.RequestToken arg0)
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.UserData>("getUserData", "(Landroid/adservices/ondevicepersonalization/RequestToken;)Landroid/adservices/ondevicepersonalization/UserData;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}