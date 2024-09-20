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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Os
{
    #region PerformanceHintManager
    public partial class PerformanceHintManager
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
        /// <see href="https://developer.android.com/reference/android/os/PerformanceHintManager.html#createHintSession(int[],long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Android.Os.PerformanceHintManager.Session"/></returns>
        public Android.Os.PerformanceHintManager.Session CreateHintSession(int[] arg0, long arg1)
        {
            return IExecute<Android.Os.PerformanceHintManager.Session>("createHintSession", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/PerformanceHintManager.html#getPreferredUpdateRateNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetPreferredUpdateRateNanos()
        {
            return IExecuteWithSignature<long>("getPreferredUpdateRateNanos", "()J");
        }

        #endregion

        #region Nested classes
        #region Session
        public partial class Session
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
            /// <see href="https://developer.android.com/reference/android/os/PerformanceHintManager.Session.html#close()"/>
            /// </summary>
            public void Close()
            {
                IExecuteWithSignature("close", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PerformanceHintManager.Session.html#reportActualWorkDuration(android.os.WorkDuration)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.WorkDuration"/></param>
            public void ReportActualWorkDuration(Android.Os.WorkDuration arg0)
            {
                IExecuteWithSignature("reportActualWorkDuration", "(Landroid/os/WorkDuration;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PerformanceHintManager.Session.html#reportActualWorkDuration(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            public void ReportActualWorkDuration(long arg0)
            {
                IExecuteWithSignature("reportActualWorkDuration", "(J)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PerformanceHintManager.Session.html#setPreferPowerEfficiency(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void SetPreferPowerEfficiency(bool arg0)
            {
                IExecuteWithSignature("setPreferPowerEfficiency", "(Z)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PerformanceHintManager.Session.html#setThreads(int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SetThreads(int[] arg0)
            {
                IExecuteWithSignature("setThreads", "([I)V", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/PerformanceHintManager.Session.html#updateTargetWorkDuration(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            public void UpdateTargetWorkDuration(long arg0)
            {
                IExecuteWithSignature("updateTargetWorkDuration", "(J)V", arg0);
            }

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