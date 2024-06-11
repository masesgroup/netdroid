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

namespace Android.Icu.Util
{
    #region IRangeValueIterator
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRangeValueIterator
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RangeValueIterator
    public partial class RangeValueIterator : Android.Icu.Util.IRangeValueIterator
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
        /// <see href="https://developer.android.com/reference/android/icu/util/RangeValueIterator.html#next(android.icu.util.RangeValueIterator.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.RangeValueIterator.Element"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Next(Android.Icu.Util.RangeValueIterator.Element arg0)
        {
            return IExecuteWithSignature<bool>("next", "(Landroid/icu/util/RangeValueIterator$Element;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/RangeValueIterator.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
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
            /// <see href="https://developer.android.com/reference/android/icu/util/RangeValueIterator.Element.html#limit"/>
            /// </summary>
            public int limit { get { return IGetField<int>("limit"); } set { ISetField("limit", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/RangeValueIterator.Element.html#start"/>
            /// </summary>
            public int start { get { return IGetField<int>("start"); } set { ISetField("start", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/util/RangeValueIterator.Element.html#value"/>
            /// </summary>
            public int value { get { return IGetField<int>("value"); } set { ISetField("value", value); } }

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