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
    #region StorageStatsManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/usage/StorageStatsManager.html"/>
    /// </summary>
    public partial class StorageStatsManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StorageStatsManager>
    {
        const string _bridgeClassName = "android.app.usage.StorageStatsManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StorageStatsManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StorageStatsManager(params object[] args) : base(args) { }

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

    #region StorageStatsManager implementation
    public partial class StorageStatsManager
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
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStatsManager.html#queryExternalStatsForUser(java.util.UUID,android.os.UserHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <param name="arg1"><see cref="Android.Os.UserHandle"/></param>
        /// <returns><see cref="Android.App.Usage.ExternalStorageStats"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.App.Usage.ExternalStorageStats QueryExternalStatsForUser(Java.Util.UUID arg0, Android.Os.UserHandle arg1)
        {
            return IExecute<Android.App.Usage.ExternalStorageStats>("queryExternalStatsForUser", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStatsManager.html#queryStatsForPackage(java.util.UUID,java.lang.String,android.os.UserHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.UserHandle"/></param>
        /// <returns><see cref="Android.App.Usage.StorageStats"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Android.Content.Pm.PackageManager.NameNotFoundException"/>
        public Android.App.Usage.StorageStats QueryStatsForPackage(Java.Util.UUID arg0, Java.Lang.String arg1, Android.Os.UserHandle arg2)
        {
            return IExecute<Android.App.Usage.StorageStats>("queryStatsForPackage", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStatsManager.html#queryStatsForUid(java.util.UUID,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.App.Usage.StorageStats"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.App.Usage.StorageStats QueryStatsForUid(Java.Util.UUID arg0, int arg1)
        {
            return IExecute<Android.App.Usage.StorageStats>("queryStatsForUid", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStatsManager.html#queryStatsForUser(java.util.UUID,android.os.UserHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <param name="arg1"><see cref="Android.Os.UserHandle"/></param>
        /// <returns><see cref="Android.App.Usage.StorageStats"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.App.Usage.StorageStats QueryStatsForUser(Java.Util.UUID arg0, Android.Os.UserHandle arg1)
        {
            return IExecute<Android.App.Usage.StorageStats>("queryStatsForUser", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStatsManager.html#getFreeBytes(java.util.UUID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long GetFreeBytes(Java.Util.UUID arg0)
        {
            return IExecuteWithSignature<long>("getFreeBytes", "(Ljava/util/UUID;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStatsManager.html#getTotalBytes(java.util.UUID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long GetTotalBytes(Java.Util.UUID arg0)
        {
            return IExecuteWithSignature<long>("getTotalBytes", "(Ljava/util/UUID;)J", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}