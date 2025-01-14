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

namespace Android.Icu.Text
{
    #region PluralRules declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html"/>
    /// </summary>
    public partial class PluralRules : Java.Io.Serializable
    {
        const string _bridgeClassName = "android.icu.text.PluralRules";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PluralRules() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PluralRules(params object[] args) : base(args) { }
    
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
        #region PluralType declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.PluralType.html"/>
        /// </summary>
        public partial class PluralType : Java.Lang.Enum<Android.Icu.Text.PluralRules.PluralType>
        {
            const string _bridgeClassName = "android.icu.text.PluralRules$PluralType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public PluralType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public PluralType(params object[] args) : base(args) { }
        
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

    #region PluralRules implementation
    public partial class PluralRules
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#DEFAULT"/>
        /// </summary>
        public static Android.Icu.Text.PluralRules DEFAULT { get { if (!_DEFAULTReady) { _DEFAULTContent = SGetField<Android.Icu.Text.PluralRules>(LocalBridgeClazz, "DEFAULT"); _DEFAULTReady = true; } return _DEFAULTContent; } }
        private static Android.Icu.Text.PluralRules _DEFAULTContent = default;
        private static bool _DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#NO_UNIQUE_VALUE"/>
        /// </summary>
        public static double NO_UNIQUE_VALUE { get { if (!_NO_UNIQUE_VALUEReady) { _NO_UNIQUE_VALUEContent = SGetField<double>(LocalBridgeClazz, "NO_UNIQUE_VALUE"); _NO_UNIQUE_VALUEReady = true; } return _NO_UNIQUE_VALUEContent; } }
        private static double _NO_UNIQUE_VALUEContent = default;
        private static bool _NO_UNIQUE_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#KEYWORD_FEW"/>
        /// </summary>
        public static Java.Lang.String KEYWORD_FEW { get { if (!_KEYWORD_FEWReady) { _KEYWORD_FEWContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEYWORD_FEW"); _KEYWORD_FEWReady = true; } return _KEYWORD_FEWContent; } }
        private static Java.Lang.String _KEYWORD_FEWContent = default;
        private static bool _KEYWORD_FEWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#KEYWORD_MANY"/>
        /// </summary>
        public static Java.Lang.String KEYWORD_MANY { get { if (!_KEYWORD_MANYReady) { _KEYWORD_MANYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEYWORD_MANY"); _KEYWORD_MANYReady = true; } return _KEYWORD_MANYContent; } }
        private static Java.Lang.String _KEYWORD_MANYContent = default;
        private static bool _KEYWORD_MANYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#KEYWORD_ONE"/>
        /// </summary>
        public static Java.Lang.String KEYWORD_ONE { get { if (!_KEYWORD_ONEReady) { _KEYWORD_ONEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEYWORD_ONE"); _KEYWORD_ONEReady = true; } return _KEYWORD_ONEContent; } }
        private static Java.Lang.String _KEYWORD_ONEContent = default;
        private static bool _KEYWORD_ONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#KEYWORD_OTHER"/>
        /// </summary>
        public static Java.Lang.String KEYWORD_OTHER { get { if (!_KEYWORD_OTHERReady) { _KEYWORD_OTHERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEYWORD_OTHER"); _KEYWORD_OTHERReady = true; } return _KEYWORD_OTHERContent; } }
        private static Java.Lang.String _KEYWORD_OTHERContent = default;
        private static bool _KEYWORD_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#KEYWORD_TWO"/>
        /// </summary>
        public static Java.Lang.String KEYWORD_TWO { get { if (!_KEYWORD_TWOReady) { _KEYWORD_TWOContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEYWORD_TWO"); _KEYWORD_TWOReady = true; } return _KEYWORD_TWOContent; } }
        private static Java.Lang.String _KEYWORD_TWOContent = default;
        private static bool _KEYWORD_TWOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#KEYWORD_ZERO"/>
        /// </summary>
        public static Java.Lang.String KEYWORD_ZERO { get { if (!_KEYWORD_ZEROReady) { _KEYWORD_ZEROContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEYWORD_ZERO"); _KEYWORD_ZEROReady = true; } return _KEYWORD_ZEROContent; } }
        private static Java.Lang.String _KEYWORD_ZEROContent = default;
        private static bool _KEYWORD_ZEROReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#createRules(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Text.PluralRules"/></returns>
        public static Android.Icu.Text.PluralRules CreateRules(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.PluralRules>(LocalBridgeClazz, "createRules", "(Ljava/lang/String;)Landroid/icu/text/PluralRules;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#forLocale(android.icu.util.ULocale,android.icu.text.PluralRules.PluralType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.PluralRules.PluralType"/></param>
        /// <returns><see cref="Android.Icu.Text.PluralRules"/></returns>
        public static Android.Icu.Text.PluralRules ForLocale(Android.Icu.Util.ULocale arg0, Android.Icu.Text.PluralRules.PluralType arg1)
        {
            return SExecuteWithSignature<Android.Icu.Text.PluralRules>(LocalBridgeClazz, "forLocale", "(Landroid/icu/util/ULocale;Landroid/icu/text/PluralRules$PluralType;)Landroid/icu/text/PluralRules;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#forLocale(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Text.PluralRules"/></returns>
        public static Android.Icu.Text.PluralRules ForLocale(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.PluralRules>(LocalBridgeClazz, "forLocale", "(Landroid/icu/util/ULocale;)Landroid/icu/text/PluralRules;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#forLocale(java.util.Locale,android.icu.text.PluralRules.PluralType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.PluralRules.PluralType"/></param>
        /// <returns><see cref="Android.Icu.Text.PluralRules"/></returns>
        public static Android.Icu.Text.PluralRules ForLocale(Java.Util.Locale arg0, Android.Icu.Text.PluralRules.PluralType arg1)
        {
            return SExecuteWithSignature<Android.Icu.Text.PluralRules>(LocalBridgeClazz, "forLocale", "(Ljava/util/Locale;Landroid/icu/text/PluralRules$PluralType;)Landroid/icu/text/PluralRules;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#forLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Text.PluralRules"/></returns>
        public static Android.Icu.Text.PluralRules ForLocale(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.PluralRules>(LocalBridgeClazz, "forLocale", "(Ljava/util/Locale;)Landroid/icu/text/PluralRules;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#parseDescription(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Text.PluralRules"/></returns>
        /// <exception cref="Java.Text.ParseException"/>
        public static Android.Icu.Text.PluralRules ParseDescription(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.PluralRules>(LocalBridgeClazz, "parseDescription", "(Ljava/lang/String;)Landroid/icu/text/PluralRules;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#getUniqueKeywordValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetUniqueKeywordValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<double>("getUniqueKeywordValue", "(Ljava/lang/String;)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#select(android.icu.number.FormattedNumber)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.FormattedNumber"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Select(Android.Icu.Number.FormattedNumber arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("select", "(Landroid/icu/number/FormattedNumber;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#select(android.icu.number.FormattedNumberRange)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.FormattedNumberRange"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Select(Android.Icu.Number.FormattedNumberRange arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("select", "(Landroid/icu/number/FormattedNumberRange;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#select(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Select(double arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("select", "(D)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#getAllKeywordValues(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Java.Lang.Double> GetAllKeywordValues(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Lang.Double>>("getAllKeywordValues", "(Ljava/lang/String;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#getSamples(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Java.Lang.Double> GetSamples(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Lang.Double>>("getSamples", "(Ljava/lang/String;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.html#getKeywords()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetKeywords()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getKeywords", "()Ljava/util/Set;");
        }
    
        #endregion
    
        #region Nested classes
        #region PluralType implementation
        public partial class PluralType
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.PluralType.html#CARDINAL"/>
            /// </summary>
            public static Android.Icu.Text.PluralRules.PluralType CARDINAL { get { if (!_CARDINALReady) { _CARDINALContent = SGetField<Android.Icu.Text.PluralRules.PluralType>(LocalBridgeClazz, "CARDINAL"); _CARDINALReady = true; } return _CARDINALContent; } }
            private static Android.Icu.Text.PluralRules.PluralType _CARDINALContent = default;
            private static bool _CARDINALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.PluralType.html#ORDINAL"/>
            /// </summary>
            public static Android.Icu.Text.PluralRules.PluralType ORDINAL { get { if (!_ORDINALReady) { _ORDINALContent = SGetField<Android.Icu.Text.PluralRules.PluralType>(LocalBridgeClazz, "ORDINAL"); _ORDINALReady = true; } return _ORDINALContent; } }
            private static Android.Icu.Text.PluralRules.PluralType _ORDINALContent = default;
            private static bool _ORDINALReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.PluralType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.PluralRules.PluralType"/></returns>
            public static Android.Icu.Text.PluralRules.PluralType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.PluralRules.PluralType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/PluralRules$PluralType;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/PluralRules.PluralType.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.PluralRules.PluralType"/></returns>
            public static Android.Icu.Text.PluralRules.PluralType[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.PluralRules.PluralType>(LocalBridgeClazz, "values", "()[Landroid/icu/text/PluralRules$PluralType;");
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