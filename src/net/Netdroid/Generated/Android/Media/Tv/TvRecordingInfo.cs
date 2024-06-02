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

namespace Android.Media.Tv
{
    #region TvRecordingInfo
    public partial class TvRecordingInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#%3Cinit%3E(java.lang.String,long,long,int,java.lang.String,java.lang.String,long,long,android.net.Uri,android.net.Uri,java.util.List,android.net.Uri,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <param name="arg6"><see cref="long"/></param>
        /// <param name="arg7"><see cref="long"/></param>
        /// <param name="arg8"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg9"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg10"><see cref="Java.Util.List"/></param>
        /// <param name="arg11"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg12"><see cref="long"/></param>
        /// <param name="arg13"><see cref="long"/></param>
        public TvRecordingInfo(Java.Lang.String arg0, long arg1, long arg2, int arg3, Java.Lang.String arg4, Java.Lang.String arg5, long arg6, long arg7, Android.Net.Uri arg8, Android.Net.Uri arg9, Java.Util.List<Android.Media.Tv.TvContentRating> arg10, Android.Net.Uri arg11, long arg12, long arg13)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#FRIDAY"/>
        /// </summary>
        public static int FRIDAY { get { if (!_FRIDAYReady) { _FRIDAYContent = SGetField<int>(LocalBridgeClazz, "FRIDAY"); _FRIDAYReady = true; } return _FRIDAYContent; } }
        private static int _FRIDAYContent = default;
        private static bool _FRIDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#MONDAY"/>
        /// </summary>
        public static int MONDAY { get { if (!_MONDAYReady) { _MONDAYContent = SGetField<int>(LocalBridgeClazz, "MONDAY"); _MONDAYReady = true; } return _MONDAYContent; } }
        private static int _MONDAYContent = default;
        private static bool _MONDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#RECORDING_ALL"/>
        /// </summary>
        public static int RECORDING_ALL { get { if (!_RECORDING_ALLReady) { _RECORDING_ALLContent = SGetField<int>(LocalBridgeClazz, "RECORDING_ALL"); _RECORDING_ALLReady = true; } return _RECORDING_ALLContent; } }
        private static int _RECORDING_ALLContent = default;
        private static bool _RECORDING_ALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#RECORDING_IN_PROGRESS"/>
        /// </summary>
        public static int RECORDING_IN_PROGRESS { get { if (!_RECORDING_IN_PROGRESSReady) { _RECORDING_IN_PROGRESSContent = SGetField<int>(LocalBridgeClazz, "RECORDING_IN_PROGRESS"); _RECORDING_IN_PROGRESSReady = true; } return _RECORDING_IN_PROGRESSContent; } }
        private static int _RECORDING_IN_PROGRESSContent = default;
        private static bool _RECORDING_IN_PROGRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#RECORDING_SCHEDULED"/>
        /// </summary>
        public static int RECORDING_SCHEDULED { get { if (!_RECORDING_SCHEDULEDReady) { _RECORDING_SCHEDULEDContent = SGetField<int>(LocalBridgeClazz, "RECORDING_SCHEDULED"); _RECORDING_SCHEDULEDReady = true; } return _RECORDING_SCHEDULEDContent; } }
        private static int _RECORDING_SCHEDULEDContent = default;
        private static bool _RECORDING_SCHEDULEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#SATURDAY"/>
        /// </summary>
        public static int SATURDAY { get { if (!_SATURDAYReady) { _SATURDAYContent = SGetField<int>(LocalBridgeClazz, "SATURDAY"); _SATURDAYReady = true; } return _SATURDAYContent; } }
        private static int _SATURDAYContent = default;
        private static bool _SATURDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#SUNDAY"/>
        /// </summary>
        public static int SUNDAY { get { if (!_SUNDAYReady) { _SUNDAYContent = SGetField<int>(LocalBridgeClazz, "SUNDAY"); _SUNDAYReady = true; } return _SUNDAYContent; } }
        private static int _SUNDAYContent = default;
        private static bool _SUNDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#THURSDAY"/>
        /// </summary>
        public static int THURSDAY { get { if (!_THURSDAYReady) { _THURSDAYContent = SGetField<int>(LocalBridgeClazz, "THURSDAY"); _THURSDAYReady = true; } return _THURSDAYContent; } }
        private static int _THURSDAYContent = default;
        private static bool _THURSDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#TUESDAY"/>
        /// </summary>
        public static int TUESDAY { get { if (!_TUESDAYReady) { _TUESDAYContent = SGetField<int>(LocalBridgeClazz, "TUESDAY"); _TUESDAYReady = true; } return _TUESDAYContent; } }
        private static int _TUESDAYContent = default;
        private static bool _TUESDAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#WEDNESDAY"/>
        /// </summary>
        public static int WEDNESDAY { get { if (!_WEDNESDAYReady) { _WEDNESDAYContent = SGetField<int>(LocalBridgeClazz, "WEDNESDAY"); _WEDNESDAYReady = true; } return _WEDNESDAYContent; } }
        private static int _WEDNESDAYContent = default;
        private static bool _WEDNESDAYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getChannelUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetChannelUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getChannelUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getProgramUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetProgramUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getProgramUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getRecordingUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetRecordingUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getRecordingUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getRepeatDays()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRepeatDays()
        {
            return IExecuteWithSignature<int>("getRepeatDays", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDescription()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getRecordingId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetRecordingId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getRecordingId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getContentRatings()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Media.Tv.TvContentRating> GetContentRatings()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Media.Tv.TvContentRating>>("getContentRatings", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getEndPaddingMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetEndPaddingMillis()
        {
            return IExecuteWithSignature<long>("getEndPaddingMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getRecordingDurationMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetRecordingDurationMillis()
        {
            return IExecuteWithSignature<long>("getRecordingDurationMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getRecordingStartTimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetRecordingStartTimeMillis()
        {
            return IExecuteWithSignature<long>("getRecordingStartTimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getScheduledDurationMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetScheduledDurationMillis()
        {
            return IExecuteWithSignature<long>("getScheduledDurationMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getScheduledStartTimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetScheduledStartTimeMillis()
        {
            return IExecuteWithSignature<long>("getScheduledStartTimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#getStartPaddingMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetStartPaddingMillis()
        {
            return IExecuteWithSignature<long>("getStartPaddingMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#setDescription(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetDescription(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setDescription", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#setName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvRecordingInfo.html#writeToParcel(android.os.Parcel,int)"/>
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