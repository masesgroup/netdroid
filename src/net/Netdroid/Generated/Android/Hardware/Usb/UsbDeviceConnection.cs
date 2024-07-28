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

namespace Android.Hardware.Usb
{
    #region UsbDeviceConnection
    public partial class UsbDeviceConnection
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
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#requestWait()"/>
        /// </summary>
        /// <returns><see cref="Android.Hardware.Usb.UsbRequest"/></returns>
        public Android.Hardware.Usb.UsbRequest RequestWait()
        {
            return IExecuteWithSignature<Android.Hardware.Usb.UsbRequest>("requestWait", "()Landroid/hardware/usb/UsbRequest;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#requestWait(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Android.Hardware.Usb.UsbRequest"/></returns>
        /// <exception cref="Java.Util.Concurrent.TimeoutException"/>
        public Android.Hardware.Usb.UsbRequest RequestWait(long arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Usb.UsbRequest>("requestWait", "(J)Landroid/hardware/usb/UsbRequest;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#claimInterface(android.hardware.usb.UsbInterface,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbInterface"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ClaimInterface(Android.Hardware.Usb.UsbInterface arg0, bool arg1)
        {
            return IExecute<bool>("claimInterface", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#releaseInterface(android.hardware.usb.UsbInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbInterface"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ReleaseInterface(Android.Hardware.Usb.UsbInterface arg0)
        {
            return IExecuteWithSignature<bool>("releaseInterface", "(Landroid/hardware/usb/UsbInterface;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#setConfiguration(android.hardware.usb.UsbConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbConfiguration"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetConfiguration(Android.Hardware.Usb.UsbConfiguration arg0)
        {
            return IExecuteWithSignature<bool>("setConfiguration", "(Landroid/hardware/usb/UsbConfiguration;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#setInterface(android.hardware.usb.UsbInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbInterface"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetInterface(Android.Hardware.Usb.UsbInterface arg0)
        {
            return IExecuteWithSignature<bool>("setInterface", "(Landroid/hardware/usb/UsbInterface;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#getRawDescriptors()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetRawDescriptors()
        {
            return IExecuteWithSignatureArray<byte>("getRawDescriptors", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#bulkTransfer(android.hardware.usb.UsbEndpoint,byte[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbEndpoint"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int BulkTransfer(Android.Hardware.Usb.UsbEndpoint arg0, byte[] arg1, int arg2, int arg3, int arg4)
        {
            return IExecute<int>("bulkTransfer", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#bulkTransfer(android.hardware.usb.UsbEndpoint,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbEndpoint"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int BulkTransfer(Android.Hardware.Usb.UsbEndpoint arg0, byte[] arg1, int arg2, int arg3)
        {
            return IExecute<int>("bulkTransfer", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#controlTransfer(int,int,int,int,byte[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="byte"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ControlTransfer(int arg0, int arg1, int arg2, int arg3, byte[] arg4, int arg5, int arg6, int arg7)
        {
            return IExecute<int>("controlTransfer", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#controlTransfer(int,int,int,int,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="byte"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ControlTransfer(int arg0, int arg1, int arg2, int arg3, byte[] arg4, int arg5, int arg6)
        {
            return IExecute<int>("controlTransfer", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#getFileDescriptor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFileDescriptor()
        {
            return IExecuteWithSignature<int>("getFileDescriptor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#getSerial()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSerial()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSerial", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDeviceConnection.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}