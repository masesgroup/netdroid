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

namespace Android.Content
{
    #region AbstractThreadedSyncAdapter declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/AbstractThreadedSyncAdapter.html"/>
    /// </summary>
    public partial class AbstractThreadedSyncAdapter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AbstractThreadedSyncAdapter>
    {
        const string _bridgeClassName = "android.content.AbstractThreadedSyncAdapter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AbstractThreadedSyncAdapter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractThreadedSyncAdapter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AbstractThreadedSyncAdapter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractThreadedSyncAdapter(params object[] args) : base(args) { }
    
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

    #region AbstractThreadedSyncAdapter implementation
    public partial class AbstractThreadedSyncAdapter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AbstractThreadedSyncAdapter.html#%3Cinit%3E(android.content.Context,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public AbstractThreadedSyncAdapter(Android.Content.Context arg0, bool arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AbstractThreadedSyncAdapter.html#%3Cinit%3E(android.content.Context,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public AbstractThreadedSyncAdapter(Android.Content.Context arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AbstractThreadedSyncAdapter.html#LOG_SYNC_DETAILS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int LOG_SYNC_DETAILS { get { if (!_LOG_SYNC_DETAILSReady) { _LOG_SYNC_DETAILSContent = SGetField<int>(LocalBridgeClazz, "LOG_SYNC_DETAILS"); _LOG_SYNC_DETAILSReady = true; } return _LOG_SYNC_DETAILSContent; } }
        private static int _LOG_SYNC_DETAILSContent = default;
        private static bool _LOG_SYNC_DETAILSReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AbstractThreadedSyncAdapter.html#onPerformSync(android.accounts.Account,android.os.Bundle,java.lang.String,android.content.ContentProviderClient,android.content.SyncResult)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.Account"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Content.ContentProviderClient"/></param>
        /// <param name="arg4"><see cref="Android.Content.SyncResult"/></param>
        public void OnPerformSync(Android.Accounts.Account arg0, Android.Os.Bundle arg1, Java.Lang.String arg2, Android.Content.ContentProviderClient arg3, Android.Content.SyncResult arg4)
        {
            IExecuteWithSignature("onPerformSync", "(Landroid/accounts/Account;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/ContentProviderClient;Landroid/content/SyncResult;)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AbstractThreadedSyncAdapter.html#getContext()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Context"/></returns>
        public Android.Content.Context GetContext()
        {
            return IExecuteWithSignature<Android.Content.Context>("getContext", "()Landroid/content/Context;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AbstractThreadedSyncAdapter.html#onUnsyncableAccount()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool OnUnsyncableAccount()
        {
            return IExecuteWithSignature<bool>("onUnsyncableAccount", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AbstractThreadedSyncAdapter.html#getSyncAdapterBinder()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.IBinder"/></returns>
        public Android.Os.IBinder GetSyncAdapterBinder()
        {
            return IExecuteWithSignature<Android.Os.IBinder>("getSyncAdapterBinder", "()Landroid/os/IBinder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AbstractThreadedSyncAdapter.html#onSecurityException(android.accounts.Account,android.os.Bundle,java.lang.String,android.content.SyncResult)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.Account"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Content.SyncResult"/></param>
        public void OnSecurityException(Android.Accounts.Account arg0, Android.Os.Bundle arg1, Java.Lang.String arg2, Android.Content.SyncResult arg3)
        {
            IExecuteWithSignature("onSecurityException", "(Landroid/accounts/Account;Landroid/os/Bundle;Ljava/lang/String;Landroid/content/SyncResult;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AbstractThreadedSyncAdapter.html#onSyncCanceled()"/>
        /// </summary>
        public void OnSyncCanceled()
        {
            IExecuteWithSignature("onSyncCanceled", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/AbstractThreadedSyncAdapter.html#onSyncCanceled(java.lang.Thread)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        public void OnSyncCanceled(Java.Lang.Thread arg0)
        {
            IExecuteWithSignature("onSyncCanceled", "(Ljava/lang/Thread;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}