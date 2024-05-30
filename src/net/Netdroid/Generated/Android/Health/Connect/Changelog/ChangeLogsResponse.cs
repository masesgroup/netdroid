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

namespace Android.Health.Connect.Changelog
{
    #region ChangeLogsResponse
    public partial class ChangeLogsResponse
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsResponse.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsResponse.html#getDeletedLogs()"/> 
        /// </summary>
        public Java.Util.List<Android.Health.Connect.Changelog.ChangeLogsResponse.DeletedLog> DeletedLogs
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Health.Connect.Changelog.ChangeLogsResponse.DeletedLog>>("getDeletedLogs", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsResponse.html#getNextChangesToken()"/> 
        /// </summary>
        public Java.Lang.String NextChangesToken
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNextChangesToken", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsResponse.html#getUpsertedRecords()"/> 
        /// </summary>
        public Java.Util.List<Android.Health.Connect.Datatypes.Record> UpsertedRecords
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Health.Connect.Datatypes.Record>>("getUpsertedRecords", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsResponse.html#hasMorePages()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMorePages()
        {
            return IExecuteWithSignature<bool>("hasMorePages", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsResponse.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsResponse.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region DeletedLog
        public partial class DeletedLog
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsResponse.DeletedLog.html#%3Cinit%3E(java.lang.String,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            public DeletedLog(Java.Lang.String arg0, long arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsResponse.DeletedLog.html#getDeletedRecordId()"/> 
            /// </summary>
            public Java.Lang.String DeletedRecordId
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getDeletedRecordId", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/changelog/ChangeLogsResponse.DeletedLog.html#getDeletedTime()"/> 
            /// </summary>
            public Java.Time.Instant DeletedTime
            {
                get { return IExecuteWithSignature<Java.Time.Instant>("getDeletedTime", "()Ljava/time/Instant;"); }
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