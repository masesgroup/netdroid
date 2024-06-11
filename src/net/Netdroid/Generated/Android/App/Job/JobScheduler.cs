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

namespace Android.App.Job
{
    #region JobScheduler
    public partial class JobScheduler
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_APP"/>
        /// </summary>
        public static int PENDING_JOB_REASON_APP { get { if (!_PENDING_JOB_REASON_APPReady) { _PENDING_JOB_REASON_APPContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_APP"); _PENDING_JOB_REASON_APPReady = true; } return _PENDING_JOB_REASON_APPContent; } }
        private static int _PENDING_JOB_REASON_APPContent = default;
        private static bool _PENDING_JOB_REASON_APPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_APP_STANDBY"/>
        /// </summary>
        public static int PENDING_JOB_REASON_APP_STANDBY { get { if (!_PENDING_JOB_REASON_APP_STANDBYReady) { _PENDING_JOB_REASON_APP_STANDBYContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_APP_STANDBY"); _PENDING_JOB_REASON_APP_STANDBYReady = true; } return _PENDING_JOB_REASON_APP_STANDBYContent; } }
        private static int _PENDING_JOB_REASON_APP_STANDBYContent = default;
        private static bool _PENDING_JOB_REASON_APP_STANDBYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_BACKGROUND_RESTRICTION"/>
        /// </summary>
        public static int PENDING_JOB_REASON_BACKGROUND_RESTRICTION { get { if (!_PENDING_JOB_REASON_BACKGROUND_RESTRICTIONReady) { _PENDING_JOB_REASON_BACKGROUND_RESTRICTIONContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_BACKGROUND_RESTRICTION"); _PENDING_JOB_REASON_BACKGROUND_RESTRICTIONReady = true; } return _PENDING_JOB_REASON_BACKGROUND_RESTRICTIONContent; } }
        private static int _PENDING_JOB_REASON_BACKGROUND_RESTRICTIONContent = default;
        private static bool _PENDING_JOB_REASON_BACKGROUND_RESTRICTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_CONSTRAINT_BATTERY_NOT_LOW"/>
        /// </summary>
        public static int PENDING_JOB_REASON_CONSTRAINT_BATTERY_NOT_LOW { get { if (!_PENDING_JOB_REASON_CONSTRAINT_BATTERY_NOT_LOWReady) { _PENDING_JOB_REASON_CONSTRAINT_BATTERY_NOT_LOWContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_CONSTRAINT_BATTERY_NOT_LOW"); _PENDING_JOB_REASON_CONSTRAINT_BATTERY_NOT_LOWReady = true; } return _PENDING_JOB_REASON_CONSTRAINT_BATTERY_NOT_LOWContent; } }
        private static int _PENDING_JOB_REASON_CONSTRAINT_BATTERY_NOT_LOWContent = default;
        private static bool _PENDING_JOB_REASON_CONSTRAINT_BATTERY_NOT_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_CONSTRAINT_CHARGING"/>
        /// </summary>
        public static int PENDING_JOB_REASON_CONSTRAINT_CHARGING { get { if (!_PENDING_JOB_REASON_CONSTRAINT_CHARGINGReady) { _PENDING_JOB_REASON_CONSTRAINT_CHARGINGContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_CONSTRAINT_CHARGING"); _PENDING_JOB_REASON_CONSTRAINT_CHARGINGReady = true; } return _PENDING_JOB_REASON_CONSTRAINT_CHARGINGContent; } }
        private static int _PENDING_JOB_REASON_CONSTRAINT_CHARGINGContent = default;
        private static bool _PENDING_JOB_REASON_CONSTRAINT_CHARGINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_CONSTRAINT_CONNECTIVITY"/>
        /// </summary>
        public static int PENDING_JOB_REASON_CONSTRAINT_CONNECTIVITY { get { if (!_PENDING_JOB_REASON_CONSTRAINT_CONNECTIVITYReady) { _PENDING_JOB_REASON_CONSTRAINT_CONNECTIVITYContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_CONSTRAINT_CONNECTIVITY"); _PENDING_JOB_REASON_CONSTRAINT_CONNECTIVITYReady = true; } return _PENDING_JOB_REASON_CONSTRAINT_CONNECTIVITYContent; } }
        private static int _PENDING_JOB_REASON_CONSTRAINT_CONNECTIVITYContent = default;
        private static bool _PENDING_JOB_REASON_CONSTRAINT_CONNECTIVITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_CONSTRAINT_CONTENT_TRIGGER"/>
        /// </summary>
        public static int PENDING_JOB_REASON_CONSTRAINT_CONTENT_TRIGGER { get { if (!_PENDING_JOB_REASON_CONSTRAINT_CONTENT_TRIGGERReady) { _PENDING_JOB_REASON_CONSTRAINT_CONTENT_TRIGGERContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_CONSTRAINT_CONTENT_TRIGGER"); _PENDING_JOB_REASON_CONSTRAINT_CONTENT_TRIGGERReady = true; } return _PENDING_JOB_REASON_CONSTRAINT_CONTENT_TRIGGERContent; } }
        private static int _PENDING_JOB_REASON_CONSTRAINT_CONTENT_TRIGGERContent = default;
        private static bool _PENDING_JOB_REASON_CONSTRAINT_CONTENT_TRIGGERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_CONSTRAINT_DEVICE_IDLE"/>
        /// </summary>
        public static int PENDING_JOB_REASON_CONSTRAINT_DEVICE_IDLE { get { if (!_PENDING_JOB_REASON_CONSTRAINT_DEVICE_IDLEReady) { _PENDING_JOB_REASON_CONSTRAINT_DEVICE_IDLEContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_CONSTRAINT_DEVICE_IDLE"); _PENDING_JOB_REASON_CONSTRAINT_DEVICE_IDLEReady = true; } return _PENDING_JOB_REASON_CONSTRAINT_DEVICE_IDLEContent; } }
        private static int _PENDING_JOB_REASON_CONSTRAINT_DEVICE_IDLEContent = default;
        private static bool _PENDING_JOB_REASON_CONSTRAINT_DEVICE_IDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_CONSTRAINT_MINIMUM_LATENCY"/>
        /// </summary>
        public static int PENDING_JOB_REASON_CONSTRAINT_MINIMUM_LATENCY { get { if (!_PENDING_JOB_REASON_CONSTRAINT_MINIMUM_LATENCYReady) { _PENDING_JOB_REASON_CONSTRAINT_MINIMUM_LATENCYContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_CONSTRAINT_MINIMUM_LATENCY"); _PENDING_JOB_REASON_CONSTRAINT_MINIMUM_LATENCYReady = true; } return _PENDING_JOB_REASON_CONSTRAINT_MINIMUM_LATENCYContent; } }
        private static int _PENDING_JOB_REASON_CONSTRAINT_MINIMUM_LATENCYContent = default;
        private static bool _PENDING_JOB_REASON_CONSTRAINT_MINIMUM_LATENCYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_CONSTRAINT_PREFETCH"/>
        /// </summary>
        public static int PENDING_JOB_REASON_CONSTRAINT_PREFETCH { get { if (!_PENDING_JOB_REASON_CONSTRAINT_PREFETCHReady) { _PENDING_JOB_REASON_CONSTRAINT_PREFETCHContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_CONSTRAINT_PREFETCH"); _PENDING_JOB_REASON_CONSTRAINT_PREFETCHReady = true; } return _PENDING_JOB_REASON_CONSTRAINT_PREFETCHContent; } }
        private static int _PENDING_JOB_REASON_CONSTRAINT_PREFETCHContent = default;
        private static bool _PENDING_JOB_REASON_CONSTRAINT_PREFETCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_CONSTRAINT_STORAGE_NOT_LOW"/>
        /// </summary>
        public static int PENDING_JOB_REASON_CONSTRAINT_STORAGE_NOT_LOW { get { if (!_PENDING_JOB_REASON_CONSTRAINT_STORAGE_NOT_LOWReady) { _PENDING_JOB_REASON_CONSTRAINT_STORAGE_NOT_LOWContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_CONSTRAINT_STORAGE_NOT_LOW"); _PENDING_JOB_REASON_CONSTRAINT_STORAGE_NOT_LOWReady = true; } return _PENDING_JOB_REASON_CONSTRAINT_STORAGE_NOT_LOWContent; } }
        private static int _PENDING_JOB_REASON_CONSTRAINT_STORAGE_NOT_LOWContent = default;
        private static bool _PENDING_JOB_REASON_CONSTRAINT_STORAGE_NOT_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_DEVICE_STATE"/>
        /// </summary>
        public static int PENDING_JOB_REASON_DEVICE_STATE { get { if (!_PENDING_JOB_REASON_DEVICE_STATEReady) { _PENDING_JOB_REASON_DEVICE_STATEContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_DEVICE_STATE"); _PENDING_JOB_REASON_DEVICE_STATEReady = true; } return _PENDING_JOB_REASON_DEVICE_STATEContent; } }
        private static int _PENDING_JOB_REASON_DEVICE_STATEContent = default;
        private static bool _PENDING_JOB_REASON_DEVICE_STATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_EXECUTING"/>
        /// </summary>
        public static int PENDING_JOB_REASON_EXECUTING { get { if (!_PENDING_JOB_REASON_EXECUTINGReady) { _PENDING_JOB_REASON_EXECUTINGContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_EXECUTING"); _PENDING_JOB_REASON_EXECUTINGReady = true; } return _PENDING_JOB_REASON_EXECUTINGContent; } }
        private static int _PENDING_JOB_REASON_EXECUTINGContent = default;
        private static bool _PENDING_JOB_REASON_EXECUTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_INVALID_JOB_ID"/>
        /// </summary>
        public static int PENDING_JOB_REASON_INVALID_JOB_ID { get { if (!_PENDING_JOB_REASON_INVALID_JOB_IDReady) { _PENDING_JOB_REASON_INVALID_JOB_IDContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_INVALID_JOB_ID"); _PENDING_JOB_REASON_INVALID_JOB_IDReady = true; } return _PENDING_JOB_REASON_INVALID_JOB_IDContent; } }
        private static int _PENDING_JOB_REASON_INVALID_JOB_IDContent = default;
        private static bool _PENDING_JOB_REASON_INVALID_JOB_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_JOB_SCHEDULER_OPTIMIZATION"/>
        /// </summary>
        public static int PENDING_JOB_REASON_JOB_SCHEDULER_OPTIMIZATION { get { if (!_PENDING_JOB_REASON_JOB_SCHEDULER_OPTIMIZATIONReady) { _PENDING_JOB_REASON_JOB_SCHEDULER_OPTIMIZATIONContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_JOB_SCHEDULER_OPTIMIZATION"); _PENDING_JOB_REASON_JOB_SCHEDULER_OPTIMIZATIONReady = true; } return _PENDING_JOB_REASON_JOB_SCHEDULER_OPTIMIZATIONContent; } }
        private static int _PENDING_JOB_REASON_JOB_SCHEDULER_OPTIMIZATIONContent = default;
        private static bool _PENDING_JOB_REASON_JOB_SCHEDULER_OPTIMIZATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_QUOTA"/>
        /// </summary>
        public static int PENDING_JOB_REASON_QUOTA { get { if (!_PENDING_JOB_REASON_QUOTAReady) { _PENDING_JOB_REASON_QUOTAContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_QUOTA"); _PENDING_JOB_REASON_QUOTAReady = true; } return _PENDING_JOB_REASON_QUOTAContent; } }
        private static int _PENDING_JOB_REASON_QUOTAContent = default;
        private static bool _PENDING_JOB_REASON_QUOTAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_UNDEFINED"/>
        /// </summary>
        public static int PENDING_JOB_REASON_UNDEFINED { get { if (!_PENDING_JOB_REASON_UNDEFINEDReady) { _PENDING_JOB_REASON_UNDEFINEDContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_UNDEFINED"); _PENDING_JOB_REASON_UNDEFINEDReady = true; } return _PENDING_JOB_REASON_UNDEFINEDContent; } }
        private static int _PENDING_JOB_REASON_UNDEFINEDContent = default;
        private static bool _PENDING_JOB_REASON_UNDEFINEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#PENDING_JOB_REASON_USER"/>
        /// </summary>
        public static int PENDING_JOB_REASON_USER { get { if (!_PENDING_JOB_REASON_USERReady) { _PENDING_JOB_REASON_USERContent = SGetField<int>(LocalBridgeClazz, "PENDING_JOB_REASON_USER"); _PENDING_JOB_REASON_USERReady = true; } return _PENDING_JOB_REASON_USERContent; } }
        private static int _PENDING_JOB_REASON_USERContent = default;
        private static bool _PENDING_JOB_REASON_USERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#RESULT_FAILURE"/>
        /// </summary>
        public static int RESULT_FAILURE { get { if (!_RESULT_FAILUREReady) { _RESULT_FAILUREContent = SGetField<int>(LocalBridgeClazz, "RESULT_FAILURE"); _RESULT_FAILUREReady = true; } return _RESULT_FAILUREContent; } }
        private static int _RESULT_FAILUREContent = default;
        private static bool _RESULT_FAILUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#RESULT_SUCCESS"/>
        /// </summary>
        public static int RESULT_SUCCESS { get { if (!_RESULT_SUCCESSReady) { _RESULT_SUCCESSContent = SGetField<int>(LocalBridgeClazz, "RESULT_SUCCESS"); _RESULT_SUCCESSReady = true; } return _RESULT_SUCCESSContent; } }
        private static int _RESULT_SUCCESSContent = default;
        private static bool _RESULT_SUCCESSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#getPendingJob(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.Job.JobInfo"/></returns>
        public Android.App.Job.JobInfo GetPendingJob(int arg0)
        {
            return IExecuteWithSignature<Android.App.Job.JobInfo>("getPendingJob", "(I)Landroid/app/job/JobInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#enqueue(android.app.job.JobInfo,android.app.job.JobWorkItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobInfo"/></param>
        /// <param name="arg1"><see cref="Android.App.Job.JobWorkItem"/></param>
        /// <returns><see cref="int"/></returns>
        public int Enqueue(Android.App.Job.JobInfo arg0, Android.App.Job.JobWorkItem arg1)
        {
            return IExecute<int>("enqueue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#schedule(android.app.job.JobInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobInfo"/></param>
        /// <returns><see cref="int"/></returns>
        public int Schedule(Android.App.Job.JobInfo arg0)
        {
            return IExecuteWithSignature<int>("schedule", "(Landroid/app/job/JobInfo;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#getAllPendingJobs()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.Job.JobInfo> GetAllPendingJobs()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.Job.JobInfo>>("getAllPendingJobs", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#cancel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Cancel(int arg0)
        {
            IExecuteWithSignature("cancel", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#cancelAll()"/>
        /// </summary>
        public void CancelAll()
        {
            IExecuteWithSignature("cancelAll", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#forNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.Job.JobScheduler"/></returns>
        public Android.App.Job.JobScheduler ForNamespace(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.App.Job.JobScheduler>("forNamespace", "(Ljava/lang/String;)Landroid/app/job/JobScheduler;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#canRunUserInitiatedJobs()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanRunUserInitiatedJobs()
        {
            return IExecuteWithSignature<bool>("canRunUserInitiatedJobs", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#getPendingJobReason(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetPendingJobReason(int arg0)
        {
            return IExecuteWithSignature<int>("getPendingJobReason", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#getNamespace()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNamespace()
        {
            return IExecuteWithSignature<Java.Lang.String>("getNamespace", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#getPendingJobsInAllNamespaces()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Util.List<Android.App.Job.JobInfo>> GetPendingJobsInAllNamespaces()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.List<Android.App.Job.JobInfo>>>("getPendingJobsInAllNamespaces", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobScheduler.html#cancelInAllNamespaces()"/>
        /// </summary>
        public void CancelInAllNamespaces()
        {
            IExecuteWithSignature("cancelInAllNamespaces", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}