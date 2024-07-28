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

namespace Android.Content.Pm
{
    #region Checksum
    public partial class Checksum
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/Checksum.html#%3Cinit%3E(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public Checksum(int arg0, byte[] arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/Checksum.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/Checksum.html#TYPE_PARTIAL_MERKLE_ROOT_1M_SHA256"/>
        /// </summary>
        public static int TYPE_PARTIAL_MERKLE_ROOT_1M_SHA256 { get { if (!_TYPE_PARTIAL_MERKLE_ROOT_1M_SHA256Ready) { _TYPE_PARTIAL_MERKLE_ROOT_1M_SHA256Content = SGetField<int>(LocalBridgeClazz, "TYPE_PARTIAL_MERKLE_ROOT_1M_SHA256"); _TYPE_PARTIAL_MERKLE_ROOT_1M_SHA256Ready = true; } return _TYPE_PARTIAL_MERKLE_ROOT_1M_SHA256Content; } }
        private static int _TYPE_PARTIAL_MERKLE_ROOT_1M_SHA256Content = default;
        private static bool _TYPE_PARTIAL_MERKLE_ROOT_1M_SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/Checksum.html#TYPE_PARTIAL_MERKLE_ROOT_1M_SHA512"/>
        /// </summary>
        public static int TYPE_PARTIAL_MERKLE_ROOT_1M_SHA512 { get { if (!_TYPE_PARTIAL_MERKLE_ROOT_1M_SHA512Ready) { _TYPE_PARTIAL_MERKLE_ROOT_1M_SHA512Content = SGetField<int>(LocalBridgeClazz, "TYPE_PARTIAL_MERKLE_ROOT_1M_SHA512"); _TYPE_PARTIAL_MERKLE_ROOT_1M_SHA512Ready = true; } return _TYPE_PARTIAL_MERKLE_ROOT_1M_SHA512Content; } }
        private static int _TYPE_PARTIAL_MERKLE_ROOT_1M_SHA512Content = default;
        private static bool _TYPE_PARTIAL_MERKLE_ROOT_1M_SHA512Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/Checksum.html#TYPE_WHOLE_MD5"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_WHOLE_MD5 { get { if (!_TYPE_WHOLE_MD5Ready) { _TYPE_WHOLE_MD5Content = SGetField<int>(LocalBridgeClazz, "TYPE_WHOLE_MD5"); _TYPE_WHOLE_MD5Ready = true; } return _TYPE_WHOLE_MD5Content; } }
        private static int _TYPE_WHOLE_MD5Content = default;
        private static bool _TYPE_WHOLE_MD5Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/Checksum.html#TYPE_WHOLE_MERKLE_ROOT_4K_SHA256"/>
        /// </summary>
        public static int TYPE_WHOLE_MERKLE_ROOT_4K_SHA256 { get { if (!_TYPE_WHOLE_MERKLE_ROOT_4K_SHA256Ready) { _TYPE_WHOLE_MERKLE_ROOT_4K_SHA256Content = SGetField<int>(LocalBridgeClazz, "TYPE_WHOLE_MERKLE_ROOT_4K_SHA256"); _TYPE_WHOLE_MERKLE_ROOT_4K_SHA256Ready = true; } return _TYPE_WHOLE_MERKLE_ROOT_4K_SHA256Content; } }
        private static int _TYPE_WHOLE_MERKLE_ROOT_4K_SHA256Content = default;
        private static bool _TYPE_WHOLE_MERKLE_ROOT_4K_SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/Checksum.html#TYPE_WHOLE_SHA1"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_WHOLE_SHA1 { get { if (!_TYPE_WHOLE_SHA1Ready) { _TYPE_WHOLE_SHA1Content = SGetField<int>(LocalBridgeClazz, "TYPE_WHOLE_SHA1"); _TYPE_WHOLE_SHA1Ready = true; } return _TYPE_WHOLE_SHA1Content; } }
        private static int _TYPE_WHOLE_SHA1Content = default;
        private static bool _TYPE_WHOLE_SHA1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/Checksum.html#TYPE_WHOLE_SHA256"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_WHOLE_SHA256 { get { if (!_TYPE_WHOLE_SHA256Ready) { _TYPE_WHOLE_SHA256Content = SGetField<int>(LocalBridgeClazz, "TYPE_WHOLE_SHA256"); _TYPE_WHOLE_SHA256Ready = true; } return _TYPE_WHOLE_SHA256Content; } }
        private static int _TYPE_WHOLE_SHA256Content = default;
        private static bool _TYPE_WHOLE_SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/Checksum.html#TYPE_WHOLE_SHA512"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_WHOLE_SHA512 { get { if (!_TYPE_WHOLE_SHA512Ready) { _TYPE_WHOLE_SHA512Content = SGetField<int>(LocalBridgeClazz, "TYPE_WHOLE_SHA512"); _TYPE_WHOLE_SHA512Ready = true; } return _TYPE_WHOLE_SHA512Content; } }
        private static int _TYPE_WHOLE_SHA512Content = default;
        private static bool _TYPE_WHOLE_SHA512Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/Checksum.html#getValue()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetValue()
        {
            return IExecuteWithSignatureArray<byte>("getValue", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/Checksum.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/Checksum.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/Checksum.html#writeToParcel(android.os.Parcel,int)"/>
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