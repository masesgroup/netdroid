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

namespace Android.Icu.Util
{
    #region IValueIterator
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IValueIterator
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ValueIterator
    public partial class ValueIterator : Android.Icu.Util.IValueIterator
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
        /// <see href="https://developer.android.com/reference/android/icu/util/ValueIterator.html#next(android.icu.util.ValueIterator.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ValueIterator.Element"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Next(Android.Icu.Util.ValueIterator.Element arg0)
        {
            return IExecuteWithSignature<bool>("next", "(Landroid/icu/util/ValueIterator$Element;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/ValueIterator.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/ValueIterator.html#setRange(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetRange(int arg0, int arg1)
        {
            IExecute("setRange", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Element
        public partial class Element
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/ValueIterator.Element.html#integer"/>
            /// </summary>
            public int integer { get { return IGetField<int>("integer"); } set { ISetField("integer", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/ValueIterator.Element.html#value"/>
            /// </summary>
            public object value { get { return IGetField("value"); } set { ISetField("value", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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