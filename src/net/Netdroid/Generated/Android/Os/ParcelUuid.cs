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

namespace Android.Os
{
    #region ParcelUuid
    public partial class ParcelUuid
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelUuid.html#%3Cinit%3E(java.util.UUID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        public ParcelUuid(Java.Util.UUID arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelUuid.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelUuid.html#fromString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.ParcelUuid"/></returns>
        public static Android.Os.ParcelUuid FromString(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Os.ParcelUuid>(LocalBridgeClazz, "fromString", "(Ljava/lang/String;)Landroid/os/ParcelUuid;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelUuid.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelUuid.html#getUuid()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.UUID"/></returns>
        public Java.Util.UUID GetUuid()
        {
            return IExecuteWithSignature<Java.Util.UUID>("getUuid", "()Ljava/util/UUID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelUuid.html#writeToParcel(android.os.Parcel,int)"/>
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