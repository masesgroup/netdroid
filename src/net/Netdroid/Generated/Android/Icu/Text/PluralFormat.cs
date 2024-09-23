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
    #region PluralFormat declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html"/>
    /// </summary>
    public partial class PluralFormat : Android.Icu.Text.UFormat
    {
        const string _bridgeClassName = "android.icu.text.PluralFormat";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PluralFormat() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PluralFormat(params object[] args) : base(args) { }
    
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

    #region PluralFormat implementation
    public partial class PluralFormat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#%3Cinit%3E(android.icu.text.PluralRules,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.PluralRules"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public PluralFormat(Android.Icu.Text.PluralRules arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#%3Cinit%3E(android.icu.text.PluralRules)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.PluralRules"/></param>
        public PluralFormat(Android.Icu.Text.PluralRules arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#%3Cinit%3E(android.icu.util.ULocale,android.icu.text.PluralRules,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.PluralRules"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public PluralFormat(Android.Icu.Util.ULocale arg0, Android.Icu.Text.PluralRules arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#%3Cinit%3E(android.icu.util.ULocale,android.icu.text.PluralRules)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.PluralRules"/></param>
        public PluralFormat(Android.Icu.Util.ULocale arg0, Android.Icu.Text.PluralRules arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#%3Cinit%3E(android.icu.util.ULocale,android.icu.text.PluralRules.PluralType,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.PluralRules.PluralType"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public PluralFormat(Android.Icu.Util.ULocale arg0, Android.Icu.Text.PluralRules.PluralType arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#%3Cinit%3E(android.icu.util.ULocale,android.icu.text.PluralRules.PluralType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.PluralRules.PluralType"/></param>
        public PluralFormat(Android.Icu.Util.ULocale arg0, Android.Icu.Text.PluralRules.PluralType arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#%3Cinit%3E(android.icu.util.ULocale,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public PluralFormat(Android.Icu.Util.ULocale arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#%3Cinit%3E(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        public PluralFormat(Android.Icu.Util.ULocale arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public PluralFormat(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#%3Cinit%3E(java.util.Locale,android.icu.text.PluralRules)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.PluralRules"/></param>
        public PluralFormat(Java.Util.Locale arg0, Android.Icu.Text.PluralRules arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#%3Cinit%3E(java.util.Locale,android.icu.text.PluralRules.PluralType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.PluralRules.PluralType"/></param>
        public PluralFormat(Java.Util.Locale arg0, Android.Icu.Text.PluralRules.PluralType arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public PluralFormat(Java.Util.Locale arg0)
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
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#format(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(double arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(D)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#parse(java.lang.String,java.text.ParsePosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Text.ParsePosition"/></param>
        /// <returns><see cref="Java.Lang.Number"/></returns>
        public Java.Lang.Number Parse(Java.Lang.String arg0, Java.Text.ParsePosition arg1)
        {
            return IExecute<Java.Lang.Number>("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#toPattern()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToPattern()
        {
            return IExecuteWithSignature<Java.Lang.String>("toPattern", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#applyPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void ApplyPattern(Java.Lang.String arg0)
        {
            IExecuteWithSignature("applyPattern", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/PluralFormat.html#setNumberFormat(android.icu.text.NumberFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.NumberFormat"/></param>
        public void SetNumberFormat(Android.Icu.Text.NumberFormat arg0)
        {
            IExecuteWithSignature("setNumberFormat", "(Landroid/icu/text/NumberFormat;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}