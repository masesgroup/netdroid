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

namespace Android.Icu.Text
{
    #region ISymbolTable
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISymbolTable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SymbolTable
    public partial class SymbolTable : Android.Icu.Text.ISymbolTable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SymbolTable.html#SYMBOL_REF"/>
        /// </summary>
        public static char SYMBOL_REF { get { if (!_SYMBOL_REFReady) { _SYMBOL_REFContent = SGetField<char>(LocalBridgeClazz, "SYMBOL_REF"); _SYMBOL_REFReady = true; } return _SYMBOL_REFContent; } }
        private static char _SYMBOL_REFContent = default;
        private static bool _SYMBOL_REFReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SymbolTable.html#lookupMatcher(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Text.UnicodeMatcher"/></returns>
        public Android.Icu.Text.UnicodeMatcher LookupMatcher(int arg0)
        {
            return IExecuteWithSignature<Android.Icu.Text.UnicodeMatcher>("lookupMatcher", "(I)Landroid/icu/text/UnicodeMatcher;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SymbolTable.html#lookup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="char"/></returns>
        public char[] Lookup(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<char>("lookup", "(Ljava/lang/String;)[C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SymbolTable.html#parseReference(java.lang.String,java.text.ParsePosition,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Text.ParsePosition"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ParseReference(Java.Lang.String arg0, Java.Text.ParsePosition arg1, int arg2)
        {
            return IExecute<Java.Lang.String>("parseReference", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}