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

namespace Android.Service.Controls.Templates
{
    #region ToggleRangeTemplate
    public partial class ToggleRangeTemplate
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/templates/ToggleRangeTemplate.html#%3Cinit%3E(java.lang.String,android.service.controls.templates.ControlButton,android.service.controls.templates.RangeTemplate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Service.Controls.Templates.ControlButton"/></param>
        /// <param name="arg2"><see cref="Android.Service.Controls.Templates.RangeTemplate"/></param>
        public ToggleRangeTemplate(Java.Lang.String arg0, Android.Service.Controls.Templates.ControlButton arg1, Android.Service.Controls.Templates.RangeTemplate arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/templates/ToggleRangeTemplate.html#%3Cinit%3E(java.lang.String,boolean,java.lang.CharSequence,android.service.controls.templates.RangeTemplate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="Android.Service.Controls.Templates.RangeTemplate"/></param>
        public ToggleRangeTemplate(Java.Lang.String arg0, bool arg1, Java.Lang.CharSequence arg2, Android.Service.Controls.Templates.RangeTemplate arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://developer.android.com/reference/android/service/controls/templates/ToggleRangeTemplate.html#getRange()"/>
        /// </summary>
        /// <returns><see cref="Android.Service.Controls.Templates.RangeTemplate"/></returns>
        public Android.Service.Controls.Templates.RangeTemplate GetRange()
        {
            return IExecuteWithSignature<Android.Service.Controls.Templates.RangeTemplate>("getRange", "()Landroid/service/controls/templates/RangeTemplate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/templates/ToggleRangeTemplate.html#isChecked()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsChecked()
        {
            return IExecuteWithSignature<bool>("isChecked", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/templates/ToggleRangeTemplate.html#getActionDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetActionDescription()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getActionDescription", "()Ljava/lang/CharSequence;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}