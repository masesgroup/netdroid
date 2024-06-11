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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Microedition.Khronos.Egl
{
    #region EGLContext
    public partial class EGLContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/microedition/khronos/egl/EGLContext.html#getEGL()"/>
        /// </summary>
        /// <returns><see cref="Javax.Microedition.Khronos.Egl.EGL"/></returns>
        public static Javax.Microedition.Khronos.Egl.EGL GetEGL()
        {
            return SExecuteWithSignature<Javax.Microedition.Khronos.Egl.EGL>(LocalBridgeClazz, "getEGL", "()Ljavax/microedition/khronos/egl/EGL;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/microedition/khronos/egl/EGLContext.html#getGL()"/>
        /// </summary>
        /// <returns><see cref="Javax.Microedition.Khronos.Opengles.GL"/></returns>
        public Javax.Microedition.Khronos.Opengles.GL GetGL()
        {
            return IExecuteWithSignature<Javax.Microedition.Khronos.Opengles.GL>("getGL", "()Ljavax/microedition/khronos/opengles/GL;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}