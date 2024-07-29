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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom
{
    #region IText
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IText : Org.W3c.Dom.ICharacterData
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Text
    public partial class Text : Org.W3c.Dom.IText
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
        /// <see href="https://developer.android.com/reference/org/w3c/dom/Text.html#isElementContentWhitespace()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsElementContentWhitespace()
        {
            return IExecuteWithSignature<bool>("isElementContentWhitespace", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/Text.html#getWholeText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetWholeText()
        {
            return IExecuteWithSignature<Java.Lang.String>("getWholeText", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/Text.html#replaceWholeText(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Text"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Text ReplaceWholeText(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Text>("replaceWholeText", "(Ljava/lang/String;)Lorg/w3c/dom/Text;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/Text.html#splitText(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.W3c.Dom.Text"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Text SplitText(int arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Text>("splitText", "(I)Lorg/w3c/dom/Text;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}