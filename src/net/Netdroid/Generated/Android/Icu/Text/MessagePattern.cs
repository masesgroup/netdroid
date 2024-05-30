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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Icu.Text
{
    #region MessagePattern
    public partial class MessagePattern : Java.Lang.ICloneable, Android.Icu.Util.IFreezable<Android.Icu.Text.MessagePattern>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#%3Cinit%3E(android.icu.text.MessagePattern.ApostropheMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.MessagePattern.ApostropheMode"/></param>
        public MessagePattern(Android.Icu.Text.MessagePattern.ApostropheMode arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public MessagePattern(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Icu.Text.MessagePattern"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Android.Icu.Text.MessagePattern t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Android.Icu.Text.MessagePattern"/> to <see cref="Android.Icu.Util.Freezable"/>
        /// </summary>
        public static implicit operator Android.Icu.Util.Freezable(Android.Icu.Text.MessagePattern t) => t.Cast<Android.Icu.Util.Freezable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#NO_NUMERIC_VALUE"/>
        /// </summary>
        public static double NO_NUMERIC_VALUE { get { if (!_NO_NUMERIC_VALUEReady) { _NO_NUMERIC_VALUEContent = SGetField<double>(LocalBridgeClazz, "NO_NUMERIC_VALUE"); _NO_NUMERIC_VALUEReady = true; } return _NO_NUMERIC_VALUEContent; } }
        private static double _NO_NUMERIC_VALUEContent = default;
        private static bool _NO_NUMERIC_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#ARG_NAME_NOT_NUMBER"/>
        /// </summary>
        public static int ARG_NAME_NOT_NUMBER { get { if (!_ARG_NAME_NOT_NUMBERReady) { _ARG_NAME_NOT_NUMBERContent = SGetField<int>(LocalBridgeClazz, "ARG_NAME_NOT_NUMBER"); _ARG_NAME_NOT_NUMBERReady = true; } return _ARG_NAME_NOT_NUMBERContent; } }
        private static int _ARG_NAME_NOT_NUMBERContent = default;
        private static bool _ARG_NAME_NOT_NUMBERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#ARG_NAME_NOT_VALID"/>
        /// </summary>
        public static int ARG_NAME_NOT_VALID { get { if (!_ARG_NAME_NOT_VALIDReady) { _ARG_NAME_NOT_VALIDContent = SGetField<int>(LocalBridgeClazz, "ARG_NAME_NOT_VALID"); _ARG_NAME_NOT_VALIDReady = true; } return _ARG_NAME_NOT_VALIDContent; } }
        private static int _ARG_NAME_NOT_VALIDContent = default;
        private static bool _ARG_NAME_NOT_VALIDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#validateArgumentName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ValidateArgumentName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "validateArgumentName", "(Ljava/lang/String;)I", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#getApostropheMode()"/> 
        /// </summary>
        public Android.Icu.Text.MessagePattern.ApostropheMode GetApostropheMode
        {
            get { return IExecuteWithSignature<Android.Icu.Text.MessagePattern.ApostropheMode>("getApostropheMode", "()Landroid/icu/text/MessagePattern$ApostropheMode;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#getPatternString()"/> 
        /// </summary>
        public Java.Lang.String PatternString
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPatternString", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Text.MessagePattern"/></returns>
        public Android.Icu.Text.MessagePattern Parse(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Icu.Text.MessagePattern>("parse", "(Ljava/lang/String;)Landroid/icu/text/MessagePattern;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#parseChoiceStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Text.MessagePattern"/></returns>
        public Android.Icu.Text.MessagePattern ParseChoiceStyle(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Icu.Text.MessagePattern>("parseChoiceStyle", "(Ljava/lang/String;)Landroid/icu/text/MessagePattern;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#parsePluralStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Text.MessagePattern"/></returns>
        public Android.Icu.Text.MessagePattern ParsePluralStyle(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Icu.Text.MessagePattern>("parsePluralStyle", "(Ljava/lang/String;)Landroid/icu/text/MessagePattern;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#parseSelectStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Text.MessagePattern"/></returns>
        public Android.Icu.Text.MessagePattern ParseSelectStyle(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Icu.Text.MessagePattern>("parseSelectStyle", "(Ljava/lang/String;)Landroid/icu/text/MessagePattern;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#getPart(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Text.MessagePattern.Part"/></returns>
        public Android.Icu.Text.MessagePattern.Part GetPart(int arg0)
        {
            return IExecuteWithSignature<Android.Icu.Text.MessagePattern.Part>("getPart", "(I)Landroid/icu/text/MessagePattern$Part;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#getPartType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Text.MessagePattern.Part.Type"/></returns>
        public Android.Icu.Text.MessagePattern.Part.Type GetPartType(int arg0)
        {
            return IExecuteWithSignature<Android.Icu.Text.MessagePattern.Part.Type>("getPartType", "(I)Landroid/icu/text/MessagePattern$Part$Type;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#hasNamedArguments()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNamedArguments()
        {
            return IExecuteWithSignature<bool>("hasNamedArguments", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#hasNumberedArguments()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNumberedArguments()
        {
            return IExecuteWithSignature<bool>("hasNumberedArguments", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#isFrozen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFrozen()
        {
            return IExecuteWithSignature<bool>("isFrozen", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#partSubstringMatches(android.icu.text.MessagePattern.Part,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.MessagePattern.Part"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PartSubstringMatches(Android.Icu.Text.MessagePattern.Part arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("partSubstringMatches", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#getNumericValue(android.icu.text.MessagePattern.Part)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.MessagePattern.Part"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetNumericValue(Android.Icu.Text.MessagePattern.Part arg0)
        {
            return IExecuteWithSignature<double>("getNumericValue", "(Landroid/icu/text/MessagePattern$Part;)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#getPluralOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetPluralOffset(int arg0)
        {
            return IExecuteWithSignature<double>("getPluralOffset", "(I)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#countParts()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int CountParts()
        {
            return IExecuteWithSignature<int>("countParts", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#getLimitPartIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLimitPartIndex(int arg0)
        {
            return IExecuteWithSignature<int>("getLimitPartIndex", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#getPatternIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetPatternIndex(int arg0)
        {
            return IExecuteWithSignature<int>("getPatternIndex", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#cloneAsThawed()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object CloneAsThawed()
        {
            return IExecuteWithSignature("cloneAsThawed", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#freeze()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Freeze()
        {
            return IExecuteWithSignature("freeze", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#autoQuoteApostropheDeep()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String AutoQuoteApostropheDeep()
        {
            return IExecuteWithSignature<Java.Lang.String>("autoQuoteApostropheDeep", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#getSubstring(android.icu.text.MessagePattern.Part)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.MessagePattern.Part"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSubstring(Android.Icu.Text.MessagePattern.Part arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getSubstring", "(Landroid/icu/text/MessagePattern$Part;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.html#clearPatternAndSetApostropheMode(android.icu.text.MessagePattern.ApostropheMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.MessagePattern.ApostropheMode"/></param>
        public void ClearPatternAndSetApostropheMode(Android.Icu.Text.MessagePattern.ApostropheMode arg0)
        {
            IExecuteWithSignature("clearPatternAndSetApostropheMode", "(Landroid/icu/text/MessagePattern$ApostropheMode;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region ApostropheMode
        public partial class ApostropheMode
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.ApostropheMode.html#DOUBLE_OPTIONAL"/>
            /// </summary>
            public static Android.Icu.Text.MessagePattern.ApostropheMode DOUBLE_OPTIONAL { get { if (!_DOUBLE_OPTIONALReady) { _DOUBLE_OPTIONALContent = SGetField<Android.Icu.Text.MessagePattern.ApostropheMode>(LocalBridgeClazz, "DOUBLE_OPTIONAL"); _DOUBLE_OPTIONALReady = true; } return _DOUBLE_OPTIONALContent; } }
            private static Android.Icu.Text.MessagePattern.ApostropheMode _DOUBLE_OPTIONALContent = default;
            private static bool _DOUBLE_OPTIONALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.ApostropheMode.html#DOUBLE_REQUIRED"/>
            /// </summary>
            public static Android.Icu.Text.MessagePattern.ApostropheMode DOUBLE_REQUIRED { get { if (!_DOUBLE_REQUIREDReady) { _DOUBLE_REQUIREDContent = SGetField<Android.Icu.Text.MessagePattern.ApostropheMode>(LocalBridgeClazz, "DOUBLE_REQUIRED"); _DOUBLE_REQUIREDReady = true; } return _DOUBLE_REQUIREDContent; } }
            private static Android.Icu.Text.MessagePattern.ApostropheMode _DOUBLE_REQUIREDContent = default;
            private static bool _DOUBLE_REQUIREDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.ApostropheMode.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.MessagePattern.ApostropheMode"/></returns>
            public static Android.Icu.Text.MessagePattern.ApostropheMode ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.MessagePattern.ApostropheMode>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/MessagePattern$ApostropheMode;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.ApostropheMode.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.MessagePattern.ApostropheMode"/></returns>
            public static Android.Icu.Text.MessagePattern.ApostropheMode[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.MessagePattern.ApostropheMode>(LocalBridgeClazz, "values", "()[Landroid/icu/text/MessagePattern$ApostropheMode;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ArgType
        public partial class ArgType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.ArgType.html#CHOICE"/>
            /// </summary>
            public static Android.Icu.Text.MessagePattern.ArgType CHOICE { get { if (!_CHOICEReady) { _CHOICEContent = SGetField<Android.Icu.Text.MessagePattern.ArgType>(LocalBridgeClazz, "CHOICE"); _CHOICEReady = true; } return _CHOICEContent; } }
            private static Android.Icu.Text.MessagePattern.ArgType _CHOICEContent = default;
            private static bool _CHOICEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.ArgType.html#NONE"/>
            /// </summary>
            public static Android.Icu.Text.MessagePattern.ArgType NONE { get { if (!_NONEReady) { _NONEContent = SGetField<Android.Icu.Text.MessagePattern.ArgType>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
            private static Android.Icu.Text.MessagePattern.ArgType _NONEContent = default;
            private static bool _NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.ArgType.html#PLURAL"/>
            /// </summary>
            public static Android.Icu.Text.MessagePattern.ArgType PLURAL { get { if (!_PLURALReady) { _PLURALContent = SGetField<Android.Icu.Text.MessagePattern.ArgType>(LocalBridgeClazz, "PLURAL"); _PLURALReady = true; } return _PLURALContent; } }
            private static Android.Icu.Text.MessagePattern.ArgType _PLURALContent = default;
            private static bool _PLURALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.ArgType.html#SELECT"/>
            /// </summary>
            public static Android.Icu.Text.MessagePattern.ArgType SELECT { get { if (!_SELECTReady) { _SELECTContent = SGetField<Android.Icu.Text.MessagePattern.ArgType>(LocalBridgeClazz, "SELECT"); _SELECTReady = true; } return _SELECTContent; } }
            private static Android.Icu.Text.MessagePattern.ArgType _SELECTContent = default;
            private static bool _SELECTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.ArgType.html#SELECTORDINAL"/>
            /// </summary>
            public static Android.Icu.Text.MessagePattern.ArgType SELECTORDINAL { get { if (!_SELECTORDINALReady) { _SELECTORDINALContent = SGetField<Android.Icu.Text.MessagePattern.ArgType>(LocalBridgeClazz, "SELECTORDINAL"); _SELECTORDINALReady = true; } return _SELECTORDINALContent; } }
            private static Android.Icu.Text.MessagePattern.ArgType _SELECTORDINALContent = default;
            private static bool _SELECTORDINALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.ArgType.html#SIMPLE"/>
            /// </summary>
            public static Android.Icu.Text.MessagePattern.ArgType SIMPLE { get { if (!_SIMPLEReady) { _SIMPLEContent = SGetField<Android.Icu.Text.MessagePattern.ArgType>(LocalBridgeClazz, "SIMPLE"); _SIMPLEReady = true; } return _SIMPLEContent; } }
            private static Android.Icu.Text.MessagePattern.ArgType _SIMPLEContent = default;
            private static bool _SIMPLEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.ArgType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.MessagePattern.ArgType"/></returns>
            public static Android.Icu.Text.MessagePattern.ArgType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.MessagePattern.ArgType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/MessagePattern$ArgType;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.ArgType.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.MessagePattern.ArgType"/></returns>
            public static Android.Icu.Text.MessagePattern.ArgType[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.MessagePattern.ArgType>(LocalBridgeClazz, "values", "()[Landroid/icu/text/MessagePattern$ArgType;");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.ArgType.html#hasPluralStyle()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasPluralStyle()
            {
                return IExecuteWithSignature<bool>("hasPluralStyle", "()Z");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Part
        public partial class Part
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
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.html#getArgType()"/> 
            /// </summary>
            public Android.Icu.Text.MessagePattern.ArgType GetArgType
            {
                get { return IExecuteWithSignature<Android.Icu.Text.MessagePattern.ArgType>("getArgType", "()Landroid/icu/text/MessagePattern$ArgType;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.html#getIndex()"/> 
            /// </summary>
            public int Index
            {
                get { return IExecuteWithSignature<int>("getIndex", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.html#getLength()"/> 
            /// </summary>
            public int Length
            {
                get { return IExecuteWithSignature<int>("getLength", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.html#getLimit()"/> 
            /// </summary>
            public int Limit
            {
                get { return IExecuteWithSignature<int>("getLimit", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.html#getType()"/> 
            /// </summary>
            public Android.Icu.Text.MessagePattern.Part.Type Type
            {
                get { return IExecuteWithSignature<Android.Icu.Text.MessagePattern.Part.Type>("getType", "()Landroid/icu/text/MessagePattern$Part$Type;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.html#getValue()"/> 
            /// </summary>
            public int Value
            {
                get { return IExecuteWithSignature<int>("getValue", "()I"); }
            }

            #endregion

            #region Nested classes
            #region Type
            public partial class Type
            {
                #region Constructors

                #endregion

                #region Class/Interface conversion operators

                #endregion

                #region Fields
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#ARG_DOUBLE"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type ARG_DOUBLE { get { if (!_ARG_DOUBLEReady) { _ARG_DOUBLEContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "ARG_DOUBLE"); _ARG_DOUBLEReady = true; } return _ARG_DOUBLEContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _ARG_DOUBLEContent = default;
                private static bool _ARG_DOUBLEReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#ARG_INT"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type ARG_INT { get { if (!_ARG_INTReady) { _ARG_INTContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "ARG_INT"); _ARG_INTReady = true; } return _ARG_INTContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _ARG_INTContent = default;
                private static bool _ARG_INTReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#ARG_LIMIT"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type ARG_LIMIT { get { if (!_ARG_LIMITReady) { _ARG_LIMITContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "ARG_LIMIT"); _ARG_LIMITReady = true; } return _ARG_LIMITContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _ARG_LIMITContent = default;
                private static bool _ARG_LIMITReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#ARG_NAME"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type ARG_NAME { get { if (!_ARG_NAMEReady) { _ARG_NAMEContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "ARG_NAME"); _ARG_NAMEReady = true; } return _ARG_NAMEContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _ARG_NAMEContent = default;
                private static bool _ARG_NAMEReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#ARG_NUMBER"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type ARG_NUMBER { get { if (!_ARG_NUMBERReady) { _ARG_NUMBERContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "ARG_NUMBER"); _ARG_NUMBERReady = true; } return _ARG_NUMBERContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _ARG_NUMBERContent = default;
                private static bool _ARG_NUMBERReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#ARG_SELECTOR"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type ARG_SELECTOR { get { if (!_ARG_SELECTORReady) { _ARG_SELECTORContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "ARG_SELECTOR"); _ARG_SELECTORReady = true; } return _ARG_SELECTORContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _ARG_SELECTORContent = default;
                private static bool _ARG_SELECTORReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#ARG_START"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type ARG_START { get { if (!_ARG_STARTReady) { _ARG_STARTContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "ARG_START"); _ARG_STARTReady = true; } return _ARG_STARTContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _ARG_STARTContent = default;
                private static bool _ARG_STARTReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#ARG_STYLE"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type ARG_STYLE { get { if (!_ARG_STYLEReady) { _ARG_STYLEContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "ARG_STYLE"); _ARG_STYLEReady = true; } return _ARG_STYLEContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _ARG_STYLEContent = default;
                private static bool _ARG_STYLEReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#ARG_TYPE"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type ARG_TYPE { get { if (!_ARG_TYPEReady) { _ARG_TYPEContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "ARG_TYPE"); _ARG_TYPEReady = true; } return _ARG_TYPEContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _ARG_TYPEContent = default;
                private static bool _ARG_TYPEReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#INSERT_CHAR"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type INSERT_CHAR { get { if (!_INSERT_CHARReady) { _INSERT_CHARContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "INSERT_CHAR"); _INSERT_CHARReady = true; } return _INSERT_CHARContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _INSERT_CHARContent = default;
                private static bool _INSERT_CHARReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#MSG_LIMIT"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type MSG_LIMIT { get { if (!_MSG_LIMITReady) { _MSG_LIMITContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "MSG_LIMIT"); _MSG_LIMITReady = true; } return _MSG_LIMITContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _MSG_LIMITContent = default;
                private static bool _MSG_LIMITReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#MSG_START"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type MSG_START { get { if (!_MSG_STARTReady) { _MSG_STARTContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "MSG_START"); _MSG_STARTReady = true; } return _MSG_STARTContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _MSG_STARTContent = default;
                private static bool _MSG_STARTReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#REPLACE_NUMBER"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type REPLACE_NUMBER { get { if (!_REPLACE_NUMBERReady) { _REPLACE_NUMBERContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "REPLACE_NUMBER"); _REPLACE_NUMBERReady = true; } return _REPLACE_NUMBERContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _REPLACE_NUMBERContent = default;
                private static bool _REPLACE_NUMBERReady = false; // this is used because in case of generics 
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#SKIP_SYNTAX"/>
                /// </summary>
                public static Android.Icu.Text.MessagePattern.Part.Type SKIP_SYNTAX { get { if (!_SKIP_SYNTAXReady) { _SKIP_SYNTAXContent = SGetField<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "SKIP_SYNTAX"); _SKIP_SYNTAXReady = true; } return _SKIP_SYNTAXContent; } }
                private static Android.Icu.Text.MessagePattern.Part.Type _SKIP_SYNTAXContent = default;
                private static bool _SKIP_SYNTAXReady = false; // this is used because in case of generics 

                #endregion

                #region Static methods
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#valueOf(java.lang.String)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.String"/></param>
                /// <returns><see cref="Android.Icu.Text.MessagePattern.Part.Type"/></returns>
                public static Android.Icu.Text.MessagePattern.Part.Type ValueOf(Java.Lang.String arg0)
                {
                    return SExecuteWithSignature<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/MessagePattern$Part$Type;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#values()"/>
                /// </summary>
                /// <returns><see cref="Android.Icu.Text.MessagePattern.Part.Type"/></returns>
                public static Android.Icu.Text.MessagePattern.Part.Type[] Values()
                {
                    return SExecuteWithSignatureArray<Android.Icu.Text.MessagePattern.Part.Type>(LocalBridgeClazz, "values", "()[Landroid/icu/text/MessagePattern$Part$Type;");
                }

                #endregion

                #region Instance methods
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/icu/text/MessagePattern.Part.Type.html#hasNumericValue()"/>
                /// </summary>
                /// <returns><see cref="bool"/></returns>
                public bool HasNumericValue()
                {
                    return IExecuteWithSignature<bool>("hasNumericValue", "()Z");
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}