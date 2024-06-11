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

namespace Org.W3c.Dom.Ls
{
    #region ILSSerializer
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILSSerializer
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LSSerializer
    public partial class LSSerializer : Org.W3c.Dom.Ls.ILSSerializer
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
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSSerializer.html#write(org.w3c.dom.Node,org.w3c.dom.ls.LSOutput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Ls.LSOutput"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        public bool Write(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Ls.LSOutput arg1)
        {
            return IExecute<bool>("write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSSerializer.html#writeToURI(org.w3c.dom.Node,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        public bool WriteToURI(Org.W3c.Dom.Node arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("writeToURI", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSSerializer.html#getNewLine()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNewLine()
        {
            return IExecuteWithSignature<Java.Lang.String>("getNewLine", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSSerializer.html#writeToString(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ls.LSException"/>
        public Java.Lang.String WriteToString(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("writeToString", "(Lorg/w3c/dom/Node;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSSerializer.html#getDomConfig()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.DOMConfiguration"/></returns>
        public Org.W3c.Dom.DOMConfiguration GetDomConfig()
        {
            return IExecuteWithSignature<Org.W3c.Dom.DOMConfiguration>("getDomConfig", "()Lorg/w3c/dom/DOMConfiguration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSSerializer.html#setNewLine(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetNewLine(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setNewLine", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}