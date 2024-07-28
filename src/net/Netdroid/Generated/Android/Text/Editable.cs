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

namespace Android.Text
{
    #region IEditable
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IEditable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Editable
    public partial class Editable : Android.Text.IEditable, Java.Lang.ICharSequence, Android.Text.IGetChars, Android.Text.ISpannable, Java.Lang.IAppendable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Text.Editable"/> to <see cref="Java.Lang.CharSequence"/>
        /// </summary>
        public static implicit operator Java.Lang.CharSequence(Android.Text.Editable t) => t.Cast<Java.Lang.CharSequence>();
        /// <summary>
        /// Converter from <see cref="Android.Text.Editable"/> to <see cref="Android.Text.GetChars"/>
        /// </summary>
        public static implicit operator Android.Text.GetChars(Android.Text.Editable t) => t.Cast<Android.Text.GetChars>();
        /// <summary>
        /// Converter from <see cref="Android.Text.Editable"/> to <see cref="Android.Text.Spannable"/>
        /// </summary>
        public static implicit operator Android.Text.Spannable(Android.Text.Editable t) => t.Cast<Android.Text.Spannable>();
        /// <summary>
        /// Converter from <see cref="Android.Text.Editable"/> to <see cref="Java.Lang.Appendable"/>
        /// </summary>
        public static implicit operator Java.Lang.Appendable(Android.Text.Editable t) => t.Cast<Java.Lang.Appendable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Editable.html#delete(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Text.Editable"/></returns>
        public Android.Text.Editable Delete(int arg0, int arg1)
        {
            return IExecute<Android.Text.Editable>("delete", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Editable.html#insert(int,java.lang.CharSequence,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.Text.Editable"/></returns>
        public Android.Text.Editable Insert(int arg0, Java.Lang.CharSequence arg1, int arg2, int arg3)
        {
            return IExecute<Android.Text.Editable>("insert", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Editable.html#insert(int,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Text.Editable"/></returns>
        public Android.Text.Editable Insert(int arg0, Java.Lang.CharSequence arg1)
        {
            return IExecute<Android.Text.Editable>("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Editable.html#replace(int,int,java.lang.CharSequence,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Android.Text.Editable"/></returns>
        public Android.Text.Editable Replace(int arg0, int arg1, Java.Lang.CharSequence arg2, int arg3, int arg4)
        {
            return IExecute<Android.Text.Editable>("replace", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Editable.html#replace(int,int,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Text.Editable"/></returns>
        public Android.Text.Editable Replace(int arg0, int arg1, Java.Lang.CharSequence arg2)
        {
            return IExecute<Android.Text.Editable>("replace", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Editable.html#getFilters()"/>
        /// </summary>
        /// <returns><see cref="Android.Text.InputFilter"/></returns>
        public Android.Text.InputFilter[] GetFilters()
        {
            return IExecuteWithSignatureArray<Android.Text.InputFilter>("getFilters", "()[Landroid/text/InputFilter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Editable.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Editable.html#clearSpans()"/>
        /// </summary>
        public void ClearSpans()
        {
            IExecuteWithSignature("clearSpans", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Editable.html#setFilters(android.text.InputFilter[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.InputFilter"/></param>
        public void SetFilters(Android.Text.InputFilter[] arg0)
        {
            IExecuteWithSignature("setFilters", "([Landroid/text/InputFilter;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Editable.html#append(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Java.Lang.Appendable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Appendable Append(char arg0)
        {
            return IExecuteWithSignature<Java.Lang.Appendable>("append", "(C)Ljava/lang/Appendable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Editable.html#append(java.lang.CharSequence,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Appendable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Appendable Append(Java.Lang.CharSequence arg0, int arg1, int arg2)
        {
            return IExecute<Java.Lang.Appendable>("append", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/Editable.html#append(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.Appendable"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.Appendable Append(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Java.Lang.Appendable>("append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", arg0);
        }

        #endregion

        #region Nested classes
        #region Factory
        public partial class Factory
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/Editable.Factory.html#getInstance()"/>
            /// </summary>
            /// <returns><see cref="Android.Text.Editable.Factory"/></returns>
            public static Android.Text.Editable.Factory GetInstance()
            {
                return SExecuteWithSignature<Android.Text.Editable.Factory>(LocalBridgeClazz, "getInstance", "()Landroid/text/Editable$Factory;");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/Editable.Factory.html#newEditable(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Text.Editable"/></returns>
            public Android.Text.Editable NewEditable(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Text.Editable>("newEditable", "(Ljava/lang/CharSequence;)Landroid/text/Editable;", arg0);
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