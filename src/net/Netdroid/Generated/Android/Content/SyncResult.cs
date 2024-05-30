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

namespace Android.Content
{
    #region SyncResult
    public partial class SyncResult
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#databaseError"/>
        /// </summary>
        public bool databaseError { get { return IGetField<bool>("databaseError"); } set { ISetField("databaseError", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#fullSyncRequested"/>
        /// </summary>
        public bool fullSyncRequested { get { return IGetField<bool>("fullSyncRequested"); } set { ISetField("fullSyncRequested", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#moreRecordsToGet"/>
        /// </summary>
        public bool moreRecordsToGet { get { return IGetField<bool>("moreRecordsToGet"); } set { ISetField("moreRecordsToGet", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#partialSyncUnavailable"/>
        /// </summary>
        public bool partialSyncUnavailable { get { return IGetField<bool>("partialSyncUnavailable"); } set { ISetField("partialSyncUnavailable", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#tooManyDeletions"/>
        /// </summary>
        public bool tooManyDeletions { get { return IGetField<bool>("tooManyDeletions"); } set { ISetField("tooManyDeletions", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#tooManyRetries"/>
        /// </summary>
        public bool tooManyRetries { get { return IGetField<bool>("tooManyRetries"); } set { ISetField("tooManyRetries", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#stats"/>
        /// </summary>
        public Android.Content.SyncStats stats { get { if (!_statsReady) { _statsContent = IGetField<Android.Content.SyncStats>("stats"); _statsReady = true; } return _statsContent; } }
        private Android.Content.SyncStats _statsContent = default;
        private bool _statsReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#syncAlreadyInProgress"/>
        /// </summary>
        public bool syncAlreadyInProgress { get { if (!_syncAlreadyInProgressReady) { _syncAlreadyInProgressContent = IGetField<bool>("syncAlreadyInProgress"); _syncAlreadyInProgressReady = true; } return _syncAlreadyInProgressContent; } }
        private bool _syncAlreadyInProgressContent = default;
        private bool _syncAlreadyInProgressReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#delayUntil"/>
        /// </summary>
        public long delayUntil { get { return IGetField<long>("delayUntil"); } set { ISetField("delayUntil", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#ALREADY_IN_PROGRESS"/>
        /// </summary>
        public static Android.Content.SyncResult ALREADY_IN_PROGRESS { get { if (!_ALREADY_IN_PROGRESSReady) { _ALREADY_IN_PROGRESSContent = SGetField<Android.Content.SyncResult>(LocalBridgeClazz, "ALREADY_IN_PROGRESS"); _ALREADY_IN_PROGRESSReady = true; } return _ALREADY_IN_PROGRESSContent; } }
        private static Android.Content.SyncResult _ALREADY_IN_PROGRESSContent = default;
        private static bool _ALREADY_IN_PROGRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#hasError()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasError()
        {
            return IExecuteWithSignature<bool>("hasError", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#hasHardError()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasHardError()
        {
            return IExecuteWithSignature<bool>("hasHardError", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#hasSoftError()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasSoftError()
        {
            return IExecuteWithSignature<bool>("hasSoftError", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#madeSomeProgress()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool MadeSomeProgress()
        {
            return IExecuteWithSignature<bool>("madeSomeProgress", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#toDebugString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToDebugString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toDebugString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncResult.html#writeToParcel(android.os.Parcel,int)"/>
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