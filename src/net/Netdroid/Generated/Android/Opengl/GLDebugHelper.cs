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

namespace Android.Opengl
{
    #region GLDebugHelper
    public partial class GLDebugHelper
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLDebugHelper.html#CONFIG_CHECK_GL_ERROR"/>
        /// </summary>
        public static int CONFIG_CHECK_GL_ERROR { get { if (!_CONFIG_CHECK_GL_ERRORReady) { _CONFIG_CHECK_GL_ERRORContent = SGetField<int>(LocalBridgeClazz, "CONFIG_CHECK_GL_ERROR"); _CONFIG_CHECK_GL_ERRORReady = true; } return _CONFIG_CHECK_GL_ERRORContent; } }
        private static int _CONFIG_CHECK_GL_ERRORContent = default;
        private static bool _CONFIG_CHECK_GL_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLDebugHelper.html#CONFIG_CHECK_THREAD"/>
        /// </summary>
        public static int CONFIG_CHECK_THREAD { get { if (!_CONFIG_CHECK_THREADReady) { _CONFIG_CHECK_THREADContent = SGetField<int>(LocalBridgeClazz, "CONFIG_CHECK_THREAD"); _CONFIG_CHECK_THREADReady = true; } return _CONFIG_CHECK_THREADContent; } }
        private static int _CONFIG_CHECK_THREADContent = default;
        private static bool _CONFIG_CHECK_THREADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLDebugHelper.html#CONFIG_LOG_ARGUMENT_NAMES"/>
        /// </summary>
        public static int CONFIG_LOG_ARGUMENT_NAMES { get { if (!_CONFIG_LOG_ARGUMENT_NAMESReady) { _CONFIG_LOG_ARGUMENT_NAMESContent = SGetField<int>(LocalBridgeClazz, "CONFIG_LOG_ARGUMENT_NAMES"); _CONFIG_LOG_ARGUMENT_NAMESReady = true; } return _CONFIG_LOG_ARGUMENT_NAMESContent; } }
        private static int _CONFIG_LOG_ARGUMENT_NAMESContent = default;
        private static bool _CONFIG_LOG_ARGUMENT_NAMESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLDebugHelper.html#ERROR_WRONG_THREAD"/>
        /// </summary>
        public static int ERROR_WRONG_THREAD { get { if (!_ERROR_WRONG_THREADReady) { _ERROR_WRONG_THREADContent = SGetField<int>(LocalBridgeClazz, "ERROR_WRONG_THREAD"); _ERROR_WRONG_THREADReady = true; } return _ERROR_WRONG_THREADContent; } }
        private static int _ERROR_WRONG_THREADContent = default;
        private static bool _ERROR_WRONG_THREADReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLDebugHelper.html#wrap(javax.microedition.khronos.egl.EGL,int,java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Microedition.Khronos.Egl.EGL"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Io.Writer"/></param>
        /// <returns><see cref="Javax.Microedition.Khronos.Egl.EGL"/></returns>
        public static Javax.Microedition.Khronos.Egl.EGL Wrap(Javax.Microedition.Khronos.Egl.EGL arg0, int arg1, Java.Io.Writer arg2)
        {
            return SExecute<Javax.Microedition.Khronos.Egl.EGL>(LocalBridgeClazz, "wrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/GLDebugHelper.html#wrap(javax.microedition.khronos.opengles.GL,int,java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Microedition.Khronos.Opengles.GL"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Io.Writer"/></param>
        /// <returns><see cref="Javax.Microedition.Khronos.Opengles.GL"/></returns>
        public static Javax.Microedition.Khronos.Opengles.GL Wrap(Javax.Microedition.Khronos.Opengles.GL arg0, int arg1, Java.Io.Writer arg2)
        {
            return SExecute<Javax.Microedition.Khronos.Opengles.GL>(LocalBridgeClazz, "wrap", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}