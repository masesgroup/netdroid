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

namespace Android.Media
{
    #region MediaDescription
    public partial class MediaDescription
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#EXTRA_BT_FOLDER_TYPE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_BT_FOLDER_TYPE { get { if (!_EXTRA_BT_FOLDER_TYPEReady) { _EXTRA_BT_FOLDER_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_BT_FOLDER_TYPE"); _EXTRA_BT_FOLDER_TYPEReady = true; } return _EXTRA_BT_FOLDER_TYPEContent; } }
        private static Java.Lang.String _EXTRA_BT_FOLDER_TYPEContent = default;
        private static bool _EXTRA_BT_FOLDER_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#BT_FOLDER_TYPE_ALBUMS"/>
        /// </summary>
        public static long BT_FOLDER_TYPE_ALBUMS { get { if (!_BT_FOLDER_TYPE_ALBUMSReady) { _BT_FOLDER_TYPE_ALBUMSContent = SGetField<long>(LocalBridgeClazz, "BT_FOLDER_TYPE_ALBUMS"); _BT_FOLDER_TYPE_ALBUMSReady = true; } return _BT_FOLDER_TYPE_ALBUMSContent; } }
        private static long _BT_FOLDER_TYPE_ALBUMSContent = default;
        private static bool _BT_FOLDER_TYPE_ALBUMSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#BT_FOLDER_TYPE_ARTISTS"/>
        /// </summary>
        public static long BT_FOLDER_TYPE_ARTISTS { get { if (!_BT_FOLDER_TYPE_ARTISTSReady) { _BT_FOLDER_TYPE_ARTISTSContent = SGetField<long>(LocalBridgeClazz, "BT_FOLDER_TYPE_ARTISTS"); _BT_FOLDER_TYPE_ARTISTSReady = true; } return _BT_FOLDER_TYPE_ARTISTSContent; } }
        private static long _BT_FOLDER_TYPE_ARTISTSContent = default;
        private static bool _BT_FOLDER_TYPE_ARTISTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#BT_FOLDER_TYPE_GENRES"/>
        /// </summary>
        public static long BT_FOLDER_TYPE_GENRES { get { if (!_BT_FOLDER_TYPE_GENRESReady) { _BT_FOLDER_TYPE_GENRESContent = SGetField<long>(LocalBridgeClazz, "BT_FOLDER_TYPE_GENRES"); _BT_FOLDER_TYPE_GENRESReady = true; } return _BT_FOLDER_TYPE_GENRESContent; } }
        private static long _BT_FOLDER_TYPE_GENRESContent = default;
        private static bool _BT_FOLDER_TYPE_GENRESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#BT_FOLDER_TYPE_MIXED"/>
        /// </summary>
        public static long BT_FOLDER_TYPE_MIXED { get { if (!_BT_FOLDER_TYPE_MIXEDReady) { _BT_FOLDER_TYPE_MIXEDContent = SGetField<long>(LocalBridgeClazz, "BT_FOLDER_TYPE_MIXED"); _BT_FOLDER_TYPE_MIXEDReady = true; } return _BT_FOLDER_TYPE_MIXEDContent; } }
        private static long _BT_FOLDER_TYPE_MIXEDContent = default;
        private static bool _BT_FOLDER_TYPE_MIXEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#BT_FOLDER_TYPE_PLAYLISTS"/>
        /// </summary>
        public static long BT_FOLDER_TYPE_PLAYLISTS { get { if (!_BT_FOLDER_TYPE_PLAYLISTSReady) { _BT_FOLDER_TYPE_PLAYLISTSContent = SGetField<long>(LocalBridgeClazz, "BT_FOLDER_TYPE_PLAYLISTS"); _BT_FOLDER_TYPE_PLAYLISTSReady = true; } return _BT_FOLDER_TYPE_PLAYLISTSContent; } }
        private static long _BT_FOLDER_TYPE_PLAYLISTSContent = default;
        private static bool _BT_FOLDER_TYPE_PLAYLISTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#BT_FOLDER_TYPE_TITLES"/>
        /// </summary>
        public static long BT_FOLDER_TYPE_TITLES { get { if (!_BT_FOLDER_TYPE_TITLESReady) { _BT_FOLDER_TYPE_TITLESContent = SGetField<long>(LocalBridgeClazz, "BT_FOLDER_TYPE_TITLES"); _BT_FOLDER_TYPE_TITLESReady = true; } return _BT_FOLDER_TYPE_TITLESContent; } }
        private static long _BT_FOLDER_TYPE_TITLESContent = default;
        private static bool _BT_FOLDER_TYPE_TITLESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#BT_FOLDER_TYPE_YEARS"/>
        /// </summary>
        public static long BT_FOLDER_TYPE_YEARS { get { if (!_BT_FOLDER_TYPE_YEARSReady) { _BT_FOLDER_TYPE_YEARSContent = SGetField<long>(LocalBridgeClazz, "BT_FOLDER_TYPE_YEARS"); _BT_FOLDER_TYPE_YEARSReady = true; } return _BT_FOLDER_TYPE_YEARSContent; } }
        private static long _BT_FOLDER_TYPE_YEARSContent = default;
        private static bool _BT_FOLDER_TYPE_YEARSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#getIconBitmap()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap GetIconBitmap()
        {
            return IExecuteWithSignature<Android.Graphics.Bitmap>("getIconBitmap", "()Landroid/graphics/Bitmap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#getIconUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetIconUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getIconUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#getMediaUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetMediaUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getMediaUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#getDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetDescription()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getDescription", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#getSubtitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetSubtitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getSubtitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#getTitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetTitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#getMediaId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMediaId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMediaId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaDescription.html#writeToParcel(android.os.Parcel,int)"/>
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

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaDescription.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.MediaDescription"/></returns>
            public Android.Media.MediaDescription Build()
            {
                return IExecuteWithSignature<Android.Media.MediaDescription>("build", "()Landroid/media/MediaDescription;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaDescription.Builder.html#setDescription(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Media.MediaDescription.Builder"/></returns>
            public Android.Media.MediaDescription.Builder SetDescription(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Media.MediaDescription.Builder>("setDescription", "(Ljava/lang/CharSequence;)Landroid/media/MediaDescription$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaDescription.Builder.html#setExtras(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Media.MediaDescription.Builder"/></returns>
            public Android.Media.MediaDescription.Builder SetExtras(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.Media.MediaDescription.Builder>("setExtras", "(Landroid/os/Bundle;)Landroid/media/MediaDescription$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaDescription.Builder.html#setIconBitmap(android.graphics.Bitmap)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
            /// <returns><see cref="Android.Media.MediaDescription.Builder"/></returns>
            public Android.Media.MediaDescription.Builder SetIconBitmap(Android.Graphics.Bitmap arg0)
            {
                return IExecuteWithSignature<Android.Media.MediaDescription.Builder>("setIconBitmap", "(Landroid/graphics/Bitmap;)Landroid/media/MediaDescription$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaDescription.Builder.html#setIconUri(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.Media.MediaDescription.Builder"/></returns>
            public Android.Media.MediaDescription.Builder SetIconUri(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.Media.MediaDescription.Builder>("setIconUri", "(Landroid/net/Uri;)Landroid/media/MediaDescription$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaDescription.Builder.html#setMediaId(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Media.MediaDescription.Builder"/></returns>
            public Android.Media.MediaDescription.Builder SetMediaId(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Media.MediaDescription.Builder>("setMediaId", "(Ljava/lang/String;)Landroid/media/MediaDescription$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaDescription.Builder.html#setMediaUri(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.Media.MediaDescription.Builder"/></returns>
            public Android.Media.MediaDescription.Builder SetMediaUri(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.Media.MediaDescription.Builder>("setMediaUri", "(Landroid/net/Uri;)Landroid/media/MediaDescription$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaDescription.Builder.html#setSubtitle(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Media.MediaDescription.Builder"/></returns>
            public Android.Media.MediaDescription.Builder SetSubtitle(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Media.MediaDescription.Builder>("setSubtitle", "(Ljava/lang/CharSequence;)Landroid/media/MediaDescription$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaDescription.Builder.html#setTitle(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Media.MediaDescription.Builder"/></returns>
            public Android.Media.MediaDescription.Builder SetTitle(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Media.MediaDescription.Builder>("setTitle", "(Ljava/lang/CharSequence;)Landroid/media/MediaDescription$Builder;", arg0);
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