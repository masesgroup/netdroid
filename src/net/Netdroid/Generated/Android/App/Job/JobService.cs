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

namespace Android.App.Job
{
    #region JobService
    public partial class JobService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#JOB_END_NOTIFICATION_POLICY_DETACH"/>
        /// </summary>
        public static int JOB_END_NOTIFICATION_POLICY_DETACH { get { if (!_JOB_END_NOTIFICATION_POLICY_DETACHReady) { _JOB_END_NOTIFICATION_POLICY_DETACHContent = SGetField<int>(LocalBridgeClazz, "JOB_END_NOTIFICATION_POLICY_DETACH"); _JOB_END_NOTIFICATION_POLICY_DETACHReady = true; } return _JOB_END_NOTIFICATION_POLICY_DETACHContent; } }
        private static int _JOB_END_NOTIFICATION_POLICY_DETACHContent = default;
        private static bool _JOB_END_NOTIFICATION_POLICY_DETACHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#JOB_END_NOTIFICATION_POLICY_REMOVE"/>
        /// </summary>
        public static int JOB_END_NOTIFICATION_POLICY_REMOVE { get { if (!_JOB_END_NOTIFICATION_POLICY_REMOVEReady) { _JOB_END_NOTIFICATION_POLICY_REMOVEContent = SGetField<int>(LocalBridgeClazz, "JOB_END_NOTIFICATION_POLICY_REMOVE"); _JOB_END_NOTIFICATION_POLICY_REMOVEReady = true; } return _JOB_END_NOTIFICATION_POLICY_REMOVEContent; } }
        private static int _JOB_END_NOTIFICATION_POLICY_REMOVEContent = default;
        private static bool _JOB_END_NOTIFICATION_POLICY_REMOVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#PERMISSION_BIND"/>
        /// </summary>
        public static Java.Lang.String PERMISSION_BIND { get { if (!_PERMISSION_BINDReady) { _PERMISSION_BINDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PERMISSION_BIND"); _PERMISSION_BINDReady = true; } return _PERMISSION_BINDContent; } }
        private static Java.Lang.String _PERMISSION_BINDContent = default;
        private static bool _PERMISSION_BINDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#onStartJob(android.app.job.JobParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnStartJob(Android.App.Job.JobParameters arg0)
        {
            return IExecuteWithSignature<bool>("onStartJob", "(Landroid/app/job/JobParameters;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#onStopJob(android.app.job.JobParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnStopJob(Android.App.Job.JobParameters arg0)
        {
            return IExecuteWithSignature<bool>("onStopJob", "(Landroid/app/job/JobParameters;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#jobFinished(android.app.job.JobParameters,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void JobFinished(Android.App.Job.JobParameters arg0, bool arg1)
        {
            IExecute("jobFinished", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#setNotification(android.app.job.JobParameters,int,android.app.Notification,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.App.Notification"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetNotification(Android.App.Job.JobParameters arg0, int arg1, Android.App.Notification arg2, int arg3)
        {
            IExecute("setNotification", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#updateEstimatedNetworkBytes(android.app.job.JobParameters,android.app.job.JobWorkItem,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <param name="arg1"><see cref="Android.App.Job.JobWorkItem"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public void UpdateEstimatedNetworkBytes(Android.App.Job.JobParameters arg0, Android.App.Job.JobWorkItem arg1, long arg2, long arg3)
        {
            IExecute("updateEstimatedNetworkBytes", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#updateEstimatedNetworkBytes(android.app.job.JobParameters,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void UpdateEstimatedNetworkBytes(Android.App.Job.JobParameters arg0, long arg1, long arg2)
        {
            IExecute("updateEstimatedNetworkBytes", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#updateTransferredNetworkBytes(android.app.job.JobParameters,android.app.job.JobWorkItem,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <param name="arg1"><see cref="Android.App.Job.JobWorkItem"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public void UpdateTransferredNetworkBytes(Android.App.Job.JobParameters arg0, Android.App.Job.JobWorkItem arg1, long arg2, long arg3)
        {
            IExecute("updateTransferredNetworkBytes", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#updateTransferredNetworkBytes(android.app.job.JobParameters,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void UpdateTransferredNetworkBytes(Android.App.Job.JobParameters arg0, long arg1, long arg2)
        {
            IExecute("updateTransferredNetworkBytes", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobService.html#onNetworkChanged(android.app.job.JobParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobParameters"/></param>
        public void OnNetworkChanged(Android.App.Job.JobParameters arg0)
        {
            IExecuteWithSignature("onNetworkChanged", "(Landroid/app/job/JobParameters;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}