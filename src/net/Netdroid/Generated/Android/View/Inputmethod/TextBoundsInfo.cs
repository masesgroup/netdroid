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

namespace Android.View.Inputmethod
{
    #region TextBoundsInfo
    public partial class TextBoundsInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#FLAG_CHARACTER_LINEFEED"/>
        /// </summary>
        public static int FLAG_CHARACTER_LINEFEED { get { if (!_FLAG_CHARACTER_LINEFEEDReady) { _FLAG_CHARACTER_LINEFEEDContent = SGetField<int>(LocalBridgeClazz, "FLAG_CHARACTER_LINEFEED"); _FLAG_CHARACTER_LINEFEEDReady = true; } return _FLAG_CHARACTER_LINEFEEDContent; } }
        private static int _FLAG_CHARACTER_LINEFEEDContent = default;
        private static bool _FLAG_CHARACTER_LINEFEEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#FLAG_CHARACTER_PUNCTUATION"/>
        /// </summary>
        public static int FLAG_CHARACTER_PUNCTUATION { get { if (!_FLAG_CHARACTER_PUNCTUATIONReady) { _FLAG_CHARACTER_PUNCTUATIONContent = SGetField<int>(LocalBridgeClazz, "FLAG_CHARACTER_PUNCTUATION"); _FLAG_CHARACTER_PUNCTUATIONReady = true; } return _FLAG_CHARACTER_PUNCTUATIONContent; } }
        private static int _FLAG_CHARACTER_PUNCTUATIONContent = default;
        private static bool _FLAG_CHARACTER_PUNCTUATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#FLAG_CHARACTER_WHITESPACE"/>
        /// </summary>
        public static int FLAG_CHARACTER_WHITESPACE { get { if (!_FLAG_CHARACTER_WHITESPACEReady) { _FLAG_CHARACTER_WHITESPACEContent = SGetField<int>(LocalBridgeClazz, "FLAG_CHARACTER_WHITESPACE"); _FLAG_CHARACTER_WHITESPACEReady = true; } return _FLAG_CHARACTER_WHITESPACEContent; } }
        private static int _FLAG_CHARACTER_WHITESPACEContent = default;
        private static bool _FLAG_CHARACTER_WHITESPACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#FLAG_LINE_IS_RTL"/>
        /// </summary>
        public static int FLAG_LINE_IS_RTL { get { if (!_FLAG_LINE_IS_RTLReady) { _FLAG_LINE_IS_RTLContent = SGetField<int>(LocalBridgeClazz, "FLAG_LINE_IS_RTL"); _FLAG_LINE_IS_RTLReady = true; } return _FLAG_LINE_IS_RTLContent; } }
        private static int _FLAG_LINE_IS_RTLContent = default;
        private static bool _FLAG_LINE_IS_RTLReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#getGraphemeSegmentFinder()"/>
        /// </summary>
        /// <returns><see cref="Android.Text.SegmentFinder"/></returns>
        public Android.Text.SegmentFinder GetGraphemeSegmentFinder()
        {
            return IExecuteWithSignature<Android.Text.SegmentFinder>("getGraphemeSegmentFinder", "()Landroid/text/SegmentFinder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#getLineSegmentFinder()"/>
        /// </summary>
        /// <returns><see cref="Android.Text.SegmentFinder"/></returns>
        public Android.Text.SegmentFinder GetLineSegmentFinder()
        {
            return IExecuteWithSignature<Android.Text.SegmentFinder>("getLineSegmentFinder", "()Landroid/text/SegmentFinder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#getWordSegmentFinder()"/>
        /// </summary>
        /// <returns><see cref="Android.Text.SegmentFinder"/></returns>
        public Android.Text.SegmentFinder GetWordSegmentFinder()
        {
            return IExecuteWithSignature<Android.Text.SegmentFinder>("getWordSegmentFinder", "()Landroid/text/SegmentFinder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#getCharacterBidiLevel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetCharacterBidiLevel(int arg0)
        {
            return IExecuteWithSignature<int>("getCharacterBidiLevel", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#getCharacterFlags(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetCharacterFlags(int arg0)
        {
            return IExecuteWithSignature<int>("getCharacterFlags", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#getEndIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEndIndex()
        {
            return IExecuteWithSignature<int>("getEndIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#getOffsetForPosition(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetOffsetForPosition(float arg0, float arg1)
        {
            return IExecute<int>("getOffsetForPosition", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#getStartIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStartIndex()
        {
            return IExecuteWithSignature<int>("getStartIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#getRangeForRect(android.graphics.RectF,android.text.SegmentFinder,android.text.Layout.TextInclusionStrategy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
        /// <param name="arg1"><see cref="Android.Text.SegmentFinder"/></param>
        /// <param name="arg2"><see cref="Android.Text.Layout.TextInclusionStrategy"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetRangeForRect(Android.Graphics.RectF arg0, Android.Text.SegmentFinder arg1, Android.Text.Layout.TextInclusionStrategy arg2)
        {
            return IExecuteArray<int>("getRangeForRect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#getCharacterBounds(int,android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.RectF"/></param>
        public void GetCharacterBounds(int arg0, Android.Graphics.RectF arg1)
        {
            IExecute("getCharacterBounds", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#getMatrix(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        public void GetMatrix(Android.Graphics.Matrix arg0)
        {
            IExecuteWithSignature("getMatrix", "(Landroid/graphics/Matrix;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.Builder.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public Builder(int arg0, int arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Inputmethod.TextBoundsInfo"/></returns>
            public Android.View.Inputmethod.TextBoundsInfo Build()
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextBoundsInfo>("build", "()Landroid/view/inputmethod/TextBoundsInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.Builder.html#clear()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Inputmethod.TextBoundsInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextBoundsInfo.Builder Clear()
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextBoundsInfo.Builder>("clear", "()Landroid/view/inputmethod/TextBoundsInfo$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.Builder.html#setCharacterBidiLevel(int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextBoundsInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextBoundsInfo.Builder SetCharacterBidiLevel(int[] arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextBoundsInfo.Builder>("setCharacterBidiLevel", "([I)Landroid/view/inputmethod/TextBoundsInfo$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.Builder.html#setCharacterBounds(float[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextBoundsInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextBoundsInfo.Builder SetCharacterBounds(float[] arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextBoundsInfo.Builder>("setCharacterBounds", "([F)Landroid/view/inputmethod/TextBoundsInfo$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.Builder.html#setCharacterFlags(int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextBoundsInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextBoundsInfo.Builder SetCharacterFlags(int[] arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextBoundsInfo.Builder>("setCharacterFlags", "([I)Landroid/view/inputmethod/TextBoundsInfo$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.Builder.html#setGraphemeSegmentFinder(android.text.SegmentFinder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Text.SegmentFinder"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextBoundsInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextBoundsInfo.Builder SetGraphemeSegmentFinder(Android.Text.SegmentFinder arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextBoundsInfo.Builder>("setGraphemeSegmentFinder", "(Landroid/text/SegmentFinder;)Landroid/view/inputmethod/TextBoundsInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.Builder.html#setLineSegmentFinder(android.text.SegmentFinder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Text.SegmentFinder"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextBoundsInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextBoundsInfo.Builder SetLineSegmentFinder(Android.Text.SegmentFinder arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextBoundsInfo.Builder>("setLineSegmentFinder", "(Landroid/text/SegmentFinder;)Landroid/view/inputmethod/TextBoundsInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.Builder.html#setMatrix(android.graphics.Matrix)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextBoundsInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextBoundsInfo.Builder SetMatrix(Android.Graphics.Matrix arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextBoundsInfo.Builder>("setMatrix", "(Landroid/graphics/Matrix;)Landroid/view/inputmethod/TextBoundsInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.Builder.html#setStartAndEnd(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextBoundsInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextBoundsInfo.Builder SetStartAndEnd(int arg0, int arg1)
            {
                return IExecute<Android.View.Inputmethod.TextBoundsInfo.Builder>("setStartAndEnd", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfo.Builder.html#setWordSegmentFinder(android.text.SegmentFinder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Text.SegmentFinder"/></param>
            /// <returns><see cref="Android.View.Inputmethod.TextBoundsInfo.Builder"/></returns>
            public Android.View.Inputmethod.TextBoundsInfo.Builder SetWordSegmentFinder(Android.Text.SegmentFinder arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.TextBoundsInfo.Builder>("setWordSegmentFinder", "(Landroid/text/SegmentFinder;)Landroid/view/inputmethod/TextBoundsInfo$Builder;", arg0);
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