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
    #region Transliterator declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html"/>
    /// </summary>
    public partial class Transliterator : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Transliterator>
    {
        const string _bridgeClassName = "android.icu.text.Transliterator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Transliterator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Transliterator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Transliterator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Transliterator(params object[] args) : base(args) { }
    
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
        #region Position declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.Position.html"/>
        /// </summary>
        public partial class Position : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Position>
        {
            const string _bridgeClassName = "android.icu.text.Transliterator$Position";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Position() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Position(params object[] args) : base(args) { }
        
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

    #region Transliterator implementation
    public partial class Transliterator
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#FORWARD"/>
        /// </summary>
        public static int FORWARD { get { if (!_FORWARDReady) { _FORWARDContent = SGetField<int>(LocalBridgeClazz, "FORWARD"); _FORWARDReady = true; } return _FORWARDContent; } }
        private static int _FORWARDContent = default;
        private static bool _FORWARDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#REVERSE"/>
        /// </summary>
        public static int REVERSE { get { if (!_REVERSEReady) { _REVERSEContent = SGetField<int>(LocalBridgeClazz, "REVERSE"); _REVERSEReady = true; } return _REVERSEContent; } }
        private static int _REVERSEContent = default;
        private static bool _REVERSEReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getInstance(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Text.Transliterator"/></returns>
        public static Android.Icu.Text.Transliterator GetInstance(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Android.Icu.Text.Transliterator>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#createFromRules(java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Text.Transliterator"/></returns>
        public static Android.Icu.Text.Transliterator CreateFromRules(Java.Lang.String arg0, Java.Lang.String arg1, int arg2)
        {
            return SExecute<Android.Icu.Text.Transliterator>(LocalBridgeClazz, "createFromRules", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Text.Transliterator"/></returns>
        public static Android.Icu.Text.Transliterator GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.Transliterator>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Landroid/icu/text/Transliterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getDisplayName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetDisplayName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getDisplayName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getAvailableIDs()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public static Java.Util.Enumeration<Java.Lang.String> GetAvailableIDs()
        {
            return SExecuteWithSignature<Java.Util.Enumeration<Java.Lang.String>>(LocalBridgeClazz, "getAvailableIDs", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getAvailableSources()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public static Java.Util.Enumeration<Java.Lang.String> GetAvailableSources()
        {
            return SExecuteWithSignature<Java.Util.Enumeration<Java.Lang.String>>(LocalBridgeClazz, "getAvailableSources", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getAvailableTargets(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public static Java.Util.Enumeration<Java.Lang.String> GetAvailableTargets(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Enumeration<Java.Lang.String>>(LocalBridgeClazz, "getAvailableTargets", "(Ljava/lang/String;)Ljava/util/Enumeration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getAvailableVariants(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public static Java.Util.Enumeration<Java.Lang.String> GetAvailableVariants(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Util.Enumeration<Java.Lang.String>>(LocalBridgeClazz, "getAvailableVariants", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getDisplayName(java.lang.String,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetDisplayName(Java.Lang.String arg0, Android.Icu.Util.ULocale arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "getDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getDisplayName(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetDisplayName(Java.Lang.String arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "getDisplayName", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getElements()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.Transliterator"/></returns>
        public Android.Icu.Text.Transliterator[] GetElements()
        {
            return IExecuteWithSignatureArray<Android.Icu.Text.Transliterator>("getElements", "()[Landroid/icu/text/Transliterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getTargetSet()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.UnicodeSet"/></returns>
        public Android.Icu.Text.UnicodeSet GetTargetSet()
        {
            return IExecuteWithSignature<Android.Icu.Text.UnicodeSet>("getTargetSet", "()Landroid/icu/text/UnicodeSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getInverse()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.Transliterator"/></returns>
        public Android.Icu.Text.Transliterator GetInverse()
        {
            return IExecuteWithSignature<Android.Icu.Text.Transliterator>("getInverse", "()Landroid/icu/text/Transliterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.UnicodeFilter"/></returns>
        public Android.Icu.Text.UnicodeFilter GetFilter()
        {
            return IExecuteWithSignature<Android.Icu.Text.UnicodeFilter>("getFilter", "()Landroid/icu/text/UnicodeFilter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getSourceSet()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.UnicodeSet"/></returns>
        public Android.Icu.Text.UnicodeSet GetSourceSet()
        {
            return IExecuteWithSignature<Android.Icu.Text.UnicodeSet>("getSourceSet", "()Landroid/icu/text/UnicodeSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getMaximumContextLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaximumContextLength()
        {
            return IExecuteWithSignature<int>("getMaximumContextLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#transliterate(android.icu.text.Replaceable,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.Replaceable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Transliterate(Android.Icu.Text.Replaceable arg0, int arg1, int arg2)
        {
            return IExecute<int>("transliterate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#getID()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetID()
        {
            return IExecuteWithSignature<Java.Lang.String>("getID", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#transliterate(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Transliterate(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("transliterate", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#finishTransliteration(android.icu.text.Replaceable,android.icu.text.Transliterator.Position)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.Replaceable"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.Transliterator.Position"/></param>
        public void FinishTransliteration(Android.Icu.Text.Replaceable arg0, Android.Icu.Text.Transliterator.Position arg1)
        {
            IExecute("finishTransliteration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#transliterate(android.icu.text.Replaceable,android.icu.text.Transliterator.Position,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.Replaceable"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.Transliterator.Position"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void Transliterate(Android.Icu.Text.Replaceable arg0, Android.Icu.Text.Transliterator.Position arg1, int arg2)
        {
            IExecute("transliterate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#transliterate(android.icu.text.Replaceable,android.icu.text.Transliterator.Position,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.Replaceable"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.Transliterator.Position"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public void Transliterate(Android.Icu.Text.Replaceable arg0, Android.Icu.Text.Transliterator.Position arg1, Java.Lang.String arg2)
        {
            IExecute("transliterate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#transliterate(android.icu.text.Replaceable,android.icu.text.Transliterator.Position)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.Replaceable"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.Transliterator.Position"/></param>
        public void Transliterate(Android.Icu.Text.Replaceable arg0, Android.Icu.Text.Transliterator.Position arg1)
        {
            IExecute("transliterate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#transliterate(android.icu.text.Replaceable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.Replaceable"/></param>
        public void Transliterate(Android.Icu.Text.Replaceable arg0)
        {
            IExecuteWithSignature("transliterate", "(Landroid/icu/text/Replaceable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#toRules(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToRules(bool arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("toRules", "(Z)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#filteredTransliterate(android.icu.text.Replaceable,android.icu.text.Transliterator.Position,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.Replaceable"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.Transliterator.Position"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void FilteredTransliterate(Android.Icu.Text.Replaceable arg0, Android.Icu.Text.Transliterator.Position arg1, bool arg2)
        {
            IExecute("filteredTransliterate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.html#setFilter(android.icu.text.UnicodeFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.UnicodeFilter"/></param>
        public void SetFilter(Android.Icu.Text.UnicodeFilter arg0)
        {
            IExecuteWithSignature("setFilter", "(Landroid/icu/text/UnicodeFilter;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region Position implementation
        public partial class Position
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.Position.html#%3Cinit%3E(android.icu.text.Transliterator.Position)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Icu.Text.Transliterator.Position"/></param>
            public Position(Android.Icu.Text.Transliterator.Position arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.Position.html#%3Cinit%3E(int,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public Position(int arg0, int arg1, int arg2, int arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.Position.html#%3Cinit%3E(int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public Position(int arg0, int arg1, int arg2)
                : base(arg0, arg1, arg2)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.Position.html#contextLimit"/>
            /// </summary>
            public int contextLimit { get { return IGetField<int>("contextLimit"); } set { ISetField("contextLimit", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.Position.html#contextStart"/>
            /// </summary>
            public int contextStart { get { return IGetField<int>("contextStart"); } set { ISetField("contextStart", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.Position.html#limit"/>
            /// </summary>
            public int limit { get { return IGetField<int>("limit"); } set { ISetField("limit", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.Position.html#start"/>
            /// </summary>
            public int start { get { return IGetField<int>("start"); } set { ISetField("start", value); } }
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.Position.html#validate(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void Validate(int arg0)
            {
                IExecuteWithSignature("validate", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Transliterator.Position.html#set(android.icu.text.Transliterator.Position)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Icu.Text.Transliterator.Position"/></param>
            public void Set(Android.Icu.Text.Transliterator.Position arg0)
            {
                IExecuteWithSignature("set", "(Landroid/icu/text/Transliterator$Position;)V", arg0);
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