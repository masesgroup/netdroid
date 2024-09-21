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

namespace Android.Transition
{
    #region TransitionManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/transition/TransitionManager.html"/>
    /// </summary>
    public partial class TransitionManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TransitionManager>
    {
        const string _bridgeClassName = "android.transition.TransitionManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TransitionManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TransitionManager(params object[] args) : base(args) { }

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

    #region TransitionManager implementation
    public partial class TransitionManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionManager.html#beginDelayedTransition(android.view.ViewGroup,android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        /// <param name="arg1"><see cref="Android.Transition.Transition"/></param>
        public static void BeginDelayedTransition(Android.View.ViewGroup arg0, Android.Transition.Transition arg1)
        {
            SExecute(LocalBridgeClazz, "beginDelayedTransition", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionManager.html#beginDelayedTransition(android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        public static void BeginDelayedTransition(Android.View.ViewGroup arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "beginDelayedTransition", "(Landroid/view/ViewGroup;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionManager.html#endTransitions(android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ViewGroup"/></param>
        public static void EndTransitions(Android.View.ViewGroup arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "endTransitions", "(Landroid/view/ViewGroup;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionManager.html#go(android.transition.Scene,android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Scene"/></param>
        /// <param name="arg1"><see cref="Android.Transition.Transition"/></param>
        public static void Go(Android.Transition.Scene arg0, Android.Transition.Transition arg1)
        {
            SExecute(LocalBridgeClazz, "go", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionManager.html#go(android.transition.Scene)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Scene"/></param>
        public static void Go(Android.Transition.Scene arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "go", "(Landroid/transition/Scene;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionManager.html#setTransition(android.transition.Scene,android.transition.Scene,android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Scene"/></param>
        /// <param name="arg1"><see cref="Android.Transition.Scene"/></param>
        /// <param name="arg2"><see cref="Android.Transition.Transition"/></param>
        public void SetTransition(Android.Transition.Scene arg0, Android.Transition.Scene arg1, Android.Transition.Transition arg2)
        {
            IExecute("setTransition", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionManager.html#setTransition(android.transition.Scene,android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Scene"/></param>
        /// <param name="arg1"><see cref="Android.Transition.Transition"/></param>
        public void SetTransition(Android.Transition.Scene arg0, Android.Transition.Transition arg1)
        {
            IExecute("setTransition", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionManager.html#transitionTo(android.transition.Scene)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Scene"/></param>
        public void TransitionTo(Android.Transition.Scene arg0)
        {
            IExecuteWithSignature("transitionTo", "(Landroid/transition/Scene;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}