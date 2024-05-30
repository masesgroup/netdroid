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

namespace Android.App.Appsearch
{
    #region AppSearchResult
    public partial class AppSearchResult
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_INTERNAL_ERROR"/>
        /// </summary>
        public static int RESULT_INTERNAL_ERROR { get { if (!_RESULT_INTERNAL_ERRORReady) { _RESULT_INTERNAL_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_INTERNAL_ERROR"); _RESULT_INTERNAL_ERRORReady = true; } return _RESULT_INTERNAL_ERRORContent; } }
        private static int _RESULT_INTERNAL_ERRORContent = default;
        private static bool _RESULT_INTERNAL_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_INVALID_ARGUMENT"/>
        /// </summary>
        public static int RESULT_INVALID_ARGUMENT { get { if (!_RESULT_INVALID_ARGUMENTReady) { _RESULT_INVALID_ARGUMENTContent = SGetField<int>(LocalBridgeClazz, "RESULT_INVALID_ARGUMENT"); _RESULT_INVALID_ARGUMENTReady = true; } return _RESULT_INVALID_ARGUMENTContent; } }
        private static int _RESULT_INVALID_ARGUMENTContent = default;
        private static bool _RESULT_INVALID_ARGUMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_INVALID_SCHEMA"/>
        /// </summary>
        public static int RESULT_INVALID_SCHEMA { get { if (!_RESULT_INVALID_SCHEMAReady) { _RESULT_INVALID_SCHEMAContent = SGetField<int>(LocalBridgeClazz, "RESULT_INVALID_SCHEMA"); _RESULT_INVALID_SCHEMAReady = true; } return _RESULT_INVALID_SCHEMAContent; } }
        private static int _RESULT_INVALID_SCHEMAContent = default;
        private static bool _RESULT_INVALID_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_IO_ERROR"/>
        /// </summary>
        public static int RESULT_IO_ERROR { get { if (!_RESULT_IO_ERRORReady) { _RESULT_IO_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_IO_ERROR"); _RESULT_IO_ERRORReady = true; } return _RESULT_IO_ERRORContent; } }
        private static int _RESULT_IO_ERRORContent = default;
        private static bool _RESULT_IO_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_NOT_FOUND"/>
        /// </summary>
        public static int RESULT_NOT_FOUND { get { if (!_RESULT_NOT_FOUNDReady) { _RESULT_NOT_FOUNDContent = SGetField<int>(LocalBridgeClazz, "RESULT_NOT_FOUND"); _RESULT_NOT_FOUNDReady = true; } return _RESULT_NOT_FOUNDContent; } }
        private static int _RESULT_NOT_FOUNDContent = default;
        private static bool _RESULT_NOT_FOUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_OK"/>
        /// </summary>
        public static int RESULT_OK { get { if (!_RESULT_OKReady) { _RESULT_OKContent = SGetField<int>(LocalBridgeClazz, "RESULT_OK"); _RESULT_OKReady = true; } return _RESULT_OKContent; } }
        private static int _RESULT_OKContent = default;
        private static bool _RESULT_OKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_OUT_OF_SPACE"/>
        /// </summary>
        public static int RESULT_OUT_OF_SPACE { get { if (!_RESULT_OUT_OF_SPACEReady) { _RESULT_OUT_OF_SPACEContent = SGetField<int>(LocalBridgeClazz, "RESULT_OUT_OF_SPACE"); _RESULT_OUT_OF_SPACEReady = true; } return _RESULT_OUT_OF_SPACEContent; } }
        private static int _RESULT_OUT_OF_SPACEContent = default;
        private static bool _RESULT_OUT_OF_SPACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_SECURITY_ERROR"/>
        /// </summary>
        public static int RESULT_SECURITY_ERROR { get { if (!_RESULT_SECURITY_ERRORReady) { _RESULT_SECURITY_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_SECURITY_ERROR"); _RESULT_SECURITY_ERRORReady = true; } return _RESULT_SECURITY_ERRORContent; } }
        private static int _RESULT_SECURITY_ERRORContent = default;
        private static bool _RESULT_SECURITY_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_UNKNOWN_ERROR"/>
        /// </summary>
        public static int RESULT_UNKNOWN_ERROR { get { if (!_RESULT_UNKNOWN_ERRORReady) { _RESULT_UNKNOWN_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_UNKNOWN_ERROR"); _RESULT_UNKNOWN_ERRORReady = true; } return _RESULT_UNKNOWN_ERRORContent; } }
        private static int _RESULT_UNKNOWN_ERRORContent = default;
        private static bool _RESULT_UNKNOWN_ERRORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#newFailedResult(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.Appsearch.AppSearchResult"/></returns>
        public static Android.App.Appsearch.AppSearchResult NewFailedResult(int arg0, Java.Lang.String arg1)
        {
            return SExecute<Android.App.Appsearch.AppSearchResult>(LocalBridgeClazz, "newFailedResult", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#newSuccessfulResult(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Android.App.Appsearch.AppSearchResult"/></returns>
        public static Android.App.Appsearch.AppSearchResult NewSuccessfulResult(object arg0)
        {
            return SExecuteWithSignature<Android.App.Appsearch.AppSearchResult>(LocalBridgeClazz, "newSuccessfulResult", "(Ljava/lang/Object;)Landroid/app/appsearch/AppSearchResult;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#getErrorMessage()"/> 
        /// </summary>
        public Java.Lang.String ErrorMessage
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getErrorMessage", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#getResultCode()"/> 
        /// </summary>
        public int ResultCode
        {
            get { return IExecuteWithSignature<int>("getResultCode", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#getResultValue()"/> 
        /// </summary>
        public object ResultValue
        {
            get { return IExecuteWithSignature("getResultValue", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#isSuccess()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSuccess()
        {
            return IExecuteWithSignature<bool>("isSuccess", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AppSearchResult<ValueType>
    public partial class AppSearchResult<ValueType>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.App.Appsearch.AppSearchResult{ValueType}"/> to <see cref="Android.App.Appsearch.AppSearchResult"/>
        /// </summary>
        public static implicit operator Android.App.Appsearch.AppSearchResult(Android.App.Appsearch.AppSearchResult<ValueType> t) => t.Cast<Android.App.Appsearch.AppSearchResult>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_INTERNAL_ERROR"/>
        /// </summary>
        public static int RESULT_INTERNAL_ERROR { get { if (!_RESULT_INTERNAL_ERRORReady) { _RESULT_INTERNAL_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_INTERNAL_ERROR"); _RESULT_INTERNAL_ERRORReady = true; } return _RESULT_INTERNAL_ERRORContent; } }
        private static int _RESULT_INTERNAL_ERRORContent = default;
        private static bool _RESULT_INTERNAL_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_INVALID_ARGUMENT"/>
        /// </summary>
        public static int RESULT_INVALID_ARGUMENT { get { if (!_RESULT_INVALID_ARGUMENTReady) { _RESULT_INVALID_ARGUMENTContent = SGetField<int>(LocalBridgeClazz, "RESULT_INVALID_ARGUMENT"); _RESULT_INVALID_ARGUMENTReady = true; } return _RESULT_INVALID_ARGUMENTContent; } }
        private static int _RESULT_INVALID_ARGUMENTContent = default;
        private static bool _RESULT_INVALID_ARGUMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_INVALID_SCHEMA"/>
        /// </summary>
        public static int RESULT_INVALID_SCHEMA { get { if (!_RESULT_INVALID_SCHEMAReady) { _RESULT_INVALID_SCHEMAContent = SGetField<int>(LocalBridgeClazz, "RESULT_INVALID_SCHEMA"); _RESULT_INVALID_SCHEMAReady = true; } return _RESULT_INVALID_SCHEMAContent; } }
        private static int _RESULT_INVALID_SCHEMAContent = default;
        private static bool _RESULT_INVALID_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_IO_ERROR"/>
        /// </summary>
        public static int RESULT_IO_ERROR { get { if (!_RESULT_IO_ERRORReady) { _RESULT_IO_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_IO_ERROR"); _RESULT_IO_ERRORReady = true; } return _RESULT_IO_ERRORContent; } }
        private static int _RESULT_IO_ERRORContent = default;
        private static bool _RESULT_IO_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_NOT_FOUND"/>
        /// </summary>
        public static int RESULT_NOT_FOUND { get { if (!_RESULT_NOT_FOUNDReady) { _RESULT_NOT_FOUNDContent = SGetField<int>(LocalBridgeClazz, "RESULT_NOT_FOUND"); _RESULT_NOT_FOUNDReady = true; } return _RESULT_NOT_FOUNDContent; } }
        private static int _RESULT_NOT_FOUNDContent = default;
        private static bool _RESULT_NOT_FOUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_OK"/>
        /// </summary>
        public static int RESULT_OK { get { if (!_RESULT_OKReady) { _RESULT_OKContent = SGetField<int>(LocalBridgeClazz, "RESULT_OK"); _RESULT_OKReady = true; } return _RESULT_OKContent; } }
        private static int _RESULT_OKContent = default;
        private static bool _RESULT_OKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_OUT_OF_SPACE"/>
        /// </summary>
        public static int RESULT_OUT_OF_SPACE { get { if (!_RESULT_OUT_OF_SPACEReady) { _RESULT_OUT_OF_SPACEContent = SGetField<int>(LocalBridgeClazz, "RESULT_OUT_OF_SPACE"); _RESULT_OUT_OF_SPACEReady = true; } return _RESULT_OUT_OF_SPACEContent; } }
        private static int _RESULT_OUT_OF_SPACEContent = default;
        private static bool _RESULT_OUT_OF_SPACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_SECURITY_ERROR"/>
        /// </summary>
        public static int RESULT_SECURITY_ERROR { get { if (!_RESULT_SECURITY_ERRORReady) { _RESULT_SECURITY_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_SECURITY_ERROR"); _RESULT_SECURITY_ERRORReady = true; } return _RESULT_SECURITY_ERRORContent; } }
        private static int _RESULT_SECURITY_ERRORContent = default;
        private static bool _RESULT_SECURITY_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#RESULT_UNKNOWN_ERROR"/>
        /// </summary>
        public static int RESULT_UNKNOWN_ERROR { get { if (!_RESULT_UNKNOWN_ERRORReady) { _RESULT_UNKNOWN_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_UNKNOWN_ERROR"); _RESULT_UNKNOWN_ERRORReady = true; } return _RESULT_UNKNOWN_ERRORContent; } }
        private static int _RESULT_UNKNOWN_ERRORContent = default;
        private static bool _RESULT_UNKNOWN_ERRORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#newFailedResult(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.Appsearch.AppSearchResult"/></returns>
        public static Android.App.Appsearch.AppSearchResult<ValueType> NewFailedResult(int arg0, Java.Lang.String arg1)
        {
            return SExecute<Android.App.Appsearch.AppSearchResult<ValueType>>(LocalBridgeClazz, "newFailedResult", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#newSuccessfulResult(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="ValueType"/></param>
        /// <returns><see cref="Android.App.Appsearch.AppSearchResult"/></returns>
        public static Android.App.Appsearch.AppSearchResult<ValueType> NewSuccessfulResult(ValueType arg0)
        {
            return SExecuteWithSignature<Android.App.Appsearch.AppSearchResult<ValueType>>(LocalBridgeClazz, "newSuccessfulResult", "(Ljava/lang/Object;)Landroid/app/appsearch/AppSearchResult;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#getErrorMessage()"/> 
        /// </summary>
        public Java.Lang.String ErrorMessage
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getErrorMessage", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#getResultCode()"/> 
        /// </summary>
        public int ResultCode
        {
            get { return IExecuteWithSignature<int>("getResultCode", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#getResultValue()"/> 
        /// </summary>
        public ValueType ResultValue
        {
            get { return IExecuteWithSignature<ValueType>("getResultValue", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchResult.html#isSuccess()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSuccess()
        {
            return IExecuteWithSignature<bool>("isSuccess", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}