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

namespace Android.Media.Tv
{
    #region AdBuffer
    public partial class AdBuffer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdBuffer.html#%3Cinit%3E(int,java.lang.String,android.os.SharedMemory,int,int,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.SharedMemory"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public AdBuffer(int arg0, Java.Lang.String arg1, Android.Os.SharedMemory arg2, int arg3, int arg4, long arg5, int arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdBuffer.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdBuffer.html#getSharedMemory()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.SharedMemory"/></returns>
        public Android.Os.SharedMemory GetSharedMemory()
        {
            return IExecuteWithSignature<Android.Os.SharedMemory>("getSharedMemory", "()Landroid/os/SharedMemory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdBuffer.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdBuffer.html#getFlags()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFlags()
        {
            return IExecuteWithSignature<int>("getFlags", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdBuffer.html#getId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetId()
        {
            return IExecuteWithSignature<int>("getId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdBuffer.html#getLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLength()
        {
            return IExecuteWithSignature<int>("getLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdBuffer.html#getOffset()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetOffset()
        {
            return IExecuteWithSignature<int>("getOffset", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdBuffer.html#getMimeType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMimeType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMimeType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdBuffer.html#getPresentationTimeUs()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetPresentationTimeUs()
        {
            return IExecuteWithSignature<long>("getPresentationTimeUs", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdBuffer.html#writeToParcel(android.os.Parcel,int)"/>
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