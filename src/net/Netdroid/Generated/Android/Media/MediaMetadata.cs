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

namespace Android.Media
{
    #region MediaMetadata
    public partial class MediaMetadata
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_ALBUM"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_ALBUM { get { if (!_METADATA_KEY_ALBUMReady) { _METADATA_KEY_ALBUMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_ALBUM"); _METADATA_KEY_ALBUMReady = true; } return _METADATA_KEY_ALBUMContent; } }
        private static Java.Lang.String _METADATA_KEY_ALBUMContent = default;
        private static bool _METADATA_KEY_ALBUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_ALBUM_ART"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_ALBUM_ART { get { if (!_METADATA_KEY_ALBUM_ARTReady) { _METADATA_KEY_ALBUM_ARTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_ALBUM_ART"); _METADATA_KEY_ALBUM_ARTReady = true; } return _METADATA_KEY_ALBUM_ARTContent; } }
        private static Java.Lang.String _METADATA_KEY_ALBUM_ARTContent = default;
        private static bool _METADATA_KEY_ALBUM_ARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_ALBUM_ART_URI"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_ALBUM_ART_URI { get { if (!_METADATA_KEY_ALBUM_ART_URIReady) { _METADATA_KEY_ALBUM_ART_URIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_ALBUM_ART_URI"); _METADATA_KEY_ALBUM_ART_URIReady = true; } return _METADATA_KEY_ALBUM_ART_URIContent; } }
        private static Java.Lang.String _METADATA_KEY_ALBUM_ART_URIContent = default;
        private static bool _METADATA_KEY_ALBUM_ART_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_ALBUM_ARTIST"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_ALBUM_ARTIST { get { if (!_METADATA_KEY_ALBUM_ARTISTReady) { _METADATA_KEY_ALBUM_ARTISTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_ALBUM_ARTIST"); _METADATA_KEY_ALBUM_ARTISTReady = true; } return _METADATA_KEY_ALBUM_ARTISTContent; } }
        private static Java.Lang.String _METADATA_KEY_ALBUM_ARTISTContent = default;
        private static bool _METADATA_KEY_ALBUM_ARTISTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_ART"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_ART { get { if (!_METADATA_KEY_ARTReady) { _METADATA_KEY_ARTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_ART"); _METADATA_KEY_ARTReady = true; } return _METADATA_KEY_ARTContent; } }
        private static Java.Lang.String _METADATA_KEY_ARTContent = default;
        private static bool _METADATA_KEY_ARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_ART_URI"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_ART_URI { get { if (!_METADATA_KEY_ART_URIReady) { _METADATA_KEY_ART_URIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_ART_URI"); _METADATA_KEY_ART_URIReady = true; } return _METADATA_KEY_ART_URIContent; } }
        private static Java.Lang.String _METADATA_KEY_ART_URIContent = default;
        private static bool _METADATA_KEY_ART_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_ARTIST"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_ARTIST { get { if (!_METADATA_KEY_ARTISTReady) { _METADATA_KEY_ARTISTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_ARTIST"); _METADATA_KEY_ARTISTReady = true; } return _METADATA_KEY_ARTISTContent; } }
        private static Java.Lang.String _METADATA_KEY_ARTISTContent = default;
        private static bool _METADATA_KEY_ARTISTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_AUTHOR"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_AUTHOR { get { if (!_METADATA_KEY_AUTHORReady) { _METADATA_KEY_AUTHORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_AUTHOR"); _METADATA_KEY_AUTHORReady = true; } return _METADATA_KEY_AUTHORContent; } }
        private static Java.Lang.String _METADATA_KEY_AUTHORContent = default;
        private static bool _METADATA_KEY_AUTHORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_BT_FOLDER_TYPE"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_BT_FOLDER_TYPE { get { if (!_METADATA_KEY_BT_FOLDER_TYPEReady) { _METADATA_KEY_BT_FOLDER_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_BT_FOLDER_TYPE"); _METADATA_KEY_BT_FOLDER_TYPEReady = true; } return _METADATA_KEY_BT_FOLDER_TYPEContent; } }
        private static Java.Lang.String _METADATA_KEY_BT_FOLDER_TYPEContent = default;
        private static bool _METADATA_KEY_BT_FOLDER_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_COMPILATION"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_COMPILATION { get { if (!_METADATA_KEY_COMPILATIONReady) { _METADATA_KEY_COMPILATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_COMPILATION"); _METADATA_KEY_COMPILATIONReady = true; } return _METADATA_KEY_COMPILATIONContent; } }
        private static Java.Lang.String _METADATA_KEY_COMPILATIONContent = default;
        private static bool _METADATA_KEY_COMPILATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_COMPOSER"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_COMPOSER { get { if (!_METADATA_KEY_COMPOSERReady) { _METADATA_KEY_COMPOSERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_COMPOSER"); _METADATA_KEY_COMPOSERReady = true; } return _METADATA_KEY_COMPOSERContent; } }
        private static Java.Lang.String _METADATA_KEY_COMPOSERContent = default;
        private static bool _METADATA_KEY_COMPOSERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_DATE"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_DATE { get { if (!_METADATA_KEY_DATEReady) { _METADATA_KEY_DATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_DATE"); _METADATA_KEY_DATEReady = true; } return _METADATA_KEY_DATEContent; } }
        private static Java.Lang.String _METADATA_KEY_DATEContent = default;
        private static bool _METADATA_KEY_DATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_DISC_NUMBER"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_DISC_NUMBER { get { if (!_METADATA_KEY_DISC_NUMBERReady) { _METADATA_KEY_DISC_NUMBERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_DISC_NUMBER"); _METADATA_KEY_DISC_NUMBERReady = true; } return _METADATA_KEY_DISC_NUMBERContent; } }
        private static Java.Lang.String _METADATA_KEY_DISC_NUMBERContent = default;
        private static bool _METADATA_KEY_DISC_NUMBERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_DISPLAY_DESCRIPTION"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_DISPLAY_DESCRIPTION { get { if (!_METADATA_KEY_DISPLAY_DESCRIPTIONReady) { _METADATA_KEY_DISPLAY_DESCRIPTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_DISPLAY_DESCRIPTION"); _METADATA_KEY_DISPLAY_DESCRIPTIONReady = true; } return _METADATA_KEY_DISPLAY_DESCRIPTIONContent; } }
        private static Java.Lang.String _METADATA_KEY_DISPLAY_DESCRIPTIONContent = default;
        private static bool _METADATA_KEY_DISPLAY_DESCRIPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_DISPLAY_ICON"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_DISPLAY_ICON { get { if (!_METADATA_KEY_DISPLAY_ICONReady) { _METADATA_KEY_DISPLAY_ICONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_DISPLAY_ICON"); _METADATA_KEY_DISPLAY_ICONReady = true; } return _METADATA_KEY_DISPLAY_ICONContent; } }
        private static Java.Lang.String _METADATA_KEY_DISPLAY_ICONContent = default;
        private static bool _METADATA_KEY_DISPLAY_ICONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_DISPLAY_ICON_URI"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_DISPLAY_ICON_URI { get { if (!_METADATA_KEY_DISPLAY_ICON_URIReady) { _METADATA_KEY_DISPLAY_ICON_URIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_DISPLAY_ICON_URI"); _METADATA_KEY_DISPLAY_ICON_URIReady = true; } return _METADATA_KEY_DISPLAY_ICON_URIContent; } }
        private static Java.Lang.String _METADATA_KEY_DISPLAY_ICON_URIContent = default;
        private static bool _METADATA_KEY_DISPLAY_ICON_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_DISPLAY_SUBTITLE"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_DISPLAY_SUBTITLE { get { if (!_METADATA_KEY_DISPLAY_SUBTITLEReady) { _METADATA_KEY_DISPLAY_SUBTITLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_DISPLAY_SUBTITLE"); _METADATA_KEY_DISPLAY_SUBTITLEReady = true; } return _METADATA_KEY_DISPLAY_SUBTITLEContent; } }
        private static Java.Lang.String _METADATA_KEY_DISPLAY_SUBTITLEContent = default;
        private static bool _METADATA_KEY_DISPLAY_SUBTITLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_DISPLAY_TITLE"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_DISPLAY_TITLE { get { if (!_METADATA_KEY_DISPLAY_TITLEReady) { _METADATA_KEY_DISPLAY_TITLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_DISPLAY_TITLE"); _METADATA_KEY_DISPLAY_TITLEReady = true; } return _METADATA_KEY_DISPLAY_TITLEContent; } }
        private static Java.Lang.String _METADATA_KEY_DISPLAY_TITLEContent = default;
        private static bool _METADATA_KEY_DISPLAY_TITLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_DURATION"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_DURATION { get { if (!_METADATA_KEY_DURATIONReady) { _METADATA_KEY_DURATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_DURATION"); _METADATA_KEY_DURATIONReady = true; } return _METADATA_KEY_DURATIONContent; } }
        private static Java.Lang.String _METADATA_KEY_DURATIONContent = default;
        private static bool _METADATA_KEY_DURATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_GENRE"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_GENRE { get { if (!_METADATA_KEY_GENREReady) { _METADATA_KEY_GENREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_GENRE"); _METADATA_KEY_GENREReady = true; } return _METADATA_KEY_GENREContent; } }
        private static Java.Lang.String _METADATA_KEY_GENREContent = default;
        private static bool _METADATA_KEY_GENREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_MEDIA_ID"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_MEDIA_ID { get { if (!_METADATA_KEY_MEDIA_IDReady) { _METADATA_KEY_MEDIA_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_MEDIA_ID"); _METADATA_KEY_MEDIA_IDReady = true; } return _METADATA_KEY_MEDIA_IDContent; } }
        private static Java.Lang.String _METADATA_KEY_MEDIA_IDContent = default;
        private static bool _METADATA_KEY_MEDIA_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_MEDIA_URI"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_MEDIA_URI { get { if (!_METADATA_KEY_MEDIA_URIReady) { _METADATA_KEY_MEDIA_URIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_MEDIA_URI"); _METADATA_KEY_MEDIA_URIReady = true; } return _METADATA_KEY_MEDIA_URIContent; } }
        private static Java.Lang.String _METADATA_KEY_MEDIA_URIContent = default;
        private static bool _METADATA_KEY_MEDIA_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_NUM_TRACKS"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_NUM_TRACKS { get { if (!_METADATA_KEY_NUM_TRACKSReady) { _METADATA_KEY_NUM_TRACKSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_NUM_TRACKS"); _METADATA_KEY_NUM_TRACKSReady = true; } return _METADATA_KEY_NUM_TRACKSContent; } }
        private static Java.Lang.String _METADATA_KEY_NUM_TRACKSContent = default;
        private static bool _METADATA_KEY_NUM_TRACKSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_RATING"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_RATING { get { if (!_METADATA_KEY_RATINGReady) { _METADATA_KEY_RATINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_RATING"); _METADATA_KEY_RATINGReady = true; } return _METADATA_KEY_RATINGContent; } }
        private static Java.Lang.String _METADATA_KEY_RATINGContent = default;
        private static bool _METADATA_KEY_RATINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_TITLE"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_TITLE { get { if (!_METADATA_KEY_TITLEReady) { _METADATA_KEY_TITLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_TITLE"); _METADATA_KEY_TITLEReady = true; } return _METADATA_KEY_TITLEContent; } }
        private static Java.Lang.String _METADATA_KEY_TITLEContent = default;
        private static bool _METADATA_KEY_TITLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_TRACK_NUMBER"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_TRACK_NUMBER { get { if (!_METADATA_KEY_TRACK_NUMBERReady) { _METADATA_KEY_TRACK_NUMBERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_TRACK_NUMBER"); _METADATA_KEY_TRACK_NUMBERReady = true; } return _METADATA_KEY_TRACK_NUMBERContent; } }
        private static Java.Lang.String _METADATA_KEY_TRACK_NUMBERContent = default;
        private static bool _METADATA_KEY_TRACK_NUMBERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_USER_RATING"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_USER_RATING { get { if (!_METADATA_KEY_USER_RATINGReady) { _METADATA_KEY_USER_RATINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_USER_RATING"); _METADATA_KEY_USER_RATINGReady = true; } return _METADATA_KEY_USER_RATINGContent; } }
        private static Java.Lang.String _METADATA_KEY_USER_RATINGContent = default;
        private static bool _METADATA_KEY_USER_RATINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_WRITER"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_WRITER { get { if (!_METADATA_KEY_WRITERReady) { _METADATA_KEY_WRITERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_WRITER"); _METADATA_KEY_WRITERReady = true; } return _METADATA_KEY_WRITERContent; } }
        private static Java.Lang.String _METADATA_KEY_WRITERContent = default;
        private static bool _METADATA_KEY_WRITERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#METADATA_KEY_YEAR"/>
        /// </summary>
        public static Java.Lang.String METADATA_KEY_YEAR { get { if (!_METADATA_KEY_YEARReady) { _METADATA_KEY_YEARContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "METADATA_KEY_YEAR"); _METADATA_KEY_YEARReady = true; } return _METADATA_KEY_YEARContent; } }
        private static Java.Lang.String _METADATA_KEY_YEARContent = default;
        private static bool _METADATA_KEY_YEARReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#getBitmap(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap GetBitmap(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Bitmap>("getBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#getDescription()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.MediaDescription"/></returns>
        public Android.Media.MediaDescription GetDescription()
        {
            return IExecuteWithSignature<Android.Media.MediaDescription>("getDescription", "()Landroid/media/MediaDescription;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#getRating(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Media.Rating"/></returns>
        public Android.Media.Rating GetRating(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Media.Rating>("getRating", "(Ljava/lang/String;)Landroid/media/Rating;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#containsKey(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("containsKey", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#getBitmapDimensionLimit()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBitmapDimensionLimit()
        {
            return IExecuteWithSignature<int>("getBitmapDimensionLimit", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#getText(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetText(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getText", "(Ljava/lang/String;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#getString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetString(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getString", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#keySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> KeySet()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("keySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#getLong(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<long>("getLong", "(Ljava/lang/String;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.Builder.html#%3Cinit%3E(android.media.MediaMetadata)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.MediaMetadata"/></param>
            public Builder(Android.Media.MediaMetadata arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.MediaMetadata"/></returns>
            public Android.Media.MediaMetadata Build()
            {
                return IExecuteWithSignature<Android.Media.MediaMetadata>("build", "()Landroid/media/MediaMetadata;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.Builder.html#putBitmap(java.lang.String,android.graphics.Bitmap)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Graphics.Bitmap"/></param>
            /// <returns><see cref="Android.Media.MediaMetadata.Builder"/></returns>
            public Android.Media.MediaMetadata.Builder PutBitmap(Java.Lang.String arg0, Android.Graphics.Bitmap arg1)
            {
                return IExecute<Android.Media.MediaMetadata.Builder>("putBitmap", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.Builder.html#putLong(java.lang.String,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <returns><see cref="Android.Media.MediaMetadata.Builder"/></returns>
            public Android.Media.MediaMetadata.Builder PutLong(Java.Lang.String arg0, long arg1)
            {
                return IExecute<Android.Media.MediaMetadata.Builder>("putLong", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.Builder.html#putRating(java.lang.String,android.media.Rating)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Media.Rating"/></param>
            /// <returns><see cref="Android.Media.MediaMetadata.Builder"/></returns>
            public Android.Media.MediaMetadata.Builder PutRating(Java.Lang.String arg0, Android.Media.Rating arg1)
            {
                return IExecute<Android.Media.MediaMetadata.Builder>("putRating", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.Builder.html#putString(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Media.MediaMetadata.Builder"/></returns>
            public Android.Media.MediaMetadata.Builder PutString(Java.Lang.String arg0, Java.Lang.String arg1)
            {
                return IExecute<Android.Media.MediaMetadata.Builder>("putString", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.Builder.html#putText(java.lang.String,java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Media.MediaMetadata.Builder"/></returns>
            public Android.Media.MediaMetadata.Builder PutText(Java.Lang.String arg0, Java.Lang.CharSequence arg1)
            {
                return IExecute<Android.Media.MediaMetadata.Builder>("putText", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaMetadata.Builder.html#setBitmapDimensionLimit(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.MediaMetadata.Builder"/></returns>
            public Android.Media.MediaMetadata.Builder SetBitmapDimensionLimit(int arg0)
            {
                return IExecuteWithSignature<Android.Media.MediaMetadata.Builder>("setBitmapDimensionLimit", "(I)Landroid/media/MediaMetadata$Builder;", arg0);
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