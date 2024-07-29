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

namespace Android.Companion
{
    #region BluetoothLeDeviceFilter
    public partial class BluetoothLeDeviceFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/BluetoothLeDeviceFilter.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/BluetoothLeDeviceFilter.html#getRenamePrefixLengthLimit()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetRenamePrefixLengthLimit()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getRenamePrefixLengthLimit", "()I");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/BluetoothLeDeviceFilter.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/BluetoothLeDeviceFilter.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/companion/BluetoothLeDeviceFilter.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Companion.BluetoothLeDeviceFilter"/></returns>
            public Android.Companion.BluetoothLeDeviceFilter Build()
            {
                return IExecuteWithSignature<Android.Companion.BluetoothLeDeviceFilter>("build", "()Landroid/companion/BluetoothLeDeviceFilter;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/BluetoothLeDeviceFilter.Builder.html#setNamePattern(java.util.regex.Pattern)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
            /// <returns><see cref="Android.Companion.BluetoothLeDeviceFilter.Builder"/></returns>
            public Android.Companion.BluetoothLeDeviceFilter.Builder SetNamePattern(Java.Util.Regex.Pattern arg0)
            {
                return IExecuteWithSignature<Android.Companion.BluetoothLeDeviceFilter.Builder>("setNamePattern", "(Ljava/util/regex/Pattern;)Landroid/companion/BluetoothLeDeviceFilter$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/BluetoothLeDeviceFilter.Builder.html#setRawDataFilter(byte[],byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <returns><see cref="Android.Companion.BluetoothLeDeviceFilter.Builder"/></returns>
            public Android.Companion.BluetoothLeDeviceFilter.Builder SetRawDataFilter(byte[] arg0, byte[] arg1)
            {
                return IExecute<Android.Companion.BluetoothLeDeviceFilter.Builder>("setRawDataFilter", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/BluetoothLeDeviceFilter.Builder.html#setRenameFromBytes(java.lang.String,java.lang.String,int,int,java.nio.ByteOrder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="Java.Nio.ByteOrder"/></param>
            /// <returns><see cref="Android.Companion.BluetoothLeDeviceFilter.Builder"/></returns>
            public Android.Companion.BluetoothLeDeviceFilter.Builder SetRenameFromBytes(Java.Lang.String arg0, Java.Lang.String arg1, int arg2, int arg3, Java.Nio.ByteOrder arg4)
            {
                return IExecute<Android.Companion.BluetoothLeDeviceFilter.Builder>("setRenameFromBytes", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/BluetoothLeDeviceFilter.Builder.html#setRenameFromName(java.lang.String,java.lang.String,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <returns><see cref="Android.Companion.BluetoothLeDeviceFilter.Builder"/></returns>
            public Android.Companion.BluetoothLeDeviceFilter.Builder SetRenameFromName(Java.Lang.String arg0, Java.Lang.String arg1, int arg2, int arg3)
            {
                return IExecute<Android.Companion.BluetoothLeDeviceFilter.Builder>("setRenameFromName", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/BluetoothLeDeviceFilter.Builder.html#setScanFilter(android.bluetooth.le.ScanFilter)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Bluetooth.Le.ScanFilter"/></param>
            /// <returns><see cref="Android.Companion.BluetoothLeDeviceFilter.Builder"/></returns>
            public Android.Companion.BluetoothLeDeviceFilter.Builder SetScanFilter(Android.Bluetooth.Le.ScanFilter arg0)
            {
                return IExecuteWithSignature<Android.Companion.BluetoothLeDeviceFilter.Builder>("setScanFilter", "(Landroid/bluetooth/le/ScanFilter;)Landroid/companion/BluetoothLeDeviceFilter$Builder;", arg0);
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