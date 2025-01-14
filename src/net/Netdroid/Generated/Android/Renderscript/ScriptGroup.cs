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

namespace Android.Renderscript
{
    #region ScriptGroup declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class ScriptGroup : Android.Renderscript.BaseObj
    {
        const string _bridgeClassName = "android.renderscript.ScriptGroup";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ScriptGroup() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ScriptGroup(params object[] args) : base(args) { }
    
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
        #region Binding declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Binding.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class Binding : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Binding>
        {
            const string _bridgeClassName = "android.renderscript.ScriptGroup$Binding";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Binding() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Binding(params object[] args) : base(args) { }
        
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

        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Builder.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.renderscript.ScriptGroup$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
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

        #region Builder2 declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Builder2.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class Builder2 : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder2>
        {
            const string _bridgeClassName = "android.renderscript.ScriptGroup$Builder2";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder2() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder2(params object[] args) : base(args) { }
        
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

        #region Closure declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Closure.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class Closure : Android.Renderscript.BaseObj
        {
            const string _bridgeClassName = "android.renderscript.ScriptGroup$Closure";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Closure() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Closure(params object[] args) : base(args) { }
        
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

        #region Future declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Future.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class Future : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Future>
        {
            const string _bridgeClassName = "android.renderscript.ScriptGroup$Future";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Future() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Future(params object[] args) : base(args) { }
        
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

        #region Input declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Input.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class Input : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Input>
        {
            const string _bridgeClassName = "android.renderscript.ScriptGroup$Input";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Input() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Input(params object[] args) : base(args) { }
        
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

    #region ScriptGroup implementation
    public partial class ScriptGroup
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
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.html#execute(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        [global::System.Obsolete()]
        public object[] Execute(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignatureArray<object>("execute", "([Ljava/lang/Object;)[Ljava/lang/Object;"); else return IExecuteWithSignatureArray<object>("execute", "([Ljava/lang/Object;)[Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.html#execute()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Execute()
        {
            IExecuteWithSignature("execute", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.html#setInput(android.renderscript.Script.KernelID,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Script.KernelID"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void SetInput(Android.Renderscript.Script.KernelID arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("setInput", "(Landroid/renderscript/Script$KernelID;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.html#setOutput(android.renderscript.Script.KernelID,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Script.KernelID"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void SetOutput(Android.Renderscript.Script.KernelID arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("setOutput", "(Landroid/renderscript/Script$KernelID;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region Binding implementation
        public partial class Binding
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Binding.html#%3Cinit%3E(android.renderscript.Script.FieldID,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Renderscript.Script.FieldID"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            [global::System.Obsolete()]
            public Binding(Android.Renderscript.Script.FieldID arg0, object arg1)
                : base(arg0, arg1)
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
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Builder.html#%3Cinit%3E(android.renderscript.RenderScript)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Renderscript.RenderScript"/></param>
            [global::System.Obsolete()]
            public Builder(Android.Renderscript.RenderScript arg0)
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
            /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Builder.html#create()"/>
            /// </summary>
            /// <returns><see cref="Android.Renderscript.ScriptGroup"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.ScriptGroup Create()
            {
                return IExecuteWithSignature<Android.Renderscript.ScriptGroup>("create", "()Landroid/renderscript/ScriptGroup;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Builder.html#addConnection(android.renderscript.Type,android.renderscript.Script.KernelID,android.renderscript.Script.FieldID)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Renderscript.Type"/></param>
            /// <param name="arg1"><see cref="Android.Renderscript.Script.KernelID"/></param>
            /// <param name="arg2"><see cref="Android.Renderscript.Script.FieldID"/></param>
            /// <returns><see cref="Android.Renderscript.ScriptGroup.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.ScriptGroup.Builder AddConnection(Android.Renderscript.Type arg0, Android.Renderscript.Script.KernelID arg1, Android.Renderscript.Script.FieldID arg2)
            {
                return IExecuteWithSignature<Android.Renderscript.ScriptGroup.Builder>("addConnection", "(Landroid/renderscript/Type;Landroid/renderscript/Script$KernelID;Landroid/renderscript/Script$FieldID;)Landroid/renderscript/ScriptGroup$Builder;", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Builder.html#addConnection(android.renderscript.Type,android.renderscript.Script.KernelID,android.renderscript.Script.KernelID)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Renderscript.Type"/></param>
            /// <param name="arg1"><see cref="Android.Renderscript.Script.KernelID"/></param>
            /// <param name="arg2"><see cref="Android.Renderscript.Script.KernelID"/></param>
            /// <returns><see cref="Android.Renderscript.ScriptGroup.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.ScriptGroup.Builder AddConnection(Android.Renderscript.Type arg0, Android.Renderscript.Script.KernelID arg1, Android.Renderscript.Script.KernelID arg2)
            {
                return IExecuteWithSignature<Android.Renderscript.ScriptGroup.Builder>("addConnection", "(Landroid/renderscript/Type;Landroid/renderscript/Script$KernelID;Landroid/renderscript/Script$KernelID;)Landroid/renderscript/ScriptGroup$Builder;", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Builder.html#addKernel(android.renderscript.Script.KernelID)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Renderscript.Script.KernelID"/></param>
            /// <returns><see cref="Android.Renderscript.ScriptGroup.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.ScriptGroup.Builder AddKernel(Android.Renderscript.Script.KernelID arg0)
            {
                return IExecuteWithSignature<Android.Renderscript.ScriptGroup.Builder>("addKernel", "(Landroid/renderscript/Script$KernelID;)Landroid/renderscript/ScriptGroup$Builder;", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Builder2 implementation
        public partial class Builder2
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Builder2.html#%3Cinit%3E(android.renderscript.RenderScript)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Renderscript.RenderScript"/></param>
            [global::System.Obsolete()]
            public Builder2(Android.Renderscript.RenderScript arg0)
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
            /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Builder2.html#create(java.lang.String,android.renderscript.ScriptGroup.Future[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Renderscript.ScriptGroup.Future"/></param>
            /// <returns><see cref="Android.Renderscript.ScriptGroup"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.ScriptGroup Create(Java.Lang.String arg0, params Android.Renderscript.ScriptGroup.Future[] arg1)
            {
                if (arg1.Length == 0) return IExecuteWithSignature<Android.Renderscript.ScriptGroup>("create", "(Ljava/lang/String;[Landroid/renderscript/ScriptGroup$Future;)Landroid/renderscript/ScriptGroup;", arg0); else return IExecuteWithSignature<Android.Renderscript.ScriptGroup>("create", "(Ljava/lang/String;[Landroid/renderscript/ScriptGroup$Future;)Landroid/renderscript/ScriptGroup;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Builder2.html#addInvoke(android.renderscript.Script.InvokeID,java.lang.Object[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Renderscript.Script.InvokeID"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="Android.Renderscript.ScriptGroup.Closure"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.ScriptGroup.Closure AddInvoke(Android.Renderscript.Script.InvokeID arg0, params object[] arg1)
            {
                if (arg1.Length == 0) return IExecuteWithSignature<Android.Renderscript.ScriptGroup.Closure>("addInvoke", "(Landroid/renderscript/Script$InvokeID;[Ljava/lang/Object;)Landroid/renderscript/ScriptGroup$Closure;", arg0); else return IExecuteWithSignature<Android.Renderscript.ScriptGroup.Closure>("addInvoke", "(Landroid/renderscript/Script$InvokeID;[Ljava/lang/Object;)Landroid/renderscript/ScriptGroup$Closure;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Builder2.html#addKernel(android.renderscript.Script.KernelID,android.renderscript.Type,java.lang.Object[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Renderscript.Script.KernelID"/></param>
            /// <param name="arg1"><see cref="Android.Renderscript.Type"/></param>
            /// <param name="arg2"><see cref="object"/></param>
            /// <returns><see cref="Android.Renderscript.ScriptGroup.Closure"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.ScriptGroup.Closure AddKernel(Android.Renderscript.Script.KernelID arg0, Android.Renderscript.Type arg1, params object[] arg2)
            {
                if (arg2.Length == 0) return IExecuteWithSignature<Android.Renderscript.ScriptGroup.Closure>("addKernel", "(Landroid/renderscript/Script$KernelID;Landroid/renderscript/Type;[Ljava/lang/Object;)Landroid/renderscript/ScriptGroup$Closure;", arg0, arg1); else return IExecuteWithSignature<Android.Renderscript.ScriptGroup.Closure>("addKernel", "(Landroid/renderscript/Script$KernelID;Landroid/renderscript/Type;[Ljava/lang/Object;)Landroid/renderscript/ScriptGroup$Closure;", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Builder2.html#addInput()"/>
            /// </summary>
            /// <returns><see cref="Android.Renderscript.ScriptGroup.Input"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.ScriptGroup.Input AddInput()
            {
                return IExecuteWithSignature<Android.Renderscript.ScriptGroup.Input>("addInput", "()Landroid/renderscript/ScriptGroup$Input;");
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Closure implementation
        public partial class Closure
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
            /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Closure.html#getGlobal(android.renderscript.Script.FieldID)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Renderscript.Script.FieldID"/></param>
            /// <returns><see cref="Android.Renderscript.ScriptGroup.Future"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.ScriptGroup.Future GetGlobal(Android.Renderscript.Script.FieldID arg0)
            {
                return IExecuteWithSignature<Android.Renderscript.ScriptGroup.Future>("getGlobal", "(Landroid/renderscript/Script$FieldID;)Landroid/renderscript/ScriptGroup$Future;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.Closure.html#getReturn()"/>
            /// </summary>
            /// <returns><see cref="Android.Renderscript.ScriptGroup.Future"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.ScriptGroup.Future GetReturn()
            {
                return IExecuteWithSignature<Android.Renderscript.ScriptGroup.Future>("getReturn", "()Landroid/renderscript/ScriptGroup$Future;");
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Future implementation
        public partial class Future
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
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Input implementation
        public partial class Input
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