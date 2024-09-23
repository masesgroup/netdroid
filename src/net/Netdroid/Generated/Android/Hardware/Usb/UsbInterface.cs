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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Hardware.Usb
{
    #region UsbInterface declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbInterface.html"/>
    /// </summary>
    public partial class UsbInterface : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.hardware.usb.UsbInterface";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UsbInterface() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UsbInterface(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region UsbInterface implementation
    public partial class UsbInterface
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbInterface.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbInterface.html#getEndpoint(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Hardware.Usb.UsbEndpoint"/></returns>
        public Android.Hardware.Usb.UsbEndpoint GetEndpoint(int arg0)
        {
            return IExecute<Android.Hardware.Usb.UsbEndpoint>("getEndpoint", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbInterface.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecute<int>("describeContents");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbInterface.html#getAlternateSetting()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAlternateSetting()
        {
            return IExecute<int>("getAlternateSetting");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbInterface.html#getEndpointCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEndpointCount()
        {
            return IExecute<int>("getEndpointCount");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbInterface.html#getId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetId()
        {
            return IExecute<int>("getId");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbInterface.html#getInterfaceClass()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInterfaceClass()
        {
            return IExecute<int>("getInterfaceClass");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbInterface.html#getInterfaceProtocol()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInterfaceProtocol()
        {
            return IExecute<int>("getInterfaceProtocol");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbInterface.html#getInterfaceSubclass()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInterfaceSubclass()
        {
            return IExecute<int>("getInterfaceSubclass");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbInterface.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecute<Java.Lang.String>("getName");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbInterface.html#writeToParcel(android.os.Parcel,int)"/>
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