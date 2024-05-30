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

namespace Android.Widget
{
    #region TextClock
    public partial class TextClock
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TextClock.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public TextClock(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TextClock.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public TextClock(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TextClock.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public TextClock(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TextClock.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public TextClock(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/TextClock.html#getFormat12Hour()"/> <see href="https://developer.android.com/reference/android/widget/TextClock.html#setFormat12Hour(java.lang.CharSequence)"/>
        /// </summary>
        public Java.Lang.CharSequence Format12Hour
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getFormat12Hour", "()Ljava/lang/CharSequence;"); } set { IExecuteWithSignature("setFormat12Hour", "(Ljava/lang/CharSequence;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TextClock.html#getFormat24Hour()"/> <see href="https://developer.android.com/reference/android/widget/TextClock.html#setFormat24Hour(java.lang.CharSequence)"/>
        /// </summary>
        public Java.Lang.CharSequence Format24Hour
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getFormat24Hour", "()Ljava/lang/CharSequence;"); } set { IExecuteWithSignature("setFormat24Hour", "(Ljava/lang/CharSequence;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TextClock.html#getTimeZone()"/> <see href="https://developer.android.com/reference/android/widget/TextClock.html#setTimeZone(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String TimeZone
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTimeZone", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setTimeZone", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TextClock.html#is24HourModeEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Is24HourModeEnabled()
        {
            return IExecuteWithSignature<bool>("is24HourModeEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TextClock.html#refreshTime()"/>
        /// </summary>
        public void RefreshTime()
        {
            IExecuteWithSignature("refreshTime", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}