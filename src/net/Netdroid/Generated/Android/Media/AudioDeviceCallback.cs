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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Media
{
    #region AudioDeviceCallback
    public partial class AudioDeviceCallback
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
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceCallback.html#onAudioDevicesAdded(android.media.AudioDeviceInfo[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.AudioDeviceInfo"/></param>
        public void OnAudioDevicesAdded(Android.Media.AudioDeviceInfo[] arg0)
        {
            IExecuteWithSignature("onAudioDevicesAdded", "([Landroid/media/AudioDeviceInfo;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceCallback.html#onAudioDevicesRemoved(android.media.AudioDeviceInfo[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.AudioDeviceInfo"/></param>
        public void OnAudioDevicesRemoved(Android.Media.AudioDeviceInfo[] arg0)
        {
            IExecuteWithSignature("onAudioDevicesRemoved", "([Landroid/media/AudioDeviceInfo;)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}