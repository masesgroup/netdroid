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

namespace Android.Text.Style
{
    #region ITabStopSpan
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITabStopSpan : Android.Text.Style.IParagraphStyle
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TabStopSpan
    public partial class TabStopSpan : Android.Text.Style.ITabStopSpan
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
        /// <see href="https://developer.android.com/reference/android/text/style/TabStopSpan.html#getTabStop()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTabStop()
        {
            return IExecuteWithSignature<int>("getTabStop", "()I");
        }

        #endregion

        #region Nested classes
        #region Standard
        public partial class Standard
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/TabStopSpan.Standard.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Standard(int arg0)
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
            /// <see href="https://developer.android.com/reference/android/text/style/TabStopSpan.Standard.html#getTabStop()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetTabStop()
            {
                return IExecuteWithSignature<int>("getTabStop", "()I");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}