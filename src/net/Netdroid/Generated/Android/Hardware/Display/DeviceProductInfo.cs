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

namespace Android.Hardware.Display
{
    #region DeviceProductInfo
    public partial class DeviceProductInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public DeviceProductInfo(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#CONNECTION_TO_SINK_BUILT_IN"/>
        /// </summary>
        public static int CONNECTION_TO_SINK_BUILT_IN { get { if (!_CONNECTION_TO_SINK_BUILT_INReady) { _CONNECTION_TO_SINK_BUILT_INContent = SGetField<int>(LocalBridgeClazz, "CONNECTION_TO_SINK_BUILT_IN"); _CONNECTION_TO_SINK_BUILT_INReady = true; } return _CONNECTION_TO_SINK_BUILT_INContent; } }
        private static int _CONNECTION_TO_SINK_BUILT_INContent = default;
        private static bool _CONNECTION_TO_SINK_BUILT_INReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#CONNECTION_TO_SINK_DIRECT"/>
        /// </summary>
        public static int CONNECTION_TO_SINK_DIRECT { get { if (!_CONNECTION_TO_SINK_DIRECTReady) { _CONNECTION_TO_SINK_DIRECTContent = SGetField<int>(LocalBridgeClazz, "CONNECTION_TO_SINK_DIRECT"); _CONNECTION_TO_SINK_DIRECTReady = true; } return _CONNECTION_TO_SINK_DIRECTContent; } }
        private static int _CONNECTION_TO_SINK_DIRECTContent = default;
        private static bool _CONNECTION_TO_SINK_DIRECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#CONNECTION_TO_SINK_TRANSITIVE"/>
        /// </summary>
        public static int CONNECTION_TO_SINK_TRANSITIVE { get { if (!_CONNECTION_TO_SINK_TRANSITIVEReady) { _CONNECTION_TO_SINK_TRANSITIVEContent = SGetField<int>(LocalBridgeClazz, "CONNECTION_TO_SINK_TRANSITIVE"); _CONNECTION_TO_SINK_TRANSITIVEReady = true; } return _CONNECTION_TO_SINK_TRANSITIVEContent; } }
        private static int _CONNECTION_TO_SINK_TRANSITIVEContent = default;
        private static bool _CONNECTION_TO_SINK_TRANSITIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#CONNECTION_TO_SINK_UNKNOWN"/>
        /// </summary>
        public static int CONNECTION_TO_SINK_UNKNOWN { get { if (!_CONNECTION_TO_SINK_UNKNOWNReady) { _CONNECTION_TO_SINK_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "CONNECTION_TO_SINK_UNKNOWN"); _CONNECTION_TO_SINK_UNKNOWNReady = true; } return _CONNECTION_TO_SINK_UNKNOWNContent; } }
        private static int _CONNECTION_TO_SINK_UNKNOWNContent = default;
        private static bool _CONNECTION_TO_SINK_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#getConnectionToSinkType()"/> 
        /// </summary>
        public int ConnectionToSinkType
        {
            get { return IExecuteWithSignature<int>("getConnectionToSinkType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#getManufacturerPnpId()"/> 
        /// </summary>
        public Java.Lang.String ManufacturerPnpId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getManufacturerPnpId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#getManufactureWeek()"/> 
        /// </summary>
        public int ManufactureWeek
        {
            get { return IExecuteWithSignature<int>("getManufactureWeek", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#getManufactureYear()"/> 
        /// </summary>
        public int ManufactureYear
        {
            get { return IExecuteWithSignature<int>("getManufactureYear", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#getModelYear()"/> 
        /// </summary>
        public int ModelYear
        {
            get { return IExecuteWithSignature<int>("getModelYear", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#getProductId()"/> 
        /// </summary>
        public Java.Lang.String ProductId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getProductId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/DeviceProductInfo.html#writeToParcel(android.os.Parcel,int)"/>
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