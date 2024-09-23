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
    #region UnicodeSetSpanner declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html"/>
    /// </summary>
    public partial class UnicodeSetSpanner : MASES.JCOBridge.C2JBridge.JVMBridgeBase<UnicodeSetSpanner>
    {
        const string _bridgeClassName = "android.icu.text.UnicodeSetSpanner";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UnicodeSetSpanner() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UnicodeSetSpanner(params object[] args) : base(args) { }
    
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
        #region CountMethod declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.CountMethod.html"/>
        /// </summary>
        public partial class CountMethod : Java.Lang.Enum<Android.Icu.Text.UnicodeSetSpanner.CountMethod>
        {
            const string _bridgeClassName = "android.icu.text.UnicodeSetSpanner$CountMethod";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public CountMethod() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public CountMethod(params object[] args) : base(args) { }
        
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

        #region TrimOption declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.TrimOption.html"/>
        /// </summary>
        public partial class TrimOption : Java.Lang.Enum<Android.Icu.Text.UnicodeSetSpanner.TrimOption>
        {
            const string _bridgeClassName = "android.icu.text.UnicodeSetSpanner$TrimOption";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public TrimOption() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public TrimOption(params object[] args) : base(args) { }
        
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

    #region UnicodeSetSpanner implementation
    public partial class UnicodeSetSpanner
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html#%3Cinit%3E(android.icu.text.UnicodeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.UnicodeSet"/></param>
        public UnicodeSetSpanner(Android.Icu.Text.UnicodeSet arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html#getUnicodeSet()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.UnicodeSet"/></returns>
        public Android.Icu.Text.UnicodeSet GetUnicodeSet()
        {
            return IExecuteWithSignature<Android.Icu.Text.UnicodeSet>("getUnicodeSet", "()Landroid/icu/text/UnicodeSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html#countIn(java.lang.CharSequence,android.icu.text.UnicodeSetSpanner.CountMethod,android.icu.text.UnicodeSet.SpanCondition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.UnicodeSetSpanner.CountMethod"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.UnicodeSet.SpanCondition"/></param>
        /// <returns><see cref="int"/></returns>
        public int CountIn(Java.Lang.CharSequence arg0, Android.Icu.Text.UnicodeSetSpanner.CountMethod arg1, Android.Icu.Text.UnicodeSet.SpanCondition arg2)
        {
            return IExecute<int>("countIn", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html#countIn(java.lang.CharSequence,android.icu.text.UnicodeSetSpanner.CountMethod)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.UnicodeSetSpanner.CountMethod"/></param>
        /// <returns><see cref="int"/></returns>
        public int CountIn(Java.Lang.CharSequence arg0, Android.Icu.Text.UnicodeSetSpanner.CountMethod arg1)
        {
            return IExecute<int>("countIn", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html#countIn(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="int"/></returns>
        public int CountIn(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<int>("countIn", "(Ljava/lang/CharSequence;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html#trim(java.lang.CharSequence,android.icu.text.UnicodeSetSpanner.TrimOption,android.icu.text.UnicodeSet.SpanCondition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.UnicodeSetSpanner.TrimOption"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.UnicodeSet.SpanCondition"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence Trim(Java.Lang.CharSequence arg0, Android.Icu.Text.UnicodeSetSpanner.TrimOption arg1, Android.Icu.Text.UnicodeSet.SpanCondition arg2)
        {
            return IExecute<Java.Lang.CharSequence>("trim", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html#trim(java.lang.CharSequence,android.icu.text.UnicodeSetSpanner.TrimOption)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.UnicodeSetSpanner.TrimOption"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence Trim(Java.Lang.CharSequence arg0, Android.Icu.Text.UnicodeSetSpanner.TrimOption arg1)
        {
            return IExecute<Java.Lang.CharSequence>("trim", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html#trim(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence Trim(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("trim", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html#deleteFrom(java.lang.CharSequence,android.icu.text.UnicodeSet.SpanCondition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.UnicodeSet.SpanCondition"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String DeleteFrom(Java.Lang.CharSequence arg0, Android.Icu.Text.UnicodeSet.SpanCondition arg1)
        {
            return IExecute<Java.Lang.String>("deleteFrom", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html#deleteFrom(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String DeleteFrom(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("deleteFrom", "(Ljava/lang/CharSequence;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html#replaceFrom(java.lang.CharSequence,java.lang.CharSequence,android.icu.text.UnicodeSetSpanner.CountMethod,android.icu.text.UnicodeSet.SpanCondition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.UnicodeSetSpanner.CountMethod"/></param>
        /// <param name="arg3"><see cref="Android.Icu.Text.UnicodeSet.SpanCondition"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ReplaceFrom(Java.Lang.CharSequence arg0, Java.Lang.CharSequence arg1, Android.Icu.Text.UnicodeSetSpanner.CountMethod arg2, Android.Icu.Text.UnicodeSet.SpanCondition arg3)
        {
            return IExecute<Java.Lang.String>("replaceFrom", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html#replaceFrom(java.lang.CharSequence,java.lang.CharSequence,android.icu.text.UnicodeSetSpanner.CountMethod)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.UnicodeSetSpanner.CountMethod"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ReplaceFrom(Java.Lang.CharSequence arg0, Java.Lang.CharSequence arg1, Android.Icu.Text.UnicodeSetSpanner.CountMethod arg2)
        {
            return IExecute<Java.Lang.String>("replaceFrom", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.html#replaceFrom(java.lang.CharSequence,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ReplaceFrom(Java.Lang.CharSequence arg0, Java.Lang.CharSequence arg1)
        {
            return IExecute<Java.Lang.String>("replaceFrom", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region CountMethod implementation
        public partial class CountMethod
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.CountMethod.html#MIN_ELEMENTS"/>
            /// </summary>
            public static Android.Icu.Text.UnicodeSetSpanner.CountMethod MIN_ELEMENTS { get { if (!_MIN_ELEMENTSReady) { _MIN_ELEMENTSContent = SGetField<Android.Icu.Text.UnicodeSetSpanner.CountMethod>(LocalBridgeClazz, "MIN_ELEMENTS"); _MIN_ELEMENTSReady = true; } return _MIN_ELEMENTSContent; } }
            private static Android.Icu.Text.UnicodeSetSpanner.CountMethod _MIN_ELEMENTSContent = default;
            private static bool _MIN_ELEMENTSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.CountMethod.html#WHOLE_SPAN"/>
            /// </summary>
            public static Android.Icu.Text.UnicodeSetSpanner.CountMethod WHOLE_SPAN { get { if (!_WHOLE_SPANReady) { _WHOLE_SPANContent = SGetField<Android.Icu.Text.UnicodeSetSpanner.CountMethod>(LocalBridgeClazz, "WHOLE_SPAN"); _WHOLE_SPANReady = true; } return _WHOLE_SPANContent; } }
            private static Android.Icu.Text.UnicodeSetSpanner.CountMethod _WHOLE_SPANContent = default;
            private static bool _WHOLE_SPANReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.CountMethod.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.UnicodeSetSpanner.CountMethod"/></returns>
            public static Android.Icu.Text.UnicodeSetSpanner.CountMethod ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.UnicodeSetSpanner.CountMethod>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/UnicodeSetSpanner$CountMethod;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.CountMethod.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.UnicodeSetSpanner.CountMethod"/></returns>
            public static Android.Icu.Text.UnicodeSetSpanner.CountMethod[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.UnicodeSetSpanner.CountMethod>(LocalBridgeClazz, "values", "()[Landroid/icu/text/UnicodeSetSpanner$CountMethod;");
            }
        
            #endregion
        
            #region Instance methods
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region TrimOption implementation
        public partial class TrimOption
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.TrimOption.html#BOTH"/>
            /// </summary>
            public static Android.Icu.Text.UnicodeSetSpanner.TrimOption BOTH { get { if (!_BOTHReady) { _BOTHContent = SGetField<Android.Icu.Text.UnicodeSetSpanner.TrimOption>(LocalBridgeClazz, "BOTH"); _BOTHReady = true; } return _BOTHContent; } }
            private static Android.Icu.Text.UnicodeSetSpanner.TrimOption _BOTHContent = default;
            private static bool _BOTHReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.TrimOption.html#LEADING"/>
            /// </summary>
            public static Android.Icu.Text.UnicodeSetSpanner.TrimOption LEADING { get { if (!_LEADINGReady) { _LEADINGContent = SGetField<Android.Icu.Text.UnicodeSetSpanner.TrimOption>(LocalBridgeClazz, "LEADING"); _LEADINGReady = true; } return _LEADINGContent; } }
            private static Android.Icu.Text.UnicodeSetSpanner.TrimOption _LEADINGContent = default;
            private static bool _LEADINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.TrimOption.html#TRAILING"/>
            /// </summary>
            public static Android.Icu.Text.UnicodeSetSpanner.TrimOption TRAILING { get { if (!_TRAILINGReady) { _TRAILINGContent = SGetField<Android.Icu.Text.UnicodeSetSpanner.TrimOption>(LocalBridgeClazz, "TRAILING"); _TRAILINGReady = true; } return _TRAILINGContent; } }
            private static Android.Icu.Text.UnicodeSetSpanner.TrimOption _TRAILINGContent = default;
            private static bool _TRAILINGReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.TrimOption.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.UnicodeSetSpanner.TrimOption"/></returns>
            public static Android.Icu.Text.UnicodeSetSpanner.TrimOption ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.UnicodeSetSpanner.TrimOption>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/UnicodeSetSpanner$TrimOption;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeSetSpanner.TrimOption.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.UnicodeSetSpanner.TrimOption"/></returns>
            public static Android.Icu.Text.UnicodeSetSpanner.TrimOption[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.UnicodeSetSpanner.TrimOption>(LocalBridgeClazz, "values", "()[Landroid/icu/text/UnicodeSetSpanner$TrimOption;");
            }
        
            #endregion
        
            #region Instance methods
        
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