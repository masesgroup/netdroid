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

namespace Android.Graphics.Fonts
{
    #region FontFamily
    public partial class FontFamily
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
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontFamily.html#getFont(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Fonts.Font"/></returns>
        public Android.Graphics.Fonts.Font GetFont(int arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Fonts.Font>("getFont", "(I)Landroid/graphics/fonts/Font;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontFamily.html#getSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSize()
        {
            return IExecuteWithSignature<int>("getSize", "()I");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontFamily.Builder.html#%3Cinit%3E(android.graphics.fonts.Font)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Fonts.Font"/></param>
            public Builder(Android.Graphics.Fonts.Font arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontFamily.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Fonts.FontFamily"/></returns>
            public Android.Graphics.Fonts.FontFamily Build()
            {
                return IExecuteWithSignature<Android.Graphics.Fonts.FontFamily>("build", "()Landroid/graphics/fonts/FontFamily;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontFamily.Builder.html#buildVariableFamily()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Fonts.FontFamily"/></returns>
            public Android.Graphics.Fonts.FontFamily BuildVariableFamily()
            {
                return IExecuteWithSignature<Android.Graphics.Fonts.FontFamily>("buildVariableFamily", "()Landroid/graphics/fonts/FontFamily;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/fonts/FontFamily.Builder.html#addFont(android.graphics.fonts.Font)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Fonts.Font"/></param>
            /// <returns><see cref="Android.Graphics.Fonts.FontFamily.Builder"/></returns>
            public Android.Graphics.Fonts.FontFamily.Builder AddFont(Android.Graphics.Fonts.Font arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Fonts.FontFamily.Builder>("addFont", "(Landroid/graphics/fonts/Font;)Landroid/graphics/fonts/FontFamily$Builder;", arg0);
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