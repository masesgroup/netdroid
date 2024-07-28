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

namespace Android.Companion.Virtual
{
    #region VirtualDevice
    public partial class VirtualDevice
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDevice.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDevice.html#hasCustomSensorSupport()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasCustomSensorSupport()
        {
            return IExecuteWithSignature<bool>("hasCustomSensorSupport", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDevice.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDevice.html#getDeviceId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDeviceId()
        {
            return IExecuteWithSignature<int>("getDeviceId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDevice.html#getDisplayIds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetDisplayIds()
        {
            return IExecuteWithSignatureArray<int>("getDisplayIds", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDevice.html#getDisplayName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetDisplayName()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getDisplayName", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDevice.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDevice.html#getPersistentDeviceId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPersistentDeviceId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPersistentDeviceId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/virtual/VirtualDevice.html#writeToParcel(android.os.Parcel,int)"/>
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