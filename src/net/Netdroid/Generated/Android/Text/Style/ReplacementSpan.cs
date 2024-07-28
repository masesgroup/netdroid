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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Text.Style
{
    #region ReplacementSpan
    public partial class ReplacementSpan
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
        /// <see href="https://developer.android.com/reference/android/text/style/ReplacementSpan.html#getSize(android.graphics.Paint,java.lang.CharSequence,int,int,android.graphics.Paint.FontMetricsInt)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Paint"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Android.Graphics.Paint.FontMetricsInt"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSize(Android.Graphics.Paint arg0, Java.Lang.CharSequence arg1, int arg2, int arg3, Android.Graphics.Paint.FontMetricsInt arg4)
        {
            return IExecute<int>("getSize", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/ReplacementSpan.html#draw(android.graphics.Canvas,java.lang.CharSequence,int,int,float,int,int,int,android.graphics.Paint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="Android.Graphics.Paint"/></param>
        public void Draw(Android.Graphics.Canvas arg0, Java.Lang.CharSequence arg1, int arg2, int arg3, float arg4, int arg5, int arg6, int arg7, Android.Graphics.Paint arg8)
        {
            IExecute("draw", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/ReplacementSpan.html#getContentDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetContentDescription()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getContentDescription", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/ReplacementSpan.html#setContentDescription(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetContentDescription(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setContentDescription", "(Ljava/lang/CharSequence;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}