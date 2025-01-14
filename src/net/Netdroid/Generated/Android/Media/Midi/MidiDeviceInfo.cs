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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Media.Midi
{
    #region MidiDeviceInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html"/>
    /// </summary>
    public partial class MidiDeviceInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.media.midi.MidiDeviceInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MidiDeviceInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MidiDeviceInfo(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region PortInfo declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.PortInfo.html"/>
        /// </summary>
        public partial class PortInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PortInfo>
        {
            const string _bridgeClassName = "android.media.midi.MidiDeviceInfo$PortInfo";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public PortInfo() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public PortInfo(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region MidiDeviceInfo implementation
    public partial class MidiDeviceInfo
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITS"/>
        /// </summary>
        public static int PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITS { get { if (!_PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITSReady) { _PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITSContent = SGetField<int>(LocalBridgeClazz, "PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITS"); _PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITSReady = true; } return _PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITSContent; } }
        private static int _PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITSContent = default;
        private static bool _PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITS_AND_JRTS"/>
        /// </summary>
        public static int PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITS_AND_JRTS { get { if (!_PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITS_AND_JRTSReady) { _PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITS_AND_JRTSContent = SGetField<int>(LocalBridgeClazz, "PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITS_AND_JRTS"); _PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITS_AND_JRTSReady = true; } return _PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITS_AND_JRTSContent; } }
        private static int _PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITS_AND_JRTSContent = default;
        private static bool _PROTOCOL_UMP_MIDI_1_0_UP_TO_128_BITS_AND_JRTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITS"/>
        /// </summary>
        public static int PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITS { get { if (!_PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITSReady) { _PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITSContent = SGetField<int>(LocalBridgeClazz, "PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITS"); _PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITSReady = true; } return _PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITSContent; } }
        private static int _PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITSContent = default;
        private static bool _PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITS_AND_JRTS"/>
        /// </summary>
        public static int PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITS_AND_JRTS { get { if (!_PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITS_AND_JRTSReady) { _PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITS_AND_JRTSContent = SGetField<int>(LocalBridgeClazz, "PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITS_AND_JRTS"); _PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITS_AND_JRTSReady = true; } return _PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITS_AND_JRTSContent; } }
        private static int _PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITS_AND_JRTSContent = default;
        private static bool _PROTOCOL_UMP_MIDI_1_0_UP_TO_64_BITS_AND_JRTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROTOCOL_UMP_MIDI_2_0"/>
        /// </summary>
        public static int PROTOCOL_UMP_MIDI_2_0 { get { if (!_PROTOCOL_UMP_MIDI_2_0Ready) { _PROTOCOL_UMP_MIDI_2_0Content = SGetField<int>(LocalBridgeClazz, "PROTOCOL_UMP_MIDI_2_0"); _PROTOCOL_UMP_MIDI_2_0Ready = true; } return _PROTOCOL_UMP_MIDI_2_0Content; } }
        private static int _PROTOCOL_UMP_MIDI_2_0Content = default;
        private static bool _PROTOCOL_UMP_MIDI_2_0Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROTOCOL_UMP_MIDI_2_0_AND_JRTS"/>
        /// </summary>
        public static int PROTOCOL_UMP_MIDI_2_0_AND_JRTS { get { if (!_PROTOCOL_UMP_MIDI_2_0_AND_JRTSReady) { _PROTOCOL_UMP_MIDI_2_0_AND_JRTSContent = SGetField<int>(LocalBridgeClazz, "PROTOCOL_UMP_MIDI_2_0_AND_JRTS"); _PROTOCOL_UMP_MIDI_2_0_AND_JRTSReady = true; } return _PROTOCOL_UMP_MIDI_2_0_AND_JRTSContent; } }
        private static int _PROTOCOL_UMP_MIDI_2_0_AND_JRTSContent = default;
        private static bool _PROTOCOL_UMP_MIDI_2_0_AND_JRTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROTOCOL_UMP_USE_MIDI_CI"/>
        /// </summary>
        public static int PROTOCOL_UMP_USE_MIDI_CI { get { if (!_PROTOCOL_UMP_USE_MIDI_CIReady) { _PROTOCOL_UMP_USE_MIDI_CIContent = SGetField<int>(LocalBridgeClazz, "PROTOCOL_UMP_USE_MIDI_CI"); _PROTOCOL_UMP_USE_MIDI_CIReady = true; } return _PROTOCOL_UMP_USE_MIDI_CIContent; } }
        private static int _PROTOCOL_UMP_USE_MIDI_CIContent = default;
        private static bool _PROTOCOL_UMP_USE_MIDI_CIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROTOCOL_UNKNOWN"/>
        /// </summary>
        public static int PROTOCOL_UNKNOWN { get { if (!_PROTOCOL_UNKNOWNReady) { _PROTOCOL_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "PROTOCOL_UNKNOWN"); _PROTOCOL_UNKNOWNReady = true; } return _PROTOCOL_UNKNOWNContent; } }
        private static int _PROTOCOL_UNKNOWNContent = default;
        private static bool _PROTOCOL_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#TYPE_BLUETOOTH"/>
        /// </summary>
        public static int TYPE_BLUETOOTH { get { if (!_TYPE_BLUETOOTHReady) { _TYPE_BLUETOOTHContent = SGetField<int>(LocalBridgeClazz, "TYPE_BLUETOOTH"); _TYPE_BLUETOOTHReady = true; } return _TYPE_BLUETOOTHContent; } }
        private static int _TYPE_BLUETOOTHContent = default;
        private static bool _TYPE_BLUETOOTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#TYPE_USB"/>
        /// </summary>
        public static int TYPE_USB { get { if (!_TYPE_USBReady) { _TYPE_USBContent = SGetField<int>(LocalBridgeClazz, "TYPE_USB"); _TYPE_USBReady = true; } return _TYPE_USBContent; } }
        private static int _TYPE_USBContent = default;
        private static bool _TYPE_USBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#TYPE_VIRTUAL"/>
        /// </summary>
        public static int TYPE_VIRTUAL { get { if (!_TYPE_VIRTUALReady) { _TYPE_VIRTUALContent = SGetField<int>(LocalBridgeClazz, "TYPE_VIRTUAL"); _TYPE_VIRTUALReady = true; } return _TYPE_VIRTUALContent; } }
        private static int _TYPE_VIRTUALContent = default;
        private static bool _TYPE_VIRTUALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROPERTY_BLUETOOTH_DEVICE"/>
        /// </summary>
        public static Java.Lang.String PROPERTY_BLUETOOTH_DEVICE { get { if (!_PROPERTY_BLUETOOTH_DEVICEReady) { _PROPERTY_BLUETOOTH_DEVICEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PROPERTY_BLUETOOTH_DEVICE"); _PROPERTY_BLUETOOTH_DEVICEReady = true; } return _PROPERTY_BLUETOOTH_DEVICEContent; } }
        private static Java.Lang.String _PROPERTY_BLUETOOTH_DEVICEContent = default;
        private static bool _PROPERTY_BLUETOOTH_DEVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROPERTY_MANUFACTURER"/>
        /// </summary>
        public static Java.Lang.String PROPERTY_MANUFACTURER { get { if (!_PROPERTY_MANUFACTURERReady) { _PROPERTY_MANUFACTURERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PROPERTY_MANUFACTURER"); _PROPERTY_MANUFACTURERReady = true; } return _PROPERTY_MANUFACTURERContent; } }
        private static Java.Lang.String _PROPERTY_MANUFACTURERContent = default;
        private static bool _PROPERTY_MANUFACTURERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROPERTY_NAME"/>
        /// </summary>
        public static Java.Lang.String PROPERTY_NAME { get { if (!_PROPERTY_NAMEReady) { _PROPERTY_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PROPERTY_NAME"); _PROPERTY_NAMEReady = true; } return _PROPERTY_NAMEContent; } }
        private static Java.Lang.String _PROPERTY_NAMEContent = default;
        private static bool _PROPERTY_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROPERTY_PRODUCT"/>
        /// </summary>
        public static Java.Lang.String PROPERTY_PRODUCT { get { if (!_PROPERTY_PRODUCTReady) { _PROPERTY_PRODUCTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PROPERTY_PRODUCT"); _PROPERTY_PRODUCTReady = true; } return _PROPERTY_PRODUCTContent; } }
        private static Java.Lang.String _PROPERTY_PRODUCTContent = default;
        private static bool _PROPERTY_PRODUCTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROPERTY_SERIAL_NUMBER"/>
        /// </summary>
        public static Java.Lang.String PROPERTY_SERIAL_NUMBER { get { if (!_PROPERTY_SERIAL_NUMBERReady) { _PROPERTY_SERIAL_NUMBERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PROPERTY_SERIAL_NUMBER"); _PROPERTY_SERIAL_NUMBERReady = true; } return _PROPERTY_SERIAL_NUMBERContent; } }
        private static Java.Lang.String _PROPERTY_SERIAL_NUMBERContent = default;
        private static bool _PROPERTY_SERIAL_NUMBERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROPERTY_USB_DEVICE"/>
        /// </summary>
        public static Java.Lang.String PROPERTY_USB_DEVICE { get { if (!_PROPERTY_USB_DEVICEReady) { _PROPERTY_USB_DEVICEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PROPERTY_USB_DEVICE"); _PROPERTY_USB_DEVICEReady = true; } return _PROPERTY_USB_DEVICEContent; } }
        private static Java.Lang.String _PROPERTY_USB_DEVICEContent = default;
        private static bool _PROPERTY_USB_DEVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#PROPERTY_VERSION"/>
        /// </summary>
        public static Java.Lang.String PROPERTY_VERSION { get { if (!_PROPERTY_VERSIONReady) { _PROPERTY_VERSIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PROPERTY_VERSION"); _PROPERTY_VERSIONReady = true; } return _PROPERTY_VERSIONContent; } }
        private static Java.Lang.String _PROPERTY_VERSIONContent = default;
        private static bool _PROPERTY_VERSIONReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#getPorts()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Midi.MidiDeviceInfo.PortInfo"/></returns>
        public Android.Media.Midi.MidiDeviceInfo.PortInfo[] GetPorts()
        {
            return IExecuteWithSignatureArray<Android.Media.Midi.MidiDeviceInfo.PortInfo>("getPorts", "()[Landroid/media/midi/MidiDeviceInfo$PortInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#getProperties()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetProperties()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getProperties", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#isPrivate()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPrivate()
        {
            return IExecuteWithSignature<bool>("isPrivate", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#getDefaultProtocol()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDefaultProtocol()
        {
            return IExecuteWithSignature<int>("getDefaultProtocol", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#getId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetId()
        {
            return IExecuteWithSignature<int>("getId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#getInputPortCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInputPortCount()
        {
            return IExecuteWithSignature<int>("getInputPortCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#getOutputPortCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetOutputPortCount()
        {
            return IExecuteWithSignature<int>("getOutputPortCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region PortInfo implementation
        public partial class PortInfo
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.PortInfo.html#TYPE_INPUT"/>
            /// </summary>
            public static int TYPE_INPUT { get { if (!_TYPE_INPUTReady) { _TYPE_INPUTContent = SGetField<int>(LocalBridgeClazz, "TYPE_INPUT"); _TYPE_INPUTReady = true; } return _TYPE_INPUTContent; } }
            private static int _TYPE_INPUTContent = default;
            private static bool _TYPE_INPUTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.PortInfo.html#TYPE_OUTPUT"/>
            /// </summary>
            public static int TYPE_OUTPUT { get { if (!_TYPE_OUTPUTReady) { _TYPE_OUTPUTContent = SGetField<int>(LocalBridgeClazz, "TYPE_OUTPUT"); _TYPE_OUTPUTReady = true; } return _TYPE_OUTPUTContent; } }
            private static int _TYPE_OUTPUTContent = default;
            private static bool _TYPE_OUTPUTReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.PortInfo.html#getPortNumber()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetPortNumber()
            {
                return IExecuteWithSignature<int>("getPortNumber", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.PortInfo.html#getType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetType()
            {
                return IExecuteWithSignature<int>("getType", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/midi/MidiDeviceInfo.PortInfo.html#getName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
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