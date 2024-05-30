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

namespace Android.View.Translation
{
    #region IUiTranslationStateCallback
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IUiTranslationStateCallback
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onFinished()"/>
        /// </summary>
        void OnFinished();
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onPaused()"/>
        /// </summary>
        void OnPaused();
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onFinished(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        void OnFinished(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onPaused(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        void OnPaused(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onResumed(android.icu.util.ULocale,android.icu.util.ULocale,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        void OnResumed(Android.Icu.Util.ULocale arg0, Android.Icu.Util.ULocale arg1, Java.Lang.String arg2);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onResumed(android.icu.util.ULocale,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        void OnResumed(Android.Icu.Util.ULocale arg0, Android.Icu.Util.ULocale arg1);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onStarted(android.icu.util.ULocale,android.icu.util.ULocale,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        void OnStarted(Android.Icu.Util.ULocale arg0, Android.Icu.Util.ULocale arg1, Java.Lang.String arg2);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onStarted(android.icu.util.ULocale,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        void OnStarted(Android.Icu.Util.ULocale arg0, Android.Icu.Util.ULocale arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UiTranslationStateCallback
    public partial class UiTranslationStateCallback : Android.View.Translation.IUiTranslationStateCallback
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
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onFinished()"/>
        /// </summary>
        public void OnFinished()
        {
            IExecuteWithSignature("onFinished", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onPaused()"/>
        /// </summary>
        public void OnPaused()
        {
            IExecuteWithSignature("onPaused", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onFinished(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void OnFinished(Java.Lang.String arg0)
        {
            IExecuteWithSignature("onFinished", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onPaused(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void OnPaused(Java.Lang.String arg0)
        {
            IExecuteWithSignature("onPaused", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onResumed(android.icu.util.ULocale,android.icu.util.ULocale,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public void OnResumed(Android.Icu.Util.ULocale arg0, Android.Icu.Util.ULocale arg1, Java.Lang.String arg2)
        {
            IExecute("onResumed", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onResumed(android.icu.util.ULocale,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        public void OnResumed(Android.Icu.Util.ULocale arg0, Android.Icu.Util.ULocale arg1)
        {
            IExecute("onResumed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onStarted(android.icu.util.ULocale,android.icu.util.ULocale,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public void OnStarted(Android.Icu.Util.ULocale arg0, Android.Icu.Util.ULocale arg1, Java.Lang.String arg2)
        {
            IExecute("onStarted", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/translation/UiTranslationStateCallback.html#onStarted(android.icu.util.ULocale,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        public void OnStarted(Android.Icu.Util.ULocale arg0, Android.Icu.Util.ULocale arg1)
        {
            IExecute("onStarted", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}