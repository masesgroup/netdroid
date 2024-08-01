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

namespace Java.Util.Zip
{
    #region InflaterOutputStream
    public partial class InflaterOutputStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/InflaterOutputStream.html#%3Cinit%3E(java.io.OutputStream,java.util.zip.Inflater,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Java.Util.Zip.Inflater"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public InflaterOutputStream(Java.Io.OutputStream arg0, Java.Util.Zip.Inflater arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/InflaterOutputStream.html#%3Cinit%3E(java.io.OutputStream,java.util.zip.Inflater)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Java.Util.Zip.Inflater"/></param>
        public InflaterOutputStream(Java.Io.OutputStream arg0, Java.Util.Zip.Inflater arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/InflaterOutputStream.html#%3Cinit%3E(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        public InflaterOutputStream(Java.Io.OutputStream arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/InflaterOutputStream.html#finish()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Finish()
        {
            IExecuteWithSignature("finish", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}