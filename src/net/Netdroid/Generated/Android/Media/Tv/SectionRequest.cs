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

namespace Android.Media.Tv
{
    #region SectionRequest
    public partial class SectionRequest
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/SectionRequest.html#%3Cinit%3E(int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public SectionRequest(int arg0, int arg1, int arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/SectionRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/SectionRequest.html#getTableId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTableId()
        {
            return IExecuteWithSignature<int>("getTableId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/SectionRequest.html#getTsPid()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTsPid()
        {
            return IExecuteWithSignature<int>("getTsPid", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/SectionRequest.html#getVersion()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVersion()
        {
            return IExecuteWithSignature<int>("getVersion", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}