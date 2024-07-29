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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Renderscript
{
    #region ScriptGroup
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
            IExecute("setInput", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptGroup.html#setOutput(android.renderscript.Script.KernelID,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Script.KernelID"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void SetOutput(Android.Renderscript.Script.KernelID arg0, Android.Renderscript.Allocation arg1)
        {
            IExecute("setOutput", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Binding
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

        #region Builder
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
                return IExecute<Android.Renderscript.ScriptGroup.Builder>("addConnection", arg0, arg1, arg2);
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
                return IExecute<Android.Renderscript.ScriptGroup.Builder>("addConnection", arg0, arg1, arg2);
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

        #region Builder2
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
                if (arg1.Length == 0) return IExecute<Android.Renderscript.ScriptGroup>("create", arg0); else return IExecute<Android.Renderscript.ScriptGroup>("create", arg0, arg1);
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
                if (arg1.Length == 0) return IExecute<Android.Renderscript.ScriptGroup.Closure>("addInvoke", arg0); else return IExecute<Android.Renderscript.ScriptGroup.Closure>("addInvoke", arg0, arg1);
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
                if (arg2.Length == 0) return IExecute<Android.Renderscript.ScriptGroup.Closure>("addKernel", arg0, arg1); else return IExecute<Android.Renderscript.ScriptGroup.Closure>("addKernel", arg0, arg1, arg2);
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

        #region Closure
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

        #region Future
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

        #region Input
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