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

namespace Android.View
{
    #region InputEvent
    public partial class InputEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputEvent.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputEvent.html#getDeviceId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDeviceId()
        {
            return IExecuteWithSignature<int>("getDeviceId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputEvent.html#getSource()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSource()
        {
            return IExecuteWithSignature<int>("getSource", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputEvent.html#getEventTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetEventTime()
        {
            return IExecuteWithSignature<long>("getEventTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputEvent.html#isFromSource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsFromSource(int arg0)
        {
            return IExecuteWithSignature<bool>("isFromSource", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputEvent.html#getDevice()"/>
        /// </summary>
        /// <returns><see cref="Android.View.InputDevice"/></returns>
        public Android.View.InputDevice GetDevice()
        {
            return IExecuteWithSignature<Android.View.InputDevice>("getDevice", "()Landroid/view/InputDevice;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/InputEvent.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}