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

namespace Android.Companion
{
    #region CompanionDeviceService
    public partial class CompanionDeviceService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceService.html#attachSystemDataTransport(int,java.io.InputStream,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Android.Companion.DeviceNotAssociatedException"/>
        public void AttachSystemDataTransport(int arg0, Java.Io.InputStream arg1, Java.Io.OutputStream arg2)
        {
            IExecute("attachSystemDataTransport", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceService.html#detachSystemDataTransport(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Android.Companion.DeviceNotAssociatedException"/>
        public void DetachSystemDataTransport(int arg0)
        {
            IExecuteWithSignature("detachSystemDataTransport", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceService.html#onDeviceAppeared(android.companion.AssociationInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Companion.AssociationInfo"/></param>
        public void OnDeviceAppeared(Android.Companion.AssociationInfo arg0)
        {
            IExecuteWithSignature("onDeviceAppeared", "(Landroid/companion/AssociationInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceService.html#onDeviceDisappeared(android.companion.AssociationInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Companion.AssociationInfo"/></param>
        public void OnDeviceDisappeared(Android.Companion.AssociationInfo arg0)
        {
            IExecuteWithSignature("onDeviceDisappeared", "(Landroid/companion/AssociationInfo;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}