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

namespace Android.Gesture
{
    #region GestureLibrary
    public partial class GestureLibrary
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
        /// <see href="https://developer.android.com/reference/android/gesture/GestureLibrary.html#load()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Load()
        {
            return IExecuteWithSignature<bool>("load", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureLibrary.html#save()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Save()
        {
            return IExecuteWithSignature<bool>("save", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureLibrary.html#isReadOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReadOnly()
        {
            return IExecuteWithSignature<bool>("isReadOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureLibrary.html#getOrientationStyle()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetOrientationStyle()
        {
            return IExecuteWithSignature<int>("getOrientationStyle", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureLibrary.html#getSequenceType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSequenceType()
        {
            return IExecuteWithSignature<int>("getSequenceType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureLibrary.html#getGestures(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.ArrayList"/></returns>
        public Java.Util.ArrayList<Android.Gesture.Gesture> GetGestures(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.ArrayList<Android.Gesture.Gesture>>("getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureLibrary.html#recognize(android.gesture.Gesture)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Gesture.Gesture"/></param>
        /// <returns><see cref="Java.Util.ArrayList"/></returns>
        public Java.Util.ArrayList<Android.Gesture.Prediction> Recognize(Android.Gesture.Gesture arg0)
        {
            return IExecuteWithSignature<Java.Util.ArrayList<Android.Gesture.Prediction>>("recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureLibrary.html#getGestureEntries()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetGestureEntries()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getGestureEntries", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureLibrary.html#addGesture(java.lang.String,android.gesture.Gesture)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Gesture.Gesture"/></param>
        public void AddGesture(Java.Lang.String arg0, Android.Gesture.Gesture arg1)
        {
            IExecute("addGesture", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureLibrary.html#removeEntry(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemoveEntry(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeEntry", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureLibrary.html#removeGesture(java.lang.String,android.gesture.Gesture)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Gesture.Gesture"/></param>
        public void RemoveGesture(Java.Lang.String arg0, Android.Gesture.Gesture arg1)
        {
            IExecute("removeGesture", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureLibrary.html#setOrientationStyle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetOrientationStyle(int arg0)
        {
            IExecuteWithSignature("setOrientationStyle", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureLibrary.html#setSequenceType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetSequenceType(int arg0)
        {
            IExecuteWithSignature("setSequenceType", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}