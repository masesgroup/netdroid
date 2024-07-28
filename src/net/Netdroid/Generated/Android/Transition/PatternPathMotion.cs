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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Transition
{
    #region PatternPathMotion
    public partial class PatternPathMotion
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/PatternPathMotion.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public PatternPathMotion(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/PatternPathMotion.html#%3Cinit%3E(android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        public PatternPathMotion(Android.Graphics.Path arg0)
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
        /// <see href="https://developer.android.com/reference/android/transition/PatternPathMotion.html#getPatternPath()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Path"/></returns>
        public Android.Graphics.Path GetPatternPath()
        {
            return IExecuteWithSignature<Android.Graphics.Path>("getPatternPath", "()Landroid/graphics/Path;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/PatternPathMotion.html#setPatternPath(android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        public void SetPatternPath(Android.Graphics.Path arg0)
        {
            IExecuteWithSignature("setPatternPath", "(Landroid/graphics/Path;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}