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
    #region ParsePosition
    public partial class ParsePosition
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/ParsePosition.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ParsePosition(int arg0)
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
        /// <see href="https://developer.android.com/reference/java/text/ParsePosition.html#getErrorIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetErrorIndex()
        {
            return IExecuteWithSignature<int>("getErrorIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/ParsePosition.html#getIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIndex()
        {
            return IExecuteWithSignature<int>("getIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/ParsePosition.html#setErrorIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetErrorIndex(int arg0)
        {
            IExecuteWithSignature("setErrorIndex", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/ParsePosition.html#setIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetIndex(int arg0)
        {
            IExecuteWithSignature("setIndex", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}