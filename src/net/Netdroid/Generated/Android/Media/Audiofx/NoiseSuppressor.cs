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

namespace Android.Media.Audiofx
{
    #region NoiseSuppressor
    public partial class NoiseSuppressor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/NoiseSuppressor.html#create(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.Audiofx.NoiseSuppressor"/></returns>
        public static Android.Media.Audiofx.NoiseSuppressor Create(int arg0)
        {
            return SExecuteWithSignature<Android.Media.Audiofx.NoiseSuppressor>(LocalBridgeClazz, "create", "(I)Landroid/media/audiofx/NoiseSuppressor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/NoiseSuppressor.html#isAvailable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsAvailable()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isAvailable", "()Z");
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