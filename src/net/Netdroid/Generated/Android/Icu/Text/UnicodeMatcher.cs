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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Icu.Text
{
    #region IUnicodeMatcher
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IUnicodeMatcher
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UnicodeMatcher
    public partial class UnicodeMatcher : Android.Icu.Text.IUnicodeMatcher
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeMatcher.html#ETHER"/>
        /// </summary>
        public static char ETHER { get { if (!_ETHERReady) { _ETHERContent = SGetField<char>(LocalBridgeClazz, "ETHER"); _ETHERReady = true; } return _ETHERContent; } }
        private static char _ETHERContent = default;
        private static bool _ETHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeMatcher.html#U_MATCH"/>
        /// </summary>
        public static int U_MATCH { get { if (!_U_MATCHReady) { _U_MATCHContent = SGetField<int>(LocalBridgeClazz, "U_MATCH"); _U_MATCHReady = true; } return _U_MATCHContent; } }
        private static int _U_MATCHContent = default;
        private static bool _U_MATCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeMatcher.html#U_MISMATCH"/>
        /// </summary>
        public static int U_MISMATCH { get { if (!_U_MISMATCHReady) { _U_MISMATCHContent = SGetField<int>(LocalBridgeClazz, "U_MISMATCH"); _U_MISMATCHReady = true; } return _U_MISMATCHContent; } }
        private static int _U_MISMATCHContent = default;
        private static bool _U_MISMATCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeMatcher.html#U_PARTIAL_MATCH"/>
        /// </summary>
        public static int U_PARTIAL_MATCH { get { if (!_U_PARTIAL_MATCHReady) { _U_PARTIAL_MATCHContent = SGetField<int>(LocalBridgeClazz, "U_PARTIAL_MATCH"); _U_PARTIAL_MATCHReady = true; } return _U_PARTIAL_MATCHContent; } }
        private static int _U_PARTIAL_MATCHContent = default;
        private static bool _U_PARTIAL_MATCHReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeMatcher.html#matchesIndexValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool MatchesIndexValue(int arg0)
        {
            return IExecuteWithSignature<bool>("matchesIndexValue", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeMatcher.html#matches(android.icu.text.Replaceable,int[],int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.Replaceable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int Matches(Android.Icu.Text.Replaceable arg0, int[] arg1, int arg2, bool arg3)
        {
            return IExecute<int>("matches", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeMatcher.html#toPattern(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToPattern(bool arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("toPattern", "(Z)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UnicodeMatcher.html#addMatchSetTo(android.icu.text.UnicodeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.UnicodeSet"/></param>
        public void AddMatchSetTo(Android.Icu.Text.UnicodeSet arg0)
        {
            IExecuteWithSignature("addMatchSetTo", "(Landroid/icu/text/UnicodeSet;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}