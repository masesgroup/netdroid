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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Regex
{
    #region Pattern
    public partial class Pattern
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#CANON_EQ"/>
        /// </summary>
        public static int CANON_EQ { get { if (!_CANON_EQReady) { _CANON_EQContent = SGetField<int>(LocalBridgeClazz, "CANON_EQ"); _CANON_EQReady = true; } return _CANON_EQContent; } }
        private static int _CANON_EQContent = default;
        private static bool _CANON_EQReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#CASE_INSENSITIVE"/>
        /// </summary>
        public static int CASE_INSENSITIVE { get { if (!_CASE_INSENSITIVEReady) { _CASE_INSENSITIVEContent = SGetField<int>(LocalBridgeClazz, "CASE_INSENSITIVE"); _CASE_INSENSITIVEReady = true; } return _CASE_INSENSITIVEContent; } }
        private static int _CASE_INSENSITIVEContent = default;
        private static bool _CASE_INSENSITIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#COMMENTS"/>
        /// </summary>
        public static int COMMENTS { get { if (!_COMMENTSReady) { _COMMENTSContent = SGetField<int>(LocalBridgeClazz, "COMMENTS"); _COMMENTSReady = true; } return _COMMENTSContent; } }
        private static int _COMMENTSContent = default;
        private static bool _COMMENTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#DOTALL"/>
        /// </summary>
        public static int DOTALL { get { if (!_DOTALLReady) { _DOTALLContent = SGetField<int>(LocalBridgeClazz, "DOTALL"); _DOTALLReady = true; } return _DOTALLContent; } }
        private static int _DOTALLContent = default;
        private static bool _DOTALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#LITERAL"/>
        /// </summary>
        public static int LITERAL { get { if (!_LITERALReady) { _LITERALContent = SGetField<int>(LocalBridgeClazz, "LITERAL"); _LITERALReady = true; } return _LITERALContent; } }
        private static int _LITERALContent = default;
        private static bool _LITERALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#MULTILINE"/>
        /// </summary>
        public static int MULTILINE { get { if (!_MULTILINEReady) { _MULTILINEContent = SGetField<int>(LocalBridgeClazz, "MULTILINE"); _MULTILINEReady = true; } return _MULTILINEContent; } }
        private static int _MULTILINEContent = default;
        private static bool _MULTILINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#UNICODE_CASE"/>
        /// </summary>
        public static int UNICODE_CASE { get { if (!_UNICODE_CASEReady) { _UNICODE_CASEContent = SGetField<int>(LocalBridgeClazz, "UNICODE_CASE"); _UNICODE_CASEReady = true; } return _UNICODE_CASEContent; } }
        private static int _UNICODE_CASEContent = default;
        private static bool _UNICODE_CASEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#UNICODE_CHARACTER_CLASS"/>
        /// </summary>
        public static int UNICODE_CHARACTER_CLASS { get { if (!_UNICODE_CHARACTER_CLASSReady) { _UNICODE_CHARACTER_CLASSContent = SGetField<int>(LocalBridgeClazz, "UNICODE_CHARACTER_CLASS"); _UNICODE_CHARACTER_CLASSReady = true; } return _UNICODE_CHARACTER_CLASSContent; } }
        private static int _UNICODE_CHARACTER_CLASSContent = default;
        private static bool _UNICODE_CHARACTER_CLASSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#UNIX_LINES"/>
        /// </summary>
        public static int UNIX_LINES { get { if (!_UNIX_LINESReady) { _UNIX_LINESContent = SGetField<int>(LocalBridgeClazz, "UNIX_LINES"); _UNIX_LINESReady = true; } return _UNIX_LINESContent; } }
        private static int _UNIX_LINESContent = default;
        private static bool _UNIX_LINESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#matches(java.lang.String,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Matches(Java.Lang.String arg0, Java.Lang.CharSequence arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "matches", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#quote(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Quote(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "quote", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#compile(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Regex.Pattern"/></returns>
        public static Java.Util.Regex.Pattern Compile(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Java.Util.Regex.Pattern>(LocalBridgeClazz, "compile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#compile(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Regex.Pattern"/></returns>
        public static Java.Util.Regex.Pattern Compile(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Regex.Pattern>(LocalBridgeClazz, "compile", "(Ljava/lang/String;)Ljava/util/regex/Pattern;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#flags()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Flags()
        {
            return IExecuteWithSignature<int>("flags", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#pattern()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String PatternMethod()
        {
            return IExecuteWithSignature<Java.Lang.String>("pattern", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#split(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] Split(Java.Lang.CharSequence arg0, int arg1)
        {
            return IExecuteArray<Java.Lang.String>("split", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#split(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] Split(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("split", "(Ljava/lang/CharSequence;)[Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#asMatchPredicate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate<Java.Lang.String> AsMatchPredicate()
        {
            return IExecuteWithSignature<Java.Util.Function.Predicate<Java.Lang.String>>("asMatchPredicate", "()Ljava/util/function/Predicate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#asMatchPredicate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate<Java.Lang.String> AsMatchPredicateDirect()
        {
            return IExecuteWithSignature<Java.Util.Function.PredicateDirect<Java.Lang.String>, Java.Util.Function.Predicate<Java.Lang.String>>("asMatchPredicate", "()Ljava/util/function/Predicate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#asPredicate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate<Java.Lang.String> AsPredicate()
        {
            return IExecuteWithSignature<Java.Util.Function.Predicate<Java.Lang.String>>("asPredicate", "()Ljava/util/function/Predicate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#asPredicate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate<Java.Lang.String> AsPredicateDirect()
        {
            return IExecuteWithSignature<Java.Util.Function.PredicateDirect<Java.Lang.String>, Java.Util.Function.Predicate<Java.Lang.String>>("asPredicate", "()Ljava/util/function/Predicate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#matcher(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher Matcher(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Java.Util.Regex.Matcher>("matcher", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Pattern.html#splitAsStream(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Lang.String> SplitAsStream(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Lang.String>>("splitAsStream", "(Ljava/lang/CharSequence;)Ljava/util/stream/Stream;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}