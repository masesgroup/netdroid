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
    #region StreamEventResponse
    public partial class StreamEventResponse
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/StreamEventResponse.html#%3Cinit%3E(int,int,int,int,long,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="byte"/></param>
        public StreamEventResponse(int arg0, int arg1, int arg2, int arg3, long arg4, byte[] arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/StreamEventResponse.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/StreamEventResponse.html#getData()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetData()
        {
            return IExecuteWithSignatureArray<byte>("getData", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/StreamEventResponse.html#getEventId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEventId()
        {
            return IExecuteWithSignature<int>("getEventId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/StreamEventResponse.html#getNptMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetNptMillis()
        {
            return IExecuteWithSignature<long>("getNptMillis", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}