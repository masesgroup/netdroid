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

namespace Javax.Microedition.Khronos.Opengles
{
    #region IGL10Ext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IGL10Ext : Javax.Microedition.Khronos.Opengles.IGL
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region GL10Ext
    public partial class GL10Ext : Javax.Microedition.Khronos.Opengles.IGL10Ext
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
        /// <see href="https://developer.android.com/reference/javax/microedition/khronos/opengles/GL10Ext.html#glQueryMatrixxOES(int[],int,int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GlQueryMatrixxOES(int[] arg0, int arg1, int[] arg2, int arg3)
        {
            return IExecute<int>("glQueryMatrixxOES", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/microedition/khronos/opengles/GL10Ext.html#glQueryMatrixxOES(java.nio.IntBuffer,java.nio.IntBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.IntBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.IntBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int GlQueryMatrixxOES(Java.Nio.IntBuffer arg0, Java.Nio.IntBuffer arg1)
        {
            return IExecute<int>("glQueryMatrixxOES", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}