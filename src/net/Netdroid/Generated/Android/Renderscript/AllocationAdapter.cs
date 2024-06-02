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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Renderscript
{
    #region AllocationAdapter
    public partial class AllocationAdapter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/AllocationAdapter.html#create1D(android.renderscript.RenderScript,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.RenderScript"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <returns><see cref="Android.Renderscript.AllocationAdapter"/></returns>
        [global::System.Obsolete()]
        public static Android.Renderscript.AllocationAdapter Create1D(Android.Renderscript.RenderScript arg0, Android.Renderscript.Allocation arg1)
        {
            return SExecute<Android.Renderscript.AllocationAdapter>(LocalBridgeClazz, "create1D", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/AllocationAdapter.html#create2D(android.renderscript.RenderScript,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.RenderScript"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <returns><see cref="Android.Renderscript.AllocationAdapter"/></returns>
        [global::System.Obsolete()]
        public static Android.Renderscript.AllocationAdapter Create2D(Android.Renderscript.RenderScript arg0, Android.Renderscript.Allocation arg1)
        {
            return SExecute<Android.Renderscript.AllocationAdapter>(LocalBridgeClazz, "create2D", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/AllocationAdapter.html#createTyped(android.renderscript.RenderScript,android.renderscript.Allocation,android.renderscript.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.RenderScript"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Type"/></param>
        /// <returns><see cref="Android.Renderscript.AllocationAdapter"/></returns>
        [global::System.Obsolete()]
        public static Android.Renderscript.AllocationAdapter CreateTyped(Android.Renderscript.RenderScript arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Type arg2)
        {
            return SExecute<Android.Renderscript.AllocationAdapter>(LocalBridgeClazz, "createTyped", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/AllocationAdapter.html#setFace(android.renderscript.Type.CubemapFace)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Type.CubemapFace"/></param>
        [global::System.Obsolete()]
        public void SetFace(Android.Renderscript.Type.CubemapFace arg0)
        {
            IExecuteWithSignature("setFace", "(Landroid/renderscript/Type$CubemapFace;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/AllocationAdapter.html#setLOD(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetLOD(int arg0)
        {
            IExecuteWithSignature("setLOD", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/AllocationAdapter.html#setX(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetX(int arg0)
        {
            IExecuteWithSignature("setX", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/AllocationAdapter.html#setY(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetY(int arg0)
        {
            IExecuteWithSignature("setY", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/AllocationAdapter.html#setZ(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetZ(int arg0)
        {
            IExecuteWithSignature("setZ", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}