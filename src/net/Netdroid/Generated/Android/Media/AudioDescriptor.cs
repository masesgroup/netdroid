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

namespace Android.Media
{
    #region AudioDescriptor
    public partial class AudioDescriptor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDescriptor.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDescriptor.html#STANDARD_EDID"/>
        /// </summary>
        public static int STANDARD_EDID { get { if (!_STANDARD_EDIDReady) { _STANDARD_EDIDContent = SGetField<int>(LocalBridgeClazz, "STANDARD_EDID"); _STANDARD_EDIDReady = true; } return _STANDARD_EDIDContent; } }
        private static int _STANDARD_EDIDContent = default;
        private static bool _STANDARD_EDIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDescriptor.html#STANDARD_NONE"/>
        /// </summary>
        public static int STANDARD_NONE { get { if (!_STANDARD_NONEReady) { _STANDARD_NONEContent = SGetField<int>(LocalBridgeClazz, "STANDARD_NONE"); _STANDARD_NONEReady = true; } return _STANDARD_NONEContent; } }
        private static int _STANDARD_NONEContent = default;
        private static bool _STANDARD_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDescriptor.html#STANDARD_SADB"/>
        /// </summary>
        public static int STANDARD_SADB { get { if (!_STANDARD_SADBReady) { _STANDARD_SADBContent = SGetField<int>(LocalBridgeClazz, "STANDARD_SADB"); _STANDARD_SADBReady = true; } return _STANDARD_SADBContent; } }
        private static int _STANDARD_SADBContent = default;
        private static bool _STANDARD_SADBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDescriptor.html#STANDARD_VSADB"/>
        /// </summary>
        public static int STANDARD_VSADB { get { if (!_STANDARD_VSADBReady) { _STANDARD_VSADBContent = SGetField<int>(LocalBridgeClazz, "STANDARD_VSADB"); _STANDARD_VSADBReady = true; } return _STANDARD_VSADBContent; } }
        private static int _STANDARD_VSADBContent = default;
        private static bool _STANDARD_VSADBReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDescriptor.html#getDescriptor()"/> 
        /// </summary>
        public byte[] Descriptor
        {
            get { return IExecuteWithSignatureArray<byte>("getDescriptor", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDescriptor.html#getEncapsulationType()"/> 
        /// </summary>
        public int EncapsulationType
        {
            get { return IExecuteWithSignature<int>("getEncapsulationType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDescriptor.html#getStandard()"/> 
        /// </summary>
        public int Standard
        {
            get { return IExecuteWithSignature<int>("getStandard", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDescriptor.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDescriptor.html#writeToParcel(android.os.Parcel,int)"/>
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