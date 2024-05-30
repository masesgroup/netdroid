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

namespace Android.App.Job
{
    #region JobParameters
    public partial class JobParameters
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_APP_STANDBY"/>
        /// </summary>
        public static int STOP_REASON_APP_STANDBY { get { if (!_STOP_REASON_APP_STANDBYReady) { _STOP_REASON_APP_STANDBYContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_APP_STANDBY"); _STOP_REASON_APP_STANDBYReady = true; } return _STOP_REASON_APP_STANDBYContent; } }
        private static int _STOP_REASON_APP_STANDBYContent = default;
        private static bool _STOP_REASON_APP_STANDBYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_BACKGROUND_RESTRICTION"/>
        /// </summary>
        public static int STOP_REASON_BACKGROUND_RESTRICTION { get { if (!_STOP_REASON_BACKGROUND_RESTRICTIONReady) { _STOP_REASON_BACKGROUND_RESTRICTIONContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_BACKGROUND_RESTRICTION"); _STOP_REASON_BACKGROUND_RESTRICTIONReady = true; } return _STOP_REASON_BACKGROUND_RESTRICTIONContent; } }
        private static int _STOP_REASON_BACKGROUND_RESTRICTIONContent = default;
        private static bool _STOP_REASON_BACKGROUND_RESTRICTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_CANCELLED_BY_APP"/>
        /// </summary>
        public static int STOP_REASON_CANCELLED_BY_APP { get { if (!_STOP_REASON_CANCELLED_BY_APPReady) { _STOP_REASON_CANCELLED_BY_APPContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_CANCELLED_BY_APP"); _STOP_REASON_CANCELLED_BY_APPReady = true; } return _STOP_REASON_CANCELLED_BY_APPContent; } }
        private static int _STOP_REASON_CANCELLED_BY_APPContent = default;
        private static bool _STOP_REASON_CANCELLED_BY_APPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_CONSTRAINT_BATTERY_NOT_LOW"/>
        /// </summary>
        public static int STOP_REASON_CONSTRAINT_BATTERY_NOT_LOW { get { if (!_STOP_REASON_CONSTRAINT_BATTERY_NOT_LOWReady) { _STOP_REASON_CONSTRAINT_BATTERY_NOT_LOWContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_CONSTRAINT_BATTERY_NOT_LOW"); _STOP_REASON_CONSTRAINT_BATTERY_NOT_LOWReady = true; } return _STOP_REASON_CONSTRAINT_BATTERY_NOT_LOWContent; } }
        private static int _STOP_REASON_CONSTRAINT_BATTERY_NOT_LOWContent = default;
        private static bool _STOP_REASON_CONSTRAINT_BATTERY_NOT_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_CONSTRAINT_CHARGING"/>
        /// </summary>
        public static int STOP_REASON_CONSTRAINT_CHARGING { get { if (!_STOP_REASON_CONSTRAINT_CHARGINGReady) { _STOP_REASON_CONSTRAINT_CHARGINGContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_CONSTRAINT_CHARGING"); _STOP_REASON_CONSTRAINT_CHARGINGReady = true; } return _STOP_REASON_CONSTRAINT_CHARGINGContent; } }
        private static int _STOP_REASON_CONSTRAINT_CHARGINGContent = default;
        private static bool _STOP_REASON_CONSTRAINT_CHARGINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_CONSTRAINT_CONNECTIVITY"/>
        /// </summary>
        public static int STOP_REASON_CONSTRAINT_CONNECTIVITY { get { if (!_STOP_REASON_CONSTRAINT_CONNECTIVITYReady) { _STOP_REASON_CONSTRAINT_CONNECTIVITYContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_CONSTRAINT_CONNECTIVITY"); _STOP_REASON_CONSTRAINT_CONNECTIVITYReady = true; } return _STOP_REASON_CONSTRAINT_CONNECTIVITYContent; } }
        private static int _STOP_REASON_CONSTRAINT_CONNECTIVITYContent = default;
        private static bool _STOP_REASON_CONSTRAINT_CONNECTIVITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_CONSTRAINT_DEVICE_IDLE"/>
        /// </summary>
        public static int STOP_REASON_CONSTRAINT_DEVICE_IDLE { get { if (!_STOP_REASON_CONSTRAINT_DEVICE_IDLEReady) { _STOP_REASON_CONSTRAINT_DEVICE_IDLEContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_CONSTRAINT_DEVICE_IDLE"); _STOP_REASON_CONSTRAINT_DEVICE_IDLEReady = true; } return _STOP_REASON_CONSTRAINT_DEVICE_IDLEContent; } }
        private static int _STOP_REASON_CONSTRAINT_DEVICE_IDLEContent = default;
        private static bool _STOP_REASON_CONSTRAINT_DEVICE_IDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_CONSTRAINT_STORAGE_NOT_LOW"/>
        /// </summary>
        public static int STOP_REASON_CONSTRAINT_STORAGE_NOT_LOW { get { if (!_STOP_REASON_CONSTRAINT_STORAGE_NOT_LOWReady) { _STOP_REASON_CONSTRAINT_STORAGE_NOT_LOWContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_CONSTRAINT_STORAGE_NOT_LOW"); _STOP_REASON_CONSTRAINT_STORAGE_NOT_LOWReady = true; } return _STOP_REASON_CONSTRAINT_STORAGE_NOT_LOWContent; } }
        private static int _STOP_REASON_CONSTRAINT_STORAGE_NOT_LOWContent = default;
        private static bool _STOP_REASON_CONSTRAINT_STORAGE_NOT_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_DEVICE_STATE"/>
        /// </summary>
        public static int STOP_REASON_DEVICE_STATE { get { if (!_STOP_REASON_DEVICE_STATEReady) { _STOP_REASON_DEVICE_STATEContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_DEVICE_STATE"); _STOP_REASON_DEVICE_STATEReady = true; } return _STOP_REASON_DEVICE_STATEContent; } }
        private static int _STOP_REASON_DEVICE_STATEContent = default;
        private static bool _STOP_REASON_DEVICE_STATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_ESTIMATED_APP_LAUNCH_TIME_CHANGED"/>
        /// </summary>
        public static int STOP_REASON_ESTIMATED_APP_LAUNCH_TIME_CHANGED { get { if (!_STOP_REASON_ESTIMATED_APP_LAUNCH_TIME_CHANGEDReady) { _STOP_REASON_ESTIMATED_APP_LAUNCH_TIME_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_ESTIMATED_APP_LAUNCH_TIME_CHANGED"); _STOP_REASON_ESTIMATED_APP_LAUNCH_TIME_CHANGEDReady = true; } return _STOP_REASON_ESTIMATED_APP_LAUNCH_TIME_CHANGEDContent; } }
        private static int _STOP_REASON_ESTIMATED_APP_LAUNCH_TIME_CHANGEDContent = default;
        private static bool _STOP_REASON_ESTIMATED_APP_LAUNCH_TIME_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_PREEMPT"/>
        /// </summary>
        public static int STOP_REASON_PREEMPT { get { if (!_STOP_REASON_PREEMPTReady) { _STOP_REASON_PREEMPTContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_PREEMPT"); _STOP_REASON_PREEMPTReady = true; } return _STOP_REASON_PREEMPTContent; } }
        private static int _STOP_REASON_PREEMPTContent = default;
        private static bool _STOP_REASON_PREEMPTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_QUOTA"/>
        /// </summary>
        public static int STOP_REASON_QUOTA { get { if (!_STOP_REASON_QUOTAReady) { _STOP_REASON_QUOTAContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_QUOTA"); _STOP_REASON_QUOTAReady = true; } return _STOP_REASON_QUOTAContent; } }
        private static int _STOP_REASON_QUOTAContent = default;
        private static bool _STOP_REASON_QUOTAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_SYSTEM_PROCESSING"/>
        /// </summary>
        public static int STOP_REASON_SYSTEM_PROCESSING { get { if (!_STOP_REASON_SYSTEM_PROCESSINGReady) { _STOP_REASON_SYSTEM_PROCESSINGContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_SYSTEM_PROCESSING"); _STOP_REASON_SYSTEM_PROCESSINGReady = true; } return _STOP_REASON_SYSTEM_PROCESSINGContent; } }
        private static int _STOP_REASON_SYSTEM_PROCESSINGContent = default;
        private static bool _STOP_REASON_SYSTEM_PROCESSINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_TIMEOUT"/>
        /// </summary>
        public static int STOP_REASON_TIMEOUT { get { if (!_STOP_REASON_TIMEOUTReady) { _STOP_REASON_TIMEOUTContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_TIMEOUT"); _STOP_REASON_TIMEOUTReady = true; } return _STOP_REASON_TIMEOUTContent; } }
        private static int _STOP_REASON_TIMEOUTContent = default;
        private static bool _STOP_REASON_TIMEOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_UNDEFINED"/>
        /// </summary>
        public static int STOP_REASON_UNDEFINED { get { if (!_STOP_REASON_UNDEFINEDReady) { _STOP_REASON_UNDEFINEDContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_UNDEFINED"); _STOP_REASON_UNDEFINEDReady = true; } return _STOP_REASON_UNDEFINEDContent; } }
        private static int _STOP_REASON_UNDEFINEDContent = default;
        private static bool _STOP_REASON_UNDEFINEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#STOP_REASON_USER"/>
        /// </summary>
        public static int STOP_REASON_USER { get { if (!_STOP_REASON_USERReady) { _STOP_REASON_USERContent = SGetField<int>(LocalBridgeClazz, "STOP_REASON_USER"); _STOP_REASON_USERReady = true; } return _STOP_REASON_USERContent; } }
        private static int _STOP_REASON_USERContent = default;
        private static bool _STOP_REASON_USERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#getClipData()"/> 
        /// </summary>
        public Android.Content.ClipData ClipData
        {
            get { return IExecuteWithSignature<Android.Content.ClipData>("getClipData", "()Landroid/content/ClipData;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#getClipGrantFlags()"/> 
        /// </summary>
        public int ClipGrantFlags
        {
            get { return IExecuteWithSignature<int>("getClipGrantFlags", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#getExtras()"/> 
        /// </summary>
        public Android.Os.PersistableBundle Extras
        {
            get { return IExecuteWithSignature<Android.Os.PersistableBundle>("getExtras", "()Landroid/os/PersistableBundle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#getJobId()"/> 
        /// </summary>
        public int JobId
        {
            get { return IExecuteWithSignature<int>("getJobId", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#getJobNamespace()"/> 
        /// </summary>
        public Java.Lang.String JobNamespace
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getJobNamespace", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#getNetwork()"/> 
        /// </summary>
        public Android.Net.Network Network
        {
            get { return IExecuteWithSignature<Android.Net.Network>("getNetwork", "()Landroid/net/Network;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#getStopReason()"/> 
        /// </summary>
        public int StopReason
        {
            get { return IExecuteWithSignature<int>("getStopReason", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#getTransientExtras()"/> 
        /// </summary>
        public Android.Os.Bundle TransientExtras
        {
            get { return IExecuteWithSignature<Android.Os.Bundle>("getTransientExtras", "()Landroid/os/Bundle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#getTriggeredContentAuthorities()"/> 
        /// </summary>
        public Java.Lang.String[] TriggeredContentAuthorities
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getTriggeredContentAuthorities", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#getTriggeredContentUris()"/> 
        /// </summary>
        public Android.Net.Uri[] TriggeredContentUris
        {
            get { return IExecuteWithSignatureArray<Android.Net.Uri>("getTriggeredContentUris", "()[Landroid/net/Uri;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#dequeueWork()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Job.JobWorkItem"/></returns>
        public Android.App.Job.JobWorkItem DequeueWork()
        {
            return IExecuteWithSignature<Android.App.Job.JobWorkItem>("dequeueWork", "()Landroid/app/job/JobWorkItem;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#isExpeditedJob()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsExpeditedJob()
        {
            return IExecuteWithSignature<bool>("isExpeditedJob", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#isOverrideDeadlineExpired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOverrideDeadlineExpired()
        {
            return IExecuteWithSignature<bool>("isOverrideDeadlineExpired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#isUserInitiatedJob()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserInitiatedJob()
        {
            return IExecuteWithSignature<bool>("isUserInitiatedJob", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#completeWork(android.app.job.JobWorkItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Job.JobWorkItem"/></param>
        public void CompleteWork(Android.App.Job.JobWorkItem arg0)
        {
            IExecuteWithSignature("completeWork", "(Landroid/app/job/JobWorkItem;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/job/JobParameters.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}