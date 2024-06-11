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
    #region SearchIterator
    public partial class SearchIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#DONE"/>
        /// </summary>
        public static int DONE { get { if (!_DONEReady) { _DONEContent = SGetField<int>(LocalBridgeClazz, "DONE"); _DONEReady = true; } return _DONEContent; } }
        private static int _DONEContent = default;
        private static bool _DONEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#getIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIndex()
        {
            return IExecuteWithSignature<int>("getIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#getBreakIterator()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.BreakIterator"/></returns>
        public Android.Icu.Text.BreakIterator GetBreakIterator()
        {
            return IExecuteWithSignature<Android.Icu.Text.BreakIterator>("getBreakIterator", "()Landroid/icu/text/BreakIterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#getElementComparisonType()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.SearchIterator.ElementComparisonType"/></returns>
        public Android.Icu.Text.SearchIterator.ElementComparisonType GetElementComparisonType()
        {
            return IExecuteWithSignature<Android.Icu.Text.SearchIterator.ElementComparisonType>("getElementComparisonType", "()Landroid/icu/text/SearchIterator$ElementComparisonType;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#isOverlapping()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOverlapping()
        {
            return IExecuteWithSignature<bool>("isOverlapping", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#first()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int First()
        {
            return IExecuteWithSignature<int>("first", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#following(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Following(int arg0)
        {
            return IExecuteWithSignature<int>("following", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#last()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Last()
        {
            return IExecuteWithSignature<int>("last", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#preceding(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Preceding(int arg0)
        {
            return IExecuteWithSignature<int>("preceding", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#getMatchLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMatchLength()
        {
            return IExecuteWithSignature<int>("getMatchLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#getMatchStart()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMatchStart()
        {
            return IExecuteWithSignature<int>("getMatchStart", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#next()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Next()
        {
            return IExecuteWithSignature<int>("next", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#previous()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Previous()
        {
            return IExecuteWithSignature<int>("previous", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#getMatchedText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMatchedText()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMatchedText", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#getTarget()"/>
        /// </summary>
        /// <returns><see cref="Java.Text.CharacterIterator"/></returns>
        public Java.Text.CharacterIterator GetTarget()
        {
            return IExecuteWithSignature<Java.Text.CharacterIterator>("getTarget", "()Ljava/text/CharacterIterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#setBreakIterator(android.icu.text.BreakIterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.BreakIterator"/></param>
        public void SetBreakIterator(Android.Icu.Text.BreakIterator arg0)
        {
            IExecuteWithSignature("setBreakIterator", "(Landroid/icu/text/BreakIterator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#setElementComparisonType(android.icu.text.SearchIterator.ElementComparisonType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.SearchIterator.ElementComparisonType"/></param>
        public void SetElementComparisonType(Android.Icu.Text.SearchIterator.ElementComparisonType arg0)
        {
            IExecuteWithSignature("setElementComparisonType", "(Landroid/icu/text/SearchIterator$ElementComparisonType;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#setIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetIndex(int arg0)
        {
            IExecuteWithSignature("setIndex", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#setOverlapping(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetOverlapping(bool arg0)
        {
            IExecuteWithSignature("setOverlapping", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.html#setTarget(java.text.CharacterIterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.CharacterIterator"/></param>
        public void SetTarget(Java.Text.CharacterIterator arg0)
        {
            IExecuteWithSignature("setTarget", "(Ljava/text/CharacterIterator;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region ElementComparisonType
        public partial class ElementComparisonType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.ElementComparisonType.html#ANY_BASE_WEIGHT_IS_WILDCARD"/>
            /// </summary>
            public static Android.Icu.Text.SearchIterator.ElementComparisonType ANY_BASE_WEIGHT_IS_WILDCARD { get { if (!_ANY_BASE_WEIGHT_IS_WILDCARDReady) { _ANY_BASE_WEIGHT_IS_WILDCARDContent = SGetField<Android.Icu.Text.SearchIterator.ElementComparisonType>(LocalBridgeClazz, "ANY_BASE_WEIGHT_IS_WILDCARD"); _ANY_BASE_WEIGHT_IS_WILDCARDReady = true; } return _ANY_BASE_WEIGHT_IS_WILDCARDContent; } }
            private static Android.Icu.Text.SearchIterator.ElementComparisonType _ANY_BASE_WEIGHT_IS_WILDCARDContent = default;
            private static bool _ANY_BASE_WEIGHT_IS_WILDCARDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.ElementComparisonType.html#PATTERN_BASE_WEIGHT_IS_WILDCARD"/>
            /// </summary>
            public static Android.Icu.Text.SearchIterator.ElementComparisonType PATTERN_BASE_WEIGHT_IS_WILDCARD { get { if (!_PATTERN_BASE_WEIGHT_IS_WILDCARDReady) { _PATTERN_BASE_WEIGHT_IS_WILDCARDContent = SGetField<Android.Icu.Text.SearchIterator.ElementComparisonType>(LocalBridgeClazz, "PATTERN_BASE_WEIGHT_IS_WILDCARD"); _PATTERN_BASE_WEIGHT_IS_WILDCARDReady = true; } return _PATTERN_BASE_WEIGHT_IS_WILDCARDContent; } }
            private static Android.Icu.Text.SearchIterator.ElementComparisonType _PATTERN_BASE_WEIGHT_IS_WILDCARDContent = default;
            private static bool _PATTERN_BASE_WEIGHT_IS_WILDCARDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.ElementComparisonType.html#STANDARD_ELEMENT_COMPARISON"/>
            /// </summary>
            public static Android.Icu.Text.SearchIterator.ElementComparisonType STANDARD_ELEMENT_COMPARISON { get { if (!_STANDARD_ELEMENT_COMPARISONReady) { _STANDARD_ELEMENT_COMPARISONContent = SGetField<Android.Icu.Text.SearchIterator.ElementComparisonType>(LocalBridgeClazz, "STANDARD_ELEMENT_COMPARISON"); _STANDARD_ELEMENT_COMPARISONReady = true; } return _STANDARD_ELEMENT_COMPARISONContent; } }
            private static Android.Icu.Text.SearchIterator.ElementComparisonType _STANDARD_ELEMENT_COMPARISONContent = default;
            private static bool _STANDARD_ELEMENT_COMPARISONReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.ElementComparisonType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.SearchIterator.ElementComparisonType"/></returns>
            public static Android.Icu.Text.SearchIterator.ElementComparisonType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.SearchIterator.ElementComparisonType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/SearchIterator$ElementComparisonType;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/SearchIterator.ElementComparisonType.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.SearchIterator.ElementComparisonType"/></returns>
            public static Android.Icu.Text.SearchIterator.ElementComparisonType[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.SearchIterator.ElementComparisonType>(LocalBridgeClazz, "values", "()[Landroid/icu/text/SearchIterator$ElementComparisonType;");
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