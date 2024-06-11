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

namespace Java.Nio.File.Attribute
{
    #region IUserDefinedFileAttributeView
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IUserDefinedFileAttributeView : Java.Nio.File.Attribute.IFileAttributeView
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UserDefinedFileAttributeView
    public partial class UserDefinedFileAttributeView : Java.Nio.File.Attribute.IUserDefinedFileAttributeView
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
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/UserDefinedFileAttributeView.html#read(java.lang.String,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(Java.Lang.String arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<int>("read", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/UserDefinedFileAttributeView.html#size(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Size(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("size", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/UserDefinedFileAttributeView.html#write(java.lang.String,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Write(Java.Lang.String arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<int>("write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/UserDefinedFileAttributeView.html#name()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/UserDefinedFileAttributeView.html#list()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.List<Java.Lang.String> List()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("list", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/UserDefinedFileAttributeView.html#delete(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Delete(Java.Lang.String arg0)
        {
            IExecuteWithSignature("delete", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}