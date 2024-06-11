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

namespace Android.Text.Style
{
    #region CharacterStyle
    public partial class CharacterStyle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/CharacterStyle.html#wrap(android.text.style.CharacterStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Style.CharacterStyle"/></param>
        /// <returns><see cref="Android.Text.Style.CharacterStyle"/></returns>
        public static Android.Text.Style.CharacterStyle Wrap(Android.Text.Style.CharacterStyle arg0)
        {
            return SExecuteWithSignature<Android.Text.Style.CharacterStyle>(LocalBridgeClazz, "wrap", "(Landroid/text/style/CharacterStyle;)Landroid/text/style/CharacterStyle;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/CharacterStyle.html#updateDrawState(android.text.TextPaint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.TextPaint"/></param>
        public void UpdateDrawState(Android.Text.TextPaint arg0)
        {
            IExecuteWithSignature("updateDrawState", "(Landroid/text/TextPaint;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/CharacterStyle.html#getUnderlying()"/>
        /// </summary>
        /// <returns><see cref="Android.Text.Style.CharacterStyle"/></returns>
        public Android.Text.Style.CharacterStyle GetUnderlying()
        {
            return IExecuteWithSignature<Android.Text.Style.CharacterStyle>("getUnderlying", "()Landroid/text/style/CharacterStyle;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}