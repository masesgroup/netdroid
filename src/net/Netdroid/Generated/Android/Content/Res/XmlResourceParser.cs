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

namespace Android.Content.Res
{
    #region IXmlResourceParser
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXmlResourceParser
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/XmlResourceParser.html#getAttributeNamespace(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String GetAttributeNamespace(int arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/XmlResourceParser.html#close()"/>
        /// </summary>
        void Close();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XmlResourceParser
    public partial class XmlResourceParser : Android.Content.Res.IXmlResourceParser, Org.Xmlpull.V1.IXmlPullParser, Android.Util.IAttributeSet, Java.Lang.IAutoCloseable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Content.Res.XmlResourceParser"/> to <see cref="Org.Xmlpull.V1.XmlPullParser"/>
        /// </summary>
        public static implicit operator Org.Xmlpull.V1.XmlPullParser(Android.Content.Res.XmlResourceParser t) => t.Cast<Org.Xmlpull.V1.XmlPullParser>();
        /// <summary>
        /// Converter from <see cref="Android.Content.Res.XmlResourceParser"/> to <see cref="Android.Util.AttributeSet"/>
        /// </summary>
        public static implicit operator Android.Util.AttributeSet(Android.Content.Res.XmlResourceParser t) => t.Cast<Android.Util.AttributeSet>();
        /// <summary>
        /// Converter from <see cref="Android.Content.Res.XmlResourceParser"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Android.Content.Res.XmlResourceParser t) => t.Cast<Java.Lang.AutoCloseable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/XmlResourceParser.html#getAttributeNamespace(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeNamespace(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttributeNamespace", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/res/XmlResourceParser.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}