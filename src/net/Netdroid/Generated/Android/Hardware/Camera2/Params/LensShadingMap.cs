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

namespace Android.Hardware.Camera2.Params
{
    #region LensShadingMap
    public partial class LensShadingMap
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/LensShadingMap.html#MINIMUM_GAIN_FACTOR"/>
        /// </summary>
        public static float MINIMUM_GAIN_FACTOR { get { if (!_MINIMUM_GAIN_FACTORReady) { _MINIMUM_GAIN_FACTORContent = SGetField<float>(LocalBridgeClazz, "MINIMUM_GAIN_FACTOR"); _MINIMUM_GAIN_FACTORReady = true; } return _MINIMUM_GAIN_FACTORContent; } }
        private static float _MINIMUM_GAIN_FACTORContent = default;
        private static bool _MINIMUM_GAIN_FACTORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/LensShadingMap.html#getGainFactorVector(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Hardware.Camera2.Params.RggbChannelVector"/></returns>
        public Android.Hardware.Camera2.Params.RggbChannelVector GetGainFactorVector(int arg0, int arg1)
        {
            return IExecute<Android.Hardware.Camera2.Params.RggbChannelVector>("getGainFactorVector", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/LensShadingMap.html#getGainFactor(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetGainFactor(int arg0, int arg1, int arg2)
        {
            return IExecute<float>("getGainFactor", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/LensShadingMap.html#getColumnCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetColumnCount()
        {
            return IExecuteWithSignature<int>("getColumnCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/LensShadingMap.html#getGainFactorCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGainFactorCount()
        {
            return IExecuteWithSignature<int>("getGainFactorCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/LensShadingMap.html#getRowCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRowCount()
        {
            return IExecuteWithSignature<int>("getRowCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/LensShadingMap.html#copyGainFactors(float[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void CopyGainFactors(float[] arg0, int arg1)
        {
            IExecute("copyGainFactors", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}