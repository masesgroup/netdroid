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

namespace Android.Nfc.Cardemulation
{
    #region NfcFCardEmulation declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/NfcFCardEmulation.html"/>
    /// </summary>
    public partial class NfcFCardEmulation : MASES.JCOBridge.C2JBridge.JVMBridgeBase<NfcFCardEmulation>
    {
        const string _bridgeClassName = "android.nfc.cardemulation.NfcFCardEmulation";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NfcFCardEmulation() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public NfcFCardEmulation(params object[] args) : base(args) { }

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

    #region NfcFCardEmulation implementation
    public partial class NfcFCardEmulation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/NfcFCardEmulation.html#getInstance(android.nfc.NfcAdapter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Nfc.NfcAdapter"/></param>
        /// <returns><see cref="Android.Nfc.Cardemulation.NfcFCardEmulation"/></returns>
        public static Android.Nfc.Cardemulation.NfcFCardEmulation GetInstance(Android.Nfc.NfcAdapter arg0)
        {
            return SExecuteWithSignature<Android.Nfc.Cardemulation.NfcFCardEmulation>(LocalBridgeClazz, "getInstance", "(Landroid/nfc/NfcAdapter;)Landroid/nfc/cardemulation/NfcFCardEmulation;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/NfcFCardEmulation.html#disableService(android.app.Activity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.RuntimeException"/>
        public bool DisableService(Android.App.Activity arg0)
        {
            return IExecuteWithSignature<bool>("disableService", "(Landroid/app/Activity;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/NfcFCardEmulation.html#enableService(android.app.Activity,android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.RuntimeException"/>
        public bool EnableService(Android.App.Activity arg0, Android.Content.ComponentName arg1)
        {
            return IExecute<bool>("enableService", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/NfcFCardEmulation.html#registerSystemCodeForService(android.content.ComponentName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.RuntimeException"/>
        public bool RegisterSystemCodeForService(Android.Content.ComponentName arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("registerSystemCodeForService", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/NfcFCardEmulation.html#setNfcid2ForService(android.content.ComponentName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.RuntimeException"/>
        public bool SetNfcid2ForService(Android.Content.ComponentName arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("setNfcid2ForService", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/NfcFCardEmulation.html#unregisterSystemCodeForService(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.RuntimeException"/>
        public bool UnregisterSystemCodeForService(Android.Content.ComponentName arg0)
        {
            return IExecuteWithSignature<bool>("unregisterSystemCodeForService", "(Landroid/content/ComponentName;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/NfcFCardEmulation.html#getNfcid2ForService(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Lang.RuntimeException"/>
        public Java.Lang.String GetNfcid2ForService(Android.Content.ComponentName arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getNfcid2ForService", "(Landroid/content/ComponentName;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/cardemulation/NfcFCardEmulation.html#getSystemCodeForService(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Lang.RuntimeException"/>
        public Java.Lang.String GetSystemCodeForService(Android.Content.ComponentName arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getSystemCodeForService", "(Landroid/content/ComponentName;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}