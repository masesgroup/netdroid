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

namespace Javax.Xml.Transform.Stream
{
    #region StreamResult
    public partial class StreamResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/stream/StreamResult.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        public StreamResult(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/stream/StreamResult.html#%3Cinit%3E(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        public StreamResult(Java.Io.OutputStream arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/stream/StreamResult.html#%3Cinit%3E(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        public StreamResult(Java.Io.Writer arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/stream/StreamResult.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public StreamResult(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/stream/StreamResult.html#FEATURE"/>
        /// </summary>
        public static Java.Lang.String FEATURE { get { if (!_FEATUREReady) { _FEATUREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE"); _FEATUREReady = true; } return _FEATUREContent; } }
        private static Java.Lang.String _FEATUREContent = default;
        private static bool _FEATUREReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/stream/StreamResult.html#getOutputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        public Java.Io.OutputStream GetOutputStream()
        {
            return IExecuteWithSignature<Java.Io.OutputStream>("getOutputStream", "()Ljava/io/OutputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/stream/StreamResult.html#getWriter()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.Writer"/></returns>
        public Java.Io.Writer GetWriter()
        {
            return IExecuteWithSignature<Java.Io.Writer>("getWriter", "()Ljava/io/Writer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/stream/StreamResult.html#getSystemId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSystemId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSystemId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/stream/StreamResult.html#setOutputStream(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        public void SetOutputStream(Java.Io.OutputStream arg0)
        {
            IExecuteWithSignature("setOutputStream", "(Ljava/io/OutputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/stream/StreamResult.html#setSystemId(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        public void SetSystemId(Java.Io.File arg0)
        {
            IExecuteWithSignature("setSystemId", "(Ljava/io/File;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/stream/StreamResult.html#setSystemId(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetSystemId(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setSystemId", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/stream/StreamResult.html#setWriter(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        public void SetWriter(Java.Io.Writer arg0)
        {
            IExecuteWithSignature("setWriter", "(Ljava/io/Writer;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}