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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Media
{
    #region Session2Command
    public partial class Session2Command
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Command.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Session2Command(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Command.html#%3Cinit%3E(java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public Session2Command(Java.Lang.String arg0, Android.Os.Bundle arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Command.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Command.html#COMMAND_CODE_CUSTOM"/>
        /// </summary>
        public static int COMMAND_CODE_CUSTOM { get { if (!_COMMAND_CODE_CUSTOMReady) { _COMMAND_CODE_CUSTOMContent = SGetField<int>(LocalBridgeClazz, "COMMAND_CODE_CUSTOM"); _COMMAND_CODE_CUSTOMReady = true; } return _COMMAND_CODE_CUSTOMContent; } }
        private static int _COMMAND_CODE_CUSTOMContent = default;
        private static bool _COMMAND_CODE_CUSTOMReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Command.html#getCustomExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetCustomExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getCustomExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Command.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Command.html#getCommandCode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCommandCode()
        {
            return IExecuteWithSignature<int>("getCommandCode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Command.html#getCustomAction()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCustomAction()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCustomAction", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Session2Command.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Result
        public partial class Result
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/Session2Command.Result.html#%3Cinit%3E(int,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public Result(int arg0, Android.Os.Bundle arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/Session2Command.Result.html#RESULT_ERROR_UNKNOWN_ERROR"/>
            /// </summary>
            public static int RESULT_ERROR_UNKNOWN_ERROR { get { if (!_RESULT_ERROR_UNKNOWN_ERRORReady) { _RESULT_ERROR_UNKNOWN_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_ERROR_UNKNOWN_ERROR"); _RESULT_ERROR_UNKNOWN_ERRORReady = true; } return _RESULT_ERROR_UNKNOWN_ERRORContent; } }
            private static int _RESULT_ERROR_UNKNOWN_ERRORContent = default;
            private static bool _RESULT_ERROR_UNKNOWN_ERRORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/Session2Command.Result.html#RESULT_INFO_SKIPPED"/>
            /// </summary>
            public static int RESULT_INFO_SKIPPED { get { if (!_RESULT_INFO_SKIPPEDReady) { _RESULT_INFO_SKIPPEDContent = SGetField<int>(LocalBridgeClazz, "RESULT_INFO_SKIPPED"); _RESULT_INFO_SKIPPEDReady = true; } return _RESULT_INFO_SKIPPEDContent; } }
            private static int _RESULT_INFO_SKIPPEDContent = default;
            private static bool _RESULT_INFO_SKIPPEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/Session2Command.Result.html#RESULT_SUCCESS"/>
            /// </summary>
            public static int RESULT_SUCCESS { get { if (!_RESULT_SUCCESSReady) { _RESULT_SUCCESSContent = SGetField<int>(LocalBridgeClazz, "RESULT_SUCCESS"); _RESULT_SUCCESSReady = true; } return _RESULT_SUCCESSContent; } }
            private static int _RESULT_SUCCESSContent = default;
            private static bool _RESULT_SUCCESSReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/Session2Command.Result.html#getResultData()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.Bundle"/></returns>
            public Android.Os.Bundle GetResultData()
            {
                return IExecuteWithSignature<Android.Os.Bundle>("getResultData", "()Landroid/os/Bundle;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/Session2Command.Result.html#getResultCode()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetResultCode()
            {
                return IExecuteWithSignature<int>("getResultCode", "()I");
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