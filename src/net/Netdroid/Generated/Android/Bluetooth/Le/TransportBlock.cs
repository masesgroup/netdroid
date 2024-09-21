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

namespace Android.Bluetooth.Le
{
    #region TransportBlock declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/bluetooth/le/TransportBlock.html"/>
    /// </summary>
    public partial class TransportBlock : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.bluetooth.le.TransportBlock";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TransportBlock() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TransportBlock(params object[] args) : base(args) { }

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

    #region TransportBlock implementation
    public partial class TransportBlock
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/TransportBlock.html#%3Cinit%3E(int,int,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        public TransportBlock(int arg0, int arg1, int arg2, byte[] arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/TransportBlock.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/TransportBlock.html#getTransportData()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetTransportData()
        {
            return IExecuteWithSignatureArray<byte>("getTransportData", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/TransportBlock.html#toByteArray()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] ToByteArray()
        {
            return IExecuteWithSignatureArray<byte>("toByteArray", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/TransportBlock.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/TransportBlock.html#getOrgId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetOrgId()
        {
            return IExecuteWithSignature<int>("getOrgId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/TransportBlock.html#getTdsFlags()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTdsFlags()
        {
            return IExecuteWithSignature<int>("getTdsFlags", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/TransportBlock.html#getTransportDataLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTransportDataLength()
        {
            return IExecuteWithSignature<int>("getTransportDataLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/TransportBlock.html#totalBytes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int TotalBytes()
        {
            return IExecuteWithSignature<int>("totalBytes", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/TransportBlock.html#writeToParcel(android.os.Parcel,int)"/>
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