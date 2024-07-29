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

namespace Android.Hardware.Usb
{
    #region UsbRequest
    public partial class UsbRequest
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
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbRequest.html#getEndpoint()"/>
        /// </summary>
        /// <returns><see cref="Android.Hardware.Usb.UsbEndpoint"/></returns>
        public Android.Hardware.Usb.UsbEndpoint GetEndpoint()
        {
            return IExecuteWithSignature<Android.Hardware.Usb.UsbEndpoint>("getEndpoint", "()Landroid/hardware/usb/UsbEndpoint;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbRequest.html#cancel()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Cancel()
        {
            return IExecuteWithSignature<bool>("cancel", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbRequest.html#initialize(android.hardware.usb.UsbDeviceConnection,android.hardware.usb.UsbEndpoint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbDeviceConnection"/></param>
        /// <param name="arg1"><see cref="Android.Hardware.Usb.UsbEndpoint"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Initialize(Android.Hardware.Usb.UsbDeviceConnection arg0, Android.Hardware.Usb.UsbEndpoint arg1)
        {
            return IExecute<bool>("initialize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbRequest.html#queue(java.nio.ByteBuffer,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool Queue(Java.Nio.ByteBuffer arg0, int arg1)
        {
            return IExecute<bool>("queue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbRequest.html#queue(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Queue(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<bool>("queue", "(Ljava/nio/ByteBuffer;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbRequest.html#getClientData()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object GetClientData()
        {
            return IExecuteWithSignature("getClientData", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbRequest.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbRequest.html#setClientData(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetClientData(object arg0)
        {
            IExecuteWithSignature("setClientData", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}