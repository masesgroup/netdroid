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

namespace Android.Graphics.Text
{
    #region PositionedGlyphs
    public partial class PositionedGlyphs
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
        /// <see href="https://developer.android.com/reference/android/graphics/text/PositionedGlyphs.html#getAdvance()"/> 
        /// </summary>
        public float Advance
        {
            get { return IExecuteWithSignature<float>("getAdvance", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/PositionedGlyphs.html#getAscent()"/> 
        /// </summary>
        public float Ascent
        {
            get { return IExecuteWithSignature<float>("getAscent", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/PositionedGlyphs.html#getDescent()"/> 
        /// </summary>
        public float Descent
        {
            get { return IExecuteWithSignature<float>("getDescent", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/PositionedGlyphs.html#getOffsetX()"/> 
        /// </summary>
        public float OffsetX
        {
            get { return IExecuteWithSignature<float>("getOffsetX", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/PositionedGlyphs.html#getOffsetY()"/> 
        /// </summary>
        public float OffsetY
        {
            get { return IExecuteWithSignature<float>("getOffsetY", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/PositionedGlyphs.html#getFont(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Fonts.Font"/></returns>
        public Android.Graphics.Fonts.Font GetFont(int arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Fonts.Font>("getFont", "(I)Landroid/graphics/fonts/Font;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/PositionedGlyphs.html#getGlyphX(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetGlyphX(int arg0)
        {
            return IExecuteWithSignature<float>("getGlyphX", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/PositionedGlyphs.html#getGlyphY(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetGlyphY(int arg0)
        {
            return IExecuteWithSignature<float>("getGlyphY", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/PositionedGlyphs.html#getGlyphId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetGlyphId(int arg0)
        {
            return IExecuteWithSignature<int>("getGlyphId", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/PositionedGlyphs.html#glyphCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GlyphCount()
        {
            return IExecuteWithSignature<int>("glyphCount", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}