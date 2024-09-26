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

namespace Android.Window
{
    #region SurfaceSyncGroup declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/window/SurfaceSyncGroup.html"/>
    /// </summary>
    public partial class SurfaceSyncGroup : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SurfaceSyncGroup>
    {
        const string _bridgeClassName = "android.window.SurfaceSyncGroup";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SurfaceSyncGroup() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SurfaceSyncGroup(params object[] args) : base(args) { }

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

    #region SurfaceSyncGroup implementation
    public partial class SurfaceSyncGroup
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/window/SurfaceSyncGroup.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public SurfaceSyncGroup(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/window/SurfaceSyncGroup.html#add(android.view.AttachedSurfaceControl,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.AttachedSurfaceControl"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(Android.View.AttachedSurfaceControl arg0, Java.Lang.Runnable arg1)
        {
            return IExecuteWithSignature<bool>("add", "(Landroid/view/AttachedSurfaceControl;Ljava/lang/Runnable;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/window/SurfaceSyncGroup.html#add(android.view.SurfaceControlViewHost.SurfacePackage,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SurfaceControlViewHost.SurfacePackage"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(Android.View.SurfaceControlViewHost.SurfacePackage arg0, Java.Lang.Runnable arg1)
        {
            return IExecuteWithSignature<bool>("add", "(Landroid/view/SurfaceControlViewHost$SurfacePackage;Ljava/lang/Runnable;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/window/SurfaceSyncGroup.html#addTransaction(android.view.SurfaceControl.Transaction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SurfaceControl.Transaction"/></param>
        public void AddTransaction(Android.View.SurfaceControl.Transaction arg0)
        {
            IExecuteWithSignature("addTransaction", "(Landroid/view/SurfaceControl$Transaction;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/window/SurfaceSyncGroup.html#markSyncReady()"/>
        /// </summary>
        public void MarkSyncReady()
        {
            IExecuteWithSignature("markSyncReady", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}