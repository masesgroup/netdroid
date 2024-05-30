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

namespace Android.Text.Style
{
    #region MetricAffectingSpan
    public partial class MetricAffectingSpan
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Text.Style.MetricAffectingSpan"/> to <see cref="Android.Text.Style.UpdateLayout"/>
        /// </summary>
        public static implicit operator Android.Text.Style.UpdateLayout(Android.Text.Style.MetricAffectingSpan t) => t.Cast<Android.Text.Style.UpdateLayout>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/MetricAffectingSpan.html#updateMeasureState(android.text.TextPaint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.TextPaint"/></param>
        public void UpdateMeasureState(Android.Text.TextPaint arg0)
        {
            IExecuteWithSignature("updateMeasureState", "(Landroid/text/TextPaint;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}