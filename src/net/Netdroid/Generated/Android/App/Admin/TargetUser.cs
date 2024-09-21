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

namespace Android.App.Admin
{
    #region TargetUser declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/admin/TargetUser.html"/>
    /// </summary>
    public partial class TargetUser : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TargetUser>
    {
        const string _bridgeClassName = "android.app.admin.TargetUser";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TargetUser() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TargetUser(params object[] args) : base(args) { }

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

    #region TargetUser implementation
    public partial class TargetUser
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/TargetUser.html#GLOBAL"/>
        /// </summary>
        public static Android.App.Admin.TargetUser GLOBAL { get { if (!_GLOBALReady) { _GLOBALContent = SGetField<Android.App.Admin.TargetUser>(LocalBridgeClazz, "GLOBAL"); _GLOBALReady = true; } return _GLOBALContent; } }
        private static Android.App.Admin.TargetUser _GLOBALContent = default;
        private static bool _GLOBALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/TargetUser.html#LOCAL_USER"/>
        /// </summary>
        public static Android.App.Admin.TargetUser LOCAL_USER { get { if (!_LOCAL_USERReady) { _LOCAL_USERContent = SGetField<Android.App.Admin.TargetUser>(LocalBridgeClazz, "LOCAL_USER"); _LOCAL_USERReady = true; } return _LOCAL_USERContent; } }
        private static Android.App.Admin.TargetUser _LOCAL_USERContent = default;
        private static bool _LOCAL_USERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/TargetUser.html#PARENT_USER"/>
        /// </summary>
        public static Android.App.Admin.TargetUser PARENT_USER { get { if (!_PARENT_USERReady) { _PARENT_USERContent = SGetField<Android.App.Admin.TargetUser>(LocalBridgeClazz, "PARENT_USER"); _PARENT_USERReady = true; } return _PARENT_USERContent; } }
        private static Android.App.Admin.TargetUser _PARENT_USERContent = default;
        private static bool _PARENT_USERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/TargetUser.html#UNKNOWN_USER"/>
        /// </summary>
        public static Android.App.Admin.TargetUser UNKNOWN_USER { get { if (!_UNKNOWN_USERReady) { _UNKNOWN_USERContent = SGetField<Android.App.Admin.TargetUser>(LocalBridgeClazz, "UNKNOWN_USER"); _UNKNOWN_USERReady = true; } return _UNKNOWN_USERContent; } }
        private static Android.App.Admin.TargetUser _UNKNOWN_USERContent = default;
        private static bool _UNKNOWN_USERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}