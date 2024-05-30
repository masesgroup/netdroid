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

namespace Android.Os
{
    #region VibratorManager
    public partial class VibratorManager
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
        /// <see href="https://developer.android.com/reference/android/os/VibratorManager.html#getDefaultVibrator()"/> 
        /// </summary>
        public Android.Os.Vibrator DefaultVibrator
        {
            get { return IExecuteWithSignature<Android.Os.Vibrator>("getDefaultVibrator", "()Landroid/os/Vibrator;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibratorManager.html#getVibratorIds()"/> 
        /// </summary>
        public int[] VibratorIds
        {
            get { return IExecuteWithSignatureArray<int>("getVibratorIds", "()[I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibratorManager.html#getVibrator(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.Vibrator"/></returns>
        public Android.Os.Vibrator GetVibrator(int arg0)
        {
            return IExecuteWithSignature<Android.Os.Vibrator>("getVibrator", "(I)Landroid/os/Vibrator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibratorManager.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibratorManager.html#vibrate(android.os.CombinedVibration,android.os.VibrationAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.CombinedVibration"/></param>
        /// <param name="arg1"><see cref="Android.Os.VibrationAttributes"/></param>
        public void Vibrate(Android.Os.CombinedVibration arg0, Android.Os.VibrationAttributes arg1)
        {
            IExecute("vibrate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibratorManager.html#vibrate(android.os.CombinedVibration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.CombinedVibration"/></param>
        public void Vibrate(Android.Os.CombinedVibration arg0)
        {
            IExecuteWithSignature("vibrate", "(Landroid/os/CombinedVibration;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}