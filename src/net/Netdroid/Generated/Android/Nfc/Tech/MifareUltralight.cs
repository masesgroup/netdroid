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

namespace Android.Nfc.Tech
{
    #region MifareUltralight declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html"/>
    /// </summary>
    public partial class MifareUltralight : Android.Nfc.Tech.TagTechnology
    {
        const string _bridgeClassName = "android.nfc.tech.MifareUltralight";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MifareUltralight() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MifareUltralight(params object[] args) : base(args) { }
    
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

    #region MifareUltralight implementation
    public partial class MifareUltralight
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#PAGE_SIZE"/>
        /// </summary>
        public static int PAGE_SIZE { get { if (!_PAGE_SIZEReady) { _PAGE_SIZEContent = SGetField<int>(LocalBridgeClazz, "PAGE_SIZE"); _PAGE_SIZEReady = true; } return _PAGE_SIZEContent; } }
        private static int _PAGE_SIZEContent = default;
        private static bool _PAGE_SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#TYPE_ULTRALIGHT"/>
        /// </summary>
        public static int TYPE_ULTRALIGHT { get { if (!_TYPE_ULTRALIGHTReady) { _TYPE_ULTRALIGHTContent = SGetField<int>(LocalBridgeClazz, "TYPE_ULTRALIGHT"); _TYPE_ULTRALIGHTReady = true; } return _TYPE_ULTRALIGHTContent; } }
        private static int _TYPE_ULTRALIGHTContent = default;
        private static bool _TYPE_ULTRALIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#TYPE_ULTRALIGHT_C"/>
        /// </summary>
        public static int TYPE_ULTRALIGHT_C { get { if (!_TYPE_ULTRALIGHT_CReady) { _TYPE_ULTRALIGHT_CContent = SGetField<int>(LocalBridgeClazz, "TYPE_ULTRALIGHT_C"); _TYPE_ULTRALIGHT_CReady = true; } return _TYPE_ULTRALIGHT_CContent; } }
        private static int _TYPE_ULTRALIGHT_CContent = default;
        private static bool _TYPE_ULTRALIGHT_CReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#TYPE_UNKNOWN"/>
        /// </summary>
        public static int TYPE_UNKNOWN { get { if (!_TYPE_UNKNOWNReady) { _TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "TYPE_UNKNOWN"); _TYPE_UNKNOWNReady = true; } return _TYPE_UNKNOWNContent; } }
        private static int _TYPE_UNKNOWNContent = default;
        private static bool _TYPE_UNKNOWNReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#get(android.nfc.Tag)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Nfc.Tag"/></param>
        /// <returns><see cref="Android.Nfc.Tech.MifareUltralight"/></returns>
        public static Android.Nfc.Tech.MifareUltralight Get(Android.Nfc.Tag arg0)
        {
            return SExecuteWithSignature<Android.Nfc.Tech.MifareUltralight>(LocalBridgeClazz, "get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/MifareUltralight;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#getTag()"/>
        /// </summary>
        /// <returns><see cref="Android.Nfc.Tag"/></returns>
        public Android.Nfc.Tag GetTag()
        {
            return IExecuteWithSignature<Android.Nfc.Tag>("getTag", "()Landroid/nfc/Tag;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#readPages(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] ReadPages(int arg0)
        {
            return IExecuteWithSignatureArray<byte>("readPages", "(I)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#transceive(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] Transceive(byte[] arg0)
        {
            return IExecuteWithSignatureArray<byte>("transceive", "([B)[B", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#getMaxTransceiveLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxTransceiveLength()
        {
            return IExecuteWithSignature<int>("getMaxTransceiveLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#getTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTimeout()
        {
            return IExecuteWithSignature<int>("getTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#connect()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect()
        {
            IExecuteWithSignature("connect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#setTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetTimeout(int arg0)
        {
            IExecuteWithSignature("setTimeout", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareUltralight.html#writePage(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WritePage(int arg0, byte[] arg1)
        {
            IExecuteWithSignature("writePage", "(I[B)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}