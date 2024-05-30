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

namespace Java.Nio
{
    #region Buffer
    public partial class Buffer
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
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#hasArray()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasArray()
        {
            return IExecuteWithSignature<bool>("hasArray", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#isDirect()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDirect()
        {
            return IExecuteWithSignature<bool>("isDirect", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#isReadOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReadOnly()
        {
            return IExecuteWithSignature<bool>("isReadOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#arrayOffset()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ArrayOffset()
        {
            return IExecuteWithSignature<int>("arrayOffset", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#array()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Array()
        {
            return IExecuteWithSignature("array", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#duplicate()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Duplicate()
        {
            return IExecuteWithSignature<Java.Nio.Buffer>("duplicate", "()Ljava/nio/Buffer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#slice()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Slice()
        {
            return IExecuteWithSignature<Java.Nio.Buffer>("slice", "()Ljava/nio/Buffer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#slice(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Slice(int arg0, int arg1)
        {
            return IExecute<Java.Nio.Buffer>("slice", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#hasRemaining()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasRemaining()
        {
            return IExecuteWithSignature<bool>("hasRemaining", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#capacity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Capacity()
        {
            return IExecuteWithSignature<int>("capacity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#limit()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Limit()
        {
            return IExecuteWithSignature<int>("limit", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#position()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Position()
        {
            return IExecuteWithSignature<int>("position", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#remaining()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Remaining()
        {
            return IExecuteWithSignature<int>("remaining", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#clear()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Clear()
        {
            return IExecuteWithSignature<Java.Nio.Buffer>("clear", "()Ljava/nio/Buffer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#flip()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Flip()
        {
            return IExecuteWithSignature<Java.Nio.Buffer>("flip", "()Ljava/nio/Buffer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#limit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Limit(int arg0)
        {
            return IExecuteWithSignature<Java.Nio.Buffer>("limit", "(I)Ljava/nio/Buffer;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#mark()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Mark()
        {
            return IExecuteWithSignature<Java.Nio.Buffer>("mark", "()Ljava/nio/Buffer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#position(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Position(int arg0)
        {
            return IExecuteWithSignature<Java.Nio.Buffer>("position", "(I)Ljava/nio/Buffer;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#reset()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Reset()
        {
            return IExecuteWithSignature<Java.Nio.Buffer>("reset", "()Ljava/nio/Buffer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/Buffer.html#rewind()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Rewind()
        {
            return IExecuteWithSignature<Java.Nio.Buffer>("rewind", "()Ljava/nio/Buffer;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}