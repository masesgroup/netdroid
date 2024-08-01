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

namespace Android.Text
{
    #region ISpanned
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISpanned : Java.Lang.ICharSequence
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Spanned
    public partial class Spanned : Android.Text.ISpanned
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_COMPOSING"/>
        /// </summary>
        public static int SPAN_COMPOSING { get { if (!_SPAN_COMPOSINGReady) { _SPAN_COMPOSINGContent = SGetField<int>(LocalBridgeClazz, "SPAN_COMPOSING"); _SPAN_COMPOSINGReady = true; } return _SPAN_COMPOSINGContent; } }
        private static int _SPAN_COMPOSINGContent = default;
        private static bool _SPAN_COMPOSINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_EXCLUSIVE_EXCLUSIVE"/>
        /// </summary>
        public static int SPAN_EXCLUSIVE_EXCLUSIVE { get { if (!_SPAN_EXCLUSIVE_EXCLUSIVEReady) { _SPAN_EXCLUSIVE_EXCLUSIVEContent = SGetField<int>(LocalBridgeClazz, "SPAN_EXCLUSIVE_EXCLUSIVE"); _SPAN_EXCLUSIVE_EXCLUSIVEReady = true; } return _SPAN_EXCLUSIVE_EXCLUSIVEContent; } }
        private static int _SPAN_EXCLUSIVE_EXCLUSIVEContent = default;
        private static bool _SPAN_EXCLUSIVE_EXCLUSIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_EXCLUSIVE_INCLUSIVE"/>
        /// </summary>
        public static int SPAN_EXCLUSIVE_INCLUSIVE { get { if (!_SPAN_EXCLUSIVE_INCLUSIVEReady) { _SPAN_EXCLUSIVE_INCLUSIVEContent = SGetField<int>(LocalBridgeClazz, "SPAN_EXCLUSIVE_INCLUSIVE"); _SPAN_EXCLUSIVE_INCLUSIVEReady = true; } return _SPAN_EXCLUSIVE_INCLUSIVEContent; } }
        private static int _SPAN_EXCLUSIVE_INCLUSIVEContent = default;
        private static bool _SPAN_EXCLUSIVE_INCLUSIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_INCLUSIVE_EXCLUSIVE"/>
        /// </summary>
        public static int SPAN_INCLUSIVE_EXCLUSIVE { get { if (!_SPAN_INCLUSIVE_EXCLUSIVEReady) { _SPAN_INCLUSIVE_EXCLUSIVEContent = SGetField<int>(LocalBridgeClazz, "SPAN_INCLUSIVE_EXCLUSIVE"); _SPAN_INCLUSIVE_EXCLUSIVEReady = true; } return _SPAN_INCLUSIVE_EXCLUSIVEContent; } }
        private static int _SPAN_INCLUSIVE_EXCLUSIVEContent = default;
        private static bool _SPAN_INCLUSIVE_EXCLUSIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_INCLUSIVE_INCLUSIVE"/>
        /// </summary>
        public static int SPAN_INCLUSIVE_INCLUSIVE { get { if (!_SPAN_INCLUSIVE_INCLUSIVEReady) { _SPAN_INCLUSIVE_INCLUSIVEContent = SGetField<int>(LocalBridgeClazz, "SPAN_INCLUSIVE_INCLUSIVE"); _SPAN_INCLUSIVE_INCLUSIVEReady = true; } return _SPAN_INCLUSIVE_INCLUSIVEContent; } }
        private static int _SPAN_INCLUSIVE_INCLUSIVEContent = default;
        private static bool _SPAN_INCLUSIVE_INCLUSIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_INTERMEDIATE"/>
        /// </summary>
        public static int SPAN_INTERMEDIATE { get { if (!_SPAN_INTERMEDIATEReady) { _SPAN_INTERMEDIATEContent = SGetField<int>(LocalBridgeClazz, "SPAN_INTERMEDIATE"); _SPAN_INTERMEDIATEReady = true; } return _SPAN_INTERMEDIATEContent; } }
        private static int _SPAN_INTERMEDIATEContent = default;
        private static bool _SPAN_INTERMEDIATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_MARK_MARK"/>
        /// </summary>
        public static int SPAN_MARK_MARK { get { if (!_SPAN_MARK_MARKReady) { _SPAN_MARK_MARKContent = SGetField<int>(LocalBridgeClazz, "SPAN_MARK_MARK"); _SPAN_MARK_MARKReady = true; } return _SPAN_MARK_MARKContent; } }
        private static int _SPAN_MARK_MARKContent = default;
        private static bool _SPAN_MARK_MARKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_MARK_POINT"/>
        /// </summary>
        public static int SPAN_MARK_POINT { get { if (!_SPAN_MARK_POINTReady) { _SPAN_MARK_POINTContent = SGetField<int>(LocalBridgeClazz, "SPAN_MARK_POINT"); _SPAN_MARK_POINTReady = true; } return _SPAN_MARK_POINTContent; } }
        private static int _SPAN_MARK_POINTContent = default;
        private static bool _SPAN_MARK_POINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_PARAGRAPH"/>
        /// </summary>
        public static int SPAN_PARAGRAPH { get { if (!_SPAN_PARAGRAPHReady) { _SPAN_PARAGRAPHContent = SGetField<int>(LocalBridgeClazz, "SPAN_PARAGRAPH"); _SPAN_PARAGRAPHReady = true; } return _SPAN_PARAGRAPHContent; } }
        private static int _SPAN_PARAGRAPHContent = default;
        private static bool _SPAN_PARAGRAPHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_POINT_MARK"/>
        /// </summary>
        public static int SPAN_POINT_MARK { get { if (!_SPAN_POINT_MARKReady) { _SPAN_POINT_MARKContent = SGetField<int>(LocalBridgeClazz, "SPAN_POINT_MARK"); _SPAN_POINT_MARKReady = true; } return _SPAN_POINT_MARKContent; } }
        private static int _SPAN_POINT_MARKContent = default;
        private static bool _SPAN_POINT_MARKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_POINT_MARK_MASK"/>
        /// </summary>
        public static int SPAN_POINT_MARK_MASK { get { if (!_SPAN_POINT_MARK_MASKReady) { _SPAN_POINT_MARK_MASKContent = SGetField<int>(LocalBridgeClazz, "SPAN_POINT_MARK_MASK"); _SPAN_POINT_MARK_MASKReady = true; } return _SPAN_POINT_MARK_MASKContent; } }
        private static int _SPAN_POINT_MARK_MASKContent = default;
        private static bool _SPAN_POINT_MARK_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_POINT_POINT"/>
        /// </summary>
        public static int SPAN_POINT_POINT { get { if (!_SPAN_POINT_POINTReady) { _SPAN_POINT_POINTContent = SGetField<int>(LocalBridgeClazz, "SPAN_POINT_POINT"); _SPAN_POINT_POINTReady = true; } return _SPAN_POINT_POINTContent; } }
        private static int _SPAN_POINT_POINTContent = default;
        private static bool _SPAN_POINT_POINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_PRIORITY"/>
        /// </summary>
        public static int SPAN_PRIORITY { get { if (!_SPAN_PRIORITYReady) { _SPAN_PRIORITYContent = SGetField<int>(LocalBridgeClazz, "SPAN_PRIORITY"); _SPAN_PRIORITYReady = true; } return _SPAN_PRIORITYContent; } }
        private static int _SPAN_PRIORITYContent = default;
        private static bool _SPAN_PRIORITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_PRIORITY_SHIFT"/>
        /// </summary>
        public static int SPAN_PRIORITY_SHIFT { get { if (!_SPAN_PRIORITY_SHIFTReady) { _SPAN_PRIORITY_SHIFTContent = SGetField<int>(LocalBridgeClazz, "SPAN_PRIORITY_SHIFT"); _SPAN_PRIORITY_SHIFTReady = true; } return _SPAN_PRIORITY_SHIFTContent; } }
        private static int _SPAN_PRIORITY_SHIFTContent = default;
        private static bool _SPAN_PRIORITY_SHIFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_USER"/>
        /// </summary>
        public static int SPAN_USER { get { if (!_SPAN_USERReady) { _SPAN_USERContent = SGetField<int>(LocalBridgeClazz, "SPAN_USER"); _SPAN_USERReady = true; } return _SPAN_USERContent; } }
        private static int _SPAN_USERContent = default;
        private static bool _SPAN_USERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#SPAN_USER_SHIFT"/>
        /// </summary>
        public static int SPAN_USER_SHIFT { get { if (!_SPAN_USER_SHIFTReady) { _SPAN_USER_SHIFTContent = SGetField<int>(LocalBridgeClazz, "SPAN_USER_SHIFT"); _SPAN_USER_SHIFTReady = true; } return _SPAN_USER_SHIFTContent; } }
        private static int _SPAN_USER_SHIFTContent = default;
        private static bool _SPAN_USER_SHIFTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#getSpans(int,int,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetSpans<T>(int arg0, int arg1, Java.Lang.Class arg2)
        {
            return IExecuteArray<T>("getSpans", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#getSpanEnd(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSpanEnd(object arg0)
        {
            return IExecuteWithSignature<int>("getSpanEnd", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#getSpanFlags(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSpanFlags(object arg0)
        {
            return IExecuteWithSignature<int>("getSpanFlags", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#getSpanStart(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSpanStart(object arg0)
        {
            return IExecuteWithSignature<int>("getSpanStart", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Spanned.html#nextSpanTransition(int,int,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="int"/></returns>
        public int NextSpanTransition(int arg0, int arg1, Java.Lang.Class arg2)
        {
            return IExecute<int>("nextSpanTransition", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}