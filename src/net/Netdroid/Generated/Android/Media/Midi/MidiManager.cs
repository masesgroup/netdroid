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

namespace Android.Media.Midi
{
    #region MidiManager
    public partial class MidiManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.html#TRANSPORT_MIDI_BYTE_STREAM"/>
        /// </summary>
        public static int TRANSPORT_MIDI_BYTE_STREAM { get { if (!_TRANSPORT_MIDI_BYTE_STREAMReady) { _TRANSPORT_MIDI_BYTE_STREAMContent = SGetField<int>(LocalBridgeClazz, "TRANSPORT_MIDI_BYTE_STREAM"); _TRANSPORT_MIDI_BYTE_STREAMReady = true; } return _TRANSPORT_MIDI_BYTE_STREAMContent; } }
        private static int _TRANSPORT_MIDI_BYTE_STREAMContent = default;
        private static bool _TRANSPORT_MIDI_BYTE_STREAMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.html#TRANSPORT_UNIVERSAL_MIDI_PACKETS"/>
        /// </summary>
        public static int TRANSPORT_UNIVERSAL_MIDI_PACKETS { get { if (!_TRANSPORT_UNIVERSAL_MIDI_PACKETSReady) { _TRANSPORT_UNIVERSAL_MIDI_PACKETSContent = SGetField<int>(LocalBridgeClazz, "TRANSPORT_UNIVERSAL_MIDI_PACKETS"); _TRANSPORT_UNIVERSAL_MIDI_PACKETSReady = true; } return _TRANSPORT_UNIVERSAL_MIDI_PACKETSContent; } }
        private static int _TRANSPORT_UNIVERSAL_MIDI_PACKETSContent = default;
        private static bool _TRANSPORT_UNIVERSAL_MIDI_PACKETSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.html#getDevices()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Midi.MidiDeviceInfo"/></returns>
        [global::System.Obsolete()]
        public Android.Media.Midi.MidiDeviceInfo[] GetDevices()
        {
            return IExecuteWithSignatureArray<Android.Media.Midi.MidiDeviceInfo>("getDevices", "()[Landroid/media/midi/MidiDeviceInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.html#getDevicesForTransport(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Media.Midi.MidiDeviceInfo> GetDevicesForTransport(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Media.Midi.MidiDeviceInfo>>("getDevicesForTransport", "(I)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.html#openBluetoothDevice(android.bluetooth.BluetoothDevice,android.media.midi.MidiManager.OnDeviceOpenedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="Android.Media.Midi.MidiManager.OnDeviceOpenedListener"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        public void OpenBluetoothDevice(Android.Bluetooth.BluetoothDevice arg0, Android.Media.Midi.MidiManager.OnDeviceOpenedListener arg1, Android.Os.Handler arg2)
        {
            IExecute("openBluetoothDevice", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.html#openDevice(android.media.midi.MidiDeviceInfo,android.media.midi.MidiManager.OnDeviceOpenedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Midi.MidiDeviceInfo"/></param>
        /// <param name="arg1"><see cref="Android.Media.Midi.MidiManager.OnDeviceOpenedListener"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        public void OpenDevice(Android.Media.Midi.MidiDeviceInfo arg0, Android.Media.Midi.MidiManager.OnDeviceOpenedListener arg1, Android.Os.Handler arg2)
        {
            IExecute("openDevice", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.html#registerDeviceCallback(android.media.midi.MidiManager.DeviceCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Midi.MidiManager.DeviceCallback"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        [global::System.Obsolete()]
        public void RegisterDeviceCallback(Android.Media.Midi.MidiManager.DeviceCallback arg0, Android.Os.Handler arg1)
        {
            IExecute("registerDeviceCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.html#registerDeviceCallback(int,java.util.concurrent.Executor,android.media.midi.MidiManager.DeviceCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Media.Midi.MidiManager.DeviceCallback"/></param>
        public void RegisterDeviceCallback(int arg0, Java.Util.Concurrent.Executor arg1, Android.Media.Midi.MidiManager.DeviceCallback arg2)
        {
            IExecute("registerDeviceCallback", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.html#unregisterDeviceCallback(android.media.midi.MidiManager.DeviceCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Midi.MidiManager.DeviceCallback"/></param>
        public void UnregisterDeviceCallback(Android.Media.Midi.MidiManager.DeviceCallback arg0)
        {
            IExecuteWithSignature("unregisterDeviceCallback", "(Landroid/media/midi/MidiManager$DeviceCallback;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region DeviceCallback
        public partial class DeviceCallback
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
            /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.DeviceCallback.html#onDeviceAdded(android.media.midi.MidiDeviceInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Midi.MidiDeviceInfo"/></param>
            public void OnDeviceAdded(Android.Media.Midi.MidiDeviceInfo arg0)
            {
                IExecuteWithSignature("onDeviceAdded", "(Landroid/media/midi/MidiDeviceInfo;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.DeviceCallback.html#onDeviceRemoved(android.media.midi.MidiDeviceInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Midi.MidiDeviceInfo"/></param>
            public void OnDeviceRemoved(Android.Media.Midi.MidiDeviceInfo arg0)
            {
                IExecuteWithSignature("onDeviceRemoved", "(Landroid/media/midi/MidiDeviceInfo;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.DeviceCallback.html#onDeviceStatusChanged(android.media.midi.MidiDeviceStatus)"/>
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

        #region OnDeviceOpenedListener
        public partial class OnDeviceOpenedListener
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
            /// Handlers initializer for <see cref="OnDeviceOpenedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onDeviceOpened", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.Midi.MidiDevice>>>(OnDeviceOpenedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/midi/MidiManager.OnDeviceOpenedListener.html#onDeviceOpened(android.media.midi.MidiDevice)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnDeviceOpened"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.Midi.MidiDevice> OnOnDeviceOpened { get; set; } = null;

            void OnDeviceOpenedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.Midi.MidiDevice>> data)
            {
                var methodToExecute = (OnOnDeviceOpened != null) ? OnOnDeviceOpened : OnDeviceOpened;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.OnDeviceOpenedListener.html#onDeviceOpened(android.media.midi.MidiDevice)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Midi.MidiDevice"/></param>
            public virtual void OnDeviceOpened(Android.Media.Midi.MidiDevice arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnDeviceOpenedListenerDirect
        public partial class OnDeviceOpenedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/midi/MidiManager.OnDeviceOpenedListener.html#onDeviceOpened(android.media.midi.MidiDevice)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Midi.MidiDevice"/></param>
            public override void OnDeviceOpened(Android.Media.Midi.MidiDevice arg0)
            {
                IExecuteWithSignature("onDeviceOpened", "(Landroid/media/midi/MidiDevice;)V", arg0);
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