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

namespace Android.Mtp
{
    #region MtpDeviceInfo
    public partial class MtpDeviceInfo
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
        /// <see href="https://developer.android.com/reference/android/mtp/MtpDeviceInfo.html#isEventSupported(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEventSupported(int arg0)
        {
            return IExecuteWithSignature<bool>("isEventSupported", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpDeviceInfo.html#isOperationSupported(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOperationSupported(int arg0)
        {
            return IExecuteWithSignature<bool>("isOperationSupported", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpDeviceInfo.html#getEventsSupported()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetEventsSupported()
        {
            return IExecuteWithSignatureArray<int>("getEventsSupported", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpDeviceInfo.html#getOperationsSupported()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetOperationsSupported()
        {
            return IExecuteWithSignatureArray<int>("getOperationsSupported", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpDeviceInfo.html#getManufacturer()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetManufacturer()
        {
            return IExecuteWithSignature<Java.Lang.String>("getManufacturer", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpDeviceInfo.html#getModel()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetModel()
        {
            return IExecuteWithSignature<Java.Lang.String>("getModel", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpDeviceInfo.html#getSerialNumber()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSerialNumber()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSerialNumber", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpDeviceInfo.html#getVersion()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetVersion()
        {
            return IExecuteWithSignature<Java.Lang.String>("getVersion", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}