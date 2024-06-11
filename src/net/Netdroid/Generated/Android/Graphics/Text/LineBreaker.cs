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

namespace Android.Graphics.Text
{
    #region LineBreaker
    public partial class LineBreaker
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.html#BREAK_STRATEGY_BALANCED"/>
        /// </summary>
        public static int BREAK_STRATEGY_BALANCED { get { if (!_BREAK_STRATEGY_BALANCEDReady) { _BREAK_STRATEGY_BALANCEDContent = SGetField<int>(LocalBridgeClazz, "BREAK_STRATEGY_BALANCED"); _BREAK_STRATEGY_BALANCEDReady = true; } return _BREAK_STRATEGY_BALANCEDContent; } }
        private static int _BREAK_STRATEGY_BALANCEDContent = default;
        private static bool _BREAK_STRATEGY_BALANCEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.html#BREAK_STRATEGY_HIGH_QUALITY"/>
        /// </summary>
        public static int BREAK_STRATEGY_HIGH_QUALITY { get { if (!_BREAK_STRATEGY_HIGH_QUALITYReady) { _BREAK_STRATEGY_HIGH_QUALITYContent = SGetField<int>(LocalBridgeClazz, "BREAK_STRATEGY_HIGH_QUALITY"); _BREAK_STRATEGY_HIGH_QUALITYReady = true; } return _BREAK_STRATEGY_HIGH_QUALITYContent; } }
        private static int _BREAK_STRATEGY_HIGH_QUALITYContent = default;
        private static bool _BREAK_STRATEGY_HIGH_QUALITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.html#BREAK_STRATEGY_SIMPLE"/>
        /// </summary>
        public static int BREAK_STRATEGY_SIMPLE { get { if (!_BREAK_STRATEGY_SIMPLEReady) { _BREAK_STRATEGY_SIMPLEContent = SGetField<int>(LocalBridgeClazz, "BREAK_STRATEGY_SIMPLE"); _BREAK_STRATEGY_SIMPLEReady = true; } return _BREAK_STRATEGY_SIMPLEContent; } }
        private static int _BREAK_STRATEGY_SIMPLEContent = default;
        private static bool _BREAK_STRATEGY_SIMPLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.html#HYPHENATION_FREQUENCY_FULL"/>
        /// </summary>
        public static int HYPHENATION_FREQUENCY_FULL { get { if (!_HYPHENATION_FREQUENCY_FULLReady) { _HYPHENATION_FREQUENCY_FULLContent = SGetField<int>(LocalBridgeClazz, "HYPHENATION_FREQUENCY_FULL"); _HYPHENATION_FREQUENCY_FULLReady = true; } return _HYPHENATION_FREQUENCY_FULLContent; } }
        private static int _HYPHENATION_FREQUENCY_FULLContent = default;
        private static bool _HYPHENATION_FREQUENCY_FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.html#HYPHENATION_FREQUENCY_NONE"/>
        /// </summary>
        public static int HYPHENATION_FREQUENCY_NONE { get { if (!_HYPHENATION_FREQUENCY_NONEReady) { _HYPHENATION_FREQUENCY_NONEContent = SGetField<int>(LocalBridgeClazz, "HYPHENATION_FREQUENCY_NONE"); _HYPHENATION_FREQUENCY_NONEReady = true; } return _HYPHENATION_FREQUENCY_NONEContent; } }
        private static int _HYPHENATION_FREQUENCY_NONEContent = default;
        private static bool _HYPHENATION_FREQUENCY_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.html#HYPHENATION_FREQUENCY_NORMAL"/>
        /// </summary>
        public static int HYPHENATION_FREQUENCY_NORMAL { get { if (!_HYPHENATION_FREQUENCY_NORMALReady) { _HYPHENATION_FREQUENCY_NORMALContent = SGetField<int>(LocalBridgeClazz, "HYPHENATION_FREQUENCY_NORMAL"); _HYPHENATION_FREQUENCY_NORMALReady = true; } return _HYPHENATION_FREQUENCY_NORMALContent; } }
        private static int _HYPHENATION_FREQUENCY_NORMALContent = default;
        private static bool _HYPHENATION_FREQUENCY_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.html#JUSTIFICATION_MODE_INTER_WORD"/>
        /// </summary>
        public static int JUSTIFICATION_MODE_INTER_WORD { get { if (!_JUSTIFICATION_MODE_INTER_WORDReady) { _JUSTIFICATION_MODE_INTER_WORDContent = SGetField<int>(LocalBridgeClazz, "JUSTIFICATION_MODE_INTER_WORD"); _JUSTIFICATION_MODE_INTER_WORDReady = true; } return _JUSTIFICATION_MODE_INTER_WORDContent; } }
        private static int _JUSTIFICATION_MODE_INTER_WORDContent = default;
        private static bool _JUSTIFICATION_MODE_INTER_WORDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.html#JUSTIFICATION_MODE_NONE"/>
        /// </summary>
        public static int JUSTIFICATION_MODE_NONE { get { if (!_JUSTIFICATION_MODE_NONEReady) { _JUSTIFICATION_MODE_NONEContent = SGetField<int>(LocalBridgeClazz, "JUSTIFICATION_MODE_NONE"); _JUSTIFICATION_MODE_NONEReady = true; } return _JUSTIFICATION_MODE_NONEContent; } }
        private static int _JUSTIFICATION_MODE_NONEContent = default;
        private static bool _JUSTIFICATION_MODE_NONEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.html#computeLineBreaks(android.graphics.text.MeasuredText,android.graphics.text.LineBreaker.ParagraphConstraints,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Text.MeasuredText"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Text.LineBreaker.ParagraphConstraints"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Text.LineBreaker.Result"/></returns>
        public Android.Graphics.Text.LineBreaker.Result ComputeLineBreaks(Android.Graphics.Text.MeasuredText arg0, Android.Graphics.Text.LineBreaker.ParagraphConstraints arg1, int arg2)
        {
            return IExecute<Android.Graphics.Text.LineBreaker.Result>("computeLineBreaks", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Text.LineBreaker"/></returns>
            public Android.Graphics.Text.LineBreaker Build()
            {
                return IExecuteWithSignature<Android.Graphics.Text.LineBreaker>("build", "()Landroid/graphics/text/LineBreaker;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.Builder.html#setBreakStrategy(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Text.LineBreaker.Builder"/></returns>
            public Android.Graphics.Text.LineBreaker.Builder SetBreakStrategy(int arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Text.LineBreaker.Builder>("setBreakStrategy", "(I)Landroid/graphics/text/LineBreaker$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.Builder.html#setHyphenationFrequency(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Text.LineBreaker.Builder"/></returns>
            public Android.Graphics.Text.LineBreaker.Builder SetHyphenationFrequency(int arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Text.LineBreaker.Builder>("setHyphenationFrequency", "(I)Landroid/graphics/text/LineBreaker$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.Builder.html#setIndents(int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Text.LineBreaker.Builder"/></returns>
            public Android.Graphics.Text.LineBreaker.Builder SetIndents(int[] arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Text.LineBreaker.Builder>("setIndents", "([I)Landroid/graphics/text/LineBreaker$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.Builder.html#setJustificationMode(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Text.LineBreaker.Builder"/></returns>
            public Android.Graphics.Text.LineBreaker.Builder SetJustificationMode(int arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Text.LineBreaker.Builder>("setJustificationMode", "(I)Landroid/graphics/text/LineBreaker$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ParagraphConstraints
        public partial class ParagraphConstraints
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
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.ParagraphConstraints.html#getDefaultTabStop()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetDefaultTabStop()
            {
                return IExecuteWithSignature<float>("getDefaultTabStop", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.ParagraphConstraints.html#getFirstWidth()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetFirstWidth()
            {
                return IExecuteWithSignature<float>("getFirstWidth", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.ParagraphConstraints.html#getWidth()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetWidth()
            {
                return IExecuteWithSignature<float>("getWidth", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.ParagraphConstraints.html#getTabStops()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float[] GetTabStops()
            {
                return IExecuteWithSignatureArray<float>("getTabStops", "()[F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.ParagraphConstraints.html#getFirstWidthLineCount()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetFirstWidthLineCount()
            {
                return IExecuteWithSignature<int>("getFirstWidthLineCount", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.ParagraphConstraints.html#setIndent(float,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void SetIndent(float arg0, int arg1)
            {
                IExecute("setIndent", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.ParagraphConstraints.html#setTabStops(float[],float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            public void SetTabStops(float[] arg0, float arg1)
            {
                IExecute("setTabStops", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.ParagraphConstraints.html#setWidth(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            public void SetWidth(float arg0)
            {
                IExecuteWithSignature("setWidth", "(F)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Result
        public partial class Result
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
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.Result.html#hasLineTab(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool HasLineTab(int arg0)
            {
                return IExecuteWithSignature<bool>("hasLineTab", "(I)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.Result.html#getLineAscent(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="float"/></returns>
            public float GetLineAscent(int arg0)
            {
                return IExecuteWithSignature<float>("getLineAscent", "(I)F", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.Result.html#getLineDescent(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="float"/></returns>
            public float GetLineDescent(int arg0)
            {
                return IExecuteWithSignature<float>("getLineDescent", "(I)F", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.Result.html#getLineWidth(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="float"/></returns>
            public float GetLineWidth(int arg0)
            {
                return IExecuteWithSignature<float>("getLineWidth", "(I)F", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.Result.html#getEndLineHyphenEdit(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            public int GetEndLineHyphenEdit(int arg0)
            {
                return IExecuteWithSignature<int>("getEndLineHyphenEdit", "(I)I", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.Result.html#getLineBreakOffset(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            public int GetLineBreakOffset(int arg0)
            {
                return IExecuteWithSignature<int>("getLineBreakOffset", "(I)I", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.Result.html#getLineCount()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetLineCount()
            {
                return IExecuteWithSignature<int>("getLineCount", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/LineBreaker.Result.html#getStartLineHyphenEdit(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            public int GetStartLineHyphenEdit(int arg0)
            {
                return IExecuteWithSignature<int>("getStartLineHyphenEdit", "(I)I", arg0);
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