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

namespace Android.Media.Midi
{
    #region MidiDeviceService
    public partial class MidiDeviceService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceService.html#getDeviceInfo()"/> 
        /// </summary>
        public Android.Media.Midi.MidiDeviceInfo DeviceInfo
        {
            get { return IExecuteWithSignature<Android.Media.Midi.MidiDeviceInfo>("getDeviceInfo", "()Landroid/media/midi/MidiDeviceInfo;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceService.html#getOutputPortReceivers()"/> 
        /// </summary>
        public Android.Media.Midi.MidiReceiver[] OutputPortReceivers
        {
            get { return IExecuteWithSignatureArray<Android.Media.Midi.MidiReceiver>("getOutputPortReceivers", "()[Landroid/media/midi/MidiReceiver;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceService.html#onGetInputPortReceivers()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Midi.MidiReceiver"/></returns>
        public Android.Media.Midi.MidiReceiver[] OnGetInputPortReceivers()
        {
            return IExecuteWithSignatureArray<Android.Media.Midi.MidiReceiver>("onGetInputPortReceivers", "()[Landroid/media/midi/MidiReceiver;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceService.html#onClose()"/>
        /// </summary>
        public void OnClose()
        {
            IExecuteWithSignature("onClose", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceService.html#onDeviceStatusChanged(android.media.midi.MidiDeviceStatus)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Midi.MidiDeviceStatus"/></param>
        public void OnDeviceStatusChanged(Android.Media.Midi.MidiDeviceStatus arg0)
        {
            IExecuteWithSignature("onDeviceStatusChanged", "(Landroid/media/midi/MidiDeviceStatus;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}