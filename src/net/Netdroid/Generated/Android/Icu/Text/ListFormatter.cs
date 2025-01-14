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
    #region ListFormatter declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.html"/>
    /// </summary>
    public partial class ListFormatter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ListFormatter>
    {
        const string _bridgeClassName = "android.icu.text.ListFormatter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ListFormatter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ListFormatter(params object[] args) : base(args) { }
    
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
        #region FormattedList declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.FormattedList.html"/>
        /// </summary>
        public partial class FormattedList : Android.Icu.Text.FormattedValue
        {
            const string _bridgeClassName = "android.icu.text.ListFormatter$FormattedList";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public FormattedList() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public FormattedList(params object[] args) : base(args) { }
        
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

        #region Type declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.Type.html"/>
        /// </summary>
        public partial class Type : Java.Lang.Enum<Android.Icu.Text.ListFormatter.Type>
        {
            const string _bridgeClassName = "android.icu.text.ListFormatter$Type";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Type() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Type(params object[] args) : base(args) { }
        
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

        #region Width declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.Width.html"/>
        /// </summary>
        public partial class Width : Java.Lang.Enum<Android.Icu.Text.ListFormatter.Width>
        {
            const string _bridgeClassName = "android.icu.text.ListFormatter$Width";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Width() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Width(params object[] args) : base(args) { }
        
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

    #region ListFormatter implementation
    public partial class ListFormatter
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.ListFormatter"/></returns>
        public static Android.Icu.Text.ListFormatter GetInstance()
        {
            return SExecuteWithSignature<Android.Icu.Text.ListFormatter>(LocalBridgeClazz, "getInstance", "()Landroid/icu/text/ListFormatter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.html#getInstance(android.icu.util.ULocale,android.icu.text.ListFormatter.Type,android.icu.text.ListFormatter.Width)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.ListFormatter.Type"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.ListFormatter.Width"/></param>
        /// <returns><see cref="Android.Icu.Text.ListFormatter"/></returns>
        public static Android.Icu.Text.ListFormatter GetInstance(Android.Icu.Util.ULocale arg0, Android.Icu.Text.ListFormatter.Type arg1, Android.Icu.Text.ListFormatter.Width arg2)
        {
            return SExecuteWithSignature<Android.Icu.Text.ListFormatter>(LocalBridgeClazz, "getInstance", "(Landroid/icu/util/ULocale;Landroid/icu/text/ListFormatter$Type;Landroid/icu/text/ListFormatter$Width;)Landroid/icu/text/ListFormatter;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.html#getInstance(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Text.ListFormatter"/></returns>
        public static Android.Icu.Text.ListFormatter GetInstance(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.ListFormatter>(LocalBridgeClazz, "getInstance", "(Landroid/icu/util/ULocale;)Landroid/icu/text/ListFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.html#getInstance(java.util.Locale,android.icu.text.ListFormatter.Type,android.icu.text.ListFormatter.Width)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.ListFormatter.Type"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.ListFormatter.Width"/></param>
        /// <returns><see cref="Android.Icu.Text.ListFormatter"/></returns>
        public static Android.Icu.Text.ListFormatter GetInstance(Java.Util.Locale arg0, Android.Icu.Text.ListFormatter.Type arg1, Android.Icu.Text.ListFormatter.Width arg2)
        {
            return SExecuteWithSignature<Android.Icu.Text.ListFormatter>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;Landroid/icu/text/ListFormatter$Type;Landroid/icu/text/ListFormatter$Width;)Landroid/icu/text/ListFormatter;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Text.ListFormatter"/></returns>
        public static Android.Icu.Text.ListFormatter GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.ListFormatter>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Landroid/icu/text/ListFormatter;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.html#formatToValue(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Android.Icu.Text.ListFormatter.FormattedList"/></returns>
        public Android.Icu.Text.ListFormatter.FormattedList FormatToValue(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Android.Icu.Text.ListFormatter.FormattedList>("formatToValue", "([Ljava/lang/Object;)Landroid/icu/text/ListFormatter$FormattedList;"); else return IExecuteWithSignature<Android.Icu.Text.ListFormatter.FormattedList>("formatToValue", "([Ljava/lang/Object;)Landroid/icu/text/ListFormatter$FormattedList;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.html#formatToValue(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Android.Icu.Text.ListFormatter.FormattedList"/></returns>
        public Android.Icu.Text.ListFormatter.FormattedList FormatToValue(Java.Util.Collection<object> arg0)
        {
            return IExecuteWithSignature<Android.Icu.Text.ListFormatter.FormattedList>("formatToValue", "(Ljava/util/Collection;)Landroid/icu/text/ListFormatter$FormattedList;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.html#format(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(params object[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Lang.String>("format", "([Ljava/lang/Object;)Ljava/lang/String;"); else return IExecuteWithSignature<Java.Lang.String>("format", "([Ljava/lang/Object;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.html#format(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(Java.Util.Collection<object> arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(Ljava/util/Collection;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.html#getPatternForNumItems(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPatternForNumItems(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getPatternForNumItems", "(I)Ljava/lang/String;", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region FormattedList implementation
        public partial class FormattedList
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
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.FormattedList.html#appendTo(java.lang.Appendable)"/>
            /// </summary>
            /// <param name="arg0"><typeparamref name="A"/></param>
            /// <typeparam name="A"><see cref="Java.Lang.IAppendable"/></typeparam>
            /// <returns><typeparamref name="A"/></returns>
            public A AppendTo<A>(A arg0) where A : Java.Lang.IAppendable, new()
            {
                return IExecuteWithSignature<A>("appendTo", "(Ljava/lang/Appendable;)Ljava/lang/Appendable;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.FormattedList.html#nextPosition(android.icu.text.ConstrainedFieldPosition)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Icu.Text.ConstrainedFieldPosition"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool NextPosition(Android.Icu.Text.ConstrainedFieldPosition arg0)
            {
                return IExecuteWithSignature<bool>("nextPosition", "(Landroid/icu/text/ConstrainedFieldPosition;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.FormattedList.html#charAt(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="char"/></returns>
            public char CharAt(int arg0)
            {
                return IExecuteWithSignature<char>("charAt", "(I)C", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.FormattedList.html#length()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Length()
            {
                return IExecuteWithSignature<int>("length", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.FormattedList.html#subSequence(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence SubSequence(int arg0, int arg1)
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("subSequence", "(II)Ljava/lang/CharSequence;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.FormattedList.html#toCharacterIterator()"/>
            /// </summary>
            /// <returns><see cref="Java.Text.AttributedCharacterIterator"/></returns>
            public Java.Text.AttributedCharacterIterator ToCharacterIterator()
            {
                return IExecuteWithSignature<Java.Text.AttributedCharacterIterator>("toCharacterIterator", "()Ljava/text/AttributedCharacterIterator;");
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Type implementation
        public partial class Type
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.Type.html#AND"/>
            /// </summary>
            public static Android.Icu.Text.ListFormatter.Type AND { get { if (!_ANDReady) { _ANDContent = SGetField<Android.Icu.Text.ListFormatter.Type>(LocalBridgeClazz, "AND"); _ANDReady = true; } return _ANDContent; } }
            private static Android.Icu.Text.ListFormatter.Type _ANDContent = default;
            private static bool _ANDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.Type.html#OR"/>
            /// </summary>
            public static Android.Icu.Text.ListFormatter.Type OR { get { if (!_ORReady) { _ORContent = SGetField<Android.Icu.Text.ListFormatter.Type>(LocalBridgeClazz, "OR"); _ORReady = true; } return _ORContent; } }
            private static Android.Icu.Text.ListFormatter.Type _ORContent = default;
            private static bool _ORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.Type.html#UNITS"/>
            /// </summary>
            public static Android.Icu.Text.ListFormatter.Type UNITS { get { if (!_UNITSReady) { _UNITSContent = SGetField<Android.Icu.Text.ListFormatter.Type>(LocalBridgeClazz, "UNITS"); _UNITSReady = true; } return _UNITSContent; } }
            private static Android.Icu.Text.ListFormatter.Type _UNITSContent = default;
            private static bool _UNITSReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.Type.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.ListFormatter.Type"/></returns>
            public static Android.Icu.Text.ListFormatter.Type ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.ListFormatter.Type>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/ListFormatter$Type;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.Type.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.ListFormatter.Type"/></returns>
            public static Android.Icu.Text.ListFormatter.Type[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.ListFormatter.Type>(LocalBridgeClazz, "values", "()[Landroid/icu/text/ListFormatter$Type;");
            }
        
            #endregion
        
            #region Instance methods
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Width implementation
        public partial class Width
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.Width.html#NARROW"/>
            /// </summary>
            public static Android.Icu.Text.ListFormatter.Width NARROW { get { if (!_NARROWReady) { _NARROWContent = SGetField<Android.Icu.Text.ListFormatter.Width>(LocalBridgeClazz, "NARROW"); _NARROWReady = true; } return _NARROWContent; } }
            private static Android.Icu.Text.ListFormatter.Width _NARROWContent = default;
            private static bool _NARROWReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.Width.html#SHORT"/>
            /// </summary>
            public static Android.Icu.Text.ListFormatter.Width SHORT { get { if (!_SHORTReady) { _SHORTContent = SGetField<Android.Icu.Text.ListFormatter.Width>(LocalBridgeClazz, "SHORT"); _SHORTReady = true; } return _SHORTContent; } }
            private static Android.Icu.Text.ListFormatter.Width _SHORTContent = default;
            private static bool _SHORTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.Width.html#WIDE"/>
            /// </summary>
            public static Android.Icu.Text.ListFormatter.Width WIDE { get { if (!_WIDEReady) { _WIDEContent = SGetField<Android.Icu.Text.ListFormatter.Width>(LocalBridgeClazz, "WIDE"); _WIDEReady = true; } return _WIDEContent; } }
            private static Android.Icu.Text.ListFormatter.Width _WIDEContent = default;
            private static bool _WIDEReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.Width.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.ListFormatter.Width"/></returns>
            public static Android.Icu.Text.ListFormatter.Width ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.ListFormatter.Width>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/ListFormatter$Width;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/ListFormatter.Width.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.ListFormatter.Width"/></returns>
            public static Android.Icu.Text.ListFormatter.Width[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.ListFormatter.Width>(LocalBridgeClazz, "values", "()[Landroid/icu/text/ListFormatter$Width;");
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