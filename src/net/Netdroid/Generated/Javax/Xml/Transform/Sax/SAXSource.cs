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

namespace Javax.Xml.Transform.Sax
{
    #region SAXSource
    public partial class SAXSource
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/sax/SAXSource.html#%3Cinit%3E(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        public SAXSource(Org.Xml.Sax.InputSource arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/sax/SAXSource.html#%3Cinit%3E(org.xml.sax.XMLReader,org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.XMLReader"/></param>
        /// <param name="arg1"><see cref="Org.Xml.Sax.InputSource"/></param>
        public SAXSource(Org.Xml.Sax.XMLReader arg0, Org.Xml.Sax.InputSource arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/sax/SAXSource.html#FEATURE"/>
        /// </summary>
        public static Java.Lang.String FEATURE { get { if (!_FEATUREReady) { _FEATUREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE"); _FEATUREReady = true; } return _FEATUREContent; } }
        private static Java.Lang.String _FEATUREContent = default;
        private static bool _FEATUREReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/sax/SAXSource.html#sourceToInputSource(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        public static Org.Xml.Sax.InputSource SourceToInputSource(Javax.Xml.Transform.Source arg0)
        {
            return SExecuteWithSignature<Org.Xml.Sax.InputSource>(LocalBridgeClazz, "sourceToInputSource", "(Ljavax/xml/transform/Source;)Lorg/xml/sax/InputSource;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/sax/SAXSource.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/sax/SAXSource.html#getSystemId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSystemId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSystemId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/sax/SAXSource.html#getInputSource()"/>
        /// </summary>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        public Org.Xml.Sax.InputSource GetInputSource()
        {
            return IExecuteWithSignature<Org.Xml.Sax.InputSource>("getInputSource", "()Lorg/xml/sax/InputSource;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/sax/SAXSource.html#getXMLReader()"/>
        /// </summary>
        /// <returns><see cref="Org.Xml.Sax.XMLReader"/></returns>
        public Org.Xml.Sax.XMLReader GetXMLReader()
        {
            return IExecuteWithSignature<Org.Xml.Sax.XMLReader>("getXMLReader", "()Lorg/xml/sax/XMLReader;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/sax/SAXSource.html#setInputSource(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        public void SetInputSource(Org.Xml.Sax.InputSource arg0)
        {
            IExecuteWithSignature("setInputSource", "(Lorg/xml/sax/InputSource;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/sax/SAXSource.html#setSystemId(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetSystemId(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setSystemId", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/sax/SAXSource.html#setXMLReader(org.xml.sax.XMLReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.XMLReader"/></param>
        public void SetXMLReader(Org.Xml.Sax.XMLReader arg0)
        {
            IExecuteWithSignature("setXMLReader", "(Lorg/xml/sax/XMLReader;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}