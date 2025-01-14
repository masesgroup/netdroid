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
    #region Ndef declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html"/>
    /// </summary>
    public partial class Ndef : Android.Nfc.Tech.TagTechnology
    {
        const string _bridgeClassName = "android.nfc.tech.Ndef";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Ndef() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Ndef(params object[] args) : base(args) { }
    
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

    #region Ndef implementation
    public partial class Ndef
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#MIFARE_CLASSIC"/>
        /// </summary>
        public static Java.Lang.String MIFARE_CLASSIC { get { if (!_MIFARE_CLASSICReady) { _MIFARE_CLASSICContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MIFARE_CLASSIC"); _MIFARE_CLASSICReady = true; } return _MIFARE_CLASSICContent; } }
        private static Java.Lang.String _MIFARE_CLASSICContent = default;
        private static bool _MIFARE_CLASSICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#NFC_FORUM_TYPE_1"/>
        /// </summary>
        public static Java.Lang.String NFC_FORUM_TYPE_1 { get { if (!_NFC_FORUM_TYPE_1Ready) { _NFC_FORUM_TYPE_1Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "NFC_FORUM_TYPE_1"); _NFC_FORUM_TYPE_1Ready = true; } return _NFC_FORUM_TYPE_1Content; } }
        private static Java.Lang.String _NFC_FORUM_TYPE_1Content = default;
        private static bool _NFC_FORUM_TYPE_1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#NFC_FORUM_TYPE_2"/>
        /// </summary>
        public static Java.Lang.String NFC_FORUM_TYPE_2 { get { if (!_NFC_FORUM_TYPE_2Ready) { _NFC_FORUM_TYPE_2Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "NFC_FORUM_TYPE_2"); _NFC_FORUM_TYPE_2Ready = true; } return _NFC_FORUM_TYPE_2Content; } }
        private static Java.Lang.String _NFC_FORUM_TYPE_2Content = default;
        private static bool _NFC_FORUM_TYPE_2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#NFC_FORUM_TYPE_3"/>
        /// </summary>
        public static Java.Lang.String NFC_FORUM_TYPE_3 { get { if (!_NFC_FORUM_TYPE_3Ready) { _NFC_FORUM_TYPE_3Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "NFC_FORUM_TYPE_3"); _NFC_FORUM_TYPE_3Ready = true; } return _NFC_FORUM_TYPE_3Content; } }
        private static Java.Lang.String _NFC_FORUM_TYPE_3Content = default;
        private static bool _NFC_FORUM_TYPE_3Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#NFC_FORUM_TYPE_4"/>
        /// </summary>
        public static Java.Lang.String NFC_FORUM_TYPE_4 { get { if (!_NFC_FORUM_TYPE_4Ready) { _NFC_FORUM_TYPE_4Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "NFC_FORUM_TYPE_4"); _NFC_FORUM_TYPE_4Ready = true; } return _NFC_FORUM_TYPE_4Content; } }
        private static Java.Lang.String _NFC_FORUM_TYPE_4Content = default;
        private static bool _NFC_FORUM_TYPE_4Ready = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#get(android.nfc.Tag)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Nfc.Tag"/></param>
        /// <returns><see cref="Android.Nfc.Tech.Ndef"/></returns>
        public static Android.Nfc.Tech.Ndef Get(Android.Nfc.Tag arg0)
        {
            return SExecuteWithSignature<Android.Nfc.Tech.Ndef>(LocalBridgeClazz, "get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/Ndef;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#getCachedNdefMessage()"/>
        /// </summary>
        /// <returns><see cref="Android.Nfc.NdefMessage"/></returns>
        public Android.Nfc.NdefMessage GetCachedNdefMessage()
        {
            return IExecuteWithSignature<Android.Nfc.NdefMessage>("getCachedNdefMessage", "()Landroid/nfc/NdefMessage;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#getNdefMessage()"/>
        /// </summary>
        /// <returns><see cref="Android.Nfc.NdefMessage"/></returns>
        /// <exception cref="Android.Nfc.FormatException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Nfc.NdefMessage GetNdefMessage()
        {
            return IExecuteWithSignature<Android.Nfc.NdefMessage>("getNdefMessage", "()Landroid/nfc/NdefMessage;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#getTag()"/>
        /// </summary>
        /// <returns><see cref="Android.Nfc.Tag"/></returns>
        public Android.Nfc.Tag GetTag()
        {
            return IExecuteWithSignature<Android.Nfc.Tag>("getTag", "()Landroid/nfc/Tag;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#canMakeReadOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanMakeReadOnly()
        {
            return IExecuteWithSignature<bool>("canMakeReadOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#isWritable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWritable()
        {
            return IExecuteWithSignature<bool>("isWritable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#makeReadOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool MakeReadOnly()
        {
            return IExecuteWithSignature<bool>("makeReadOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#getMaxSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxSize()
        {
            return IExecuteWithSignature<int>("getMaxSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#getType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#connect()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect()
        {
            IExecuteWithSignature("connect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/Ndef.html#writeNdefMessage(android.nfc.NdefMessage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Nfc.NdefMessage"/></param>
        /// <exception cref="Android.Nfc.FormatException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteNdefMessage(Android.Nfc.NdefMessage arg0)
        {
            IExecuteWithSignature("writeNdefMessage", "(Landroid/nfc/NdefMessage;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}