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

namespace Android.Icu.Text
{
    #region Edits
    public partial class Edits
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
        /// <see href="https://developer.android.com/reference/android/icu/text/Edits.html#mergeAndAppend(android.icu.text.Edits,android.icu.text.Edits)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.Edits"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.Edits"/></param>
        /// <returns><see cref="Android.Icu.Text.Edits"/></returns>
        public Android.Icu.Text.Edits MergeAndAppend(Android.Icu.Text.Edits arg0, Android.Icu.Text.Edits arg1)
        {
            return IExecute<Android.Icu.Text.Edits>("mergeAndAppend", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Edits.html#getCoarseChangesIterator()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.Edits.Iterator"/></returns>
        public Android.Icu.Text.Edits.Iterator GetCoarseChangesIterator()
        {
            return IExecuteWithSignature<Android.Icu.Text.Edits.Iterator>("getCoarseChangesIterator", "()Landroid/icu/text/Edits$Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Edits.html#getCoarseIterator()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.Edits.Iterator"/></returns>
        public Android.Icu.Text.Edits.Iterator GetCoarseIterator()
        {
            return IExecuteWithSignature<Android.Icu.Text.Edits.Iterator>("getCoarseIterator", "()Landroid/icu/text/Edits$Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Edits.html#getFineChangesIterator()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.Edits.Iterator"/></returns>
        public Android.Icu.Text.Edits.Iterator GetFineChangesIterator()
        {
            return IExecuteWithSignature<Android.Icu.Text.Edits.Iterator>("getFineChangesIterator", "()Landroid/icu/text/Edits$Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Edits.html#getFineIterator()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.Edits.Iterator"/></returns>
        public Android.Icu.Text.Edits.Iterator GetFineIterator()
        {
            return IExecuteWithSignature<Android.Icu.Text.Edits.Iterator>("getFineIterator", "()Landroid/icu/text/Edits$Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Edits.html#hasChanges()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasChanges()
        {
            return IExecuteWithSignature<bool>("hasChanges", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Edits.html#lengthDelta()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LengthDelta()
        {
            return IExecuteWithSignature<int>("lengthDelta", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Edits.html#numberOfChanges()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int NumberOfChanges()
        {
            return IExecuteWithSignature<int>("numberOfChanges", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Edits.html#addReplace(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void AddReplace(int arg0, int arg1)
        {
            IExecute("addReplace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Edits.html#addUnchanged(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AddUnchanged(int arg0)
        {
            IExecuteWithSignature("addUnchanged", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Edits.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }

        #endregion

        #region Nested classes
        #region Iterator
        public partial class Iterator
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
            /// <see href="https://developer.android.com/reference/android/icu/text/Edits.Iterator.html#findDestinationIndex(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool FindDestinationIndex(int arg0)
            {
                return IExecuteWithSignature<bool>("findDestinationIndex", "(I)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Edits.Iterator.html#findSourceIndex(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool FindSourceIndex(int arg0)
            {
                return IExecuteWithSignature<bool>("findSourceIndex", "(I)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Edits.Iterator.html#hasChange()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasChange()
            {
                return IExecuteWithSignature<bool>("hasChange", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Edits.Iterator.html#next()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool Next()
            {
                return IExecuteWithSignature<bool>("next", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Edits.Iterator.html#destinationIndex()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DestinationIndex()
            {
                return IExecuteWithSignature<int>("destinationIndex", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Edits.Iterator.html#destinationIndexFromSourceIndex(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            public int DestinationIndexFromSourceIndex(int arg0)
            {
                return IExecuteWithSignature<int>("destinationIndexFromSourceIndex", "(I)I", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Edits.Iterator.html#newLength()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int NewLength()
            {
                return IExecuteWithSignature<int>("newLength", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Edits.Iterator.html#oldLength()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int OldLength()
            {
                return IExecuteWithSignature<int>("oldLength", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Edits.Iterator.html#replacementIndex()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int ReplacementIndex()
            {
                return IExecuteWithSignature<int>("replacementIndex", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Edits.Iterator.html#sourceIndex()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int SourceIndex()
            {
                return IExecuteWithSignature<int>("sourceIndex", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Edits.Iterator.html#sourceIndexFromDestinationIndex(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            public int SourceIndexFromDestinationIndex(int arg0)
            {
                return IExecuteWithSignature<int>("sourceIndexFromDestinationIndex", "(I)I", arg0);
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