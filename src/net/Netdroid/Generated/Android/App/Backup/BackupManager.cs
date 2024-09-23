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

namespace Android.App.Backup
{
    #region BackupManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/backup/BackupManager.html"/>
    /// </summary>
    public partial class BackupManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BackupManager>
    {
        const string _bridgeClassName = "android.app.backup.BackupManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BackupManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BackupManager(params object[] args) : base(args) { }
    
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

    #region BackupManager implementation
    public partial class BackupManager
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupManager.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public BackupManager(Android.Content.Context arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupManager.html#dataChanged(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void DataChanged(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "dataChanged", "(Ljava/lang/String;)V", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupManager.html#getUserForAncestralSerialNumber(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Android.Os.UserHandle"/></returns>
        public Android.Os.UserHandle GetUserForAncestralSerialNumber(long arg0)
        {
            return IExecuteWithSignature<Android.Os.UserHandle>("getUserForAncestralSerialNumber", "(J)Landroid/os/UserHandle;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupManager.html#requestRestore(android.app.backup.RestoreObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Backup.RestoreObserver"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int RequestRestore(Android.App.Backup.RestoreObserver arg0)
        {
            return IExecuteWithSignature<int>("requestRestore", "(Landroid/app/backup/RestoreObserver;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/BackupManager.html#dataChanged()"/>
        /// </summary>
        public void DataChanged()
        {
            IExecuteWithSignature("dataChanged", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}