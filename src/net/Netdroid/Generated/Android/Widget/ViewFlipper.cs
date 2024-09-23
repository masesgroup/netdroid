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

namespace Android.Widget
{
    #region ViewFlipper declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/ViewFlipper.html"/>
    /// </summary>
    public partial class ViewFlipper : Android.Widget.ViewAnimator
    {
        const string _bridgeClassName = "android.widget.ViewFlipper";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ViewFlipper() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ViewFlipper(params object[] args) : base(args) { }
    
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

    #region ViewFlipper implementation
    public partial class ViewFlipper
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewFlipper.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public ViewFlipper(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewFlipper.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public ViewFlipper(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/ViewFlipper.html#isAutoStart()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAutoStart()
        {
            return IExecuteWithSignature<bool>("isAutoStart", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewFlipper.html#isFlipping()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFlipping()
        {
            return IExecuteWithSignature<bool>("isFlipping", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewFlipper.html#getFlipInterval()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFlipInterval()
        {
            return IExecuteWithSignature<int>("getFlipInterval", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewFlipper.html#setAutoStart(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAutoStart(bool arg0)
        {
            IExecuteWithSignature("setAutoStart", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewFlipper.html#setFlipInterval(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetFlipInterval(int arg0)
        {
            IExecuteWithSignature("setFlipInterval", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewFlipper.html#startFlipping()"/>
        /// </summary>
        public void StartFlipping()
        {
            IExecuteWithSignature("startFlipping", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewFlipper.html#stopFlipping()"/>
        /// </summary>
        public void StopFlipping()
        {
            IExecuteWithSignature("stopFlipping", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}