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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Renderscript
{
    #region ScriptIntrinsicYuvToRGB
    public partial class ScriptIntrinsicYuvToRGB
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicYuvToRGB.html#create(android.renderscript.RenderScript,android.renderscript.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.RenderScript"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Element"/></param>
        /// <returns><see cref="Android.Renderscript.ScriptIntrinsicYuvToRGB"/></returns>
        [global::System.Obsolete()]
        public static Android.Renderscript.ScriptIntrinsicYuvToRGB Create(Android.Renderscript.RenderScript arg0, Android.Renderscript.Element arg1)
        {
            return SExecute<Android.Renderscript.ScriptIntrinsicYuvToRGB>(LocalBridgeClazz, "create", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicYuvToRGB.html#getFieldID_Input()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.FieldID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.FieldID GetFieldID_Input()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.FieldID>("getFieldID_Input", "()Landroid/renderscript/Script$FieldID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicYuvToRGB.html#getKernelID()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelID()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelID", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicYuvToRGB.html#forEach(android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEach(Android.Renderscript.Allocation arg0)
        {
            IExecuteWithSignature("forEach", "(Landroid/renderscript/Allocation;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicYuvToRGB.html#setInput(android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void SetInput(Android.Renderscript.Allocation arg0)
        {
            IExecuteWithSignature("setInput", "(Landroid/renderscript/Allocation;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}