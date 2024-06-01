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

namespace Android.Provider
{
    #region FontsContract
    public partial class FontsContract
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/FontsContract.html#buildTypeface(android.content.Context,android.os.CancellationSignal,android.provider.FontsContract.FontInfo[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg2"><see cref="Android.Provider.FontsContract.FontInfo"/></param>
        /// <returns><see cref="Android.Graphics.Typeface"/></returns>
        [System.Obsolete()]
        public static Android.Graphics.Typeface BuildTypeface(Android.Content.Context arg0, Android.Os.CancellationSignal arg1, Android.Provider.FontsContract.FontInfo[] arg2)
        {
            return SExecute<Android.Graphics.Typeface>(LocalBridgeClazz, "buildTypeface", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/FontsContract.html#fetchFonts(android.content.Context,android.os.CancellationSignal,android.provider.FontRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg2"><see cref="Android.Provider.FontRequest"/></param>
        /// <returns><see cref="Android.Provider.FontsContract.FontFamilyResult"/></returns>
        /// <exception cref="Android.Content.Pm.PackageManager.NameNotFoundException"/>
        [System.Obsolete()]
        public static Android.Provider.FontsContract.FontFamilyResult FetchFonts(Android.Content.Context arg0, Android.Os.CancellationSignal arg1, Android.Provider.FontRequest arg2)
        {
            return SExecute<Android.Provider.FontsContract.FontFamilyResult>(LocalBridgeClazz, "fetchFonts", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/FontsContract.html#requestFonts(android.content.Context,android.provider.FontRequest,android.os.Handler,android.os.CancellationSignal,android.provider.FontsContract.FontRequestCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Provider.FontRequest"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        /// <param name="arg3"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg4"><see cref="Android.Provider.FontsContract.FontRequestCallback"/></param>
        [System.Obsolete()]
        public static void RequestFonts(Android.Content.Context arg0, Android.Provider.FontRequest arg1, Android.Os.Handler arg2, Android.Os.CancellationSignal arg3, Android.Provider.FontsContract.FontRequestCallback arg4)
        {
            SExecute(LocalBridgeClazz, "requestFonts", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Columns
        public partial class Columns
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.Columns.html#RESULT_CODE_FONT_NOT_FOUND"/>
            /// </summary>
            [System.Obsolete()]
            public static int RESULT_CODE_FONT_NOT_FOUND { get { if (!_RESULT_CODE_FONT_NOT_FOUNDReady) { _RESULT_CODE_FONT_NOT_FOUNDContent = SGetField<int>(LocalBridgeClazz, "RESULT_CODE_FONT_NOT_FOUND"); _RESULT_CODE_FONT_NOT_FOUNDReady = true; } return _RESULT_CODE_FONT_NOT_FOUNDContent; } }
            private static int _RESULT_CODE_FONT_NOT_FOUNDContent = default;
            private static bool _RESULT_CODE_FONT_NOT_FOUNDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.Columns.html#RESULT_CODE_FONT_UNAVAILABLE"/>
            /// </summary>
            [System.Obsolete()]
            public static int RESULT_CODE_FONT_UNAVAILABLE { get { if (!_RESULT_CODE_FONT_UNAVAILABLEReady) { _RESULT_CODE_FONT_UNAVAILABLEContent = SGetField<int>(LocalBridgeClazz, "RESULT_CODE_FONT_UNAVAILABLE"); _RESULT_CODE_FONT_UNAVAILABLEReady = true; } return _RESULT_CODE_FONT_UNAVAILABLEContent; } }
            private static int _RESULT_CODE_FONT_UNAVAILABLEContent = default;
            private static bool _RESULT_CODE_FONT_UNAVAILABLEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.Columns.html#RESULT_CODE_MALFORMED_QUERY"/>
            /// </summary>
            [System.Obsolete()]
            public static int RESULT_CODE_MALFORMED_QUERY { get { if (!_RESULT_CODE_MALFORMED_QUERYReady) { _RESULT_CODE_MALFORMED_QUERYContent = SGetField<int>(LocalBridgeClazz, "RESULT_CODE_MALFORMED_QUERY"); _RESULT_CODE_MALFORMED_QUERYReady = true; } return _RESULT_CODE_MALFORMED_QUERYContent; } }
            private static int _RESULT_CODE_MALFORMED_QUERYContent = default;
            private static bool _RESULT_CODE_MALFORMED_QUERYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.Columns.html#RESULT_CODE_OK"/>
            /// </summary>
            [System.Obsolete()]
            public static int RESULT_CODE_OK { get { if (!_RESULT_CODE_OKReady) { _RESULT_CODE_OKContent = SGetField<int>(LocalBridgeClazz, "RESULT_CODE_OK"); _RESULT_CODE_OKReady = true; } return _RESULT_CODE_OKContent; } }
            private static int _RESULT_CODE_OKContent = default;
            private static bool _RESULT_CODE_OKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.Columns.html#FILE_ID"/>
            /// </summary>
            [System.Obsolete()]
            public static Java.Lang.String FILE_ID { get { if (!_FILE_IDReady) { _FILE_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FILE_ID"); _FILE_IDReady = true; } return _FILE_IDContent; } }
            private static Java.Lang.String _FILE_IDContent = default;
            private static bool _FILE_IDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.Columns.html#ITALIC"/>
            /// </summary>
            [System.Obsolete()]
            public static Java.Lang.String ITALIC { get { if (!_ITALICReady) { _ITALICContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ITALIC"); _ITALICReady = true; } return _ITALICContent; } }
            private static Java.Lang.String _ITALICContent = default;
            private static bool _ITALICReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.Columns.html#RESULT_CODE"/>
            /// </summary>
            [System.Obsolete()]
            public static Java.Lang.String RESULT_CODE { get { if (!_RESULT_CODEReady) { _RESULT_CODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RESULT_CODE"); _RESULT_CODEReady = true; } return _RESULT_CODEContent; } }
            private static Java.Lang.String _RESULT_CODEContent = default;
            private static bool _RESULT_CODEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.Columns.html#TTC_INDEX"/>
            /// </summary>
            [System.Obsolete()]
            public static Java.Lang.String TTC_INDEX { get { if (!_TTC_INDEXReady) { _TTC_INDEXContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TTC_INDEX"); _TTC_INDEXReady = true; } return _TTC_INDEXContent; } }
            private static Java.Lang.String _TTC_INDEXContent = default;
            private static bool _TTC_INDEXReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.Columns.html#VARIATION_SETTINGS"/>
            /// </summary>
            [System.Obsolete()]
            public static Java.Lang.String VARIATION_SETTINGS { get { if (!_VARIATION_SETTINGSReady) { _VARIATION_SETTINGSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "VARIATION_SETTINGS"); _VARIATION_SETTINGSReady = true; } return _VARIATION_SETTINGSContent; } }
            private static Java.Lang.String _VARIATION_SETTINGSContent = default;
            private static bool _VARIATION_SETTINGSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.Columns.html#WEIGHT"/>
            /// </summary>
            [System.Obsolete()]
            public static Java.Lang.String WEIGHT { get { if (!_WEIGHTReady) { _WEIGHTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WEIGHT"); _WEIGHTReady = true; } return _WEIGHTContent; } }
            private static Java.Lang.String _WEIGHTContent = default;
            private static bool _WEIGHTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FontFamilyResult
        public partial class FontFamilyResult
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontFamilyResult.html#STATUS_OK"/>
            /// </summary>
            [System.Obsolete()]
            public static int STATUS_OK { get { if (!_STATUS_OKReady) { _STATUS_OKContent = SGetField<int>(LocalBridgeClazz, "STATUS_OK"); _STATUS_OKReady = true; } return _STATUS_OKContent; } }
            private static int _STATUS_OKContent = default;
            private static bool _STATUS_OKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontFamilyResult.html#STATUS_REJECTED"/>
            /// </summary>
            [System.Obsolete()]
            public static int STATUS_REJECTED { get { if (!_STATUS_REJECTEDReady) { _STATUS_REJECTEDContent = SGetField<int>(LocalBridgeClazz, "STATUS_REJECTED"); _STATUS_REJECTEDReady = true; } return _STATUS_REJECTEDContent; } }
            private static int _STATUS_REJECTEDContent = default;
            private static bool _STATUS_REJECTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontFamilyResult.html#STATUS_UNEXPECTED_DATA_PROVIDED"/>
            /// </summary>
            [System.Obsolete()]
            public static int STATUS_UNEXPECTED_DATA_PROVIDED { get { if (!_STATUS_UNEXPECTED_DATA_PROVIDEDReady) { _STATUS_UNEXPECTED_DATA_PROVIDEDContent = SGetField<int>(LocalBridgeClazz, "STATUS_UNEXPECTED_DATA_PROVIDED"); _STATUS_UNEXPECTED_DATA_PROVIDEDReady = true; } return _STATUS_UNEXPECTED_DATA_PROVIDEDContent; } }
            private static int _STATUS_UNEXPECTED_DATA_PROVIDEDContent = default;
            private static bool _STATUS_UNEXPECTED_DATA_PROVIDEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontFamilyResult.html#STATUS_WRONG_CERTIFICATES"/>
            /// </summary>
            [System.Obsolete()]
            public static int STATUS_WRONG_CERTIFICATES { get { if (!_STATUS_WRONG_CERTIFICATESReady) { _STATUS_WRONG_CERTIFICATESContent = SGetField<int>(LocalBridgeClazz, "STATUS_WRONG_CERTIFICATES"); _STATUS_WRONG_CERTIFICATESReady = true; } return _STATUS_WRONG_CERTIFICATESContent; } }
            private static int _STATUS_WRONG_CERTIFICATESContent = default;
            private static bool _STATUS_WRONG_CERTIFICATESReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontFamilyResult.html#getFonts()"/> 
            /// </summary>
            [System.Obsolete()]
            public Android.Provider.FontsContract.FontInfo[] Fonts
            {
                get { return IExecuteWithSignatureArray<Android.Provider.FontsContract.FontInfo>("getFonts", "()[Landroid/provider/FontsContract$FontInfo;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontFamilyResult.html#getStatusCode()"/> 
            /// </summary>
            [System.Obsolete()]
            public int StatusCode
            {
                get { return IExecuteWithSignature<int>("getStatusCode", "()I"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FontInfo
        public partial class FontInfo
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
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontInfo.html#getAxes()"/> 
            /// </summary>
            [System.Obsolete()]
            public Android.Graphics.Fonts.FontVariationAxis[] Axes
            {
                get { return IExecuteWithSignatureArray<Android.Graphics.Fonts.FontVariationAxis>("getAxes", "()[Landroid/graphics/fonts/FontVariationAxis;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontInfo.html#getResultCode()"/> 
            /// </summary>
            [System.Obsolete()]
            public int ResultCode
            {
                get { return IExecuteWithSignature<int>("getResultCode", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontInfo.html#getTtcIndex()"/> 
            /// </summary>
            [System.Obsolete()]
            public int TtcIndex
            {
                get { return IExecuteWithSignature<int>("getTtcIndex", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontInfo.html#getUri()"/> 
            /// </summary>
            [System.Obsolete()]
            public Android.Net.Uri Uri
            {
                get { return IExecuteWithSignature<Android.Net.Uri>("getUri", "()Landroid/net/Uri;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontInfo.html#getWeight()"/> 
            /// </summary>
            [System.Obsolete()]
            public int Weight
            {
                get { return IExecuteWithSignature<int>("getWeight", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontInfo.html#isItalic()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            [System.Obsolete()]
            public bool IsItalic()
            {
                return IExecuteWithSignature<bool>("isItalic", "()Z");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FontRequestCallback
        public partial class FontRequestCallback
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontRequestCallback.html#FAIL_REASON_FONT_LOAD_ERROR"/>
            /// </summary>
            [System.Obsolete()]
            public static int FAIL_REASON_FONT_LOAD_ERROR { get { if (!_FAIL_REASON_FONT_LOAD_ERRORReady) { _FAIL_REASON_FONT_LOAD_ERRORContent = SGetField<int>(LocalBridgeClazz, "FAIL_REASON_FONT_LOAD_ERROR"); _FAIL_REASON_FONT_LOAD_ERRORReady = true; } return _FAIL_REASON_FONT_LOAD_ERRORContent; } }
            private static int _FAIL_REASON_FONT_LOAD_ERRORContent = default;
            private static bool _FAIL_REASON_FONT_LOAD_ERRORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontRequestCallback.html#FAIL_REASON_FONT_NOT_FOUND"/>
            /// </summary>
            [System.Obsolete()]
            public static int FAIL_REASON_FONT_NOT_FOUND { get { if (!_FAIL_REASON_FONT_NOT_FOUNDReady) { _FAIL_REASON_FONT_NOT_FOUNDContent = SGetField<int>(LocalBridgeClazz, "FAIL_REASON_FONT_NOT_FOUND"); _FAIL_REASON_FONT_NOT_FOUNDReady = true; } return _FAIL_REASON_FONT_NOT_FOUNDContent; } }
            private static int _FAIL_REASON_FONT_NOT_FOUNDContent = default;
            private static bool _FAIL_REASON_FONT_NOT_FOUNDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontRequestCallback.html#FAIL_REASON_FONT_UNAVAILABLE"/>
            /// </summary>
            [System.Obsolete()]
            public static int FAIL_REASON_FONT_UNAVAILABLE { get { if (!_FAIL_REASON_FONT_UNAVAILABLEReady) { _FAIL_REASON_FONT_UNAVAILABLEContent = SGetField<int>(LocalBridgeClazz, "FAIL_REASON_FONT_UNAVAILABLE"); _FAIL_REASON_FONT_UNAVAILABLEReady = true; } return _FAIL_REASON_FONT_UNAVAILABLEContent; } }
            private static int _FAIL_REASON_FONT_UNAVAILABLEContent = default;
            private static bool _FAIL_REASON_FONT_UNAVAILABLEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontRequestCallback.html#FAIL_REASON_MALFORMED_QUERY"/>
            /// </summary>
            [System.Obsolete()]
            public static int FAIL_REASON_MALFORMED_QUERY { get { if (!_FAIL_REASON_MALFORMED_QUERYReady) { _FAIL_REASON_MALFORMED_QUERYContent = SGetField<int>(LocalBridgeClazz, "FAIL_REASON_MALFORMED_QUERY"); _FAIL_REASON_MALFORMED_QUERYReady = true; } return _FAIL_REASON_MALFORMED_QUERYContent; } }
            private static int _FAIL_REASON_MALFORMED_QUERYContent = default;
            private static bool _FAIL_REASON_MALFORMED_QUERYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontRequestCallback.html#FAIL_REASON_PROVIDER_NOT_FOUND"/>
            /// </summary>
            [System.Obsolete()]
            public static int FAIL_REASON_PROVIDER_NOT_FOUND { get { if (!_FAIL_REASON_PROVIDER_NOT_FOUNDReady) { _FAIL_REASON_PROVIDER_NOT_FOUNDContent = SGetField<int>(LocalBridgeClazz, "FAIL_REASON_PROVIDER_NOT_FOUND"); _FAIL_REASON_PROVIDER_NOT_FOUNDReady = true; } return _FAIL_REASON_PROVIDER_NOT_FOUNDContent; } }
            private static int _FAIL_REASON_PROVIDER_NOT_FOUNDContent = default;
            private static bool _FAIL_REASON_PROVIDER_NOT_FOUNDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontRequestCallback.html#FAIL_REASON_WRONG_CERTIFICATES"/>
            /// </summary>
            [System.Obsolete()]
            public static int FAIL_REASON_WRONG_CERTIFICATES { get { if (!_FAIL_REASON_WRONG_CERTIFICATESReady) { _FAIL_REASON_WRONG_CERTIFICATESContent = SGetField<int>(LocalBridgeClazz, "FAIL_REASON_WRONG_CERTIFICATES"); _FAIL_REASON_WRONG_CERTIFICATESReady = true; } return _FAIL_REASON_WRONG_CERTIFICATESContent; } }
            private static int _FAIL_REASON_WRONG_CERTIFICATESContent = default;
            private static bool _FAIL_REASON_WRONG_CERTIFICATESReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontRequestCallback.html#onTypefaceRequestFailed(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            [System.Obsolete()]
            public void OnTypefaceRequestFailed(int arg0)
            {
                IExecuteWithSignature("onTypefaceRequestFailed", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/provider/FontsContract.FontRequestCallback.html#onTypefaceRetrieved(android.graphics.Typeface)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Typeface"/></param>
            [System.Obsolete()]
            public void OnTypefaceRetrieved(Android.Graphics.Typeface arg0)
            {
                IExecuteWithSignature("onTypefaceRetrieved", "(Landroid/graphics/Typeface;)V", arg0);
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