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

namespace Android.View.Textservice
{
    #region TextServicesManager
    public partial class TextServicesManager
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
        /// <see href="https://developer.android.com/reference/android/view/textservice/TextServicesManager.html#getCurrentSpellCheckerInfo()"/> 
        /// </summary>
        public Android.View.Textservice.SpellCheckerInfo CurrentSpellCheckerInfo
        {
            get { return IExecuteWithSignature<Android.View.Textservice.SpellCheckerInfo>("getCurrentSpellCheckerInfo", "()Landroid/view/textservice/SpellCheckerInfo;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/TextServicesManager.html#getEnabledSpellCheckerInfos()"/> 
        /// </summary>
        public Java.Util.List<Android.View.Textservice.SpellCheckerInfo> EnabledSpellCheckerInfos
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.View.Textservice.SpellCheckerInfo>>("getEnabledSpellCheckerInfos", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/TextServicesManager.html#newSpellCheckerSession(android.os.Bundle,java.util.Locale,android.view.textservice.SpellCheckerSession.SpellCheckerSessionListener,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionListener"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Android.View.Textservice.SpellCheckerSession"/></returns>
        public Android.View.Textservice.SpellCheckerSession NewSpellCheckerSession(Android.Os.Bundle arg0, Java.Util.Locale arg1, Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionListener arg2, bool arg3)
        {
            return IExecute<Android.View.Textservice.SpellCheckerSession>("newSpellCheckerSession", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/TextServicesManager.html#newSpellCheckerSession(android.view.textservice.SpellCheckerSession.SpellCheckerSessionParams,java.util.concurrent.Executor,android.view.textservice.SpellCheckerSession.SpellCheckerSessionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionListener"/></param>
        /// <returns><see cref="Android.View.Textservice.SpellCheckerSession"/></returns>
        public Android.View.Textservice.SpellCheckerSession NewSpellCheckerSession(Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionParams arg0, Java.Util.Concurrent.Executor arg1, Android.View.Textservice.SpellCheckerSession.SpellCheckerSessionListener arg2)
        {
            return IExecute<Android.View.Textservice.SpellCheckerSession>("newSpellCheckerSession", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/TextServicesManager.html#isSpellCheckerEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSpellCheckerEnabled()
        {
            return IExecuteWithSignature<bool>("isSpellCheckerEnabled", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}