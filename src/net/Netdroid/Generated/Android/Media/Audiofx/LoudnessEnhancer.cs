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
    #region LoudnessEnhancer
    public partial class LoudnessEnhancer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/LoudnessEnhancer.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.RuntimeException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public LoudnessEnhancer(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/LoudnessEnhancer.html#PARAM_TARGET_GAIN_MB"/>
        /// </summary>
        public static int PARAM_TARGET_GAIN_MB { get { if (!_PARAM_TARGET_GAIN_MBReady) { _PARAM_TARGET_GAIN_MBContent = SGetField<int>(LocalBridgeClazz, "PARAM_TARGET_GAIN_MB"); _PARAM_TARGET_GAIN_MBReady = true; } return _PARAM_TARGET_GAIN_MBContent; } }
        private static int _PARAM_TARGET_GAIN_MBContent = default;
        private static bool _PARAM_TARGET_GAIN_MBReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/LoudnessEnhancer.html#getTargetGain()"/> <see href="https://developer.android.com/reference/android/media/audiofx/LoudnessEnhancer.html#setTargetGain(int)"/>
        /// </summary>
        public float TargetGain
        {
            get { return IExecuteWithSignature<float>("getTargetGain", "()F"); } set { IExecuteWithSignature("setTargetGain", "(I)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}