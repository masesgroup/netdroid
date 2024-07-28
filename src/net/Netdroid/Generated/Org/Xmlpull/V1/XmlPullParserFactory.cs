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

namespace Org.Xmlpull.V1
{
    #region XmlPullParserFactory
    public partial class XmlPullParserFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParserFactory.html#PROPERTY_NAME"/>
        /// </summary>
        public static Java.Lang.String PROPERTY_NAME { get { if (!_PROPERTY_NAMEReady) { _PROPERTY_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PROPERTY_NAME"); _PROPERTY_NAMEReady = true; } return _PROPERTY_NAMEContent; } }
        private static Java.Lang.String _PROPERTY_NAMEContent = default;
        private static bool _PROPERTY_NAMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParserFactory.html#newInstance()"/>
        /// </summary>
        /// <returns><see cref="Org.Xmlpull.V1.XmlPullParserFactory"/></returns>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public static Org.Xmlpull.V1.XmlPullParserFactory NewInstance()
        {
            return SExecuteWithSignature<Org.Xmlpull.V1.XmlPullParserFactory>(LocalBridgeClazz, "newInstance", "()Lorg/xmlpull/v1/XmlPullParserFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParserFactory.html#newInstance(java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Org.Xmlpull.V1.XmlPullParserFactory"/></returns>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public static Org.Xmlpull.V1.XmlPullParserFactory NewInstance(Java.Lang.String arg0, Java.Lang.Class arg1)
        {
            return SExecute<Org.Xmlpull.V1.XmlPullParserFactory>(LocalBridgeClazz, "newInstance", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParserFactory.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetFeature(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("getFeature", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParserFactory.html#isNamespaceAware()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNamespaceAware()
        {
            return IExecuteWithSignature<bool>("isNamespaceAware", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParserFactory.html#isValidating()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsValidating()
        {
            return IExecuteWithSignature<bool>("isValidating", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParserFactory.html#newPullParser()"/>
        /// </summary>
        /// <returns><see cref="Org.Xmlpull.V1.XmlPullParser"/></returns>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public Org.Xmlpull.V1.XmlPullParser NewPullParser()
        {
            return IExecuteWithSignature<Org.Xmlpull.V1.XmlPullParser>("newPullParser", "()Lorg/xmlpull/v1/XmlPullParser;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParserFactory.html#newSerializer()"/>
        /// </summary>
        /// <returns><see cref="Org.Xmlpull.V1.XmlSerializer"/></returns>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public Org.Xmlpull.V1.XmlSerializer NewSerializer()
        {
            return IExecuteWithSignature<Org.Xmlpull.V1.XmlSerializer>("newSerializer", "()Lorg/xmlpull/v1/XmlSerializer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParserFactory.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            IExecute("setFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParserFactory.html#setNamespaceAware(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNamespaceAware(bool arg0)
        {
            IExecuteWithSignature("setNamespaceAware", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParserFactory.html#setValidating(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetValidating(bool arg0)
        {
            IExecuteWithSignature("setValidating", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}