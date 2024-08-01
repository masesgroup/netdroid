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

namespace Android.Content.Res
{
    #region AssetFileDescriptor
    public partial class AssetFileDescriptor : Android.Os.IParcelable, Java.Io.ICloseable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#%3Cinit%3E(android.os.ParcelFileDescriptor,long,long,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        public AssetFileDescriptor(Android.Os.ParcelFileDescriptor arg0, long arg1, long arg2, Android.Os.Bundle arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#%3Cinit%3E(android.os.ParcelFileDescriptor,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public AssetFileDescriptor(Android.Os.ParcelFileDescriptor arg0, long arg1, long arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Content.Res.AssetFileDescriptor"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Content.Res.AssetFileDescriptor t) => t.Cast<Android.Os.Parcelable>();
        /// <summary>
        /// Converter from <see cref="Android.Content.Res.AssetFileDescriptor"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Android.Content.Res.AssetFileDescriptor t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#UNKNOWN_LENGTH"/>
        /// </summary>
        public static long UNKNOWN_LENGTH { get { if (!_UNKNOWN_LENGTHReady) { _UNKNOWN_LENGTHContent = SGetField<long>(LocalBridgeClazz, "UNKNOWN_LENGTH"); _UNKNOWN_LENGTHReady = true; } return _UNKNOWN_LENGTHContent; } }
        private static long _UNKNOWN_LENGTHContent = default;
        private static bool _UNKNOWN_LENGTHReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#getParcelFileDescriptor()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        public Android.Os.ParcelFileDescriptor GetParcelFileDescriptor()
        {
            return IExecuteWithSignature<Android.Os.ParcelFileDescriptor>("getParcelFileDescriptor", "()Landroid/os/ParcelFileDescriptor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#getFileDescriptor()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.FileDescriptor"/></returns>
        public Java.Io.FileDescriptor GetFileDescriptor()
        {
            return IExecuteWithSignature<Java.Io.FileDescriptor>("getFileDescriptor", "()Ljava/io/FileDescriptor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#createInputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.FileInputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.FileInputStream CreateInputStream()
        {
            return IExecuteWithSignature<Java.Io.FileInputStream>("createInputStream", "()Ljava/io/FileInputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#createOutputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.FileOutputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.FileOutputStream CreateOutputStream()
        {
            return IExecuteWithSignature<Java.Io.FileOutputStream>("createOutputStream", "()Ljava/io/FileOutputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#getDeclaredLength()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDeclaredLength()
        {
            return IExecuteWithSignature<long>("getDeclaredLength", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#getLength()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetLength()
        {
            return IExecuteWithSignature<long>("getLength", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#getStartOffset()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetStartOffset()
        {
            return IExecuteWithSignature<long>("getStartOffset", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region AutoCloseInputStream
        public partial class AutoCloseInputStream
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.AutoCloseInputStream.html#%3Cinit%3E(android.content.res.AssetFileDescriptor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.AssetFileDescriptor"/></param>
            /// <exception cref="Java.Io.IOException"/>
            public AutoCloseInputStream(Android.Content.Res.AssetFileDescriptor arg0)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AutoCloseOutputStream
        public partial class AutoCloseOutputStream
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/res/AssetFileDescriptor.AutoCloseOutputStream.html#%3Cinit%3E(android.content.res.AssetFileDescriptor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.AssetFileDescriptor"/></param>
            /// <exception cref="Java.Io.IOException"/>
            public AutoCloseOutputStream(Android.Content.Res.AssetFileDescriptor arg0)
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