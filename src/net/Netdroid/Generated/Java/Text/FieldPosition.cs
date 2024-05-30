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

namespace Java.Text
{
    #region FieldPosition
    public partial class FieldPosition
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/text/FieldPosition.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public FieldPosition(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/text/FieldPosition.html#%3Cinit%3E(java.text.Format.Field,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.Format.Field"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public FieldPosition(Java.Text.Format.Field arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/text/FieldPosition.html#%3Cinit%3E(java.text.Format.Field)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.Format.Field"/></param>
        public FieldPosition(Java.Text.Format.Field arg0)
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
        /// <see href="https://developer.android.com/reference/java.base/java/text/FieldPosition.html#getBeginIndex()"/> <see href="https://developer.android.com/reference/java.base/java/text/FieldPosition.html#setBeginIndex(int)"/>
        /// </summary>
        public int BeginIndex
        {
            get { return IExecuteWithSignature<int>("getBeginIndex", "()I"); } set { IExecuteWithSignature("setBeginIndex", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/text/FieldPosition.html#getEndIndex()"/> <see href="https://developer.android.com/reference/java.base/java/text/FieldPosition.html#setEndIndex(int)"/>
        /// </summary>
        public int EndIndex
        {
            get { return IExecuteWithSignature<int>("getEndIndex", "()I"); } set { IExecuteWithSignature("setEndIndex", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/text/FieldPosition.html#getField()"/> 
        /// </summary>
        public int Field
        {
            get { return IExecuteWithSignature<int>("getField", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/text/FieldPosition.html#getFieldAttribute()"/> 
        /// </summary>
        public Java.Text.Format.Field FieldAttribute
        {
            get { return IExecuteWithSignature<Java.Text.Format.Field>("getFieldAttribute", "()Ljava/text/Format$Field;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}