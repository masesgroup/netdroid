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

namespace Android.Os
{
    #region ProfilingResult
    public partial class ProfilingResult
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#ERROR_FAILED_EXECUTING"/>
        /// </summary>
        public static int ERROR_FAILED_EXECUTING { get { if (!_ERROR_FAILED_EXECUTINGReady) { _ERROR_FAILED_EXECUTINGContent = SGetField<int>(LocalBridgeClazz, "ERROR_FAILED_EXECUTING"); _ERROR_FAILED_EXECUTINGReady = true; } return _ERROR_FAILED_EXECUTINGContent; } }
        private static int _ERROR_FAILED_EXECUTINGContent = default;
        private static bool _ERROR_FAILED_EXECUTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#ERROR_FAILED_INVALID_REQUEST"/>
        /// </summary>
        public static int ERROR_FAILED_INVALID_REQUEST { get { if (!_ERROR_FAILED_INVALID_REQUESTReady) { _ERROR_FAILED_INVALID_REQUESTContent = SGetField<int>(LocalBridgeClazz, "ERROR_FAILED_INVALID_REQUEST"); _ERROR_FAILED_INVALID_REQUESTReady = true; } return _ERROR_FAILED_INVALID_REQUESTContent; } }
        private static int _ERROR_FAILED_INVALID_REQUESTContent = default;
        private static bool _ERROR_FAILED_INVALID_REQUESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#ERROR_FAILED_NO_DISK_SPACE"/>
        /// </summary>
        public static int ERROR_FAILED_NO_DISK_SPACE { get { if (!_ERROR_FAILED_NO_DISK_SPACEReady) { _ERROR_FAILED_NO_DISK_SPACEContent = SGetField<int>(LocalBridgeClazz, "ERROR_FAILED_NO_DISK_SPACE"); _ERROR_FAILED_NO_DISK_SPACEReady = true; } return _ERROR_FAILED_NO_DISK_SPACEContent; } }
        private static int _ERROR_FAILED_NO_DISK_SPACEContent = default;
        private static bool _ERROR_FAILED_NO_DISK_SPACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#ERROR_FAILED_POST_PROCESSING"/>
        /// </summary>
        public static int ERROR_FAILED_POST_PROCESSING { get { if (!_ERROR_FAILED_POST_PROCESSINGReady) { _ERROR_FAILED_POST_PROCESSINGContent = SGetField<int>(LocalBridgeClazz, "ERROR_FAILED_POST_PROCESSING"); _ERROR_FAILED_POST_PROCESSINGReady = true; } return _ERROR_FAILED_POST_PROCESSINGContent; } }
        private static int _ERROR_FAILED_POST_PROCESSINGContent = default;
        private static bool _ERROR_FAILED_POST_PROCESSINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#ERROR_FAILED_PROFILING_IN_PROGRESS"/>
        /// </summary>
        public static int ERROR_FAILED_PROFILING_IN_PROGRESS { get { if (!_ERROR_FAILED_PROFILING_IN_PROGRESSReady) { _ERROR_FAILED_PROFILING_IN_PROGRESSContent = SGetField<int>(LocalBridgeClazz, "ERROR_FAILED_PROFILING_IN_PROGRESS"); _ERROR_FAILED_PROFILING_IN_PROGRESSReady = true; } return _ERROR_FAILED_PROFILING_IN_PROGRESSContent; } }
        private static int _ERROR_FAILED_PROFILING_IN_PROGRESSContent = default;
        private static bool _ERROR_FAILED_PROFILING_IN_PROGRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#ERROR_FAILED_RATE_LIMIT_PROCESS"/>
        /// </summary>
        public static int ERROR_FAILED_RATE_LIMIT_PROCESS { get { if (!_ERROR_FAILED_RATE_LIMIT_PROCESSReady) { _ERROR_FAILED_RATE_LIMIT_PROCESSContent = SGetField<int>(LocalBridgeClazz, "ERROR_FAILED_RATE_LIMIT_PROCESS"); _ERROR_FAILED_RATE_LIMIT_PROCESSReady = true; } return _ERROR_FAILED_RATE_LIMIT_PROCESSContent; } }
        private static int _ERROR_FAILED_RATE_LIMIT_PROCESSContent = default;
        private static bool _ERROR_FAILED_RATE_LIMIT_PROCESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#ERROR_FAILED_RATE_LIMIT_SYSTEM"/>
        /// </summary>
        public static int ERROR_FAILED_RATE_LIMIT_SYSTEM { get { if (!_ERROR_FAILED_RATE_LIMIT_SYSTEMReady) { _ERROR_FAILED_RATE_LIMIT_SYSTEMContent = SGetField<int>(LocalBridgeClazz, "ERROR_FAILED_RATE_LIMIT_SYSTEM"); _ERROR_FAILED_RATE_LIMIT_SYSTEMReady = true; } return _ERROR_FAILED_RATE_LIMIT_SYSTEMContent; } }
        private static int _ERROR_FAILED_RATE_LIMIT_SYSTEMContent = default;
        private static bool _ERROR_FAILED_RATE_LIMIT_SYSTEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#ERROR_NONE"/>
        /// </summary>
        public static int ERROR_NONE { get { if (!_ERROR_NONEReady) { _ERROR_NONEContent = SGetField<int>(LocalBridgeClazz, "ERROR_NONE"); _ERROR_NONEReady = true; } return _ERROR_NONEContent; } }
        private static int _ERROR_NONEContent = default;
        private static bool _ERROR_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#ERROR_UNKNOWN"/>
        /// </summary>
        public static int ERROR_UNKNOWN { get { if (!_ERROR_UNKNOWNReady) { _ERROR_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNKNOWN"); _ERROR_UNKNOWNReady = true; } return _ERROR_UNKNOWNContent; } }
        private static int _ERROR_UNKNOWNContent = default;
        private static bool _ERROR_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#getErrorCode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetErrorCode()
        {
            return IExecuteWithSignature<int>("getErrorCode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#getErrorMessage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetErrorMessage()
        {
            return IExecuteWithSignature<Java.Lang.String>("getErrorMessage", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#getResultFilePath()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetResultFilePath()
        {
            return IExecuteWithSignature<Java.Lang.String>("getResultFilePath", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#getTag()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTag()
        {
            return IExecuteWithSignature<Java.Lang.String>("getTag", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ProfilingResult.html#writeToParcel(android.os.Parcel,int)"/>
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