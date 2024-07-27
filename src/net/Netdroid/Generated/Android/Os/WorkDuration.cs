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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Os
{
    #region WorkDuration
    public partial class WorkDuration
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
        /// <see href="https://developer.android.com/reference/android/os/WorkDuration.html#getActualCpuDurationNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetActualCpuDurationNanos()
        {
            return IExecuteWithSignature<long>("getActualCpuDurationNanos", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkDuration.html#getActualGpuDurationNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetActualGpuDurationNanos()
        {
            return IExecuteWithSignature<long>("getActualGpuDurationNanos", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkDuration.html#getActualTotalDurationNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetActualTotalDurationNanos()
        {
            return IExecuteWithSignature<long>("getActualTotalDurationNanos", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkDuration.html#getWorkPeriodStartTimestampNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetWorkPeriodStartTimestampNanos()
        {
            return IExecuteWithSignature<long>("getWorkPeriodStartTimestampNanos", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkDuration.html#setActualCpuDurationNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetActualCpuDurationNanos(long arg0)
        {
            IExecuteWithSignature("setActualCpuDurationNanos", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkDuration.html#setActualGpuDurationNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetActualGpuDurationNanos(long arg0)
        {
            IExecuteWithSignature("setActualGpuDurationNanos", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkDuration.html#setActualTotalDurationNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetActualTotalDurationNanos(long arg0)
        {
            IExecuteWithSignature("setActualTotalDurationNanos", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkDuration.html#setWorkPeriodStartTimestampNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetWorkPeriodStartTimestampNanos(long arg0)
        {
            IExecuteWithSignature("setWorkPeriodStartTimestampNanos", "(J)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}