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

namespace Java.Text
{
    #region MessageFormat
    public partial class MessageFormat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#%3Cinit%3E(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        public MessageFormat(Java.Lang.String arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public MessageFormat(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#format(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Format(Java.Lang.String arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Java.Lang.String>(LocalBridgeClazz, "format", arg0); else return SExecute<Java.Lang.String>(LocalBridgeClazz, "format", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#format(java.lang.Object[],java.lang.StringBuffer,java.text.FieldPosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.StringBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Text.FieldPosition"/></param>
        /// <returns><see cref="Java.Lang.StringBuffer"/></returns>
        public Java.Lang.StringBuffer Format(object[] arg0, Java.Lang.StringBuffer arg1, Java.Text.FieldPosition arg2)
        {
            return IExecute<Java.Lang.StringBuffer>("format", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#parse(java.lang.String,java.text.ParsePosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Text.ParsePosition"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] Parse(Java.Lang.String arg0, Java.Text.ParsePosition arg1)
        {
            return IExecuteArray<object>("parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Text.ParseException"/>
        public object[] Parse(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<object>("parse", "(Ljava/lang/String;)[Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#toPattern()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToPattern()
        {
            return IExecuteWithSignature<Java.Lang.String>("toPattern", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#getFormats()"/>
        /// </summary>
        /// <returns><see cref="Java.Text.Format"/></returns>
        public Java.Text.Format[] GetFormats()
        {
            return IExecuteWithSignatureArray<Java.Text.Format>("getFormats", "()[Ljava/text/Format;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#getFormatsByArgumentIndex()"/>
        /// </summary>
        /// <returns><see cref="Java.Text.Format"/></returns>
        public Java.Text.Format[] GetFormatsByArgumentIndex()
        {
            return IExecuteWithSignatureArray<Java.Text.Format>("getFormatsByArgumentIndex", "()[Ljava/text/Format;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#getLocale()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public Java.Util.Locale GetLocale()
        {
            return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#applyPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void ApplyPattern(Java.Lang.String arg0)
        {
            IExecuteWithSignature("applyPattern", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#setFormat(int,java.text.Format)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Text.Format"/></param>
        public void SetFormat(int arg0, Java.Text.Format arg1)
        {
            IExecute("setFormat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#setFormatByArgumentIndex(int,java.text.Format)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Text.Format"/></param>
        public void SetFormatByArgumentIndex(int arg0, Java.Text.Format arg1)
        {
            IExecute("setFormatByArgumentIndex", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#setFormats(java.text.Format[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.Format"/></param>
        public void SetFormats(Java.Text.Format[] arg0)
        {
            IExecuteWithSignature("setFormats", "([Ljava/text/Format;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#setFormatsByArgumentIndex(java.text.Format[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.Format"/></param>
        public void SetFormatsByArgumentIndex(Java.Text.Format[] arg0)
        {
            IExecuteWithSignature("setFormatsByArgumentIndex", "([Ljava/text/Format;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/MessageFormat.html#setLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public void SetLocale(Java.Util.Locale arg0)
        {
            IExecuteWithSignature("setLocale", "(Ljava/util/Locale;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Field
        public partial class Field
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/text/MessageFormat.Field.html#ARGUMENT"/>
            /// </summary>
            public static Java.Text.MessageFormat.Field ARGUMENT { get { if (!_ARGUMENTReady) { _ARGUMENTContent = SGetField<Java.Text.MessageFormat.Field>(LocalBridgeClazz, "ARGUMENT"); _ARGUMENTReady = true; } return _ARGUMENTContent; } }
            private static Java.Text.MessageFormat.Field _ARGUMENTContent = default;
            private static bool _ARGUMENTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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