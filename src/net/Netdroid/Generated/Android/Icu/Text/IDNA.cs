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

namespace Android.Icu.Text
{
    #region IDNA declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.html"/>
    /// </summary>
    public partial class IDNA : MASES.JCOBridge.C2JBridge.JVMBridgeBase<IDNA>
    {
        const string _bridgeClassName = "android.icu.text.IDNA";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("IDNA class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public IDNA() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("IDNA class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public IDNA(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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
        #region Error declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html"/>
        /// </summary>
        public partial class Error : Java.Lang.Enum<Android.Icu.Text.IDNA.Error>
        {
            const string _bridgeClassName = "android.icu.text.IDNA$Error";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Error() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Error(params object[] args) : base(args) { }
        
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

        #region Info declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Info.html"/>
        /// </summary>
        public partial class Info : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Info>
        {
            const string _bridgeClassName = "android.icu.text.IDNA$Info";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Info() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Info(params object[] args) : base(args) { }
        
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

    #region IDNA implementation
    public partial class IDNA
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.html#CHECK_BIDI"/>
        /// </summary>
        public static int CHECK_BIDI { get { if (!_CHECK_BIDIReady) { _CHECK_BIDIContent = SGetField<int>(LocalBridgeClazz, "CHECK_BIDI"); _CHECK_BIDIReady = true; } return _CHECK_BIDIContent; } }
        private static int _CHECK_BIDIContent = default;
        private static bool _CHECK_BIDIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.html#CHECK_CONTEXTJ"/>
        /// </summary>
        public static int CHECK_CONTEXTJ { get { if (!_CHECK_CONTEXTJReady) { _CHECK_CONTEXTJContent = SGetField<int>(LocalBridgeClazz, "CHECK_CONTEXTJ"); _CHECK_CONTEXTJReady = true; } return _CHECK_CONTEXTJContent; } }
        private static int _CHECK_CONTEXTJContent = default;
        private static bool _CHECK_CONTEXTJReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.html#CHECK_CONTEXTO"/>
        /// </summary>
        public static int CHECK_CONTEXTO { get { if (!_CHECK_CONTEXTOReady) { _CHECK_CONTEXTOContent = SGetField<int>(LocalBridgeClazz, "CHECK_CONTEXTO"); _CHECK_CONTEXTOReady = true; } return _CHECK_CONTEXTOContent; } }
        private static int _CHECK_CONTEXTOContent = default;
        private static bool _CHECK_CONTEXTOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.html#DEFAULT"/>
        /// </summary>
        public static int DEFAULT { get { if (!_DEFAULTReady) { _DEFAULTContent = SGetField<int>(LocalBridgeClazz, "DEFAULT"); _DEFAULTReady = true; } return _DEFAULTContent; } }
        private static int _DEFAULTContent = default;
        private static bool _DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.html#NONTRANSITIONAL_TO_ASCII"/>
        /// </summary>
        public static int NONTRANSITIONAL_TO_ASCII { get { if (!_NONTRANSITIONAL_TO_ASCIIReady) { _NONTRANSITIONAL_TO_ASCIIContent = SGetField<int>(LocalBridgeClazz, "NONTRANSITIONAL_TO_ASCII"); _NONTRANSITIONAL_TO_ASCIIReady = true; } return _NONTRANSITIONAL_TO_ASCIIContent; } }
        private static int _NONTRANSITIONAL_TO_ASCIIContent = default;
        private static bool _NONTRANSITIONAL_TO_ASCIIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.html#NONTRANSITIONAL_TO_UNICODE"/>
        /// </summary>
        public static int NONTRANSITIONAL_TO_UNICODE { get { if (!_NONTRANSITIONAL_TO_UNICODEReady) { _NONTRANSITIONAL_TO_UNICODEContent = SGetField<int>(LocalBridgeClazz, "NONTRANSITIONAL_TO_UNICODE"); _NONTRANSITIONAL_TO_UNICODEReady = true; } return _NONTRANSITIONAL_TO_UNICODEContent; } }
        private static int _NONTRANSITIONAL_TO_UNICODEContent = default;
        private static bool _NONTRANSITIONAL_TO_UNICODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.html#USE_STD3_RULES"/>
        /// </summary>
        public static int USE_STD3_RULES { get { if (!_USE_STD3_RULESReady) { _USE_STD3_RULESContent = SGetField<int>(LocalBridgeClazz, "USE_STD3_RULES"); _USE_STD3_RULESReady = true; } return _USE_STD3_RULESContent; } }
        private static int _USE_STD3_RULESContent = default;
        private static bool _USE_STD3_RULESReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.html#getUTS46Instance(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Text.IDNA"/></returns>
        public static Android.Icu.Text.IDNA GetUTS46Instance(int arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.IDNA>(LocalBridgeClazz, "getUTS46Instance", "(I)Landroid/icu/text/IDNA;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.html#labelToASCII(java.lang.CharSequence,java.lang.StringBuilder,android.icu.text.IDNA.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.StringBuilder"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.IDNA.Info"/></param>
        /// <returns><see cref="Java.Lang.StringBuilder"/></returns>
        public Java.Lang.StringBuilder LabelToASCII(Java.Lang.CharSequence arg0, Java.Lang.StringBuilder arg1, Android.Icu.Text.IDNA.Info arg2)
        {
            return IExecute<Java.Lang.StringBuilder>("labelToASCII", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.html#labelToUnicode(java.lang.CharSequence,java.lang.StringBuilder,android.icu.text.IDNA.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.StringBuilder"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.IDNA.Info"/></param>
        /// <returns><see cref="Java.Lang.StringBuilder"/></returns>
        public Java.Lang.StringBuilder LabelToUnicode(Java.Lang.CharSequence arg0, Java.Lang.StringBuilder arg1, Android.Icu.Text.IDNA.Info arg2)
        {
            return IExecute<Java.Lang.StringBuilder>("labelToUnicode", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.html#nameToASCII(java.lang.CharSequence,java.lang.StringBuilder,android.icu.text.IDNA.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.StringBuilder"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.IDNA.Info"/></param>
        /// <returns><see cref="Java.Lang.StringBuilder"/></returns>
        public Java.Lang.StringBuilder NameToASCII(Java.Lang.CharSequence arg0, Java.Lang.StringBuilder arg1, Android.Icu.Text.IDNA.Info arg2)
        {
            return IExecute<Java.Lang.StringBuilder>("nameToASCII", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.html#nameToUnicode(java.lang.CharSequence,java.lang.StringBuilder,android.icu.text.IDNA.Info)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.StringBuilder"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.IDNA.Info"/></param>
        /// <returns><see cref="Java.Lang.StringBuilder"/></returns>
        public Java.Lang.StringBuilder NameToUnicode(Java.Lang.CharSequence arg0, Java.Lang.StringBuilder arg1, Android.Icu.Text.IDNA.Info arg2)
        {
            return IExecute<Java.Lang.StringBuilder>("nameToUnicode", arg0, arg1, arg2);
        }
    
        #endregion
    
        #region Nested classes
        #region Error implementation
        public partial class Error
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#BIDI"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error BIDI { get { if (!_BIDIReady) { _BIDIContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "BIDI"); _BIDIReady = true; } return _BIDIContent; } }
            private static Android.Icu.Text.IDNA.Error _BIDIContent = default;
            private static bool _BIDIReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#CONTEXTJ"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error CONTEXTJ { get { if (!_CONTEXTJReady) { _CONTEXTJContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "CONTEXTJ"); _CONTEXTJReady = true; } return _CONTEXTJContent; } }
            private static Android.Icu.Text.IDNA.Error _CONTEXTJContent = default;
            private static bool _CONTEXTJReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#CONTEXTO_DIGITS"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error CONTEXTO_DIGITS { get { if (!_CONTEXTO_DIGITSReady) { _CONTEXTO_DIGITSContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "CONTEXTO_DIGITS"); _CONTEXTO_DIGITSReady = true; } return _CONTEXTO_DIGITSContent; } }
            private static Android.Icu.Text.IDNA.Error _CONTEXTO_DIGITSContent = default;
            private static bool _CONTEXTO_DIGITSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#CONTEXTO_PUNCTUATION"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error CONTEXTO_PUNCTUATION { get { if (!_CONTEXTO_PUNCTUATIONReady) { _CONTEXTO_PUNCTUATIONContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "CONTEXTO_PUNCTUATION"); _CONTEXTO_PUNCTUATIONReady = true; } return _CONTEXTO_PUNCTUATIONContent; } }
            private static Android.Icu.Text.IDNA.Error _CONTEXTO_PUNCTUATIONContent = default;
            private static bool _CONTEXTO_PUNCTUATIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#DISALLOWED"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error DISALLOWED { get { if (!_DISALLOWEDReady) { _DISALLOWEDContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "DISALLOWED"); _DISALLOWEDReady = true; } return _DISALLOWEDContent; } }
            private static Android.Icu.Text.IDNA.Error _DISALLOWEDContent = default;
            private static bool _DISALLOWEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#DOMAIN_NAME_TOO_LONG"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error DOMAIN_NAME_TOO_LONG { get { if (!_DOMAIN_NAME_TOO_LONGReady) { _DOMAIN_NAME_TOO_LONGContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "DOMAIN_NAME_TOO_LONG"); _DOMAIN_NAME_TOO_LONGReady = true; } return _DOMAIN_NAME_TOO_LONGContent; } }
            private static Android.Icu.Text.IDNA.Error _DOMAIN_NAME_TOO_LONGContent = default;
            private static bool _DOMAIN_NAME_TOO_LONGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#EMPTY_LABEL"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error EMPTY_LABEL { get { if (!_EMPTY_LABELReady) { _EMPTY_LABELContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "EMPTY_LABEL"); _EMPTY_LABELReady = true; } return _EMPTY_LABELContent; } }
            private static Android.Icu.Text.IDNA.Error _EMPTY_LABELContent = default;
            private static bool _EMPTY_LABELReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#HYPHEN_3_4"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error HYPHEN_3_4 { get { if (!_HYPHEN_3_4Ready) { _HYPHEN_3_4Content = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "HYPHEN_3_4"); _HYPHEN_3_4Ready = true; } return _HYPHEN_3_4Content; } }
            private static Android.Icu.Text.IDNA.Error _HYPHEN_3_4Content = default;
            private static bool _HYPHEN_3_4Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#INVALID_ACE_LABEL"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error INVALID_ACE_LABEL { get { if (!_INVALID_ACE_LABELReady) { _INVALID_ACE_LABELContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "INVALID_ACE_LABEL"); _INVALID_ACE_LABELReady = true; } return _INVALID_ACE_LABELContent; } }
            private static Android.Icu.Text.IDNA.Error _INVALID_ACE_LABELContent = default;
            private static bool _INVALID_ACE_LABELReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#LABEL_HAS_DOT"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error LABEL_HAS_DOT { get { if (!_LABEL_HAS_DOTReady) { _LABEL_HAS_DOTContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "LABEL_HAS_DOT"); _LABEL_HAS_DOTReady = true; } return _LABEL_HAS_DOTContent; } }
            private static Android.Icu.Text.IDNA.Error _LABEL_HAS_DOTContent = default;
            private static bool _LABEL_HAS_DOTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#LABEL_TOO_LONG"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error LABEL_TOO_LONG { get { if (!_LABEL_TOO_LONGReady) { _LABEL_TOO_LONGContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "LABEL_TOO_LONG"); _LABEL_TOO_LONGReady = true; } return _LABEL_TOO_LONGContent; } }
            private static Android.Icu.Text.IDNA.Error _LABEL_TOO_LONGContent = default;
            private static bool _LABEL_TOO_LONGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#LEADING_COMBINING_MARK"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error LEADING_COMBINING_MARK { get { if (!_LEADING_COMBINING_MARKReady) { _LEADING_COMBINING_MARKContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "LEADING_COMBINING_MARK"); _LEADING_COMBINING_MARKReady = true; } return _LEADING_COMBINING_MARKContent; } }
            private static Android.Icu.Text.IDNA.Error _LEADING_COMBINING_MARKContent = default;
            private static bool _LEADING_COMBINING_MARKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#LEADING_HYPHEN"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error LEADING_HYPHEN { get { if (!_LEADING_HYPHENReady) { _LEADING_HYPHENContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "LEADING_HYPHEN"); _LEADING_HYPHENReady = true; } return _LEADING_HYPHENContent; } }
            private static Android.Icu.Text.IDNA.Error _LEADING_HYPHENContent = default;
            private static bool _LEADING_HYPHENReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#PUNYCODE"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error PUNYCODE { get { if (!_PUNYCODEReady) { _PUNYCODEContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "PUNYCODE"); _PUNYCODEReady = true; } return _PUNYCODEContent; } }
            private static Android.Icu.Text.IDNA.Error _PUNYCODEContent = default;
            private static bool _PUNYCODEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#TRAILING_HYPHEN"/>
            /// </summary>
            public static Android.Icu.Text.IDNA.Error TRAILING_HYPHEN { get { if (!_TRAILING_HYPHENReady) { _TRAILING_HYPHENContent = SGetField<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "TRAILING_HYPHEN"); _TRAILING_HYPHENReady = true; } return _TRAILING_HYPHENContent; } }
            private static Android.Icu.Text.IDNA.Error _TRAILING_HYPHENContent = default;
            private static bool _TRAILING_HYPHENReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.IDNA.Error"/></returns>
            public static Android.Icu.Text.IDNA.Error ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/IDNA$Error;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Error.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.IDNA.Error"/></returns>
            public static Android.Icu.Text.IDNA.Error[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.IDNA.Error>(LocalBridgeClazz, "values", "()[Landroid/icu/text/IDNA$Error;");
            }
        
            #endregion
        
            #region Instance methods
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Info implementation
        public partial class Info
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
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Info.html#hasErrors()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasErrors()
            {
                return IExecuteWithSignature<bool>("hasErrors", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Info.html#isTransitionalDifferent()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsTransitionalDifferent()
            {
                return IExecuteWithSignature<bool>("isTransitionalDifferent", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/IDNA.Info.html#getErrors()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Set"/></returns>
            public Java.Util.Set<Android.Icu.Text.IDNA.Error> GetErrors()
            {
                return IExecuteWithSignature<Java.Util.Set<Android.Icu.Text.IDNA.Error>>("getErrors", "()Ljava/util/Set;");
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