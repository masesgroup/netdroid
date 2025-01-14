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

namespace Android.Graphics
{
    #region Shader declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/Shader.html"/>
    /// </summary>
    public partial class Shader : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Shader>
    {
        const string _bridgeClassName = "android.graphics.Shader";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Shader() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Shader(params object[] args) : base(args) { }
    
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
        #region TileMode declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Shader.TileMode.html"/>
        /// </summary>
        public partial class TileMode : Java.Lang.Enum<Android.Graphics.Shader.TileMode>
        {
            const string _bridgeClassName = "android.graphics.Shader$TileMode";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public TileMode() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public TileMode(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region Shader implementation
    public partial class Shader
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
        /// <see href="https://developer.android.com/reference/android/graphics/Shader.html#getLocalMatrix(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetLocalMatrix(Android.Graphics.Matrix arg0)
        {
            return IExecuteWithSignature<bool>("getLocalMatrix", "(Landroid/graphics/Matrix;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Shader.html#setLocalMatrix(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        public void SetLocalMatrix(Android.Graphics.Matrix arg0)
        {
            IExecuteWithSignature("setLocalMatrix", "(Landroid/graphics/Matrix;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region TileMode implementation
        public partial class TileMode
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Shader.TileMode.html#CLAMP"/>
            /// </summary>
            public static Android.Graphics.Shader.TileMode CLAMP { get { if (!_CLAMPReady) { _CLAMPContent = SGetField<Android.Graphics.Shader.TileMode>(LocalBridgeClazz, "CLAMP"); _CLAMPReady = true; } return _CLAMPContent; } }
            private static Android.Graphics.Shader.TileMode _CLAMPContent = default;
            private static bool _CLAMPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Shader.TileMode.html#DECAL"/>
            /// </summary>
            public static Android.Graphics.Shader.TileMode DECAL { get { if (!_DECALReady) { _DECALContent = SGetField<Android.Graphics.Shader.TileMode>(LocalBridgeClazz, "DECAL"); _DECALReady = true; } return _DECALContent; } }
            private static Android.Graphics.Shader.TileMode _DECALContent = default;
            private static bool _DECALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Shader.TileMode.html#MIRROR"/>
            /// </summary>
            public static Android.Graphics.Shader.TileMode MIRROR { get { if (!_MIRRORReady) { _MIRRORContent = SGetField<Android.Graphics.Shader.TileMode>(LocalBridgeClazz, "MIRROR"); _MIRRORReady = true; } return _MIRRORContent; } }
            private static Android.Graphics.Shader.TileMode _MIRRORContent = default;
            private static bool _MIRRORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Shader.TileMode.html#REPEAT"/>
            /// </summary>
            public static Android.Graphics.Shader.TileMode REPEAT { get { if (!_REPEATReady) { _REPEATContent = SGetField<Android.Graphics.Shader.TileMode>(LocalBridgeClazz, "REPEAT"); _REPEATReady = true; } return _REPEATContent; } }
            private static Android.Graphics.Shader.TileMode _REPEATContent = default;
            private static bool _REPEATReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Shader.TileMode.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Graphics.Shader.TileMode"/></returns>
            public static Android.Graphics.Shader.TileMode ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Graphics.Shader.TileMode>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Shader$TileMode;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Shader.TileMode.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Shader.TileMode"/></returns>
            public static Android.Graphics.Shader.TileMode[] Values()
            {
                return SExecuteWithSignatureArray<Android.Graphics.Shader.TileMode>(LocalBridgeClazz, "values", "()[Landroid/graphics/Shader$TileMode;");
            }
        
            #endregion
        
            #region Instance methods
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}