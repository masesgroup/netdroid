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

namespace Android.Hardware
{
    #region HardwareBuffer
    public partial class HardwareBuffer : Android.Os.IParcelable, Java.Lang.IAutoCloseable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Hardware.HardwareBuffer"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Hardware.HardwareBuffer t) => t.Cast<Android.Os.Parcelable>();
        /// <summary>
        /// Converter from <see cref="Android.Hardware.HardwareBuffer"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Android.Hardware.HardwareBuffer t) => t.Cast<Java.Lang.AutoCloseable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#BLOB"/>
        /// </summary>
        public static int BLOB { get { if (!_BLOBReady) { _BLOBContent = SGetField<int>(LocalBridgeClazz, "BLOB"); _BLOBReady = true; } return _BLOBContent; } }
        private static int _BLOBContent = default;
        private static bool _BLOBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#D_16"/>
        /// </summary>
        public static int D_16 { get { if (!_D_16Ready) { _D_16Content = SGetField<int>(LocalBridgeClazz, "D_16"); _D_16Ready = true; } return _D_16Content; } }
        private static int _D_16Content = default;
        private static bool _D_16Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#D_24"/>
        /// </summary>
        public static int D_24 { get { if (!_D_24Ready) { _D_24Content = SGetField<int>(LocalBridgeClazz, "D_24"); _D_24Ready = true; } return _D_24Content; } }
        private static int _D_24Content = default;
        private static bool _D_24Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#D_FP32"/>
        /// </summary>
        public static int D_FP32 { get { if (!_D_FP32Ready) { _D_FP32Content = SGetField<int>(LocalBridgeClazz, "D_FP32"); _D_FP32Ready = true; } return _D_FP32Content; } }
        private static int _D_FP32Content = default;
        private static bool _D_FP32Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#DS_24UI8"/>
        /// </summary>
        public static int DS_24UI8 { get { if (!_DS_24UI8Ready) { _DS_24UI8Content = SGetField<int>(LocalBridgeClazz, "DS_24UI8"); _DS_24UI8Ready = true; } return _DS_24UI8Content; } }
        private static int _DS_24UI8Content = default;
        private static bool _DS_24UI8Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#DS_FP32UI8"/>
        /// </summary>
        public static int DS_FP32UI8 { get { if (!_DS_FP32UI8Ready) { _DS_FP32UI8Content = SGetField<int>(LocalBridgeClazz, "DS_FP32UI8"); _DS_FP32UI8Ready = true; } return _DS_FP32UI8Content; } }
        private static int _DS_FP32UI8Content = default;
        private static bool _DS_FP32UI8Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#RGB_565"/>
        /// </summary>
        public static int RGB_565 { get { if (!_RGB_565Ready) { _RGB_565Content = SGetField<int>(LocalBridgeClazz, "RGB_565"); _RGB_565Ready = true; } return _RGB_565Content; } }
        private static int _RGB_565Content = default;
        private static bool _RGB_565Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#RGB_888"/>
        /// </summary>
        public static int RGB_888 { get { if (!_RGB_888Ready) { _RGB_888Content = SGetField<int>(LocalBridgeClazz, "RGB_888"); _RGB_888Ready = true; } return _RGB_888Content; } }
        private static int _RGB_888Content = default;
        private static bool _RGB_888Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#RGBA_1010102"/>
        /// </summary>
        public static int RGBA_1010102 { get { if (!_RGBA_1010102Ready) { _RGBA_1010102Content = SGetField<int>(LocalBridgeClazz, "RGBA_1010102"); _RGBA_1010102Ready = true; } return _RGBA_1010102Content; } }
        private static int _RGBA_1010102Content = default;
        private static bool _RGBA_1010102Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#RGBA_8888"/>
        /// </summary>
        public static int RGBA_8888 { get { if (!_RGBA_8888Ready) { _RGBA_8888Content = SGetField<int>(LocalBridgeClazz, "RGBA_8888"); _RGBA_8888Ready = true; } return _RGBA_8888Content; } }
        private static int _RGBA_8888Content = default;
        private static bool _RGBA_8888Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#RGBA_FP16"/>
        /// </summary>
        public static int RGBA_FP16 { get { if (!_RGBA_FP16Ready) { _RGBA_FP16Content = SGetField<int>(LocalBridgeClazz, "RGBA_FP16"); _RGBA_FP16Ready = true; } return _RGBA_FP16Content; } }
        private static int _RGBA_FP16Content = default;
        private static bool _RGBA_FP16Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#RGBX_8888"/>
        /// </summary>
        public static int RGBX_8888 { get { if (!_RGBX_8888Ready) { _RGBX_8888Content = SGetField<int>(LocalBridgeClazz, "RGBX_8888"); _RGBX_8888Ready = true; } return _RGBX_8888Content; } }
        private static int _RGBX_8888Content = default;
        private static bool _RGBX_8888Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#S_UI8"/>
        /// </summary>
        public static int S_UI8 { get { if (!_S_UI8Ready) { _S_UI8Content = SGetField<int>(LocalBridgeClazz, "S_UI8"); _S_UI8Ready = true; } return _S_UI8Content; } }
        private static int _S_UI8Content = default;
        private static bool _S_UI8Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#YCBCR_420_888"/>
        /// </summary>
        public static int YCBCR_420_888 { get { if (!_YCBCR_420_888Ready) { _YCBCR_420_888Content = SGetField<int>(LocalBridgeClazz, "YCBCR_420_888"); _YCBCR_420_888Ready = true; } return _YCBCR_420_888Content; } }
        private static int _YCBCR_420_888Content = default;
        private static bool _YCBCR_420_888Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#YCBCR_P010"/>
        /// </summary>
        public static int YCBCR_P010 { get { if (!_YCBCR_P010Ready) { _YCBCR_P010Content = SGetField<int>(LocalBridgeClazz, "YCBCR_P010"); _YCBCR_P010Ready = true; } return _YCBCR_P010Content; } }
        private static int _YCBCR_P010Content = default;
        private static bool _YCBCR_P010Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_COMPOSER_OVERLAY"/>
        /// </summary>
        public static long USAGE_COMPOSER_OVERLAY { get { if (!_USAGE_COMPOSER_OVERLAYReady) { _USAGE_COMPOSER_OVERLAYContent = SGetField<long>(LocalBridgeClazz, "USAGE_COMPOSER_OVERLAY"); _USAGE_COMPOSER_OVERLAYReady = true; } return _USAGE_COMPOSER_OVERLAYContent; } }
        private static long _USAGE_COMPOSER_OVERLAYContent = default;
        private static bool _USAGE_COMPOSER_OVERLAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_CPU_READ_OFTEN"/>
        /// </summary>
        public static long USAGE_CPU_READ_OFTEN { get { if (!_USAGE_CPU_READ_OFTENReady) { _USAGE_CPU_READ_OFTENContent = SGetField<long>(LocalBridgeClazz, "USAGE_CPU_READ_OFTEN"); _USAGE_CPU_READ_OFTENReady = true; } return _USAGE_CPU_READ_OFTENContent; } }
        private static long _USAGE_CPU_READ_OFTENContent = default;
        private static bool _USAGE_CPU_READ_OFTENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_CPU_READ_RARELY"/>
        /// </summary>
        public static long USAGE_CPU_READ_RARELY { get { if (!_USAGE_CPU_READ_RARELYReady) { _USAGE_CPU_READ_RARELYContent = SGetField<long>(LocalBridgeClazz, "USAGE_CPU_READ_RARELY"); _USAGE_CPU_READ_RARELYReady = true; } return _USAGE_CPU_READ_RARELYContent; } }
        private static long _USAGE_CPU_READ_RARELYContent = default;
        private static bool _USAGE_CPU_READ_RARELYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_CPU_WRITE_OFTEN"/>
        /// </summary>
        public static long USAGE_CPU_WRITE_OFTEN { get { if (!_USAGE_CPU_WRITE_OFTENReady) { _USAGE_CPU_WRITE_OFTENContent = SGetField<long>(LocalBridgeClazz, "USAGE_CPU_WRITE_OFTEN"); _USAGE_CPU_WRITE_OFTENReady = true; } return _USAGE_CPU_WRITE_OFTENContent; } }
        private static long _USAGE_CPU_WRITE_OFTENContent = default;
        private static bool _USAGE_CPU_WRITE_OFTENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_CPU_WRITE_RARELY"/>
        /// </summary>
        public static long USAGE_CPU_WRITE_RARELY { get { if (!_USAGE_CPU_WRITE_RARELYReady) { _USAGE_CPU_WRITE_RARELYContent = SGetField<long>(LocalBridgeClazz, "USAGE_CPU_WRITE_RARELY"); _USAGE_CPU_WRITE_RARELYReady = true; } return _USAGE_CPU_WRITE_RARELYContent; } }
        private static long _USAGE_CPU_WRITE_RARELYContent = default;
        private static bool _USAGE_CPU_WRITE_RARELYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_FRONT_BUFFER"/>
        /// </summary>
        public static long USAGE_FRONT_BUFFER { get { if (!_USAGE_FRONT_BUFFERReady) { _USAGE_FRONT_BUFFERContent = SGetField<long>(LocalBridgeClazz, "USAGE_FRONT_BUFFER"); _USAGE_FRONT_BUFFERReady = true; } return _USAGE_FRONT_BUFFERContent; } }
        private static long _USAGE_FRONT_BUFFERContent = default;
        private static bool _USAGE_FRONT_BUFFERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_GPU_COLOR_OUTPUT"/>
        /// </summary>
        public static long USAGE_GPU_COLOR_OUTPUT { get { if (!_USAGE_GPU_COLOR_OUTPUTReady) { _USAGE_GPU_COLOR_OUTPUTContent = SGetField<long>(LocalBridgeClazz, "USAGE_GPU_COLOR_OUTPUT"); _USAGE_GPU_COLOR_OUTPUTReady = true; } return _USAGE_GPU_COLOR_OUTPUTContent; } }
        private static long _USAGE_GPU_COLOR_OUTPUTContent = default;
        private static bool _USAGE_GPU_COLOR_OUTPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_GPU_CUBE_MAP"/>
        /// </summary>
        public static long USAGE_GPU_CUBE_MAP { get { if (!_USAGE_GPU_CUBE_MAPReady) { _USAGE_GPU_CUBE_MAPContent = SGetField<long>(LocalBridgeClazz, "USAGE_GPU_CUBE_MAP"); _USAGE_GPU_CUBE_MAPReady = true; } return _USAGE_GPU_CUBE_MAPContent; } }
        private static long _USAGE_GPU_CUBE_MAPContent = default;
        private static bool _USAGE_GPU_CUBE_MAPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_GPU_DATA_BUFFER"/>
        /// </summary>
        public static long USAGE_GPU_DATA_BUFFER { get { if (!_USAGE_GPU_DATA_BUFFERReady) { _USAGE_GPU_DATA_BUFFERContent = SGetField<long>(LocalBridgeClazz, "USAGE_GPU_DATA_BUFFER"); _USAGE_GPU_DATA_BUFFERReady = true; } return _USAGE_GPU_DATA_BUFFERContent; } }
        private static long _USAGE_GPU_DATA_BUFFERContent = default;
        private static bool _USAGE_GPU_DATA_BUFFERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_GPU_MIPMAP_COMPLETE"/>
        /// </summary>
        public static long USAGE_GPU_MIPMAP_COMPLETE { get { if (!_USAGE_GPU_MIPMAP_COMPLETEReady) { _USAGE_GPU_MIPMAP_COMPLETEContent = SGetField<long>(LocalBridgeClazz, "USAGE_GPU_MIPMAP_COMPLETE"); _USAGE_GPU_MIPMAP_COMPLETEReady = true; } return _USAGE_GPU_MIPMAP_COMPLETEContent; } }
        private static long _USAGE_GPU_MIPMAP_COMPLETEContent = default;
        private static bool _USAGE_GPU_MIPMAP_COMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_GPU_SAMPLED_IMAGE"/>
        /// </summary>
        public static long USAGE_GPU_SAMPLED_IMAGE { get { if (!_USAGE_GPU_SAMPLED_IMAGEReady) { _USAGE_GPU_SAMPLED_IMAGEContent = SGetField<long>(LocalBridgeClazz, "USAGE_GPU_SAMPLED_IMAGE"); _USAGE_GPU_SAMPLED_IMAGEReady = true; } return _USAGE_GPU_SAMPLED_IMAGEContent; } }
        private static long _USAGE_GPU_SAMPLED_IMAGEContent = default;
        private static bool _USAGE_GPU_SAMPLED_IMAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_PROTECTED_CONTENT"/>
        /// </summary>
        public static long USAGE_PROTECTED_CONTENT { get { if (!_USAGE_PROTECTED_CONTENTReady) { _USAGE_PROTECTED_CONTENTContent = SGetField<long>(LocalBridgeClazz, "USAGE_PROTECTED_CONTENT"); _USAGE_PROTECTED_CONTENTReady = true; } return _USAGE_PROTECTED_CONTENTContent; } }
        private static long _USAGE_PROTECTED_CONTENTContent = default;
        private static bool _USAGE_PROTECTED_CONTENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_SENSOR_DIRECT_DATA"/>
        /// </summary>
        public static long USAGE_SENSOR_DIRECT_DATA { get { if (!_USAGE_SENSOR_DIRECT_DATAReady) { _USAGE_SENSOR_DIRECT_DATAContent = SGetField<long>(LocalBridgeClazz, "USAGE_SENSOR_DIRECT_DATA"); _USAGE_SENSOR_DIRECT_DATAReady = true; } return _USAGE_SENSOR_DIRECT_DATAContent; } }
        private static long _USAGE_SENSOR_DIRECT_DATAContent = default;
        private static bool _USAGE_SENSOR_DIRECT_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#USAGE_VIDEO_ENCODE"/>
        /// </summary>
        public static long USAGE_VIDEO_ENCODE { get { if (!_USAGE_VIDEO_ENCODEReady) { _USAGE_VIDEO_ENCODEContent = SGetField<long>(LocalBridgeClazz, "USAGE_VIDEO_ENCODE"); _USAGE_VIDEO_ENCODEReady = true; } return _USAGE_VIDEO_ENCODEContent; } }
        private static long _USAGE_VIDEO_ENCODEContent = default;
        private static bool _USAGE_VIDEO_ENCODEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#create(int,int,int,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <returns><see cref="Android.Hardware.HardwareBuffer"/></returns>
        public static Android.Hardware.HardwareBuffer Create(int arg0, int arg1, int arg2, int arg3, long arg4)
        {
            return SExecute<Android.Hardware.HardwareBuffer>(LocalBridgeClazz, "create", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#isSupported(int,int,int,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSupported(int arg0, int arg1, int arg2, int arg3, long arg4)
        {
            return SExecute<bool>(LocalBridgeClazz, "isSupported", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#getFormat()"/> 
        /// </summary>
        public int Format
        {
            get { return IExecuteWithSignature<int>("getFormat", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecuteWithSignature<int>("getHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#getId()"/> 
        /// </summary>
        public long Id
        {
            get { return IExecuteWithSignature<long>("getId", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#getLayers()"/> 
        /// </summary>
        public int Layers
        {
            get { return IExecuteWithSignature<int>("getLayers", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#getUsage()"/> 
        /// </summary>
        public long Usage
        {
            get { return IExecuteWithSignature<long>("getUsage", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecuteWithSignature<int>("getWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#isClosed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecuteWithSignature<bool>("isClosed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/HardwareBuffer.html#writeToParcel(android.os.Parcel,int)"/>
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