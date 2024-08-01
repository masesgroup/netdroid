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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Transform
{
    #region Transformer
    public partial class Transformer
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
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#getParameter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetParameter(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#getOutputProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Lang.String GetOutputProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getOutputProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#getOutputProperties()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Properties"/></returns>
        public Java.Util.Properties GetOutputProperties()
        {
            return IExecuteWithSignature<Java.Util.Properties>("getOutputProperties", "()Ljava/util/Properties;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#getErrorListener()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Transform.ErrorListener"/></returns>
        public Javax.Xml.Transform.ErrorListener GetErrorListener()
        {
            return IExecuteWithSignature<Javax.Xml.Transform.ErrorListener>("getErrorListener", "()Ljavax/xml/transform/ErrorListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#getErrorListener()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Transform.ErrorListener"/></returns>
        public Javax.Xml.Transform.ErrorListener GetErrorListenerDirect()
        {
            return IExecuteWithSignature<Javax.Xml.Transform.ErrorListenerDirect, Javax.Xml.Transform.ErrorListener>("getErrorListener", "()Ljavax/xml/transform/ErrorListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#getURIResolver()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Transform.URIResolver"/></returns>
        public Javax.Xml.Transform.URIResolver GetURIResolver()
        {
            return IExecuteWithSignature<Javax.Xml.Transform.URIResolver>("getURIResolver", "()Ljavax/xml/transform/URIResolver;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#clearParameters()"/>
        /// </summary>
        public void ClearParameters()
        {
            IExecuteWithSignature("clearParameters", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#setErrorListener(javax.xml.transform.ErrorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.ErrorListener"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetErrorListener(Javax.Xml.Transform.ErrorListener arg0)
        {
            IExecuteWithSignature("setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#setOutputProperties(java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
        public void SetOutputProperties(Java.Util.Properties arg0)
        {
            IExecuteWithSignature("setOutputProperties", "(Ljava/util/Properties;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#setOutputProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetOutputProperty(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("setOutputProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#setParameter(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void SetParameter(Java.Lang.String arg0, object arg1)
        {
            IExecute("setParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#setURIResolver(javax.xml.transform.URIResolver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.URIResolver"/></param>
        public void SetURIResolver(Javax.Xml.Transform.URIResolver arg0)
        {
            IExecuteWithSignature("setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#transform(javax.xml.transform.Source,javax.xml.transform.Result)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Transform.Result"/></param>
        /// <exception cref="Javax.Xml.Transform.TransformerException"/>
        public void Transform(Javax.Xml.Transform.Source arg0, Javax.Xml.Transform.Result arg1)
        {
            IExecute("transform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/Transformer.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}