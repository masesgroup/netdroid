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

namespace Android.Renderscript
{
    #region ScriptIntrinsic3DLUT declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsic3DLUT.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class ScriptIntrinsic3DLUT : Android.Renderscript.ScriptIntrinsic
    {
        const string _bridgeClassName = "android.renderscript.ScriptIntrinsic3DLUT";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ScriptIntrinsic3DLUT() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ScriptIntrinsic3DLUT(params object[] args) : base(args) { }
    
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

    #region ScriptIntrinsic3DLUT implementation
    public partial class ScriptIntrinsic3DLUT
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsic3DLUT.html#create(android.renderscript.RenderScript,android.renderscript.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.RenderScript"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Element"/></param>
        /// <returns><see cref="Android.Renderscript.ScriptIntrinsic3DLUT"/></returns>
        [global::System.Obsolete()]
        public static Android.Renderscript.ScriptIntrinsic3DLUT Create(Android.Renderscript.RenderScript arg0, Android.Renderscript.Element arg1)
        {
            return SExecute<Android.Renderscript.ScriptIntrinsic3DLUT>(LocalBridgeClazz, "create", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsic3DLUT.html#getKernelID()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelID()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelID", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsic3DLUT.html#forEach(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEach(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecute("forEach", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsic3DLUT.html#forEach(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEach(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecute("forEach", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsic3DLUT.html#setLUT(android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void SetLUT(Android.Renderscript.Allocation arg0)
        {
            IExecuteWithSignature("setLUT", "(Landroid/renderscript/Allocation;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}